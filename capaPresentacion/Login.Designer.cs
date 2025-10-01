namespace capaPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            UsuarioT = new TextBox();
            ClaveT = new TextBox();
            button1 = new Button();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // UsuarioT
            // 
            UsuarioT.Location = new Point(405, 176);
            UsuarioT.Name = "UsuarioT";
            UsuarioT.Size = new Size(125, 27);
            UsuarioT.TabIndex = 0;
            // 
            // ClaveT
            // 
            ClaveT.Location = new Point(405, 239);
            ClaveT.Name = "ClaveT";
            ClaveT.Size = new Size(125, 27);
            ClaveT.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(405, 314);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(529, 314);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 552);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ClaveT);
            Controls.Add(UsuarioT);
            Name = "Login";
            Text = "Form1";
           // Load += this.Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsuarioT;
        private TextBox ClaveT;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}
