using MRC;
using Gma.System.MouseKeyHook;
using System.Runtime.InteropServices;

class Program
{
    static byte speed = 11;
    static bool isRun = true;
    private static IKeyboardMouseEvents m_GlobalHook;

    // «” Ì—«œ œ«·… · Õ—Ìﬂ «·„«Ê”
    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SetCursorPos(int X, int Y);

    // «” Ì—«œ œ«·… ·„Õ«ﬂ«… ÷€ÿ “— «·„«Ê”
    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

    const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
    const uint MOUSEEVENTF_LEFTUP = 0x0004;
    const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
    const uint MOUSEEVENTF_RIGHTUP = 0x0010;

    static void Main(string[] args)
    {
        //  ‘€Ì· «·»—‰«„Ã ›Ì «·Œ·›Ì…
        m_GlobalHook = Hook.GlobalEvents();
        m_GlobalHook.KeyUp += IsKeyUp;
        m_GlobalHook.KeyDown += IsKeyDown;

        Application.Run(new Form1());
    }

    static void IsKeyUp(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.LControlKey)
        {
            isRun = !isRun;
            Application.OpenForms[0].BackColor = isRun ? Color.Green : Color.White;
        }
    }

    static void IsKeyDown(object? sender, KeyEventArgs e)
    {
        if (isRun)
        {
            if (e.KeyCode == Keys.End)
            {
                e.Handled = true;
                ClickMouseRight();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                e.Handled = true;
                ClickMouseLeft();
            }
            else if (e.KeyCode == Keys.RControlKey)
            {
                e.Handled = true;
                DragMouseLeft();
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                Move(0, -speed);
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                Move(0, speed);
            }
            else if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;
                Move(-speed, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                Move(speed, 0);
            }
        }
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
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
    }

    static void ClickMouseRight()
    {
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
    }
}