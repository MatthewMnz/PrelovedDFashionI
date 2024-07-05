namespace PrelovedDFashion
{
    partial class VentasForm
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
            txtbProdID = new TextBox();
            txtbCantVend = new TextBox();
            btnRegistrarVenta = new Button();
            btnSalir = new Button();
            lblProdID = new Label();
            lblCantVend = new Label();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // txtbProdID
            // 
            txtbProdID.Location = new Point(12, 307);
            txtbProdID.Name = "txtbProdID";
            txtbProdID.Size = new Size(100, 23);
            txtbProdID.TabIndex = 0;
            // 
            // txtbCantVend
            // 
            txtbCantVend.Location = new Point(118, 307);
            txtbCantVend.Name = "txtbCantVend";
            txtbCantVend.Size = new Size(100, 23);
            txtbCantVend.TabIndex = 1;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(12, 336);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(100, 23);
            btnRegistrarVenta.TabIndex = 2;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(471, 336);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Menú";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblProdID
            // 
            lblProdID.AutoSize = true;
            lblProdID.Location = new Point(12, 289);
            lblProdID.Name = "lblProdID";
            lblProdID.Size = new Size(73, 15);
            lblProdID.TabIndex = 4;
            lblProdID.Text = "ID Producto:";
            // 
            // lblCantVend
            // 
            lblCantVend.AutoSize = true;
            lblCantVend.Location = new Point(118, 289);
            lblCantVend.Name = "lblCantVend";
            lblCantVend.Size = new Size(58, 15);
            lblCantVend.TabIndex = 5;
            lblCantVend.Text = "Cantidad:";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(12, 12);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(534, 262);
            dgvVentas.TabIndex = 6;
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 371);
            Controls.Add(dgvVentas);
            Controls.Add(lblCantVend);
            Controls.Add(lblProdID);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(txtbCantVend);
            Controls.Add(txtbProdID);
            Name = "VentasForm";
            Text = "VentasForm";
            Load += VentasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbProdID;
        private TextBox txtbCantVend;
        private Button btnRegistrarVenta;
        private Button btnSalir;
        private Label lblProdID;
        private Label lblCantVend;
        private DataGridView dgvVentas;
    }
}