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
    public partial class StartLinkButton : Control
    {
        public StartLinkButton()
        {
            //InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.Width = 176;
            this.Height = 26;
            this.Text = "Texte";
            this.Font = new Font("Tahoma", 8.25f);
        }

        protected override void SetBoundsCore(int x, int y,
     int width, int height, BoundsSpecified specified)
        {
            if (this.DesignMode)
                base.SetBoundsCore(x, y, 176, 26, specified);
            else
                base.SetBoundsCore(x, y, width, height, specified);
        }


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

        private bool _bold = false;
        public bool Gras
        {
            get { return _bold; }
            set { _bold = value; Invalidate(); }
        }

        private Image _icone;
        [Category("Appearance")]
        public Image Icone
        {
            get { return _icone; }
            set { _icone = value; Invalidate(); }
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

            if(this.Icone != null)
                pe.Graphics.DrawImage(this.Icone, new Rectangle(2, 1, 24, 24));

            var ab = _bold ? new Font(this.Font, FontStyle.Bold) : this.Font;

            var black = !_hover ? new SolidBrush(Color.FromArgb(55, 55, 58)) : Brushes.White;


            pe.Graphics.DrawString(Text, ab, black, 30, 5);

        }
    }
}
