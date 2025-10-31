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
            FechaInicioM.Enabled = esFiduciario;
            FechaFinM.Enabled = esFiduciario;

            // Campos Layaway
            txtMontoTotalL.Enabled = esLayaway;
            txtPagoInicialL.Enabled = esLayaway;
            txtPagosPeriodicosL.Enabled = esLayaway;
            dtpFechaLimiteL.Enabled = esLayaway;

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

        }
    }
}
