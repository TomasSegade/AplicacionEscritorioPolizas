namespace SistemaPolizas
{
    partial class form_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Argos = new System.Windows.Forms.Button();
            this.btn_Finisterre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de polizas";
            // 
            // btn_Argos
            // 
            this.btn_Argos.Location = new System.Drawing.Point(39, 100);
            this.btn_Argos.Name = "btn_Argos";
            this.btn_Argos.Size = new System.Drawing.Size(229, 47);
            this.btn_Argos.TabIndex = 1;
            this.btn_Argos.Text = "Argos";
            this.btn_Argos.UseVisualStyleBackColor = true;
            this.btn_Argos.Click += new System.EventHandler(this.btn_Argos_Click);
            // 
            // btn_Finisterre
            // 
            this.btn_Finisterre.Location = new System.Drawing.Point(39, 184);
            this.btn_Finisterre.Name = "btn_Finisterre";
            this.btn_Finisterre.Size = new System.Drawing.Size(229, 43);
            this.btn_Finisterre.TabIndex = 2;
            this.btn_Finisterre.Text = "Finisterre";
            this.btn_Finisterre.UseVisualStyleBackColor = true;
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 286);
            this.Controls.Add(this.btn_Finisterre);
            this.Controls.Add(this.btn_Argos);
            this.Controls.Add(this.label1);
            this.Name = "form_Menu";
            this.Text = "Sistema de polizas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Argos;
        private System.Windows.Forms.Button btn_Finisterre;
    }
}

