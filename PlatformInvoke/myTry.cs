// PInvokeTest.cs
using System;
using System.Runtime.InteropServices;

class PlatformInvokeTest4
{
    [DllImport("msvcrt.dll", EntryPoint = "puts")]
    public static extern int myputs(string c);

    [DllImport("msvcrt.dll")]
    public static extern int puts(string c);
    
    [DllImport("msvcrt.dll")]
    internal static extern int _flushall();

    public static void Main()
    {
        myputs("myTest");
        _flushall();

        puts("Test");
        _flushall();
    }
}
