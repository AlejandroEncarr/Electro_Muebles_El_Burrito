using capaPresentacion.UserControl;
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
    public partial class txtFechaVencimiento : Form
    {
        public txtFechaVencimiento()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void AddUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (pProductos.Visible == false)
            {
                pProductos.Visible = true;
            }
            else
            {
                pProductos.Visible = false;
            }

            pVentas.Visible = false;
            pCliente.Visible = false;
            pCreditos.Visible = false;
            pReportes.Visible = false;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (pReportes.Visible == false)
            {
                pReportes.Visible = true;
            }
            else
            {
                pReportes.Visible = false;
            }
            pVentas.Visible = false;
            pCliente.Visible = false;
            pCreditos.Visible = false;
            pProductos.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (pCreditos.Visible == false)
            {
                pCreditos.Visible = true;
            }
            else
            {
                pCreditos.Visible = false;
            }
            pVentas.Visible = false;
            pCliente.Visible = false;
            pReportes.Visible = false;
            pProductos.Visible = false;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            /* foreach (Control c in this.control)
             {

             }*/

            if (pCliente.Visible == false)
            {
                pCliente.Visible = true;
            }
            else
            {
                pCliente.Visible = false;
            }

            pVentas.Visible = false;
            pCreditos.Visible = false;
            pReportes.Visible = false;
            pProductos.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (pVentas.Visible == false)
            {
                pVentas.Visible = true;
            }
            else
            {
                pVentas.Visible = false;
            }

            pCliente.Visible = false;
            pCreditos.Visible = false;
            pReportes.Visible = false;
            pProductos.Visible = false;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            RegistrarClienteForm ap = new RegistrarClienteForm();
            AddUserControl(ap);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AgregarProductosForm ap = new AgregarProductosForm();
            AddUserControl(ap);
            pProductos.Visible = false;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            PromocionesForm ap = new PromocionesForm();
            AddUserControl(ap);
            pProductos.Visible = false;
        }

        public void cerrarmenu()
        {
            pVentas.Visible = false;
            pCliente.Visible = false;
            pCreditos.Visible = false;
            pReportes.Visible = false;
            pProductos.Visible = false;
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            VentasForm ventass = new VentasForm();

            AddUserControl(ventass);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            txtInteres contrato = new txtInteres();
            contrato.Show();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            pagooo pago = new pagooo();

            AddUserControl(pago);
        }
    }
}
