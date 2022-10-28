namespace Proyecto_Final
{
    partial class consulta
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
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarPais = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(62, 188);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(501, 150);
            this.dgvConsulta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID CLIENTE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAIS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONSULTA CLIENTE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboId
            // 
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(220, 95);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(121, 21);
            this.cboId.TabIndex = 4;
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(220, 141);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(121, 21);
            this.cboPais.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(399, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 29);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Id";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.Location = new System.Drawing.Point(399, 137);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(105, 30);
            this.btnBuscarPais.TabIndex = 7;
            this.btnBuscarPais.Text = "Buscar Pais";
            this.btnBuscarPais.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(251, 380);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Motrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOToolStripMenuItem,
            this.rEPORTEToolStripMenuItem,
            this.mENUToolStripMenuItem});
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            // 
            // mANTENIMIENTOToolStripMenuItem
            // 
            this.mANTENIMIENTOToolStripMenuItem.Name = "mANTENIMIENTOToolStripMenuItem";
            this.mANTENIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO";
            this.mANTENIMIENTOToolStripMenuItem.Click += new System.EventHandler(this.mANTENIMIENTOToolStripMenuItem_Click);
            // 
            // rEPORTEToolStripMenuItem
            // 
            this.rEPORTEToolStripMenuItem.Name = "rEPORTEToolStripMenuItem";
            this.rEPORTEToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.rEPORTEToolStripMenuItem.Text = "REPORTE";
            this.rEPORTEToolStripMenuItem.Click += new System.EventHandler(this.rEPORTEToolStripMenuItem_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnBuscarPais);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.cboId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "consulta";
            this.Text = "consulta";
            this.Load += new System.EventHandler(this.consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarPais;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}