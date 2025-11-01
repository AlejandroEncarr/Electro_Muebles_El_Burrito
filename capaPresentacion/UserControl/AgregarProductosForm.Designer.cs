namespace capaPresentacion.UserControl
{
    partial class AgregarProductosForm
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtNumeroSerie = new TextBox();
            label5 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            txtColor = new TextBox();
            label7 = new Label();
            txtMarca = new TextBox();
            label8 = new Label();
            txtGarantia = new TextBox();
            label9 = new Label();
            txtCaracteristicas = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            Estado = new CheckBox();
            cmbCategoria = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            PoductoAgregar = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(36, 125);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(36, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(36, 181);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.ActiveCaptionText;
            txtPrecio.Location = new Point(36, 260);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(170, 27);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(36, 237);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.ForeColor = SystemColors.ActiveCaptionText;
            txtNumeroSerie.Location = new Point(244, 316);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(170, 27);
            txtNumeroSerie.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(244, 293);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 14;
            label5.Text = "Numero de Serie";
            // 
            // txtModelo
            // 
            txtModelo.ForeColor = SystemColors.ActiveCaptionText;
            txtModelo.Location = new Point(244, 260);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(170, 27);
            txtModelo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(244, 237);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 12;
            label6.Text = "Modelo";
            // 
            // txtColor
            // 
            txtColor.ForeColor = SystemColors.ActiveCaptionText;
            txtColor.Location = new Point(244, 204);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(170, 27);
            txtColor.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(244, 181);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 10;
            label7.Text = "Color";
            // 
            // txtMarca
            // 
            txtMarca.ForeColor = SystemColors.ActiveCaptionText;
            txtMarca.Location = new Point(244, 148);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(170, 27);
            txtMarca.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(244, 125);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 8;
            label8.Text = "Marca";
            // 
            // txtGarantia
            // 
            txtGarantia.ForeColor = SystemColors.ActiveCaptionText;
            txtGarantia.Location = new Point(34, 316);
            txtGarantia.Multiline = true;
            txtGarantia.Name = "txtGarantia";
            txtGarantia.Size = new Size(170, 27);
            txtGarantia.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(34, 293);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 18;
            label9.Text = "Garantia";
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.ForeColor = SystemColors.ActiveCaptionText;
            txtCaracteristicas.Location = new Point(36, 381);
            txtCaracteristicas.Multiline = true;
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(378, 74);
            txtCaracteristicas.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(34, 355);
            label10.Name = "label10";
            label10.Size = new Size(119, 23);
            label10.TabIndex = 16;
            label10.Text = "Caracteristicas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 70, 156);
            panel1.Controls.Add(Estado);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtGarantia);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtCaracteristicas);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(PoductoAgregar);
            panel1.Controls.Add(txtNumeroSerie);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtColor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 611);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Estado.ForeColor = SystemColors.ControlLightLight;
            Estado.Location = new Point(36, 461);
            Estado.Name = "Estado";
            Estado.Size = new Size(85, 27);
            Estado.TabIndex = 23;
            Estado.Text = "Estado";
            Estado.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.ForeColor = SystemColors.ActiveCaptionText;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Nevera", "Mesa", "Muebles" });
            cmbCategoria.Location = new Point(36, 204);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(170, 28);
            cmbCategoria.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(156, 68);
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
            label13.Location = new Point(72, 30);
            label13.Name = "label13";
            label13.Size = new Size(305, 38);
            label13.TabIndex = 9;
            label13.Text = "Registro de Productos";
            // 
            // PoductoAgregar
            // 
            PoductoAgregar.BackColor = Color.FromArgb(255, 128, 0);
            PoductoAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PoductoAgregar.ForeColor = SystemColors.ControlLightLight;
            PoductoAgregar.Location = new Point(168, 524);
            PoductoAgregar.Name = "PoductoAgregar";
            PoductoAgregar.Size = new Size(127, 33);
            PoductoAgregar.TabIndex = 2;
            PoductoAgregar.Text = "Crear";
            PoductoAgregar.UseVisualStyleBackColor = false;
            PoductoAgregar.Click += PoductoAgregar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(443, -20);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 611);
            panel2.TabIndex = 21;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 541);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AgregarProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarProductosForm";
            Size = new Size(1339, 571);
            Load += AgregarProductosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtNumeroSerie;
        private Label label5;
        private TextBox txtModelo;
        private Label label6;
        private TextBox txtColor;
        private Label label7;
        private TextBox txtMarca;
        private Label label8;
        private TextBox txtGarantia;
        private Label label9;
        private TextBox txtCaracteristicas;
        private Label label10;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label12;
        private Label label13;
        private Button PoductoAgregar;
        private Panel panel2;
        private DataGridView dataGridView1;
        private ComboBox cmbCategoria;
        private ErrorProvider errorProvider1;
        private CheckBox Estado;
    }
}
