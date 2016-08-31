using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialOnAndroidGui
{
    static class Program
    {
        static string guid = "{8F6F3AC1-B9A1-88fd-FFBB-72F04E6BDE8F}";
        static Mutex mutex = new Mutex(true, guid);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {

                LoadApp();
            }
            else
            {
                SentCommandLineParametersToOtherWindow();
            }
        }

        private static void SentCommandLineParametersToOtherWindow()
        {
            var theString = MainForm.processCommandLineArguments();

            NativeMethods.PostMessage(
              (IntPtr)NativeMethods.HWND_BROADCAST,
              NativeMethods.WM_SHOWME,
              IntPtr.Zero,
              IntPtr.Zero);

            foreach (var oneChar in theString.ToCharArray())
            {
                var theIntPtr = new IntPtr(oneChar);
                NativeMethods.PostMessage(
                  (IntPtr)NativeMethods.HWND_BROADCAST,
                  NativeMethods.WM_CHAR,
                  theIntPtr,
                  theIntPtr
                  );
            }
        }

        private static void LoadApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var theForm = new MainForm();
            Application.Run(theForm);
            mutex.ReleaseMutex();
        }
        
    }

}
