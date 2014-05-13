using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPdotNET
{
    

    [Designer(typeof(StartAppButtonDesigner))]
    public partial class StartAppButton : Control
    {
        public StartAppButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.Width = 176;
            this.Height = 36;
            this.Text = "Texte";
            this.Description = "Description";
            this.Font = new Font("Tahoma", 8.25f);
        }

        protected override void SetBoundsCore(int x, int y,
     int width, int height, BoundsSpecified specified)
        {
            if (this.DesignMode)
                base.SetBoundsCore(x, y, 176, 36, specified);
            else
                base.SetBoundsCore(x, y, width, height, specified);
        }

        private bool _deuxnoms = false;

        [Category("Appearance")]
        public bool DeuxNoms
        {
            get { return _deuxnoms; }
            set { _deuxnoms = value; Invalidate(); }
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


        private string _desc = "";
        [Category("Appearance")]
        public string Description
        {
            get { return _desc; }
            set { _desc = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Image Icone
        {
            get;
            set;
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

            if(Icone != null)
                pe.Graphics.DrawImage(Icone, new Rectangle(2, 2, 32, 32));

            var a = this.Font;
            var ab = new Font(this.Font, FontStyle.Bold);

            var black = !_hover ? new SolidBrush(Color.FromArgb(55, 55, 58)) : Brushes.White;
            var gray = !_hover ? new SolidBrush(Color.FromArgb(128, 128, 128)) : Brushes.White;

            if(!DeuxNoms)
            {
                if (Text.Contains('\n'))
                {
                    pe.Graphics.DrawString(Text, a, black, 38, 5);
                }
                else
                {
                    pe.Graphics.DrawString(Text, a, black, 38, 12);
                }
            }
            else
            {
                pe.Graphics.DrawString(Text, ab, black, 38, 5);
                pe.Graphics.DrawString(Description, a, gray, 38, 18);
            }
        }
    }

    public class StartAppButtonDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        public override System.Windows.Forms.Design.SelectionRules SelectionRules
        {
            get
            {
                return (base.SelectionRules & ~(System.Windows.Forms.Design.SelectionRules.AllSizeable));
            }
        }
    }
}
