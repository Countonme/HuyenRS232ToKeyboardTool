using System;

public class WindowInfo
{
    public IntPtr Hwnd { get; set; }

    public string Title { get; set; }

    public string ClassName { get; set; }

    public string ProcessName { get; set; }

    public uint PID { get; set; }
}