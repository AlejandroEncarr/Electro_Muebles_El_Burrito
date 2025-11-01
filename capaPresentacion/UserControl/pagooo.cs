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
    public partial class pagooo : System.Windows.Forms.UserControl
    {

        public pagooo()
        {
            InitializeComponent();
        }

        private void GuaradarPago_Click(object sender, EventArgs e)
        {
            // Paso 1: Validar campos
            if (!ValidarCamposPago())
            {
                MessageBox.Show("Por favor completa todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Paso 2: Convertir entradas a variables
            int ventaID = int.Parse(txtVentaID.Text);
            decimal montoPagado = decimal.Parse(txtMontoPagado.Text);
            decimal mora = decimal.Parse(txtMora.Text);
            decimal montoPendiente = decimal.Parse(txtMontoPendiente.Text);
            string fechaPago = DateTime.Today.ToString("yyyy-MM-dd"); // o usar txtFechaPago.Text si lo capturas
            string metodoPago = txtMetodoPago.Text;

            // Paso 3: Ejecutar inserción
            try
            {
                Pagos.InsertarPago(ventaID, montoPagado, mora, montoPendiente, fechaPago, metodoPago);
                MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarCamposPago()
        {
            return int.TryParse(txtVentaID.Text, out _) &&
                   decimal.TryParse(txtMontoPagado.Text, out _) &&
                   decimal.TryParse(txtMora.Text, out _) &&
                   decimal.TryParse(txtMontoPendiente.Text, out _) &&
                   !string.IsNullOrWhiteSpace(txtMetodoPago.Text);
        }

        private void LimpiarCamposPago()
        {
            txtMontoPagado.Clear();
            txtMora.Clear();
            txtMontoPendiente.Clear();
            txtMetodoPago.Clear();
        }

    }
}
