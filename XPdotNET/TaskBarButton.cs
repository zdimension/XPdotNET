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
    public class TaskBarButton : Control
    {
        #region Propriétés désactivées

        [Browsable(false)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        [Browsable(false)]
        public override System.Drawing.Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
                this.Size = value.Size;
                //Invalidate();
            }
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

        [Browsable(false)]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }


        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                base.BackgroundImageLayout = value;
            }
        }

        #endregion

        private Image _idleimg, _hovimg, _downimg = null;

        private Image IdleImage
        {
            get { return _idleimg; }
            set { _idleimg = value; Invalidate(); }
        }


        private Image HoverImage
        {
            get { return _hovimg; }
            set { _hovimg = value; Invalidate(); }
        }


        private Image DownImage
        {
            get { return _downimg; }
            set { _downimg = value; Invalidate(); }
        }

        [Category("Appearance")]
        public bool Active
        {
            get { return _state; }
            set { _state = value; SetImages(); }
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

        private Image _icon = null;

        [Category("Appearance")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; Invalidate(); }
        }

        internal void SetImage()
        {
            /*if (_state)
            {
                if (_downimg != null)
                    this.BackgroundImage = _downimg;
            }
            else
            {**/
            if (_hover)
            {
                if (_down)
                {
                    if (_downimg != null)
                        this.BackgroundImage = _downimg;
                }
                else
                {
                    if (_hovimg != null)
                        this.BackgroundImage = _hovimg;
                }
            }
            else
            {
                if (_idleimg != null)
                    this.BackgroundImage = _idleimg;
            }
            //}
        }

        internal bool _hover = false;
        internal bool _down = false;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hover = true;
            SetImage();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hover = false;
            SetImage();
        }



        public event StatusChangedEventHandler StatusChanged;

        protected virtual void OnStatusChanged()
        {
            SetImages();

            if (StatusChanged != null)
                StatusChanged(this, _state);
        }
        public void ResetStatus()
        {
            _state = false;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _state = !_state;
            OnStatusChanged();


            _down = true;

            SetImage();
        }

        private bool _state = false;

        

        public TaskBarButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            this.Font = new Font("Tahoma", 8.25f);
            this.Size = new Size(160, 25);

            SetImages();
        }

        public void SetImages()
        {
            if(_state)
            {
                this.IdleImage = XPdotNET.Properties.Resources.big_down;
                this.HoverImage = XPdotNET.Properties.Resources.big_active_hover;
                this.DownImage = XPdotNET.Properties.Resources.big_down;
            }
            else
            {
                this.IdleImage = XPdotNET.Properties.Resources.big_idle;
                this.HoverImage = XPdotNET.Properties.Resources.big_hover;
                this.DownImage = XPdotNET.Properties.Resources.big_down;
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            _down = false;
            SetImage();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            SetImage();

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            if(_icon != null)
                e.Graphics.DrawImage(_icon, new Rectangle(9, 4, 16, 16));

            var flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;

            StringFormat fmt = new StringFormat();
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            if (!Active)
            {
                if (Text != null)
                    TextRenderer.DrawText(e.Graphics, Text, this.Font, new Rectangle(27, 5, 124, 20), Color.White, flags);
            }
            else
            {
                if (Text != null)
                    TextRenderer.DrawText(e.Graphics, Text, this.Font, new Rectangle(28, 6, 124, 20), Color.White, flags);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
