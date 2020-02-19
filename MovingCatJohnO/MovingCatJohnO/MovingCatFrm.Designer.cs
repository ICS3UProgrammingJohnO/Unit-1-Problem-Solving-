namespace MovingCatJohnO
{
    partial class MovingCatFrm
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
            this.mnuFile3 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cat1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cat2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frank1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frank2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.mnuFile3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile3
            // 
            this.mnuFile3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.catToolStripMenuItem,
            this.frankToolStripMenuItem});
            this.mnuFile3.Location = new System.Drawing.Point(0, 0);
            this.mnuFile3.Name = "mnuFile3";
            this.mnuFile3.Size = new System.Drawing.Size(800, 24);
            this.mnuFile3.TabIndex = 0;
            this.mnuFile3.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cat1ToolStripMenuItem,
            this.cat2ToolStripMenuItem});
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.catToolStripMenuItem.Text = "Cat";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // cat1ToolStripMenuItem
            // 
            this.cat1ToolStripMenuItem.Name = "cat1ToolStripMenuItem";
            this.cat1ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cat1ToolStripMenuItem.Text = "Cat1";
            this.cat1ToolStripMenuItem.Click += new System.EventHandler(this.Cat1ToolStripMenuItem_Click);
            // 
            // cat2ToolStripMenuItem
            // 
            this.cat2ToolStripMenuItem.Name = "cat2ToolStripMenuItem";
            this.cat2ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cat2ToolStripMenuItem.Text = "Cat2";
            this.cat2ToolStripMenuItem.Click += new System.EventHandler(this.Cat2ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCat);
            this.groupBox1.Location = new System.Drawing.Point(199, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // frankToolStripMenuItem
            // 
            this.frankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frank1ToolStripMenuItem,
            this.frank2ToolStripMenuItem});
            this.frankToolStripMenuItem.Name = "frankToolStripMenuItem";
            this.frankToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.frankToolStripMenuItem.Text = "Frank";
            // 
            // frank1ToolStripMenuItem
            // 
            this.frank1ToolStripMenuItem.Name = "frank1ToolStripMenuItem";
            this.frank1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frank1ToolStripMenuItem.Text = "Frank1";
            this.frank1ToolStripMenuItem.Click += new System.EventHandler(this.Frank1ToolStripMenuItem_Click);
            // 
            // frank2ToolStripMenuItem
            // 
            this.frank2ToolStripMenuItem.Name = "frank2ToolStripMenuItem";
            this.frank2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frank2ToolStripMenuItem.Text = "Frank2";
            this.frank2ToolStripMenuItem.Click += new System.EventHandler(this.Frank2ToolStripMenuItem_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatJohnO.Properties.Resources.Frank1;
            this.picCat.Location = new System.Drawing.Point(37, 64);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(196, 178);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 3;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MovingCatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuFile3);
            this.MainMenuStrip = this.mnuFile3;
            this.Name = "MovingCatFrm";
            this.Text = "Form1";
            this.mnuFile3.ResumeLayout(false);
            this.mnuFile3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile3;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cat1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cat2ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.ToolStripMenuItem frankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frank1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frank2ToolStripMenuItem;
    }
}

