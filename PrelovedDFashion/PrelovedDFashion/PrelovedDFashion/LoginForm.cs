using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrelovedDFashion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetPlaceholderText(txtbUsuario, "Usuario");
            SetPlaceholderText(txtbContra, "Contraseña", isPassword: true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtbUsuario.Text;
            string contraseña = txtbContra.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Complete ambos campos para poder continuar", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuario == "DaneVivas")
            {
                if (contraseña == "010389")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario incorrecto. Inténtalo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtbContra.UseSystemPasswordChar = false;
            txtbContra.Text = string.Empty;
            txtbContra.PlaceholderText = "Contraseña";
            txtbContra.Refresh();
        }


        private void txtbContra_Enter(object sender, EventArgs e)
        {
            txtbContra.UseSystemPasswordChar = true;
        }

        private void txtbContra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbContra.Text))
            {
                txtbContra.UseSystemPasswordChar = false;
            }
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    textBox.UseSystemPasswordChar = isPassword;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.UseSystemPasswordChar = false;
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = placeholder;
                }
            };
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
