
using capaNegocio; // Referencia a la capa negocio
using System.Drawing.Text;
using System.Net.NetworkInformation;

namespace capaPresentacion

{
    public partial class Login : Form
    {
        //Instancia de la clase validacion
        private Validacion verificar = new Validacion();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = this.UsuarioT.Text.Trim();
            string contrasena = this.ClaveT.Text.Trim();

            bool camposValidos = true;

            // Validar campo Usuario
            if (string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(UsuarioT, "El campo Usuario es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(UsuarioT, "");
            }

            // Validar campo Contraseña
            if (string.IsNullOrEmpty(contrasena))
            {
                errorProvider1.SetError(ClaveT, "El campo Contraseña es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(ClaveT, "");
            }

            // Si los campos están válidos, continuar con el login
            if (camposValidos)
            {
                bool validar = verificar.ValidarLogin(usuario, contrasena);
                if (validar)
                {
                    txtFechaVencimiento menu = new txtFechaVencimiento();
                    menu.Show();
                    UsuarioT.Text = "";
                    ClaveT.Text = "";

                    //MessageBox.Show("Bienvenido " + usuario);
                }
                else
                    MessageBox.Show("Usuario o Clave incorrectos");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar_Usuario registrar_Usuario = new Registrar_Usuario();
            registrar_Usuario.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registrar_Usuario registrar_Usuario = new Registrar_Usuario();
            registrar_Usuario.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar_Usuario registrar_Usuario = new Registrar_Usuario();
            registrar_Usuario.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = this.UsuarioT.Text.Trim();
            string contrasena = this.ClaveT.Text.Trim();

            bool camposValidos = true;

            // Validar campo Usuario
            if (string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(UsuarioT, "El campo Usuario es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(UsuarioT, "");
            }

            // Validar campo Contraseña
            if (string.IsNullOrEmpty(contrasena))
            {
                errorProvider1.SetError(ClaveT, "El campo Contraseña es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(ClaveT, "");
            }

            // Si los campos están válidos, continuar con el login
            if (camposValidos)
            {
                bool validar = verificar.ValidarLogin(usuario, contrasena);
                if (validar)
                {
                    txtFechaVencimiento menu = new txtFechaVencimiento();
                    menu.Show();
                    UsuarioT.Text = "";
                    ClaveT.Text = "";

                    //MessageBox.Show("Bienvenido " + usuario);
                }
                else
                    MessageBox.Show("Usuario o Clave incorrectos");
            }
        }

        private void GuardarContraro_Click(object sender, EventArgs e)
        {
            string usuario = this.UsuarioT.Text.Trim();
            string contrasena = this.ClaveT.Text.Trim();

            bool camposValidos = true;

            // Validar campo Usuario
            if (string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(UsuarioT, "El campo Usuario es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(UsuarioT, "");
            }

            // Validar campo Contraseña
            if (string.IsNullOrEmpty(contrasena))
            {
                errorProvider1.SetError(ClaveT, "El campo Contraseña es obligatorio.");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(ClaveT, "");
            }

            // Si los campos están válidos, continuar con el login
            if (camposValidos)
            {
                bool validar = verificar.ValidarLogin(usuario, contrasena);
                if (validar)
                {
                    txtFechaVencimiento menu = new txtFechaVencimiento();
                    menu.Show();
                    UsuarioT.Text = "";
                    ClaveT.Text = "";

                    //MessageBox.Show("Bienvenido " + usuario);
                }
                else
                    MessageBox.Show("Usuario o Clave incorrectos");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }

}
