﻿
namespace Examen
{
    partial class ModificarPersona
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_creditoMaximo = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.nud_creditoMaximo = new System.Windows.Forms.NumericUpDown();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_creditoMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.AutoSize = true;
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(9, 48);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lbl_fechaNacimiento.TabIndex = 1;
            this.lbl_fechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_creditoMaximo
            // 
            this.lbl_creditoMaximo.AutoSize = true;
            this.lbl_creditoMaximo.Location = new System.Drawing.Point(12, 87);
            this.lbl_creditoMaximo.Name = "lbl_creditoMaximo";
            this.lbl_creditoMaximo.Size = new System.Drawing.Size(78, 13);
            this.lbl_creditoMaximo.TabIndex = 2;
            this.lbl_creditoMaximo.Text = "Credito maximo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 25);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(12, 64);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(207, 20);
            this.dtp_fechaNacimiento.TabIndex = 4;
            // 
            // nud_creditoMaximo
            // 
            this.nud_creditoMaximo.Location = new System.Drawing.Point(12, 103);
            this.nud_creditoMaximo.Name = "nud_creditoMaximo";
            this.nud_creditoMaximo.Size = new System.Drawing.Size(207, 20);
            this.nud_creditoMaximo.TabIndex = 5;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(15, 136);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(144, 136);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // ModificarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 171);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.nud_creditoMaximo);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_creditoMaximo);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "ModificarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarPersona";
            ((System.ComponentModel.ISupportInitialize)(this.nud_creditoMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Label lbl_creditoMaximo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.NumericUpDown nud_creditoMaximo;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}