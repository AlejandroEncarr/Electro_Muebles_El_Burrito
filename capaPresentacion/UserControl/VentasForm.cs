using capaDatos;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
            FechaVenta.Text = DateTime.Today.ToString("yyyy-MM-dd");

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

            if (Fiduciario.Checked)
            {
                txtInteresAnual.Text = "18";
                FechaInicio.Text = DateTime.Today.ToString("yyyy-MM-dd");

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
                decimal montotal = Convert.ToDecimal(txtMontoTotal.Text);
                Venta.InsertarMetodoPagoContado(ventaID, metodopago, fechaVenta, montotal);
                MessageBox.Show("Venta guardado correctamente.");
                LimpiarCamposVenta();
            }
            else if (Apartado.Checked)
            {

                decimal montoInicial = Convert.ToDecimal(txtPagoInicial.Text);
                decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text);
                decimal montoPagado = montoInicial; // Inicialmente no se ha pagado nada
                string periodoPago = txtPlazoMeses.Text;
                string estado = "1";

                // Ya validaste esta fecha antes
                DateTime fechaLimite = Convert.ToDateTime(txtFechaLimite.Text);

                Venta.InsertarMetodoPagoLayaway(
                    ventaID,
                    metodopago,
                    DateTime.Today,       // Fecha de inicio
                    fechaLimite,          // Fecha final (vencimiento)
                    montoTotal,
                    montoInicial,
                    montoPagado,
                    estado,
                    periodoPago
                );

                txtFechaVencimiento.Text = fechaLimite.ToString("yyyy-MM-dd");
                MessageBox.Show("Venta guardado correctamente.");
                LimpiarCamposVenta();



            }
            else if (Fiduciario.Checked)
            {
                // Obtener valores desde la interfaz
                decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text);
                decimal montoPagado = Convert.ToDecimal(txtMotoPagado.Text);
                string estado = "1";
                decimal montoFinanciado = montoTotal - montoPagado;
                decimal cuotasMensuales = Convert.ToDecimal(txtCuotasMensuales.Text);
                int plazo = Convert.ToInt32(txtPlazoMeses.Text);
                decimal interesAnual = Convert.ToDecimal(txtInteresAnual.Text);

                DateTime fechaInicio = Convert.ToDateTime(FechaInicio.Text);
                DateTime fechaVencimiento = fechaInicio.AddMonths(plazo);

                // Mostrar la fecha de vencimiento en la interfaz
                txtFechaVencimiento.Text = fechaVencimiento.ToString("yyyy-MM-dd");

                // Insertar en base de datos usando la capa de negocio
                conexion.InsertarFiduciario(ventaID, montoTotal, montoPagado, estado,
                                        montoFinanciado, cuotasMensuales, plazo,
                                        interesAnual, fechaInicio, fechaVencimiento);
            }

            MessageBox.Show("Venta guardado correctamente.");
            LimpiarCamposVenta();


        }

        private void LimpiarCamposVenta()
        {
            // Datos generales
            txtClienteId.Clear();
            txtIdProducto.Clear();
            txtVendedorID.Clear();
            txtSubTotal.Clear();
            txtITBIS.Clear();
            txtMontoTotal.Clear();

            // Contado
            // (no hay campos adicionales específicos)

            // Layaway
            txtPagoInicial.Clear();
            txtPagosPeriodicos.Clear();
            txtFechaLimite.Clear();

            // Fiduciario
            txtMontoFinanciado.Clear();
            txtCuotasMensuales.Clear();
            txtPlazoMeses.Clear();
            txtInteresAnual.Clear();
            txtMotoPagado.Clear();
            FechaInicio.Clear();

            // Común
            txtFechaVencimiento.Clear();

            // Opcional: desmarcar checkboxes
            Contado.Checked = false;
            Apartado.Checked = false;
            Fiduciario.Checked = false;

            // Restaurar fecha actual
            FechaVenta.Text = DateTime.Today.ToString("yyyy-MM-dd");
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

        private void txtPlazoMeses_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal montoPagado = Convert.ToDecimal(txtMotoPagado.Text);
                decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text);
                decimal montoFinanciado = montoTotal - montoPagado;

                decimal tasaMensual = 0.015m; // 18% anual dividido entre 12
                int meses = Convert.ToInt32(txtPlazoMeses.Text);

                decimal cuota = montoFinanciado * tasaMensual /
                                (1 - (decimal)Math.Pow((double)(1 + tasaMensual), -meses));

                txtCuotasMensuales.Text = Math.Round(cuota, 2).ToString("N2");

                //Calcular fecha de vencimiento sumando los meses a la fecha actual
                DateTime fechaInicio = DateTime.Today;
                DateTime fechaVencimiento = fechaInicio.AddMonths(meses);
                txtFechaVencimiento.Text = fechaVencimiento.ToString("yyyy-MM-dd");
            }
            catch
            {
                // Puedes mostrar un mensaje si lo deseas
                // MessageBox.Show("Verifica que todos los campos tengan valores válidos.");
            }



        }

        private void txtMotoPagado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal montoPagado = Convert.ToDecimal(txtMotoPagado.Text);
                decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text);
                decimal montoFinanciadoo = montoTotal - montoPagado;

                txtMontoFinanciado.Text = Math.Round(montoFinanciadoo, 2).ToString("N2");
            }
            catch
            {

            }
        }

        private void txtInteresAnual_TextChanged(object sender, EventArgs e)
        {
        }

        private void FechaVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPagosPeriodicos_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPagosPeriodicos.Text, out int meses))
            {
                DateTime fechaActual = DateTime.Today;
                DateTime fechaVencimiento = fechaActual.AddMonths(meses);

                txtFechaLimite.Text = fechaVencimiento.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido de meses.");
            }


        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
