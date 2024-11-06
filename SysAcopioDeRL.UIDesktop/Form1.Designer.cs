namespace SysAcopioDeRL.UIDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dgbPrueba = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.FormattingEnabled = true;
            this.cmbPrueba.Location = new System.Drawing.Point(488, 99);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(121, 24);
            this.cmbPrueba.TabIndex = 0;
            // 
            // dgbPrueba
            // 
            this.dgbPrueba.AllowUserToAddRows = false;
            this.dgbPrueba.AllowUserToDeleteRows = false;
            this.dgbPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPrueba.Location = new System.Drawing.Point(240, 185);
            this.dgbPrueba.Name = "dgbPrueba";
            this.dgbPrueba.ReadOnly = true;
            this.dgbPrueba.RowHeadersWidth = 51;
            this.dgbPrueba.RowTemplate.Height = 24;
            this.dgbPrueba.Size = new System.Drawing.Size(240, 150);
            this.dgbPrueba.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbPrueba);
            this.Controls.Add(this.cmbPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbPrueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrueba;
        private System.Windows.Forms.DataGridView dgbPrueba;
    }
}

