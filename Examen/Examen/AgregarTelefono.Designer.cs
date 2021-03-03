
namespace Examen
{
    partial class AgregarTelefono
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
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_agregarTelefono = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(13, 13);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(93, 13);
            this.lbl_telefono.TabIndex = 0;
            this.lbl_telefono.Text = "Numero telefonico";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(16, 30);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(203, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // btn_agregarTelefono
            // 
            this.btn_agregarTelefono.Location = new System.Drawing.Point(16, 56);
            this.btn_agregarTelefono.Name = "btn_agregarTelefono";
            this.btn_agregarTelefono.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarTelefono.TabIndex = 2;
            this.btn_agregarTelefono.Text = "Agregar";
            this.btn_agregarTelefono.UseVisualStyleBackColor = true;
            this.btn_agregarTelefono.Click += new System.EventHandler(this.btn_agregarTelefono_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(144, 56);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // AgregarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 90);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_agregarTelefono);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_telefono);
            this.Name = "AgregarTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarTelefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_agregarTelefono;
        private System.Windows.Forms.Button btn_cerrar;
    }
}