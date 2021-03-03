
namespace Examen
{
    partial class TelefonoGrilla
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
            this.dgv_listaTelefono = new System.Windows.Forms.DataGridView();
            this.TelefonoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregarTelefono = new System.Windows.Forms.Button();
            this.btn_modificarTelefono = new System.Windows.Forms.Button();
            this.btn_borrarTelefono = new System.Windows.Forms.Button();
            this.btn_cerrarTelefonoGrilla = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_personaId = new System.Windows.Forms.Label();
            this.lbl_nombreSelected = new System.Windows.Forms.Label();
            this.lbl_idSelected = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listaTelefono
            // 
            this.dgv_listaTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TelefonoID,
            this.Telefono});
            this.dgv_listaTelefono.Location = new System.Drawing.Point(154, 12);
            this.dgv_listaTelefono.Name = "dgv_listaTelefono";
            this.dgv_listaTelefono.Size = new System.Drawing.Size(243, 374);
            this.dgv_listaTelefono.TabIndex = 0;
            // 
            // TelefonoID
            // 
            this.TelefonoID.DataPropertyName = "TelefonoID";
            this.TelefonoID.HeaderText = "ID";
            this.TelefonoID.Name = "TelefonoID";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // btn_agregarTelefono
            // 
            this.btn_agregarTelefono.Location = new System.Drawing.Point(11, 12);
            this.btn_agregarTelefono.Name = "btn_agregarTelefono";
            this.btn_agregarTelefono.Size = new System.Drawing.Size(135, 23);
            this.btn_agregarTelefono.TabIndex = 1;
            this.btn_agregarTelefono.Text = "Agregar telefono";
            this.btn_agregarTelefono.UseVisualStyleBackColor = true;
            this.btn_agregarTelefono.Click += new System.EventHandler(this.btn_agregarTelefono_Click);
            // 
            // btn_modificarTelefono
            // 
            this.btn_modificarTelefono.Location = new System.Drawing.Point(11, 41);
            this.btn_modificarTelefono.Name = "btn_modificarTelefono";
            this.btn_modificarTelefono.Size = new System.Drawing.Size(135, 23);
            this.btn_modificarTelefono.TabIndex = 2;
            this.btn_modificarTelefono.Text = "Modificar telefono";
            this.btn_modificarTelefono.UseVisualStyleBackColor = true;
            this.btn_modificarTelefono.Click += new System.EventHandler(this.btn_modificarTelefono_Click);
            // 
            // btn_borrarTelefono
            // 
            this.btn_borrarTelefono.Location = new System.Drawing.Point(11, 70);
            this.btn_borrarTelefono.Name = "btn_borrarTelefono";
            this.btn_borrarTelefono.Size = new System.Drawing.Size(135, 23);
            this.btn_borrarTelefono.TabIndex = 3;
            this.btn_borrarTelefono.Text = "Borrar telefono";
            this.btn_borrarTelefono.UseVisualStyleBackColor = true;
            this.btn_borrarTelefono.Click += new System.EventHandler(this.btn_borrarTelefono_Click);
            // 
            // btn_cerrarTelefonoGrilla
            // 
            this.btn_cerrarTelefonoGrilla.Location = new System.Drawing.Point(11, 363);
            this.btn_cerrarTelefonoGrilla.Name = "btn_cerrarTelefonoGrilla";
            this.btn_cerrarTelefonoGrilla.Size = new System.Drawing.Size(135, 23);
            this.btn_cerrarTelefonoGrilla.TabIndex = 4;
            this.btn_cerrarTelefonoGrilla.Text = "Cerrar";
            this.btn_cerrarTelefonoGrilla.UseVisualStyleBackColor = true;
            this.btn_cerrarTelefonoGrilla.Click += new System.EventHandler(this.btn_cerrarTelefonoGrilla_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 100);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_personaId
            // 
            this.lbl_personaId.AutoSize = true;
            this.lbl_personaId.Location = new System.Drawing.Point(13, 127);
            this.lbl_personaId.Name = "lbl_personaId";
            this.lbl_personaId.Size = new System.Drawing.Size(21, 13);
            this.lbl_personaId.TabIndex = 7;
            this.lbl_personaId.Text = "ID:";
            // 
            // lbl_nombreSelected
            // 
            this.lbl_nombreSelected.AutoSize = true;
            this.lbl_nombreSelected.Location = new System.Drawing.Point(67, 100);
            this.lbl_nombreSelected.Name = "lbl_nombreSelected";
            this.lbl_nombreSelected.Size = new System.Drawing.Size(0, 13);
            this.lbl_nombreSelected.TabIndex = 8;
            // 
            // lbl_idSelected
            // 
            this.lbl_idSelected.AutoSize = true;
            this.lbl_idSelected.Location = new System.Drawing.Point(41, 127);
            this.lbl_idSelected.Name = "lbl_idSelected";
            this.lbl_idSelected.Size = new System.Drawing.Size(0, 13);
            this.lbl_idSelected.TabIndex = 9;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(11, 302);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(135, 23);
            this.btn_actualizar.TabIndex = 10;
            this.btn_actualizar.Text = "Actualizar grilla";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // TelefonoGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 398);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.lbl_idSelected);
            this.Controls.Add(this.lbl_nombreSelected);
            this.Controls.Add(this.lbl_personaId);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_cerrarTelefonoGrilla);
            this.Controls.Add(this.btn_borrarTelefono);
            this.Controls.Add(this.btn_modificarTelefono);
            this.Controls.Add(this.btn_agregarTelefono);
            this.Controls.Add(this.dgv_listaTelefono);
            this.Name = "TelefonoGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelefonoGrilla";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listaTelefono;
        private System.Windows.Forms.Button btn_agregarTelefono;
        private System.Windows.Forms.Button btn_modificarTelefono;
        private System.Windows.Forms.Button btn_borrarTelefono;
        private System.Windows.Forms.Button btn_cerrarTelefonoGrilla;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_personaId;
        private System.Windows.Forms.Label lbl_nombreSelected;
        private System.Windows.Forms.Label lbl_idSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btn_actualizar;
    }
}