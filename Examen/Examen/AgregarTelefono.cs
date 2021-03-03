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
    public partial class AgregarTelefono : Form
    {
        int id;
        Negocio negocio;
        public AgregarTelefono(int id, Negocio n)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.id = id;
            this.negocio = n;
        }

        private void btn_agregarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_numero.Text.Trim() != "")
                {
                    this.negocio.AgregarTelefono(new TelefonoPersona()
                    {
                        PersonaID = this.id,
                        Telefono = txt_numero.Text.Trim()
                    });

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error - No fue posible agregar un numero de telefono");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
