namespace Minesweeper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBombeBroj = new System.Windows.Forms.Label();
            this.lblBombeLabela = new System.Windows.Forms.Label();
            this.lblVremeVreme = new System.Windows.Forms.Label();
            this.lblVremeLabela = new System.Windows.Forms.Label();
            this.mstMeni = new System.Windows.Forms.MenuStrip();
            this.gAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMIZEFIELDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.sAVEGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.mstMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(168, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Linux Libertine Display G", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(155, 37);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 80);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START NEW GAME";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblBombeBroj
            // 
            this.lblBombeBroj.AutoSize = true;
            this.lblBombeBroj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBombeBroj.Font = new System.Drawing.Font("Linux Libertine Display G", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombeBroj.Location = new System.Drawing.Point(59, 151);
            this.lblBombeBroj.Name = "lblBombeBroj";
            this.lblBombeBroj.Size = new System.Drawing.Size(42, 31);
            this.lblBombeBroj.TabIndex = 5;
            this.lblBombeBroj.Text = "10";
            // 
            // lblBombeLabela
            // 
            this.lblBombeLabela.AutoSize = true;
            this.lblBombeLabela.Location = new System.Drawing.Point(12, 130);
            this.lblBombeLabela.Name = "lblBombeLabela";
            this.lblBombeLabela.Size = new System.Drawing.Size(154, 16);
            this.lblBombeLabela.TabIndex = 4;
            this.lblBombeLabela.Text = "NUMBER OF BOMBS:";
            // 
            // lblVremeVreme
            // 
            this.lblVremeVreme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVremeVreme.AutoSize = true;
            this.lblVremeVreme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblVremeVreme.Font = new System.Drawing.Font("Linux Libertine Display G", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVremeVreme.Location = new System.Drawing.Point(59, 232);
            this.lblVremeVreme.Name = "lblVremeVreme";
            this.lblVremeVreme.Size = new System.Drawing.Size(39, 31);
            this.lblVremeVreme.TabIndex = 7;
            this.lblVremeVreme.Text = "0s";
            // 
            // lblVremeLabela
            // 
            this.lblVremeLabela.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVremeLabela.AutoSize = true;
            this.lblVremeLabela.Location = new System.Drawing.Point(28, 211);
            this.lblVremeLabela.Name = "lblVremeLabela";
            this.lblVremeLabela.Size = new System.Drawing.Size(118, 16);
            this.lblVremeLabela.TabIndex = 6;
            this.lblVremeLabela.Text = "ELAPSED TIME:";
            // 
            // mstMeni
            // 
            this.mstMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAMEToolStripMenuItem});
            this.mstMeni.Location = new System.Drawing.Point(0, 0);
            this.mstMeni.Name = "mstMeni";
            this.mstMeni.Size = new System.Drawing.Size(453, 24);
            this.mstMeni.TabIndex = 8;
            this.mstMeni.Text = "menuStrip1";
            // 
            // gAMEToolStripMenuItem
            // 
            this.gAMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUSTOMIZEFIELDToolStripMenuItem,
            this.sAVEGAMEToolStripMenuItem,
            this.lOADGAMEToolStripMenuItem});
            this.gAMEToolStripMenuItem.Name = "gAMEToolStripMenuItem";
            this.gAMEToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.gAMEToolStripMenuItem.Text = "MINESWEEPER";
            // 
            // cUSTOMIZEFIELDToolStripMenuItem
            // 
            this.cUSTOMIZEFIELDToolStripMenuItem.Name = "cUSTOMIZEFIELDToolStripMenuItem";
            this.cUSTOMIZEFIELDToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cUSTOMIZEFIELDToolStripMenuItem.Text = "CUSTOMIZE FIELD";
            this.cUSTOMIZEFIELDToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMIZEFIELDToolStripMenuItem_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // pnlTabla
            // 
            this.pnlTabla.Location = new System.Drawing.Point(168, 130);
            this.pnlTabla.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(180, 180);
            this.pnlTabla.TabIndex = 9;
            // 
            // sAVEGAMEToolStripMenuItem
            // 
            this.sAVEGAMEToolStripMenuItem.Name = "sAVEGAMEToolStripMenuItem";
            this.sAVEGAMEToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sAVEGAMEToolStripMenuItem.Text = "SAVE THE GAME";
            this.sAVEGAMEToolStripMenuItem.Click += new System.EventHandler(this.sAVEGAMEToolStripMenuItem_Click);
            // 
            // lOADGAMEToolStripMenuItem
            // 
            this.lOADGAMEToolStripMenuItem.Name = "lOADGAMEToolStripMenuItem";
            this.lOADGAMEToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.lOADGAMEToolStripMenuItem.Text = "LOAD THE GAME";
            this.lOADGAMEToolStripMenuItem.Click += new System.EventHandler(this.lOADGAMEToolStripMenuItem_Click);
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(453, 328);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.lblVremeVreme);
            this.Controls.Add(this.lblVremeLabela);
            this.Controls.Add(this.lblBombeBroj);
            this.Controls.Add(this.lblBombeLabela);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mstMeni);
            this.Font = new System.Drawing.Font("Linux Libertine Display G", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mstMeni;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.mstMeni.ResumeLayout(false);
            this.mstMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBombeBroj;
        private System.Windows.Forms.Label lblBombeLabela;
        private System.Windows.Forms.Label lblVremeVreme;
        private System.Windows.Forms.Label lblVremeLabela;
        private System.Windows.Forms.MenuStrip mstMeni;
        private System.Windows.Forms.ToolStripMenuItem gAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMIZEFIELDToolStripMenuItem;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.ToolStripMenuItem sAVEGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOADGAMEToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
    }
}

