namespace WindowsFormsApp5
{
    partial class Form1
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
            this.TextBoxCedula = new System.Windows.Forms.TextBox();
            this.LabelCedula = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.BotonInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxCedula
            // 
            this.TextBoxCedula.Location = new System.Drawing.Point(104, 44);
            this.TextBoxCedula.Name = "TextBoxCedula";
            this.TextBoxCedula.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCedula.TabIndex = 0;
            // 
            // LabelCedula
            // 
            this.LabelCedula.AutoSize = true;
            this.LabelCedula.Location = new System.Drawing.Point(51, 47);
            this.LabelCedula.Name = "LabelCedula";
            this.LabelCedula.Size = new System.Drawing.Size(17, 13);
            this.LabelCedula.TabIndex = 1;
            this.LabelCedula.Text = "CI";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(51, 74);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 3;
            this.LabelNombre.Text = "Nombre";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(104, 71);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNombre.TabIndex = 2;
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(51, 100);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(44, 13);
            this.LabelApellido.TabIndex = 5;
            this.LabelApellido.Text = "Apellido";
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(104, 97);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.TextBoxApellido.TabIndex = 4;
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Location = new System.Drawing.Point(51, 126);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(49, 13);
            this.LabelTelefono.TabIndex = 7;
            this.LabelTelefono.Text = "Telefono";
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(104, 123);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTelefono.TabIndex = 6;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(51, 152);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelEmail.TabIndex = 9;
            this.LabelEmail.Text = "Email";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(104, 149);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.TextBoxEmail.TabIndex = 8;
            // 
            // BotonInsertar
            // 
            this.BotonInsertar.Location = new System.Drawing.Point(113, 188);
            this.BotonInsertar.Name = "BotonInsertar";
            this.BotonInsertar.Size = new System.Drawing.Size(75, 23);
            this.BotonInsertar.TabIndex = 10;
            this.BotonInsertar.Text = "Insertar";
            this.BotonInsertar.UseVisualStyleBackColor = true;
            this.BotonInsertar.Click += new System.EventHandler(this.BotonInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 254);
            this.Controls.Add(this.BotonInsertar);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.LabelTelefono);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.TextBoxApellido);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.LabelCedula);
            this.Controls.Add(this.TextBoxCedula);
            this.Name = "Form1";
            this.Text = "RegistroDeUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCedula;
        private System.Windows.Forms.Label LabelCedula;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button BotonInsertar;
    }
}

