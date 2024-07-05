using System.Drawing.Drawing2D;

namespace PrelovedDFashion
{
    partial class LoginForm
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
            txtbUsuario = new TextBox();
            txtbContra = new TextBox();
            btnLogin = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtbUsuario
            // 
            txtbUsuario.BackColor = Color.FromArgb(240, 240, 240);
            txtbUsuario.BorderStyle = BorderStyle.None;
            txtbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbUsuario.ForeColor = Color.Black;
            txtbUsuario.Location = new Point(111, 112);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.PlaceholderText = "Usuario";
            txtbUsuario.Size = new Size(200, 22);
            txtbUsuario.TabIndex = 0;
            // 
            // txtbContra
            // 
            txtbContra.BackColor = Color.FromArgb(240, 240, 240);
            txtbContra.BorderStyle = BorderStyle.None;
            txtbContra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbContra.ForeColor = Color.Black;
            txtbContra.Location = new Point(111, 157);
            txtbContra.Name = "txtbContra";
            txtbContra.PlaceholderText = "Contraseña";
            txtbContra.Size = new Size(200, 22);
            txtbContra.TabIndex = 1;
            txtbContra.Enter += txtbContra_Enter;
            txtbContra.Leave += txtbContra_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(91, 211);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(52, 152, 219);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(224, 211);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 40);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(52, 152, 219);
            lblTitulo.Location = new Point(82, 35);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 45);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Inicio de Sesión";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Location = new Point(111, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Location = new Point(111, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(420, 323);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(txtbContra);
            Controls.Add(txtbUsuario);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            Shown += LoginForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbUsuario;
        private TextBox txtbContra;
        private Button btnLogin;
        private Button btnSalir;
        private Label lblTitulo;
        private Panel panel2;
        private Panel panel1;
    }
}