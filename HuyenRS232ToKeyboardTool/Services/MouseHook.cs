using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class MouseHook
{
    private const int WH_MOUSE_LL = 14;
    private const int WM_LBUTTONUP = 0x0202;

    private static IntPtr _hookID = IntPtr.Zero;
    private static LowLevelMouseProc _proc = HookCallback;

    public static event Action MouseLeftButtonUp;

    public static void Start()
    {
        if (_hookID != IntPtr.Zero)
            return;

        _hookID = SetHook(_proc);
    }

    public static void Stop()
    {
        if (_hookID == IntPtr.Zero)
            return;

        UnhookWindowsHookEx(_hookID);
        _hookID = IntPtr.Zero;
    }

    private static IntPtr SetHook(LowLevelMouseProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(
                WH_MOUSE_LL,
                proc,
                GetModuleHandle(curModule.ModuleName),
                0);
        }
    }

    private delegate IntPtr LowLevelMouseProc(
        int nCode,
        IntPtr wParam,
        IntPtr lParam);

    private static IntPtr HookCallback(
        int nCode,
        IntPtr wParam,
        IntPtr lParam)
    {
        if (nCode >= 0)
        {
            if ((int)wParam == WM_LBUTTONUP)
            {
                MouseLeftButtonUp?.Invoke();
            }
        }

        return CallNextHookEx(
            _hookID,
            nCode,
            wParam,
            lParam);
    }

    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(
        int idHook,
        LowLevelMouseProc lpfn,
        IntPtr hMod,
        uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(
        IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(
        IntPtr hhk,
        int nCode,
        IntPtr wParam,
        IntPtr lParam);

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetModuleHandle(
        string lpModuleName);
}