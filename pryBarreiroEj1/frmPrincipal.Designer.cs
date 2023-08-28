namespace pryBarreiroEj1
{
    partial class frmPrincipal
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
            this.cmdCrearCarpeta = new System.Windows.Forms.Button();
            this.cmdLeerArchico = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCrearCarpeta
            // 
            this.cmdCrearCarpeta.Location = new System.Drawing.Point(12, 316);
            this.cmdCrearCarpeta.Name = "cmdCrearCarpeta";
            this.cmdCrearCarpeta.Size = new System.Drawing.Size(111, 59);
            this.cmdCrearCarpeta.TabIndex = 0;
            this.cmdCrearCarpeta.Text = "Crear carpeta";
            this.cmdCrearCarpeta.UseVisualStyleBackColor = true;
            this.cmdCrearCarpeta.Click += new System.EventHandler(this.cmdCrearCarpeta_Click);
            // 
            // cmdLeerArchico
            // 
            this.cmdLeerArchico.Location = new System.Drawing.Point(242, 316);
            this.cmdLeerArchico.Name = "cmdLeerArchico";
            this.cmdLeerArchico.Size = new System.Drawing.Size(111, 59);
            this.cmdLeerArchico.TabIndex = 1;
            this.cmdLeerArchico.Text = "leer carpeta";
            this.cmdLeerArchico.UseVisualStyleBackColor = true;
            this.cmdLeerArchico.Click += new System.EventHandler(this.cmdLeerArchico_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(242, 228);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(111, 59);
            this.cmdGrabar.TabIndex = 2;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(12, 24);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(341, 198);
            this.txtDatos.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 387);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdLeerArchico);
            this.Controls.Add(this.cmdCrearCarpeta);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCrearCarpeta;
        private System.Windows.Forms.Button cmdLeerArchico;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.TextBox txtDatos;
    }
}