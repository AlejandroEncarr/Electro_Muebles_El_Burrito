using capaDatos;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.UserControl
{
    public partial class RegistrarClienteForm : System.Windows.Forms.UserControl
    {
        private Cliente agregarCliente = new Cliente();
        public RegistrarClienteForm()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void PoductoAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool validado = true;

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider1.SetError(txtApellido, "El apellido es Obligatorio.");
                validado = false;
            }

            if (!decimal.TryParse(txtCedula.Text, out decimal precio))
            {
                errorProvider1.SetError(txtCedula, "Ingrese la cedula.");
                validado = false;
            }

            if (!int.TryParse(txtDireccion.Text, out int stock))
            {
                errorProvider1.SetError(txtDireccion, "Ingrese una direccion válida de stock.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese un gmail.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Ingrese un numero de telefono.");
                validado = false;
            }

            // Si hay errores, se detiene el proceso
            if (!validado)
                return;

            // Capturar los valores desde los controles del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;


            // Llamar al método de negocio para insertar el producto
            string resultado = agregarCliente.InsertarCliente(
                nombre, apellido, cedula, telefono, email,
                direccion
            );

            // Mostrar resultado al usuario
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario después de insertar
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
