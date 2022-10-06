using System;

namespace ATSFChsPatchCreate
{
    internal class Console
    {
        public static void WriteLine(object line)
        {
            System.Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {line}");
        }
    }
}
