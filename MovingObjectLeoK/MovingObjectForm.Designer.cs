namespace MovingObject
{
    partial class frmMovingObject
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
            this.mnuObject = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniObject = new System.Windows.Forms.ToolStripMenuItem();
            this.mniObject1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniObject2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.mnuObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuObject
            // 
            this.mnuObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniObject});
            this.mnuObject.Location = new System.Drawing.Point(0, 0);
            this.mnuObject.Name = "mnuObject";
            this.mnuObject.Size = new System.Drawing.Size(284, 24);
            this.mnuObject.TabIndex = 0;
            this.mnuObject.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mniObject
            // 
            this.mniObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniObject1,
            this.mniObject2});
            this.mniObject.Name = "mniObject";
            this.mniObject.Size = new System.Drawing.Size(54, 20);
            this.mniObject.Text = "Object";
            // 
            // mniObject1
            // 
            this.mniObject1.Name = "mniObject1";
            this.mniObject1.Size = new System.Drawing.Size(152, 22);
            this.mniObject1.Text = "Object 1";
            this.mniObject1.Click += new System.EventHandler(this.object1ToolStripMenuItem_Click);
            // 
            // mniObject2
            // 
            this.mniObject2.Name = "mniObject2";
            this.mniObject2.Size = new System.Drawing.Size(152, 22);
            this.mniObject2.Text = "Object 2";
            this.mniObject2.Click += new System.EventHandler(this.mniObject2_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingObject.Properties.Resources.cat1;
            this.picCat.Location = new System.Drawing.Point(40, 54);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(195, 177);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            // 
            // frmMovingObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuObject);
            this.MainMenuStrip = this.mnuObject;
            this.Name = "frmMovingObject";
            this.Text = "Moving Object by Leo Kay";
            this.mnuObject.ResumeLayout(false);
            this.mnuObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuObject;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniObject;
        private System.Windows.Forms.ToolStripMenuItem mniObject1;
        private System.Windows.Forms.ToolStripMenuItem mniObject2;
        private System.Windows.Forms.PictureBox picCat;
    }
}

