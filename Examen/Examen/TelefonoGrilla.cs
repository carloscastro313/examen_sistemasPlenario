using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Examen
{
    public partial class TelefonoGrilla : Form
    {
        Negocio negocio;
        Persona persona;
        public TelefonoGrilla(Negocio n, Persona p)
        {
            InitializeComponent();
            this.negocio = n;
            this.persona = p;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dgv_listaTelefono.ReadOnly = true;
            lbl_nombreSelected.Text = p.Nombre;
            lbl_idSelected.Text = p.PersonaID.ToString();
            this.actualizar();
        }

        public void actualizar()
        {
            try
            {
                dgv_listaTelefono.DataSource = this.negocio.GetListaTelefono(this.persona.PersonaID)
                                                            .Select((x) => new { x.TelefonoID, x.Telefono })
                                                            .ToList();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void btn_cerrarTelefonoGrilla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregarTelefono_Click(object sender, EventArgs e)
        {
            AgregarTelefono agregarTelefono = new AgregarTelefono(this.persona.PersonaID, this.negocio);

            agregarTelefono.ShowDialog();
            this.actualizar();
        }

        private void btn_modificarTelefono_Click(object sender, EventArgs e)
        {
            ModificarTelefono modificarTelefono = new ModificarTelefono(this.negocio, new TelefonoPersona()
            {
                PersonaID = this.persona.PersonaID,
                Telefono = (string)dgv_listaTelefono.CurrentRow.Cells[1].Value,
                TelefonoID = (int)dgv_listaTelefono.CurrentRow.Cells[0].Value,
            });
            modificarTelefono.ShowDialog();
            this.actualizar();
        }

        private void btn_borrarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.negocio.EliminarTelefono((int)dgv_listaTelefono.CurrentRow.Cells[0].Value))
                {
                    this.actualizar();
                }
                else
                {
                    MessageBox.Show("Error - No fue posible eliminar a la persona");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }
    }
}
