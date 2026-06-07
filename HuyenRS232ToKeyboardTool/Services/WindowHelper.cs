
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

public static class WindowHelper
{
    [DllImport("user32.dll")]
    private static extern bool GetCursorPos(out POINT lpPoint);

    [DllImport("user32.dll")]
    private static extern IntPtr WindowFromPoint(POINT Point);

    [DllImport("user32.dll")]
    private static extern int GetWindowText(
        IntPtr hWnd,
        StringBuilder lpString,
        int nMaxCount);

    [DllImport("user32.dll")]
    private static extern int GetClassName(
        IntPtr hWnd,
        StringBuilder lpClassName,
        int nMaxCount);

    [DllImport("user32.dll")]
    private static extern uint GetWindowThreadProcessId(
        IntPtr hWnd,
        out uint lpdwProcessId);

    [StructLayout(LayoutKind.Sequential)]
    private struct POINT
    {
        public int X;
        public int Y;
    }

    public static WindowInfo GetWindowUnderMouse()
    {
        GetCursorPos(out POINT p);

        IntPtr hwnd = WindowFromPoint(p);

        if (hwnd == IntPtr.Zero)
            return null;

        StringBuilder title = new StringBuilder(256);
        StringBuilder cls = new StringBuilder(256);

        GetWindowText(hwnd, title, 256);
        GetClassName(hwnd, cls, 256);

        GetWindowThreadProcessId(hwnd, out uint pid);

        string processName = "";

        try
        {
            processName =
                Process.GetProcessById((int)pid)
                    .ProcessName;
        }
        catch
        {
        }

        return new WindowInfo
        {
            Hwnd = hwnd,
            Title = title.ToString(),
            ClassName = cls.ToString(),
            ProcessName = processName,
            PID = pid
        };
    }
}

public class WindowInfo
{
    public IntPtr Hwnd { get; set; }

    public string Title { get; set; }

    public string ClassName { get; set; }

    public string ProcessName { get; set; }

    public uint PID { get; set; }
}