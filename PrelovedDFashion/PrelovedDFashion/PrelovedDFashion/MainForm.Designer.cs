namespace PrelovedDFashion
{
    partial class MainForm
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
            btnGestion = new Button();
            btnGestionVentas = new Button();
            btnReporteVentas = new Button();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.FromArgb(52, 152, 219);
            btnGestion.FlatAppearance.BorderSize = 0;
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestion.ForeColor = Color.White;
            btnGestion.Location = new Point(38, 106);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(309, 60);
            btnGestion.TabIndex = 0;
            btnGestion.Text = "Gestion de Inventario";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.BackColor = Color.FromArgb(52, 152, 219);
            btnGestionVentas.FlatAppearance.BorderSize = 0;
            btnGestionVentas.FlatStyle = FlatStyle.Flat;
            btnGestionVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionVentas.ForeColor = Color.White;
            btnGestionVentas.Location = new Point(38, 172);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(309, 60);
            btnGestionVentas.TabIndex = 1;
            btnGestionVentas.Text = "Gestion de Ventas";
            btnGestionVentas.UseVisualStyleBackColor = false;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.FromArgb(52, 152, 219);
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteVentas.ForeColor = Color.White;
            btnReporteVentas.Location = new Point(38, 238);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(309, 60);
            btnReporteVentas.TabIndex = 2;
            btnReporteVentas.Text = "Reporte de Ventas";
            btnReporteVentas.UseVisualStyleBackColor = false;
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(52, 152, 219);
            lblTitulo.Location = new Point(38, 18);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(309, 45);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Preloved D'Fashion";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Black;
            lblSubtitulo.Location = new Point(110, 63);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(172, 25);
            lblSubtitulo.TabIndex = 8;
            lblSubtitulo.Text = "Menú de Opciones";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(38, 304);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(309, 60);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 407);
            Controls.Add(btnSalir);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnReporteVentas);
            Controls.Add(btnGestionVentas);
            Controls.Add(btnGestion);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestion;
        private Button btnGestionVentas;
        private Button btnReporteVentas;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnSalir;
    }
}