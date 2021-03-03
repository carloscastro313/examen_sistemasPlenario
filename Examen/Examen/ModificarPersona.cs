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
    public partial class ModificarPersona : Form
    {
        private Negocio negocio;
        readonly int id;
        public ModificarPersona(Negocio n, Persona p)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.negocio = n;
            this.id = p.PersonaID; 

            txt_nombre.Text = p.Nombre;
            dtp_fechaNacimiento.Value = p.FechaNacimiento;
            nud_creditoMaximo.Value = p.CreditoMaximo;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text != "" && dtp_fechaNacimiento.Value != null)
                {
                    DialogResult dialog = MessageBox.Show("¿Esta seguro que realizar esta modificarcion?", "Modificar", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        if (this.negocio.ModificarPersona(new Persona()
                        {
                            Nombre = txt_nombre.Text.Trim(),
                            FechaNacimiento = dtp_fechaNacimiento.Value,
                            CreditoMaximo = nud_creditoMaximo.Value,
                            PersonaID = id
                        }))
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
