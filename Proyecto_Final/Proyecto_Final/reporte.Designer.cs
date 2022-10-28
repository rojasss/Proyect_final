namespace Proyecto_Final
{
    partial class reporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE CLIENTE";
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(126, 214);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(240, 150);
            this.dgvReporte.TabIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(69, 122);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(111, 44);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(332, 122);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(96, 44);
            this.btnPdf.TabIndex = 3;
            this.btnPdf.Text = "Exportar PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOToolStripMenuItem,
            this.cONSULTAToolStripMenuItem,
            this.mENUToolStripMenuItem});
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
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cONSULTAToolStripMenuItem.Text = "CONSULTA";
            this.cONSULTAToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAToolStripMenuItem_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 439);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reporte";
            this.Text = "reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}