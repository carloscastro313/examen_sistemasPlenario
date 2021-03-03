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
    public partial class ModificarTelefono : Form
    {
        Negocio negocio;
        TelefonoPersona telefono;
        public ModificarTelefono(Negocio n, TelefonoPersona t)
        {
            InitializeComponent();
            this.negocio = n;
            this.telefono = t;

            txt_numeroTelefonico.Text = t.Telefono;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btn_modificarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_numeroTelefonico.Text != "")
                {
                    DialogResult dialog = MessageBox.Show("¿Esta seguro que realizar esta modificarcion?", "Modificar", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        this.telefono.Telefono = txt_numeroTelefonico.Text;
                        if (this.negocio.ModificarTelefono(this.telefono))
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error - No fue posible modificar a la persona");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error - Se tiene que completas todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
