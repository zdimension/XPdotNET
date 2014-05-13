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
    public class XPLabel : Label
    {
        private Font StandardFont = new Font("Tahoma", 8.25f);
        private Font TitleFont = new Font("Trebuchet MS", 9.75f, FontStyle.Bold);

        public XPLabel()
        {
            this.Font = StandardFont;
        }

        [Category("Appearance")]
        public bool Gras
        {
            get { return this.Font.Bold; }
            set { this.Font = new Font(this.Font, value ? FontStyle.Bold : FontStyle.Regular); Invalidate(); }
        }

        [Category("Appearance")]
        public bool Titre
        {
            get { return this.Font == TitleFont; }
            set { this.Font = value ? TitleFont : StandardFont; Invalidate(); }
        }

        private bool _shadow = false;

        [Category("Appearance")]
        public bool Ombre
        {
            get { return _shadow; }
            set { _shadow = value; Invalidate(); }
        }

        [Browsable(false)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            if (_shadow)
            {
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(10, 24, 131)), 1, 1, StringFormat.GenericDefault);
            }

            base.OnPaint(e);           
        }
    }
}
