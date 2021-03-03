
namespace Examen
{
    partial class FormPrincipal
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
            this.dgv_Personas = new System.Windows.Forms.DataGridView();
            this.PersonaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarPersona = new System.Windows.Forms.Button();
            this.btn_eliminarPersona = new System.Windows.Forms.Button();
            this.btn_modificarPersona = new System.Windows.Forms.Button();
            this.btn_telefono = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nombreBuscar = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_reconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Personas
            // 
            this.dgv_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Personas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonaID,
            this.Nombre,
            this.FechaNacimiento,
            this.CreditoMaximo});
            this.dgv_Personas.Location = new System.Drawing.Point(12, 12);
            this.dgv_Personas.Name = "dgv_Personas";
            this.dgv_Personas.Size = new System.Drawing.Size(444, 398);
            this.dgv_Personas.TabIndex = 0;
            // 
            // PersonaID
            // 
            this.PersonaID.DataPropertyName = "PersonaID";
            this.PersonaID.HeaderText = "ID";
            this.PersonaID.Name = "PersonaID";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // CreditoMaximo
            // 
            this.CreditoMaximo.DataPropertyName = "CreditoMaximo";
            this.CreditoMaximo.HeaderText = "Credito maximo";
            this.CreditoMaximo.Name = "CreditoMaximo";
            // 
            // btn_AgregarPersona
            // 
            this.btn_AgregarPersona.Location = new System.Drawing.Point(462, 11);
            this.btn_AgregarPersona.Name = "btn_AgregarPersona";
            this.btn_AgregarPersona.Size = new System.Drawing.Size(124, 23);
            this.btn_AgregarPersona.TabIndex = 1;
            this.btn_AgregarPersona.Text = "Agregar persona";
            this.btn_AgregarPersona.UseVisualStyleBackColor = true;
            this.btn_AgregarPersona.Click += new System.EventHandler(this.btn_AgregarPersona_Click);
            // 
            // btn_eliminarPersona
            // 
            this.btn_eliminarPersona.Location = new System.Drawing.Point(462, 41);
            this.btn_eliminarPersona.Name = "btn_eliminarPersona";
            this.btn_eliminarPersona.Size = new System.Drawing.Size(124, 23);
            this.btn_eliminarPersona.TabIndex = 2;
            this.btn_eliminarPersona.Text = "Eliminar persona";
            this.btn_eliminarPersona.UseVisualStyleBackColor = true;
            this.btn_eliminarPersona.Click += new System.EventHandler(this.btn_eliminarPersona_Click);
            // 
            // btn_modificarPersona
            // 
            this.btn_modificarPersona.Location = new System.Drawing.Point(462, 71);
            this.btn_modificarPersona.Name = "btn_modificarPersona";
            this.btn_modificarPersona.Size = new System.Drawing.Size(124, 23);
            this.btn_modificarPersona.TabIndex = 3;
            this.btn_modificarPersona.Text = "Modificar persona";
            this.btn_modificarPersona.UseVisualStyleBackColor = true;
            this.btn_modificarPersona.Click += new System.EventHandler(this.btn_modificarPersona_Click);
            // 
            // btn_telefono
            // 
            this.btn_telefono.Location = new System.Drawing.Point(462, 101);
            this.btn_telefono.Name = "btn_telefono";
            this.btn_telefono.Size = new System.Drawing.Size(124, 23);
            this.btn_telefono.TabIndex = 4;
            this.btn_telefono.Text = "Telefono";
            this.btn_telefono.UseVisualStyleBackColor = true;
            this.btn_telefono.Click += new System.EventHandler(this.btn_telefono_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(111, 413);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(50, 23);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_nombreBuscar
            // 
            this.txt_nombreBuscar.Location = new System.Drawing.Point(12, 415);
            this.txt_nombreBuscar.Name = "txt_nombreBuscar";
            this.txt_nombreBuscar.Size = new System.Drawing.Size(93, 20);
            this.txt_nombreBuscar.TabIndex = 6;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(462, 406);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(120, 23);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "Actualizar lista";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_reconectar
            // 
            this.btn_reconectar.Location = new System.Drawing.Point(462, 377);
            this.btn_reconectar.Name = "btn_reconectar";
            this.btn_reconectar.Size = new System.Drawing.Size(120, 23);
            this.btn_reconectar.TabIndex = 8;
            this.btn_reconectar.Text = "Reconectar";
            this.btn_reconectar.UseVisualStyleBackColor = true;
            this.btn_reconectar.Click += new System.EventHandler(this.btn_reconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 441);
            this.Controls.Add(this.btn_reconectar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_nombreBuscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_telefono);
            this.Controls.Add(this.btn_modificarPersona);
            this.Controls.Add(this.btn_eliminarPersona);
            this.Controls.Add(this.btn_AgregarPersona);
            this.Controls.Add(this.dgv_Personas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Personas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoMaximo;
        private System.Windows.Forms.Button btn_AgregarPersona;
        private System.Windows.Forms.Button btn_eliminarPersona;
        private System.Windows.Forms.Button btn_modificarPersona;
        private System.Windows.Forms.Button btn_telefono;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombreBuscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_reconectar;
    }
}

