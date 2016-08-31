using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialOnAndroidGui
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var googleDeviceId = Properties.Settings.Default["googleDeviceId"];
            if (googleDeviceId != null)
            {
                textBoxGoogleAndroidKey.Text = googleDeviceId.ToString();
            }
            textBoxDial.Focus();

            textBoxDial.Text = processCommandLineArguments();

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME){
                ShowMe();
                textBoxDial.Text = "";
            }
            else {
                if (m.Msg == NativeMethods.WM_CHAR) {

                    textBoxDial.Text += (char)m.LParam; // this is probably wrong.
                }
            }

            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            var top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }


        public static string processCommandLineArguments()
        {
            var output = "";
            var first = true;
            var second = true;
            var args = Environment.GetCommandLineArgs();
            foreach (var arg in args)
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                if (second)
                {
                    second = false;
                }
                else { output += " "; }

                output += arg;
            }
            return output;
          
        }

        private void ButtonClicker(object sender, EventArgs e)
        {
            var theButton = (Button)sender;
            textBoxDial.Text += theButton.Text;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDial.Text = "";
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ToolTipText = "";
            textBoxDial.Focus();
        }



        private async void buttonGo_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Sending data to Android ...";
            textBoxDial.Focus();
            if (Properties.Settings.Default["googleDeviceId"].ToString() != textBoxGoogleAndroidKey.Text)
            {
                Properties.Settings.Default["googleDeviceId"] = textBoxGoogleAndroidKey.Text;
                Properties.Settings.Default.Save();
            }


            var watch = System.Diagnostics.Stopwatch.StartNew();
            var msg = await DialOnAndroid.SendNotificationFromFirebaseCloud(textBoxGoogleAndroidKey.Text.Trim(), textBoxDial.Text);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            msg = String.Format("Elapsed: {0} seconds. [{1}]",
                elapsedMs / 1000,
                msg
                ).Replace("\n", "").Replace("\r", "").Trim();
            toolStripStatusLabel1.Text = msg;
            toolStripStatusLabel1.ToolTipText = msg;
        }

        private void textBoxDial_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGo_Click(this, new EventArgs());
            }
        }
    }
}
