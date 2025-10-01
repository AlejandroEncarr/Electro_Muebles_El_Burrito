namespace capaPresentacion
{
    partial class Registrar_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Usuario = new TextBox();
            Contrasena = new TextBox();
            IdRoll = new TextBox();
            RegistrarUsuario = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.Location = new Point(282, 196);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(125, 27);
            Usuario.TabIndex = 0;
            // 
            // Contrasena
            // 
            Contrasena.Location = new Point(282, 240);
            Contrasena.Name = "Contrasena";
            Contrasena.Size = new Size(125, 27);
            Contrasena.TabIndex = 1;
            // 
            // IdRoll
            // 
            IdRoll.Location = new Point(282, 284);
            IdRoll.Name = "IdRoll";
            IdRoll.Size = new Size(125, 27);
            IdRoll.TabIndex = 2;
            // 
            // RegistrarUsuario
            // 
            RegistrarUsuario.Location = new Point(282, 332);
            RegistrarUsuario.Name = "RegistrarUsuario";
            RegistrarUsuario.Size = new Size(94, 29);
            RegistrarUsuario.TabIndex = 3;
            RegistrarUsuario.Text = "Registrar";
            RegistrarUsuario.UseVisualStyleBackColor = true;
            RegistrarUsuario.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Registrar_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 512);
            Controls.Add(RegistrarUsuario);
            Controls.Add(IdRoll);
            Controls.Add(Contrasena);
            Controls.Add(Usuario);
            Name = "Registrar_Usuario";
            Text = "Registrar_Usuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usuario;
        private TextBox Contrasena;
        private TextBox IdRoll;
        private Button RegistrarUsuario;
        private ErrorProvider errorProvider1;
    }
}