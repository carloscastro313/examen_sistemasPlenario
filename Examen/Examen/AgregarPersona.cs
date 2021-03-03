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
    public partial class AgregarPersona : Form
    {
        Negocio negocios;
        public AgregarPersona(Negocio negocios)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.negocios = negocios;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nombre.Text != "" && dtp_fechaNacimiento.Value != null)
                {
                    this.negocios.AgregarPersona(new Persona()
                    {
                        Nombre = txt_nombre.Text.Trim(),
                        FechaNacimiento = dtp_fechaNacimiento.Value,
                        CreditoMaximo = nud_creditoMaximo.Value,
                        PersonaID = 0
                    });

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error - Se tiene que completas todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
