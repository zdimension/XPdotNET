namespace XPdotNET
{
    partial class XPForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.cornerBottomRight = new System.Windows.Forms.PictureBox();
            this.cornerBottomLeft = new System.Windows.Forms.PictureBox();
            this.buttonXP1 = new PinkieControls.ButtonXP();
            this.tb = new XPdotNET.ThreePicturePanel();
            this.btnClose = new XPdotNET.TriStateButton();
            this.btnMax = new XPdotNET.TriStateButton();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.btnMin = new XPdotNET.TriStateButton();
            this.lblText = new XPdotNET.XPLabel();
            this.pnlTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornerBottomLeft)).BeginInit();
            this.tb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.tb);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(602, 30);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.pnlContent.Controls.Add(this.buttonXP1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(596, 366);
            this.pnlContent.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.BackgroundImage = global::XPdotNET.Properties.Resources.right;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(599, 30);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(3, 366);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackgroundImage = global::XPdotNET.Properties.Resources.left;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 30);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(3, 366);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackgroundImage = global::XPdotNET.Properties.Resources.bottom1;
            this.pnlBottom.Controls.Add(this.cornerBottomRight);
            this.pnlBottom.Controls.Add(this.cornerBottomLeft);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 396);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(602, 3);
            this.pnlBottom.TabIndex = 1;
            // 
            // cornerBottomRight
            // 
            this.cornerBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.cornerBottomRight.Image = global::XPdotNET.Properties.Resources.corner_bottomright;
            this.cornerBottomRight.Location = new System.Drawing.Point(598, 0);
            this.cornerBottomRight.Name = "cornerBottomRight";
            this.cornerBottomRight.Size = new System.Drawing.Size(4, 3);
            this.cornerBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cornerBottomRight.TabIndex = 1;
            this.cornerBottomRight.TabStop = false;
            // 
            // cornerBottomLeft
            // 
            this.cornerBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.cornerBottomLeft.Image = global::XPdotNET.Properties.Resources.corner_bottomleft;
            this.cornerBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.cornerBottomLeft.Name = "cornerBottomLeft";
            this.cornerBottomLeft.Size = new System.Drawing.Size(4, 3);
            this.cornerBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cornerBottomLeft.TabIndex = 0;
            this.cornerBottomLeft.TabStop = false;
            // 
            // buttonXP1
            // 
            this.buttonXP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.buttonXP1.DefaultScheme = true;
            this.buttonXP1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonXP1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXP1.Hint = "";
            this.buttonXP1.Location = new System.Drawing.Point(84, 74);
            this.buttonXP1.Name = "buttonXP1";
            this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
            this.buttonXP1.Size = new System.Drawing.Size(75, 23);
            this.buttonXP1.TabIndex = 0;
            this.buttonXP1.Text = "buttonXP1";
            // 
            // tb
            // 
            this.tb.Controls.Add(this.btnClose);
            this.tb.Controls.Add(this.btnMax);
            this.tb.Controls.Add(this.pbxIcon);
            this.tb.Controls.Add(this.btnMin);
            this.tb.Controls.Add(this.lblText);
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.LeftImage = global::XPdotNET.Properties.Resources.testcorner;
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.MiddleImage = global::XPdotNET.Properties.Resources.window;
            this.tb.Name = "tb";
            this.tb.RightImage = global::XPdotNET.Properties.Resources.testcorner2;
            this.tb.Size = new System.Drawing.Size(602, 30);
            this.tb.TabIndex = 1;
            this.tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopSide_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::XPdotNET.Properties.Resources.close;
            this.btnClose.DownImage = global::XPdotNET.Properties.Resources.closeon;
            this.btnClose.HoverImage = global::XPdotNET.Properties.Resources.closeov;
            this.btnClose.IdleImage = global::XPdotNET.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(575, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 1;
            this.btnClose.Toggle = false;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::XPdotNET.Properties.Resources.big;
            this.btnMax.DownImage = global::XPdotNET.Properties.Resources.bigon;
            this.btnMax.HoverImage = global::XPdotNET.Properties.Resources.bigov;
            this.btnMax.IdleImage = global::XPdotNET.Properties.Resources.big;
            this.btnMax.Location = new System.Drawing.Point(552, 6);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 21);
            this.btnMax.TabIndex = 1;
            this.btnMax.Toggle = false;
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Image = global::XPdotNET.Properties.Resources.computer;
            this.pbxIcon.Location = new System.Drawing.Point(6, 8);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(16, 16);
            this.pbxIcon.TabIndex = 1;
            this.pbxIcon.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::XPdotNET.Properties.Resources.reduce;
            this.btnMin.DownImage = global::XPdotNET.Properties.Resources.reduceon;
            this.btnMin.HoverImage = global::XPdotNET.Properties.Resources.reduceov;
            this.btnMin.IdleImage = global::XPdotNET.Properties.Resources.reduce;
            this.btnMin.Location = new System.Drawing.Point(529, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 21);
            this.btnMin.TabIndex = 1;
            this.btnMin.Toggle = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Gras = true;
            this.lblText.Location = new System.Drawing.Point(23, 8);
            this.lblText.Name = "lblText";
            this.lblText.Ombre = true;
            this.lblText.Size = new System.Drawing.Size(103, 18);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Poste de travail";
            this.lblText.Titre = true;
            // 
            // XPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(602, 399);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XPForm";
            this.Text = "XPForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Deactivate += new System.EventHandler(this.XPForm_Deactivate);
            this.pnlTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornerBottomLeft)).EndInit();
            this.tb.ResumeLayout(false);
            this.tb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox cornerBottomLeft;
        private System.Windows.Forms.PictureBox cornerBottomRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlContent;
        private TriStateButton btnClose;
        private PinkieControls.ButtonXP buttonXP1;
        private TriStateButton btnMax;
        private TriStateButton btnMin;
        private System.Windows.Forms.PictureBox pbxIcon;
        private XPLabel lblText;
        private ThreePicturePanel tb;
    }
}