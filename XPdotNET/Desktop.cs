using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPdotNET
{
    public partial class Desktop : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        public Desktop()
        {
            InitializeComponent();
            this.SetBevel(false);
            timerTime.Start();


        }

        private void LoadApplication(string path, IntPtr handle)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int timeout = 10 * 1000;     // Timeout value (10s) in case we want to cancel the task if it's taking too long.

            Process p = Process.Start(path);
            while (p.MainWindowHandle == IntPtr.Zero)
            {
                System.Threading.Thread.Sleep(10);
                p.Refresh();

                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop();
                    return;
                }
            }

            SetParent(p.MainWindowHandle, handle);      // Set the process parent window to the window we want
            SetWindowPos(p.MainWindowHandle, 0, 0, 0, 0, 0, 0x0001 | 0x0040);       // Place the window in the top left of the parent window without resizing it
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            XPForm t = new XPForm();
            t.Show();
            SetParent(t.Handle, this.Handle);      // Set the process parent window to the window we want
            SetWindowPos(t.Handle, 0, 0, 0, 0, 0, 0x0001 | 0x0040);       // Place the window in the top left of the parent window without resizing it



            LoadApplication("notepad.exe", this.Handle);
        }

        public void LoadTasks()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            base.OnPaint(e);
        }

        private void triStateButton1_StatusChanged(object sender, bool newStatus)
        {
            startMenu.Visible = btnDemarrer._state;
            startMenu.BringToFront();
        }

        private void btnDemarrer_Leave(object sender, EventArgs e)
        {
            btnDemarrer.ResetStatus();
            startMenu.Visible = false;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            toolTip.SetToolTip(lblTime, (DateTime.Now.ToString("dddd", new CultureInfo("fr-FR")) + " " + DateTime.Now.Day + " " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year).ToLower());
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {

        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {

        }
    }
}
