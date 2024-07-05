namespace PrelovedDFashion
{
    partial class ReporteForm
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
            btnCalcularTotal = new Button();
            btnSalir = new Button();
            dgvReporte = new DataGridView();
            txtbTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.Location = new Point(12, 122);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(94, 23);
            btnCalcularTotal.TabIndex = 0;
            btnCalcularTotal.Text = "Calcular Total";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(270, 151);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Menú";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(12, 12);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.Size = new Size(352, 89);
            dgvReporte.TabIndex = 2;
            // 
            // txtbTotal
            // 
            txtbTotal.Location = new Point(12, 151);
            txtbTotal.Name = "txtbTotal";
            txtbTotal.ReadOnly = true;
            txtbTotal.Size = new Size(147, 23);
            txtbTotal.TabIndex = 3;
            // 
            // ReporteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 190);
            Controls.Add(txtbTotal);
            Controls.Add(dgvReporte);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcularTotal);
            Name = "ReporteForm";
            Text = "ReporteForm";
            Load += ReporteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularTotal;
        private Button btnSalir;
        private DataGridView dgvReporte;
        private TextBox txtbTotal;
    }
}