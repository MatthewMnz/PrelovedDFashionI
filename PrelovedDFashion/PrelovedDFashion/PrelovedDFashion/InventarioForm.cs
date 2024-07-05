using PrelovedDFashion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelovedDFashion
{
    public partial class InventarioForm : Form
    {
        private List<Producto> inventario;

        public InventarioForm(List<Producto> inventario)
        {
            InitializeComponent();
            this.inventario = inventario ?? new List<Producto>();
            LoadInventario();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            rdbRopa.CheckedChanged += (s, e) => ToggleInputs();
            rdbJoyeria.CheckedChanged += (s, e) => ToggleInputs();
            cmbSexo.SelectedIndex = -1;
        }

        private void LoadInventario()
        {
            if (dgvInventario.Columns.Count > 0)
            {
                dgvInventario.Columns.Clear();
            }

            dgvInventario.Columns.Add("Id", "ID");
            dgvInventario.Columns.Add("Nombre", "Nombre");
            dgvInventario.Columns.Add("Precio", "Precio");
            dgvInventario.Columns.Add("Cantidad", "Cantidad");
            dgvInventario.Columns.Add("Sexo", "Sexo");
            dgvInventario.Columns.Add("Talla", "Talla");
            dgvInventario.Columns.Add("Material", "Material");

            dgvInventario.Rows.Clear();

            foreach (var producto in inventario)
            {
                if (producto is Ropa ropa)
                {
                    dgvInventario.Rows.Add(ropa.Id, ropa.Nombre, ropa.Precio, ropa.Cantidad, ropa.Sexo, ropa.Talla, null);
                }
                else if (producto is Joyeria joyeria)
                {
                    dgvInventario.Rows.Add(joyeria.Id, joyeria.Nombre, joyeria.Precio, joyeria.Cantidad, joyeria.Sexo, null, joyeria.Material);
                }
            }

            dgvInventario.ReadOnly = true;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ToggleInputs()
        {
            if (rdbRopa.Checked)
            {
                txtbTalla.Enabled = true;
                txtbMaterial.Enabled = false;
                txtbMaterial.Clear();
            }
            else if (rdbJoyeria.Checked)
            {
                txtbTalla.Enabled = false;
                txtbMaterial.Enabled = true;
                txtbTalla.Clear();
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones())
                {
                    return;
                }

                int id = int.Parse(txtbID.Text);
                string nombre = txtbNombre.Text;
                decimal precio = decimal.Parse(txtbPrecio.Text);
                int cantidad = int.Parse(txtbCantidad.Text);
                string sexo = cmbSexo.SelectedItem.ToString();

                Producto nuevoProducto = rdbRopa.Checked
                    ? new Ropa(id, nombre, precio, cantidad, sexo, txtbTalla.Text)
                    : (Producto)new Joyeria(id, nombre, precio, cantidad, sexo, txtbMaterial.Text);

                inventario.Add(nuevoProducto);
                LoadInventario();
                ClearInputs();
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Error en el formato de los datos: {fe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }

        private bool Validaciones()
        {
            if (string.IsNullOrWhiteSpace(txtbID.Text) ||
                string.IsNullOrWhiteSpace(txtbNombre.Text) ||
                string.IsNullOrWhiteSpace(txtbPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtbCantidad.Text) ||
                cmbSexo.SelectedItem == null ||
                (!rdbRopa.Checked && !rdbJoyeria.Checked) ||
                (rdbRopa.Checked && string.IsNullOrWhiteSpace(txtbTalla.Text)) ||
                (rdbJoyeria.Checked && string.IsNullOrWhiteSpace(txtbMaterial.Text)))
            {
                MessageBox.Show("Todos los campos son obligatorios y deben estar completos.");
                return false;
            }

            if (!decimal.TryParse(txtbPrecio.Text, out _) || !int.TryParse(txtbID.Text, out _) || !int.TryParse(txtbCantidad.Text, out _))
            {
                MessageBox.Show("ID, Precio y Cantidad deben ser valores numéricos válidos.");
                return false;
            }

            return true;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
              try
            {
                if (dgvInventario.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvInventario.SelectedRows[0];
                    var productoSeleccionado = inventario.FirstOrDefault(p => p.Id == (int)selectedRow.Cells["Id"].Value);

                    if (productoSeleccionado != null)
                    {
                        if (!string.IsNullOrWhiteSpace(txtbNombre.Text))
                        {
                            productoSeleccionado.Nombre = txtbNombre.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(txtbPrecio.Text) && decimal.TryParse(txtbPrecio.Text, out decimal precio))
                        {
                            productoSeleccionado.Precio = precio;
                        }
                        if (!string.IsNullOrWhiteSpace(txtbCantidad.Text) && int.TryParse(txtbCantidad.Text, out int cantidad))
                        {
                            productoSeleccionado.Cantidad = cantidad;
                        }
                        if (cmbSexo.SelectedIndex != -1)
                        {
                            productoSeleccionado.Sexo = cmbSexo.SelectedItem.ToString();
                        }

                        if (productoSeleccionado is Ropa ropa && !string.IsNullOrWhiteSpace(txtbTalla.Text))
                        {
                            ropa.Talla = txtbTalla.Text;
                        }
                        else if (productoSeleccionado is Joyeria joyeria && !string.IsNullOrWhiteSpace(txtbMaterial.Text))
                        {
                            joyeria.Material = txtbMaterial.Text;
                        }

                        LoadInventario();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para actualizar.");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Formato de datos incorrecto: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvInventario.SelectedRows[0];
                    var productoSeleccionado = inventario.FirstOrDefault(p => p.Id == (int)selectedRow.Cells["Id"].Value);

                    if (productoSeleccionado != null)
                    {
                        inventario.Remove(productoSeleccionado);
                        LoadInventario();
                        ClearInputs();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtbID.Clear();
            txtbNombre.Clear();
            txtbPrecio.Clear();
            txtbCantidad.Clear();
            cmbSexo.SelectedIndex = -1;
            txtbTalla.Clear();
            txtbMaterial.Clear();
            rdbRopa.Checked = false;
            rdbJoyeria.Checked = false;
        }
    }
}
