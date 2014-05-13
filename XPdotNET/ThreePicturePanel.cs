using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPdotNET
{
    public class ThreePicturePanel : Panel
    {
        private Image _left, _middle, _right = null;

        [Category("Appearance")]
        public Image LeftImage
        {
            get { return _left; }
            set { _left = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Image MiddleImage
        {
            get { return _middle; }
            set { _middle = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Image RightImage
        {
            get { return _right; }
            set { _right = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            //e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;

            if (_left != null)
                e.Graphics.DrawImage(_left, new Rectangle(0, 0, _left.Width, this.Height));

            if (_middle != null)
            {
                int wd = this.Width - (_right.Width * 2);
                using (var attribs = new ImageAttributes())
                {
                    attribs.SetWrapMode(WrapMode.TileFlipXY);
                    e.Graphics.DrawImage(_middle, new Rectangle(_left.Width, 0, wd, this.Height), 0f, 0f, (float)_middle.Width, (float)_middle.Height, GraphicsUnit.Pixel, attribs);
                }
            }

            if (_right != null)
                e.Graphics.DrawImage(_right, new Rectangle(this.Width - _right.Width, 0, _right.Width, this.Height));
        }
    }
}
