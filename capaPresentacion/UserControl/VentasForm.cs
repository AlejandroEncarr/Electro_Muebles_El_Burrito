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
    public partial class VentasForm : System.Windows.Forms.UserControl
    {
        public VentasForm()
        {
            InitializeComponent();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarEstadoCampos()
        {
            bool esFiduciario = Fiduciario.Checked;
            bool esLayaway = Apartado.Checked;
            bool esContado = Contado.Checked;

            // Campos Fiduciario
            txtMontoFinanciado.Enabled = esFiduciario;
            txtCuotasMensuales.Enabled = esFiduciario;
            txtPlazoMeses.Enabled = esFiduciario;
            txtInteresAnual.Enabled = esFiduciario;
            FechaInicio.Enabled = esFiduciario;
            txtFechaVencimiento.Enabled = esFiduciario;

            // Campos Layaway
            // txtMontoTotalL.Enabled = esLayaway;
            txtPagoInicial.Enabled = esLayaway;
            txtPagosPeriodicos.Enabled = esLayaway;
            txtFechaLimite.Enabled = esLayaway;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Contado.Checked)
            {
                Apartado.Checked = false; // Desmarcar el otro
                Contado.Checked = false;
            }
            ActualizarEstadoCampos();
        }

        private void Apartado_CheckedChanged(object sender, EventArgs e)
        {
            if (Apartado.Checked)
            {
                Contado.Checked = false; // Desmarcar el otro
                Fiduciario.Checked = false; // Desmarcar el otro

            }
            ActualizarEstadoCampos();
        }

        private void Contado_CheckedChanged(object sender, EventArgs e)
        {
            if (Contado.Checked)
            {
                Fiduciario.Checked = false; // Desmarcar el otro
                Apartado.Checked = false;
            }
            ActualizarEstadoCampos();
        }

        private void GuaradarVentas_Click(object sender, EventArgs e)
        {
            string metodopago = "";

            if (Contado.Checked)
            {
                metodopago = "Contado";
            }
            else if (Apartado.Checked)
            {
                metodopago = "Layaway";
            }
            else if (Fiduciario.Checked)
            {
                metodopago = "Fiduciario";
            }

            DateTime fechaVenta = DateTime.Today;

            int ventaID = Venta.InsertarVenta(
                Convert.ToInt32(txtClienteId.Text),
                Convert.ToInt32(txtIdProducto.Text),
                Convert.ToInt32(txtVendedorID.Text),
                fechaVenta,
                metodopago,
                Convert.ToDecimal(txtSubTotal.Text),
                Convert.ToDecimal(txtITBIS.Text),
                Convert.ToDecimal(txtMontoTotal.Text)
            );

            // Insertar método de pago correspondiente
            if (Contado.Checked)
            {
                // Venta.InsertarMetodoPagoContado(ventaID, tipoMetodo, fechaPago, montoTotal);
            }
            else if (Apartado.Checked)
            {

                // Venta.InsertarMetodoPagoLayaway(ventaID, 
            }
            else if (Fiduciario.Checked)
            {

            }

            MessageBox.Show("Contrato guardado correctamente.");

        }

        private void txtProductoID_TextChanged(object sender, EventArgs e)
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

                    txtMontoTotal.Text = fila["Precio"].ToString();
                    if (decimal.TryParse(txtMontoTotal.Text, out decimal precio))
                    {
                        decimal itbis = precio * 0.18m;
                        decimal totalSinItbis = precio - itbis;

                        txtITBIS.Text = itbis.ToString("N2");       // Formato con 2 decimales
                        txtSubTotal.Text = totalSinItbis.ToString("N2");
                    

                    }
                    else
                    {
                        txtITBIS.Text = "";
                        txtMontoTotal.Text = "";
                    }
                 
                }
                else
                {
                    //LimpiarCamposProducto();
                }
            }
            else
            {
                //LimpiarCamposProducto();
            }
        }

        private void txtVendedorID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
