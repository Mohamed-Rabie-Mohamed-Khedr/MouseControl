using MRC;
using Gma.System.MouseKeyHook;
using System.Runtime.InteropServices;
using MRC.Properties;
using System.Media;
using Microsoft.Win32;
class Program
{
    public static bool controlRoomIsRun;
    static byte speed = 11;
    static bool isRun = true, isUp, isDown, isLeft, isRight;
    static Keys up = Keys.Up, down = Keys.Down, right = Keys.Right, left = Keys.Left, mouseLeft = Keys.Insert, mouseRight = Keys.End, dragAndDrop = Keys.RControlKey, onAndOff = Keys.LControlKey;
    static IKeyboardMouseEvents m_GlobalHook;
    static SoundPlayer sound;
    const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
    const uint MOUSEEVENTF_LEFTUP = 0x0004;
    const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
    const uint MOUSEEVENTF_RIGHTUP = 0x0010;
    const int VK_LBUTTON = 0x01;
    
    [DllImport("user32.dll")]
    static extern short GetAsyncKeyState(int vKey);

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SetCursorPos(int X, int Y);

    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
    
    static void Main(string[] args)
    {
        Mutex mutex = new Mutex(true, "0Mouse Manager", out bool isCreatedNew);

        if (!isCreatedNew) MessageBox.Show("The Program Is Run", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        else
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyUp += IsKeyUp;
            m_GlobalHook.KeyDown += IsKeyDown;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (registryKey.GetValue(Application.ProductName) == null)
            {
                registryKey.SetValue(Application.ProductName, Application.ExecutablePath);
                MessageBox.Show("F3 To Settings", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            registryKey.Dispose();

            if (File.Exists("save.txt")) KeysUpdate();
            Application.Run();
        }
    }

    public static void KeysUpdate()
    {
        string[] k = File.ReadAllText("save.txt").Split(',');
        speed = byte.Parse(k[0]);
        up = (Keys)Enum.Parse(typeof(Keys), k[1]);
        down = (Keys)Enum.Parse(typeof(Keys), k[2]);
        right = (Keys)Enum.Parse(typeof(Keys), k[3]);
        left = (Keys)Enum.Parse(typeof(Keys), k[4]);
        mouseRight = (Keys)Enum.Parse(typeof(Keys), k[5]);
        mouseLeft = (Keys)Enum.Parse(typeof(Keys), k[6]);
        dragAndDrop = (Keys)Enum.Parse(typeof(Keys), k[7]);
        onAndOff = (Keys)Enum.Parse(typeof(Keys), k[8]);
    }

    static void IsKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F3 && !controlRoomIsRun)
        {
            e.Handled = true;
            controlRoomIsRun = true;
            ControlRoom controlRoom = new ControlRoom();
            controlRoom.Show();
        }
        if (isRun)
        {
            if (e.KeyCode == mouseRight)
            {
                e.Handled = true;
                ClickMouseRight();
            }
            else if (e.KeyCode == mouseLeft)
            {
                e.Handled = true;
                ClickMouseLeft();
            }
            else if (e.KeyCode == dragAndDrop)
            {
                e.Handled = true;
                DragMouseLeft();
            }
            else if (isUp && isRight)
            {
                e.Handled = true;
                Move(speed, -speed);
            }
            else if (isUp && isLeft)
            {
                e.Handled = true;
                Move(-speed, -speed);
            }
            else if (isDown && isRight)
            {
                e.Handled = true;
                Move(speed, speed);
            }
            else if (isDown && isLeft)
            {
                e.Handled = true;
                Move(-speed, speed);
            }
            else if (e.KeyCode == up)
            {
                e.Handled = true;
                isUp = true;
                Move(0, -speed);
            }
            else if (e.KeyCode == down)
            {
                e.Handled = true;
                isDown = true;
                Move(0, speed);
            }
            else if (e.KeyCode == left)
            {
                e.Handled = true;
                isLeft = true;
                Move(-speed, 0);
            }
            else if (e.KeyCode == right)
            {
                e.Handled = true;
                isRight = true;
                Move(speed, 0);
            }
        }
    }

    static void IsKeyUp(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == onAndOff)
        {
            isRun = !isRun;
            sound = isRun ? new SoundPlayer(Resources.ON) : new SoundPlayer(Resources.off);
            sound.Play();
        }
        else if (e.KeyCode == up) isUp = false;
        else if (e.KeyCode == down) isDown = false;
        else if (e.KeyCode == right) isRight = false;
        else if (e.KeyCode == left) isLeft = false;
    }

    static void Move(int deltaX, int deltaY)
    {
        SetCursorPos(Cursor.Position.X + deltaX, Cursor.Position.Y + deltaY);
    }

    static void ClickMouseLeft()
    {
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }

    static void DragMouseLeft()
    {
        if (KeyState(VK_LBUTTON))
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        else mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
    }

    static void ClickMouseRight()
    {
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
    }

    public static string[] RaedData()
    {
        return $"{speed},{up},{down},{right},{left},{mouseRight},{mouseLeft},{dragAndDrop},{onAndOff}".Split(',');
    }

    public static bool KeyState(int vKey)
    {
        return (GetAsyncKeyState(vKey) & 0x8000) != 0;
    }
}