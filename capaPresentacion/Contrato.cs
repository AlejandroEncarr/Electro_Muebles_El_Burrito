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

namespace capaPresentacion
{
    public partial class txtInteres : Form
    {
        public txtInteres()
        {
            InitializeComponent();

        }

        private void Contrato_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox24_TextChanged(object sender, EventArgs e)
        {
            //Este es el textbox en el cual pongo el id del prodcuto
            // Validar que el texto sea un número válido
            if (int.TryParse(txtIdProducto.Text, out int productoId))
            {
                Producto producto = new Producto();
                DataTable dt = producto.ObtenerProductoPorId(productoId);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    txtNombre.Text = fila["Nombre"].ToString();
                    //txtCategoria.Text = fila["Categoria"].ToString();
                    txtPrecio.Text = fila["Precio"].ToString();
                    if (decimal.TryParse(txtPrecio.Text, out decimal precio))
                    {
                        decimal itbis = precio * 0.18m;
                        decimal totalSinItbis = precio - itbis;

                        txtITBIS.Text = itbis.ToString("N2");       // Formato con 2 decimales
                        txtTotal.Text = totalSinItbis.ToString("N2");
                        txtMontoTotalL.Text = txtPrecio.Text;

                    }
                    else
                    {
                        txtITBIS.Text = "";
                        txtTotal.Text = "";
                    }

                    //txtStock.Text = fila["Stock"].ToString();
                    //txtCaracteristicas.Text = fila["Caracteristicas"].ToString();
                    txtMarca.Text = fila["Marca"].ToString();
                    txtColor.Text = fila["Color"].ToString();
                    txtModelo.Text = fila["Modelo"].ToString();
                    txtNumeroSerie.Text = fila["NumeroSerie"].ToString();
                    txtGarantiaMeses.Text = fila["GarantiaMeses"].ToString();
                }
                else
                {
                    LimpiarCamposProducto();
                }
            }
            else
            {
                LimpiarCamposProducto();
            }

        }

        private void LimpiarCamposProducto()
        {
            txtNombre.Text = "";
            //txtCategoria.Text = "";
            txtPrecio.Text = "";
            //txtStock.Text = "";
            //txtCaracteristicas.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtModelo.Text = "";
            txtNumeroSerie.Text = "";
            txtGarantiaMeses.Text = "";
        }

        private void txtIdVendedor_TextChanged(object sender, EventArgs e)
        {
            //Este es el textbox en el cual pongo el id del vendedor
            // Validar que el texto sea un número válido
            if (int.TryParse(txtIdVendedor.Text, out int vendedorid))
            {
                Vendedor producto = new Vendedor();
                DataTable dt = producto.ObtenerVendedorPorId(vendedorid);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    txtDirreccion.Text = fila["Direccion"].ToString();
                    txtTelefono.Text = fila["Telefono"].ToString();
                    txtEmail.Text = fila["Email"].ToString();
                    txtNombreComercial.Text = fila["NombreComercial"].ToString();
                    txtRNC.Text = fila["RNC"].ToString();
                }
                else
                {
                    LimpiarCamposProducto();
                }
            }
            else
            {
                LimpiarCamposProducto();
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdCliente.Text, out int clienteId))
            {
                Clienteid cliente = new Clienteid();
                DataTable dt = cliente.ObtenerClientePorId(clienteId);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    txtCedula.Text = fila["Cedula"].ToString();
                    txtNombreCompleto.Text = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString(); // ← Concatenado
                    txtTelefonoCliente.Text = fila["Telefono"].ToString();
                    txtEmailCliente.Text = fila["Email"].ToString();
                    txtDireccion.Text = fila["Direccion"].ToString();
                }
                else
                {
                    LimpiarCamposCliente();
                }
            }
            else
            {
                LimpiarCamposCliente();
            }


        }

        private void LimpiarCamposCliente()
        {
            txtCedula.Text = "";
            txtNombreCompleto.Text = "";
            txtTelefono.Text = "";
            txtEmailCliente.Text = "";
            txtDireccion.Text = "";
        }

        private void GuardarContraro_Click(object sender, EventArgs e)
        {
            /*
                        if(Fiduciario.Checked == true)
                        {
                            // Capturar los valores desde los controles del formulario
                            DateTime fechaInicio = DateTime.Now; // ← automática
                            DateTime fechaFinal = DateTime.Now;
                           // DateTime fechaFinal = txtFechaFinal.Value;
                            decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text);
                            decimal montoInicial = Convert.ToDecimal(txtMontoInicial.Text);
                            // string estado = Estado.Text;
                            string estado = "Activo";
                            int clienteID = Convert.ToInt32(txtIdCliente.Text);
                            int productoID = Convert.ToInt32(txtIdProducto.Text);
                            string pagosPeriodicos = txtPagosPeriodicos.Text;

                            // Llamar al método de negocio para insertar el contrato Layaway
                            Layaway layaway = new Layaway();
                            string resultado = layaway.InsertarLayaway(
                                fechaInicio,
                                fechaFinal,
                                montoTotal,
                                montoInicial,
                                estado,
                                clienteID,
                                productoID,
                                pagosPeriodicos
                            );


                        }
                        else
                        {

                        }*/


        }

        private void Fiduciario_CheckedChanged(object sender, EventArgs e)
        {
            if (Fiduciario.Checked)
            {
                Apartado.Checked = false; // Desmarcar el otro
            }
            ActualizarEstadoCampos();

        }



        private void BloqueoFiduciario()
        {

        }

        private void guna2TextBox25_TextChanged(object sender, EventArgs e)
        {
        }

        private void Apartado_CheckedChanged(object sender, EventArgs e)
        {
            if (Apartado.Checked)
            {
                Fiduciario.Checked = false; // Desmarcar el otro
            }
            ActualizarEstadoCampos();

        }

        private void ActualizarEstadoCampos()
        {
            bool esFiduciario = Fiduciario.Checked;
            bool esLayaway = Apartado.Checked;

            // Campos Fiduciario
            txtMontoFinanciado.Enabled = esFiduciario;
            txtCuotasMensuales.Enabled = esFiduciario;
            txtPlazoMeses.Enabled = esFiduciario;
            txtInteresAnual.Enabled = esFiduciario;
            FechaInicioM.Enabled = esFiduciario;
            FechaFinM.Enabled = esFiduciario;

            // Campos Layaway
            txtMontoTotalL.Enabled = esLayaway;
            txtPagoInicialL.Enabled = esLayaway;
            txtPagosPeriodicosL.Enabled = esLayaway;
            dtpFechaLimiteL.Enabled = esLayaway;
            //dtpFechaLimiteL.Enabled = esLayaway;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoTotalL_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
