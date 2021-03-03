
namespace Examen
{
    partial class ModificarTelefono
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numeroTelefonico = new System.Windows.Forms.TextBox();
            this.btn_modificarTelefono = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(13, 13);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(93, 13);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Numero telefonico";
            // 
            // txt_numeroTelefonico
            // 
            this.txt_numeroTelefonico.Location = new System.Drawing.Point(16, 30);
            this.txt_numeroTelefonico.Name = "txt_numeroTelefonico";
            this.txt_numeroTelefonico.Size = new System.Drawing.Size(203, 20);
            this.txt_numeroTelefonico.TabIndex = 1;
            // 
            // btn_modificarTelefono
            // 
            this.btn_modificarTelefono.Location = new System.Drawing.Point(16, 55);
            this.btn_modificarTelefono.Name = "btn_modificarTelefono";
            this.btn_modificarTelefono.Size = new System.Drawing.Size(75, 23);
            this.btn_modificarTelefono.TabIndex = 2;
            this.btn_modificarTelefono.Text = "Modificar";
            this.btn_modificarTelefono.UseVisualStyleBackColor = true;
            this.btn_modificarTelefono.Click += new System.EventHandler(this.btn_modificarTelefono_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModificarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 90);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_modificarTelefono);
            this.Controls.Add(this.txt_numeroTelefonico);
            this.Controls.Add(this.lbl_numero);
            this.Name = "ModificarTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarTelefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_numeroTelefonico;
        private System.Windows.Forms.Button btn_modificarTelefono;
        private System.Windows.Forms.Button button2;
    }
}