using System;
using System.Runtime.InteropServices;

namespace Turn_Off_LCD
{
  internal class PowerBoard
  {
    private int WM_SYSCOMMAND = 274;
    private int SC_MONITORPOWER = 61808;
    private const int MONITOR_OFF = 2;

    [DllImport("user32.dll")]
    private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    public void TurnOffLCD()
    {
      PowerBoard.SendMessage(PowerBoard.FindWindow((string) null, (string) null).ToInt32(), this.WM_SYSCOMMAND, this.SC_MONITORPOWER, 2);
    }
  }
}
