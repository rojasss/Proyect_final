namespace Proyecto_Final
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOToolStripMenuItem,
            this.cONSULTASToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            // 
            // mANTENIMIENTOToolStripMenuItem
            // 
            this.mANTENIMIENTOToolStripMenuItem.Name = "mANTENIMIENTOToolStripMenuItem";
            this.mANTENIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO";
            this.mANTENIMIENTOToolStripMenuItem.Click += new System.EventHandler(this.mANTENIMIENTOToolStripMenuItem_Click);
            // 
            // cONSULTASToolStripMenuItem
            // 
            this.cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            this.cONSULTASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            this.cONSULTASToolStripMenuItem.Click += new System.EventHandler(this.cONSULTASToolStripMenuItem_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            this.rEPORTESToolStripMenuItem.Click += new System.EventHandler(this.rEPORTESToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
    }
}