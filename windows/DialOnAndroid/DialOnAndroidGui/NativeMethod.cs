using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DialOnAndroidGui
{
    internal class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
        public static readonly int WM_CHAR = RegisterWindowMessage("WM_CHAR");
        public static readonly int WM_DIAL = RegisterWindowMessage("WM_DIAL");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
