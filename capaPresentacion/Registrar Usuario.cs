using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace capaPresentacion
{
    public partial class Registrar_Usuario : Form
    {
        Validacion verificar = new Validacion();
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.Usuario.Text;
            string contrasena = this.Contrasena.Text;
            string IdRoll = this.IdRoll.Text;

            //Esta variable es para romper el bucle del error provide
            bool camposValidos = true;

            if (string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(Usuario, "El campo Usuario es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(Usuario, "");
            }

            if (camposValidos)
            {
                bool validar = verificar.ValidarUsuario(usuario);
                if (validar)
                {
                    MessageBox.Show("Usuario ya existe " + usuario);
                    errorProvider1.SetError(Usuario,"Usuario ya existe");
                }
                else
                {
                    verificar.InsertarUsuario(usuario, contrasena, Convert.ToInt32(IdRoll));

                }
            }
            
        }
    }
}
