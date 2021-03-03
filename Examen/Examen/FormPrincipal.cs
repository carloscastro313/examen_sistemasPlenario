using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Examen
{
    public partial class FormPrincipal : Form
    {
        Negocio negocio;
        public FormPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            btn_reconectar.Hide();
            dgv_Personas.ReadOnly = true;
            this.conectar();
            this.actualizar();
        }

        private void conectar()
        {
            try
            {
                this.negocio = new Negocio();
                btn_reconectar.Hide();
            }
            catch (Exception e)
            {
                btn_reconectar.Show();
                MessageBox.Show(e.Message);
            }
        }

        private void actualizar()
        {
            try
            {
                dgv_Personas.DataSource = this.negocio.GetLista;
            }
            catch (Exception e)
            {
                btn_reconectar.Show();
                MessageBox.Show(e.Message);
            }
        }

        private void btn_AgregarPersona_Click(object sender, EventArgs e)
        {
            AgregarPersona frm_agregarPersona = new AgregarPersona(this.negocio);
            
            frm_agregarPersona.ShowDialog();
            this.actualizar();
        }

        private void btn_eliminarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.negocio.EliminarPersona((int)dgv_Personas.CurrentRow.Cells[0].Value))
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
                btn_reconectar.Show();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modificarPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona() {
                PersonaID = (int)dgv_Personas.CurrentRow.Cells[0].Value,
                Nombre = (string)dgv_Personas.CurrentRow.Cells[1].Value,
                CreditoMaximo = (decimal)dgv_Personas.CurrentRow.Cells[3].Value,
                FechaNacimiento = (DateTime)dgv_Personas.CurrentRow.Cells[2].Value
            };
            ModificarPersona frm_modificarPersona = new ModificarPersona(this.negocio, persona);

            frm_modificarPersona.ShowDialog();
            this.actualizar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreBuscar.Text != "")
                {
                    dgv_Personas.DataSource = this.negocio.GetPersonas_Nombre(txt_nombreBuscar.Text.Trim());
                }
                else
                {
                    this.actualizar();
                }
            }
            catch (Exception ex)
            {
                btn_reconectar.Show();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void btn_reconectar_Click(object sender, EventArgs e)
        {
            this.conectar();
            this.actualizar();
        }

        private void btn_telefono_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona()
            {
                PersonaID = (int)dgv_Personas.CurrentRow.Cells[0].Value,
                Nombre = (string)dgv_Personas.CurrentRow.Cells[1].Value,
                CreditoMaximo = (decimal)dgv_Personas.CurrentRow.Cells[3].Value,
                FechaNacimiento = (DateTime)dgv_Personas.CurrentRow.Cells[2].Value
            };
            TelefonoGrilla telefonoGrilla = new TelefonoGrilla(this.negocio, persona);

            telefonoGrilla.ShowDialog();
        }
    }
}
