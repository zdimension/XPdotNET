namespace XPdotNET
{
    partial class Desktop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTaskBar = new System.Windows.Forms.Panel();
            this.pnlTray = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.startMenu = new XPdotNET.StartMenu();
            this.taskBarButton1 = new XPdotNET.TaskBarButton();
            this.btnDemarrer = new XPdotNET.TriStateButton();
            this.btnTrayToggle = new XPdotNET.TriStateButton();
            this.lblTime = new XPdotNET.XPLabel();
            this.toolTip = new XPdotNET.XPToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.pnlTaskBar.SuspendLayout();
            this.pnlTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlTaskBar);
            this.pnlBottom.Controls.Add(this.btnTrayToggle);
            this.pnlBottom.Controls.Add(this.pnlTray);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 546);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1024, 30);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackgroundImage = global::XPdotNET.Properties.Resources.xptaskbar;
            this.pnlTaskBar.Controls.Add(this.taskBarButton1);
            this.pnlTaskBar.Controls.Add(this.btnDemarrer);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(866, 30);
            this.pnlTaskBar.TabIndex = 0;
            // 
            // pnlTray
            // 
            this.pnlTray.BackgroundImage = global::XPdotNET.Properties.Resources.tasktraygood;
            this.pnlTray.Controls.Add(this.lblTime);
            this.pnlTray.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTray.Location = new System.Drawing.Point(885, 0);
            this.pnlTray.Name = "pnlTray";
            this.pnlTray.Size = new System.Drawing.Size(139, 30);
            this.pnlTray.TabIndex = 1;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // startMenu
            // 
            this.startMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startMenu.BackColor = System.Drawing.Color.Transparent;
            this.startMenu.Location = new System.Drawing.Point(0, 68);
            this.startMenu.Margin = new System.Windows.Forms.Padding(0);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(380, 478);
            this.startMenu.TabIndex = 1;
            this.startMenu.Visible = false;
            this.startMenu.Leave += new System.EventHandler(this.btnDemarrer_Leave);
            // 
            // taskBarButton1
            // 
            this.taskBarButton1.Active = false;
            this.taskBarButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskBarButton1.BackgroundImage")));
            this.taskBarButton1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.taskBarButton1.Icon = null;
            this.taskBarButton1.Location = new System.Drawing.Point(145, 3);
            this.taskBarButton1.Name = "taskBarButton1";
            this.taskBarButton1.Size = new System.Drawing.Size(160, 25);
            this.taskBarButton1.TabIndex = 1;
            this.taskBarButton1.Text = "ABCDEFGHIJKLMNOPQRSTU";
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.BackgroundImage = global::XPdotNET.Properties.Resources.idle1;
            this.btnDemarrer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDemarrer.DownImage = global::XPdotNET.Properties.Resources.down1;
            this.btnDemarrer.HoverImage = global::XPdotNET.Properties.Resources.hover;
            this.btnDemarrer.IdleImage = global::XPdotNET.Properties.Resources.idle1;
            this.btnDemarrer.Location = new System.Drawing.Point(0, 0);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(138, 30);
            this.btnDemarrer.TabIndex = 0;
            this.btnDemarrer.Toggle = true;
            this.btnDemarrer.StatusChanged += new XPdotNET.StatusChangedEventHandler(this.triStateButton1_StatusChanged);
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            this.btnDemarrer.Leave += new System.EventHandler(this.btnDemarrer_Leave);
            // 
            // btnTrayToggle
            // 
            this.btnTrayToggle.BackgroundImage = global::XPdotNET.Properties.Resources.splitbar_idle;
            this.btnTrayToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTrayToggle.DownImage = global::XPdotNET.Properties.Resources.splitbar_down;
            this.btnTrayToggle.HoverImage = global::XPdotNET.Properties.Resources.splitbar_hover;
            this.btnTrayToggle.IdleImage = global::XPdotNET.Properties.Resources.splitbar_idle;
            this.btnTrayToggle.Location = new System.Drawing.Point(866, 0);
            this.btnTrayToggle.Name = "btnTrayToggle";
            this.btnTrayToggle.Size = new System.Drawing.Size(19, 30);
            this.btnTrayToggle.TabIndex = 2;
            this.btnTrayToggle.Toggle = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Gras = false;
            this.lblTime.Location = new System.Drawing.Point(95, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Ombre = false;
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "09:59";
            this.lblTime.Titre = false;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.toolTip.OwnerDraw = true;
            this.toolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip_Draw);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desktop";
            this.Text = "XPdotNET";
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTaskBar.ResumeLayout(false);
            this.pnlTray.ResumeLayout(false);
            this.pnlTray.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTaskBar;
        private StartMenu startMenu;
        private TriStateButton btnDemarrer;
        private System.Windows.Forms.Panel pnlBottom;
        private TriStateButton btnTrayToggle;
        private System.Windows.Forms.Panel pnlTray;
        private XPLabel lblTime;
        private XPToolTip toolTip;
        private System.Windows.Forms.Timer timerTime;
        private TaskBarButton taskBarButton1;
    }
}

