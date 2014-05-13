using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPdotNET
{
    [Designer(typeof(StartAppButtonDesigner))]
    public partial class AllProgramsButton : Control
    {
        public AllProgramsButton()
        {
            //InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.Width = 174;
            this.Height = 24;
            this.Text = "Tous les programmes";
            this.Font = new Font("Tahoma", 8.25f);
        }

        protected override void SetBoundsCore(int x, int y,
     int width, int height, BoundsSpecified specified)
        {
            if (this.DesignMode)
                base.SetBoundsCore(x, y, 174, 24, specified);
            else
                base.SetBoundsCore(x, y, width, height, specified);
        }


        [Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }


        private bool _hover = false;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hover = true;
            this.BackColor = SystemColors.HotTrack;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hover = false;
            this.BackColor = Color.Transparent;
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            pe.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            if(_hover)
                pe.Graphics.DrawImage(XPdotNET.Properties.Resources.greenarrow_hover, new Rectangle(158, 0, 16, 24));
            else
                pe.Graphics.DrawImage(XPdotNET.Properties.Resources.greenarrow_idle, new Rectangle(158, 0, 16, 24));

            var ab = new Font(this.Font, FontStyle.Bold);

            var black = !_hover ? new SolidBrush(Color.FromArgb(55, 55, 58)) : Brushes.White;


            pe.Graphics.DrawString(Text, ab, black, 25, 5);

        }
    }

}
