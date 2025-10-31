namespace capaPresentacion.UserControl
{
    partial class RegistrarClienteForm
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarClienteForm));
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            AgregarCliente = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtCedula = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txtTelefono = new TextBox();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(443, -31);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 611);
            panel2.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 541);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 70, 156);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(AgregarCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 611);
            panel1.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(298, 447);
            button3.Name = "button3";
            button3.Size = new Size(127, 33);
            button3.TabIndex = 21;
            button3.Text = "Eliminiar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(164, 447);
            button2.Name = "button2";
            button2.Size = new Size(127, 33);
            button2.TabIndex = 20;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(364, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 30);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(153, 180);
            label12.Name = "label12";
            label12.Size = new Size(109, 23);
            label12.TabIndex = 10;
            label12.Text = "Buena calidad";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(69, 142);
            label13.Name = "label13";
            label13.Size = new Size(264, 38);
            label13.TabIndex = 9;
            label13.Text = "Registro de Cliente";
            label13.Click += label13_Click;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(240, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 27);
            txtEmail.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(240, 294);
            label10.Name = "label10";
            label10.Size = new Size(51, 23);
            label10.TabIndex = 16;
            label10.Text = "Email";
            // 
            // AgregarCliente
            // 
            AgregarCliente.BackColor = Color.FromArgb(255, 128, 0);
            AgregarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarCliente.ForeColor = SystemColors.ControlLightLight;
            AgregarCliente.Location = new Point(28, 447);
            AgregarCliente.Name = "AgregarCliente";
            AgregarCliente.Size = new Size(127, 33);
            AgregarCliente.TabIndex = 2;
            AgregarCliente.Text = "Crear";
            AgregarCliente.UseVisualStyleBackColor = false;
            AgregarCliente.Click += PoductoAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(33, 237);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(33, 260);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(33, 293);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = SystemColors.ActiveCaptionText;
            txtApellido.Location = new Point(33, 319);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(170, 27);
            txtApellido.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(33, 349);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 4;
            label4.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.ForeColor = SystemColors.ActiveCaptionText;
            txtCedula.Location = new Point(33, 372);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(170, 27);
            txtCedula.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.ForeColor = SystemColors.ActiveCaptionText;
            txtDireccion.Location = new Point(240, 372);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 27);
            txtDireccion.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(240, 237);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(240, 349);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 8;
            label8.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = SystemColors.ActiveCaptionText;
            txtTelefono.Location = new Point(240, 260);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 27);
            txtTelefono.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegistrarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrarClienteForm";
            Size = new Size(1339, 569);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox4;
        private Label label12;
        private Label label13;
        private TextBox txtEmail;
        private Label label10;
        private Button AgregarCliente;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtCedula;
        private TextBox txtDireccion;
        private Label label3;
        private Label label8;
        private TextBox txtTelefono;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}
