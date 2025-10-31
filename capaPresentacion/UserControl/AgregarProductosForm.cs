using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capaPresentacion.UserControl
{
    public partial class AgregarProductosForm : System.Windows.Forms.UserControl
    {
        private Productos agregarProducto = new Productos();
        public AgregarProductosForm()
        {
            InitializeComponent();

            txtStock.Text = "1";
            Estado.Checked = true;
        }

        private void AgregarProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Evento que se ejecuta al hacer clic en el botón "Agregar Producto"
        private void PoductoAgregar_Click(object sender, EventArgs e)
        {
            Estado.Checked = false;
            // Limpiar errores anteriores
            errorProvider1.Clear();

            bool validado = true;

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría.");
                validado = false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                errorProvider1.SetError(txtPrecio, "Ingrese un precio válido.");
                validado = false;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                errorProvider1.SetError(txtStock, "Ingrese una cantidad válida de stock.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtCaracteristicas.Text))
            {
                errorProvider1.SetError(txtCaracteristicas, "Ingrese las características.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, "La marca es obligatoria.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                errorProvider1.SetError(txtColor, "El color es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                errorProvider1.SetError(txtModelo, "El modelo es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                errorProvider1.SetError(txtNumeroSerie, "Ingrese el número de serie.");
                validado = false;
            }

            if (!int.TryParse(txtGarantia.Text, out int garantiaMeses))
            {
                errorProvider1.SetError(txtGarantia, "Ingrese la garantía en meses.");
                validado = false;
            }

            // Si hay errores, se detiene el proceso
            if (!validado)
                return;

            // Capturar los valores desde los controles del formulario
            string nombre = txtNombre.Text;
            string categoria = cmbCategoria.Text;
            string caracteristicas = txtCaracteristicas.Text;
            string marca = txtMarca.Text;
            string color = txtColor.Text;
            string modelo = txtModelo.Text;
            string numeroSerie = txtNumeroSerie.Text;

            // Llamar al método de negocio para insertar el producto
            string resultado = agregarProducto.InsertarProducto(
                nombre, categoria, precio, stock, caracteristicas,
                marca, color, modelo, numeroSerie, garantiaMeses
            );

            // Mostrar resultado al usuario
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario después de insertar
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();
            txtCaracteristicas.Clear();
            txtMarca.Clear();
            txtColor.Clear();
            txtModelo.Clear();
            txtNumeroSerie.Clear();
            txtGarantia.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
