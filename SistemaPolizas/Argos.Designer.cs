namespace SistemaPolizas
{
    partial class form_Argos
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lst_lista = new System.Windows.Forms.ListBox();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Patente = new System.Windows.Forms.Label();
            this.lbl_Endoso = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Patente = new System.Windows.Forms.TextBox();
            this.txt_Endoso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(369, 204);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(262, 50);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(369, 273);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(262, 50);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(369, 342);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(262, 50);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // lst_lista
            // 
            this.lst_lista.FormattingEnabled = true;
            this.lst_lista.Location = new System.Drawing.Point(21, 24);
            this.lst_lista.Name = "lst_lista";
            this.lst_lista.Size = new System.Drawing.Size(313, 368);
            this.lst_lista.TabIndex = 3;
            this.lst_lista.SelectedIndexChanged += new System.EventHandler(this.lst_lista_SelectedIndexChanged);
            this.lst_lista.Leave += new System.EventHandler(this.lst_lista_Leave);
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dni.Location = new System.Drawing.Point(366, 35);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(46, 20);
            this.lbl_Dni.TabIndex = 4;
            this.lbl_Dni.Text = "Dni: ";
            // 
            // lbl_Patente
            // 
            this.lbl_Patente.AutoSize = true;
            this.lbl_Patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Patente.Location = new System.Drawing.Point(365, 88);
            this.lbl_Patente.Name = "lbl_Patente";
            this.lbl_Patente.Size = new System.Drawing.Size(77, 20);
            this.lbl_Patente.TabIndex = 5;
            this.lbl_Patente.Text = "Patente:";
            // 
            // lbl_Endoso
            // 
            this.lbl_Endoso.AutoSize = true;
            this.lbl_Endoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Endoso.Location = new System.Drawing.Point(366, 139);
            this.lbl_Endoso.Name = "lbl_Endoso";
            this.lbl_Endoso.Size = new System.Drawing.Size(174, 20);
            this.lbl_Endoso.TabIndex = 6;
            this.lbl_Endoso.Text = "Endoso a refacturar:";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(456, 34);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(175, 20);
            this.txt_Dni.TabIndex = 7;
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_Patente
            // 
            this.txt_Patente.Location = new System.Drawing.Point(456, 88);
            this.txt_Patente.Name = "txt_Patente";
            this.txt_Patente.Size = new System.Drawing.Size(175, 20);
            this.txt_Patente.TabIndex = 8;
            this.txt_Patente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Patente_KeyPress);
            // 
            // txt_Endoso
            // 
            this.txt_Endoso.Location = new System.Drawing.Point(546, 139);
            this.txt_Endoso.Name = "txt_Endoso";
            this.txt_Endoso.Size = new System.Drawing.Size(85, 20);
            this.txt_Endoso.TabIndex = 9;
            this.txt_Endoso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Endoso_KeyPress);
            // 
            // form_Argos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 414);
            this.Controls.Add(this.txt_Endoso);
            this.Controls.Add(this.txt_Patente);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.lbl_Endoso);
            this.Controls.Add(this.lbl_Patente);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lst_lista);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Name = "form_Argos";
            this.Text = "Argos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ListBox lst_lista;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Patente;
        private System.Windows.Forms.Label lbl_Endoso;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Patente;
        private System.Windows.Forms.TextBox txt_Endoso;
    }
}