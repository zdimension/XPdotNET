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

namespace XPdotNET
{
    public partial class XPForm : Form
    {
        public XPForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.GotFocus += XPForm_GotFocus;
            foreach (Control c in this.Controls)
            {
                c.GotFocus += XPForm_GotFocus;
                c.LostFocus += XPForm_Deactivate;
            }
        }

        void XPForm_GotFocus(object sender, EventArgs e)
        {
            SetPictures(true);
        }

        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlTopSide_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        [Category("Appearance")]
        public bool MaxButton
        {
            get { return btnMax.Enabled; }
            set 
            { 
                btnMax.Enabled = value; 
                if(!value && !btnMin.Enabled)
                {
                    btnMax.Visible = false;
                    btnMin.Visible = false;
                }
            }
        }

        [Category("Appearance")]
        public bool MinButton
        {
            get { return btnMin.Enabled; }
            set 
            { 
                btnMin.Enabled = value;
                if (!value && !btnMin.Enabled)
                {
                    btnMax.Visible = false;
                    btnMin.Visible = false;
                }
            }
        }

        public new bool MaximizeBox
        {
            get { return true; }
        }

        public new bool MinimizeBox
        {
            get { return true; }
        }


        private FormWindowState mLastState;
        protected override void OnClientSizeChanged(EventArgs e)
        {
            if (this.WindowState != mLastState)
            {
                mLastState = this.WindowState;
                OnWindowStateChanged(e);
            }
            base.OnClientSizeChanged(e);
        }
        protected void OnWindowStateChanged(EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.btnMax.DownImage = global::XPdotNET.Properties.Resources.bigon;
                this.btnMax.HoverImage = global::XPdotNET.Properties.Resources.bigov;
                this.btnMax.IdleImage = global::XPdotNET.Properties.Resources.big;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                this.btnMax.DownImage = global::XPdotNET.Properties.Resources.resizeon;
                this.btnMax.HoverImage = global::XPdotNET.Properties.Resources.resizeov;
                this.btnMax.IdleImage = global::XPdotNET.Properties.Resources.resize;
            }
        }

        void SetPictures(bool active)
        {
            if(active)
            {
                tb.MiddleImage = XPdotNET.Properties.Resources.window;

                tb.LeftImage = XPdotNET.Properties.Resources.corner_upleft;
                tb.RightImage = XPdotNET.Properties.Resources.corner_upright;
                cornerBottomLeft.Image = XPdotNET.Properties.Resources.corner_bottomleft;
                cornerBottomRight.Image = XPdotNET.Properties.Resources.corner_bottomright;

                pnlLeft.BackgroundImage = XPdotNET.Properties.Resources.left;
                pnlRight.BackgroundImage = XPdotNET.Properties.Resources.right;
                pnlBottom.BackgroundImage = XPdotNET.Properties.Resources.bottom1;

                btnMax.IdleImage = this.WindowState == FormWindowState.Maximized ? XPdotNET.Properties.Resources.resize : XPdotNET.Properties.Resources.big;
                btnMin.IdleImage = XPdotNET.Properties.Resources.reduce;
                btnClose.IdleImage = XPdotNET.Properties.Resources.close;
            }
            else
            {
                tb.MiddleImage = XPdotNET.Properties.Resources.windowinactive;

                tb.LeftImage = XPdotNET.Properties.Resources.inactive_corner_upleft;
                tb.RightImage = XPdotNET.Properties.Resources.inactive_corner_upright;
                cornerBottomLeft.Image = XPdotNET.Properties.Resources.inactive_corner_bottomleft;
                cornerBottomRight.Image = XPdotNET.Properties.Resources.inactive_corner_bottomright;

                pnlLeft.BackgroundImage = XPdotNET.Properties.Resources.inactive_left;
                pnlRight.BackgroundImage = XPdotNET.Properties.Resources.inactive_right;
                pnlBottom.BackgroundImage = XPdotNET.Properties.Resources.inactive_bottom;

                btnMax.IdleImage = this.WindowState == FormWindowState.Maximized ? XPdotNET.Properties.Resources.resizeinactive : XPdotNET.Properties.Resources.biginactive;
                btnMin.IdleImage = XPdotNET.Properties.Resources.reduceinactive;
                btnClose.IdleImage = XPdotNET.Properties.Resources.closeinactive;
            }
        }

        private void XPForm_Deactivate(object sender, EventArgs e)
        {
            SetPictures(false);
        }

        private void pnlTopSide_Paint(object sender, PaintEventArgs e)
        {

        }

        #region 'Resize'
        const int WM_NCHITTEST = 0x0084;
        const int HTLEFT = 10;    //  
        const int HTRIGHT = 11;   //  
        const int HTTOP = 12; //  
        const int HTTOPLEFT = 13; //  
        const int HTTOPRIGHT = 14;    //  
        const int HTBOTTOM = 15;  //  
        const int HTBOTTOMLEFT = 0x10;    //  
        const int HTBOTTOMRIGHT = 17; //  

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF,
                            (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        //??  
                        if (this.WindowState != FormWindowState.Maximized)
                        {
                            if (vPoint.X <= 5)
                            {
                                if (vPoint.Y <= 5)
                                {
                                    m.Result = (IntPtr)HTTOPLEFT;
                                }
                                else if (vPoint.Y >= ClientSize.Height - 5)
                                {
                                    m.Result = (IntPtr)HTBOTTOMLEFT;
                                }
                                else
                                {
                                    m.Result = (IntPtr)HTLEFT;
                                }
                            }
                            else if (vPoint.X >= ClientSize.Width - 5)
                            {
                                if (vPoint.Y <= 5)
                                {
                                    m.Result = (IntPtr)HTTOPRIGHT;
                                }
                                else if (vPoint.Y >= ClientSize.Height - 5)
                                {
                                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                                }
                                else
                                {
                                    m.Result = (IntPtr)HTRIGHT;
                                }
                            }
                            else if (vPoint.Y <= 5)
                            {
                                m.Result = (IntPtr)HTTOP;
                            }
                            else if (vPoint.Y >= ClientSize.Height - 5)
                            {
                                m.Result = (IntPtr)HTBOTTOM;
                            }

                        }
                        break;
                    }
            }
        }  
        #endregion 

        private void lblText_Paint(object sender, PaintEventArgs e)
        {

        }
 
    }
}
