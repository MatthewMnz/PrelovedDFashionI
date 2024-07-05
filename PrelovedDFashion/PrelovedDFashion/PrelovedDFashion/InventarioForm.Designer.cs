namespace PrelovedDFashion
{
    partial class InventarioForm
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
            dgvInventario = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            txtbID = new TextBox();
            txtbNombre = new TextBox();
            txtbPrecio = new TextBox();
            txtbCantidad = new TextBox();
            txtbTalla = new TextBox();
            txtbMaterial = new TextBox();
            rdbRopa = new RadioButton();
            rdbJoyeria = new RadioButton();
            lblID = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblSexo = new Label();
            lblTalla = new Label();
            lblMaterial = new Label();
            cmbSexo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(12, 12);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(736, 313);
            dgvInventario.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(93, 415);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(174, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(673, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Menú";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtbID
            // 
            txtbID.Location = new Point(12, 386);
            txtbID.Name = "txtbID";
            txtbID.Size = new Size(100, 23);
            txtbID.TabIndex = 5;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(118, 386);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(100, 23);
            txtbNombre.TabIndex = 6;
            // 
            // txtbPrecio
            // 
            txtbPrecio.Location = new Point(224, 386);
            txtbPrecio.Name = "txtbPrecio";
            txtbPrecio.Size = new Size(100, 23);
            txtbPrecio.TabIndex = 7;
            // 
            // txtbCantidad
            // 
            txtbCantidad.Location = new Point(330, 386);
            txtbCantidad.Name = "txtbCantidad";
            txtbCantidad.Size = new Size(100, 23);
            txtbCantidad.TabIndex = 8;
            // 
            // txtbTalla
            // 
            txtbTalla.Location = new Point(542, 386);
            txtbTalla.Name = "txtbTalla";
            txtbTalla.Size = new Size(100, 23);
            txtbTalla.TabIndex = 10;
            // 
            // txtbMaterial
            // 
            txtbMaterial.Location = new Point(648, 386);
            txtbMaterial.Name = "txtbMaterial";
            txtbMaterial.Size = new Size(100, 23);
            txtbMaterial.TabIndex = 11;
            // 
            // rdbRopa
            // 
            rdbRopa.AutoSize = true;
            rdbRopa.Location = new Point(12, 331);
            rdbRopa.Name = "rdbRopa";
            rdbRopa.Size = new Size(52, 19);
            rdbRopa.TabIndex = 12;
            rdbRopa.TabStop = true;
            rdbRopa.Text = "Ropa";
            rdbRopa.UseVisualStyleBackColor = true;
            // 
            // rdbJoyeria
            // 
            rdbJoyeria.AutoSize = true;
            rdbJoyeria.Location = new Point(112, 331);
            rdbJoyeria.Name = "rdbJoyeria";
            rdbJoyeria.Size = new Size(61, 19);
            rdbJoyeria.TabIndex = 13;
            rdbJoyeria.TabStop = true;
            rdbJoyeria.Text = "Joyeria";
            rdbJoyeria.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 368);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 14;
            lblID.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(118, 368);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(224, 368);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(330, 368);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 17;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(436, 368);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 18;
            lblSexo.Text = "Sexo:";
            // 
            // lblTalla
            // 
            lblTalla.AutoSize = true;
            lblTalla.Location = new Point(542, 368);
            lblTalla.Name = "lblTalla";
            lblTalla.Size = new Size(33, 15);
            lblTalla.TabIndex = 19;
            lblTalla.Text = "Talla:";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(648, 368);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(53, 15);
            lblMaterial.TabIndex = 20;
            lblMaterial.Text = "Material:";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbSexo.Location = new Point(436, 386);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(100, 23);
            cmbSexo.TabIndex = 21;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 450);
            Controls.Add(cmbSexo);
            Controls.Add(lblMaterial);
            Controls.Add(lblTalla);
            Controls.Add(lblSexo);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblID);
            Controls.Add(rdbJoyeria);
            Controls.Add(rdbRopa);
            Controls.Add(txtbMaterial);
            Controls.Add(txtbTalla);
            Controls.Add(txtbCantidad);
            Controls.Add(txtbPrecio);
            Controls.Add(txtbNombre);
            Controls.Add(txtbID);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvInventario);
            Name = "InventarioForm";
            Text = "InventarioForm";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventario;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox txtbID;
        private TextBox txtbNombre;
        private TextBox txtbPrecio;
        private TextBox txtbCantidad;
        private TextBox txtbTalla;
        private TextBox txtbMaterial;
        private RadioButton rdbRopa;
        private RadioButton rdbJoyeria;
        private Label lblID;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblSexo;
        private Label lblTalla;
        private Label lblMaterial;
        private ComboBox cmbSexo;
    }
}