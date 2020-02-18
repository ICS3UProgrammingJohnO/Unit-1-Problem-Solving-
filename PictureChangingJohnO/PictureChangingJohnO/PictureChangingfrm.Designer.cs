namespace PictureChangingJohnO
{
    partial class frmPicture
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
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immaculataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherTeresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.stMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolsToolStripMenuItem});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 0;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // schoolsToolStripMenuItem
            // 
            this.schoolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.immaculataToolStripMenuItem,
            this.motherTeresaToolStripMenuItem,
            this.stMarksToolStripMenuItem});
            this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
            this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.schoolsToolStripMenuItem.Text = "Schools ";
            this.schoolsToolStripMenuItem.Click += new System.EventHandler(this.SchoolsToolStripMenuItem_Click);
            // 
            // immaculataToolStripMenuItem
            // 
            this.immaculataToolStripMenuItem.Name = "immaculataToolStripMenuItem";
            this.immaculataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.immaculataToolStripMenuItem.Text = "Immaculata";
            this.immaculataToolStripMenuItem.Click += new System.EventHandler(this.ImmaculataToolStripMenuItem_Click);
            // 
            // motherTeresaToolStripMenuItem
            // 
            this.motherTeresaToolStripMenuItem.Name = "motherTeresaToolStripMenuItem";
            this.motherTeresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motherTeresaToolStripMenuItem.Text = "Mother Teresa ";
            this.motherTeresaToolStripMenuItem.Click += new System.EventHandler(this.MotherTeresaToolStripMenuItem_Click);
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblMascot);
            this.grbSchool.Controls.Add(this.lblSchool);
            this.grbSchool.Location = new System.Drawing.Point(221, 166);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(200, 100);
            this.grbSchool.TabIndex = 1;
            this.grbSchool.TabStop = false;
            this.grbSchool.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Location = new System.Drawing.Point(68, 60);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(36, 13);
            this.lblMascot.TabIndex = 2;
            this.lblMascot.Text = "Saints";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(63, 16);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(61, 13);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "Immaculata";
            this.lblSchool.Click += new System.EventHandler(this.LblPicture_Click);
            // 
            // stMarksToolStripMenuItem
            // 
            this.stMarksToolStripMenuItem.Name = "stMarksToolStripMenuItem";
            this.stMarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stMarksToolStripMenuItem.Text = "St. Mark\'s";
            this.stMarksToolStripMenuItem.Click += new System.EventHandler(this.StMarksToolStripMenuItem_Click);
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmPicture";
            this.Text = "Pictures by John O";
            this.Load += new System.EventHandler(this.FrmPicture_Load);
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immaculataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherTeresaToolStripMenuItem;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.ToolStripMenuItem stMarksToolStripMenuItem;
    }
}

