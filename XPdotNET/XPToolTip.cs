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
    public class XPToolTip : ToolTip
    {
        public XPToolTip(IContainer container) : base(container)
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.OwnerDraw = true;
            this.Draw += XPToolTip_Draw;
        }

        void XPToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            int tX = 3;
            int tY = 4;

            int totalWidth = Convert.ToInt32(e.Graphics.MeasureString(e.ToolTipText, new Font("Tahoma", 8.25f)).Width) + 7;
            int totalHeight = Convert.ToInt32(e.Graphics.MeasureString(e.ToolTipText, new Font("Tahoma", 8.25f)).Height) + 8;



            var bFill = new SolidBrush(Color.FromArgb(255, 255, 225));

            e.Graphics.FillRectangle(bFill, 1, 1, totalWidth - 2, totalHeight - 2);

            Pen pBorder = new Pen(Color.Black);


            e.Graphics.DrawRectangle(pBorder, 0, 0, totalWidth, totalHeight);

            e.Graphics.DrawString(e.ToolTipText, new Font("Tahoma", 8.25f), Brushes.Black, tX, tY);
        }

        
    }
}
