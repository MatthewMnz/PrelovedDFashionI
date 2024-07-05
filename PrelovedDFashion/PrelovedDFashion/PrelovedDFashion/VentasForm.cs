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
    public partial class VentasForm : Form
    {
        private List<Producto> inventario;
        private List<Venta> ventas;

        public VentasForm(List<Producto> inventario, List<Venta> ventas)
        {
            InitializeComponent();
            this.inventario = inventario ?? new List<Producto>();
            this.ventas = ventas ?? new List<Venta>();
        }


        private void VentasForm_Load(object sender, EventArgs e)
        {
            if (dgvVentas.Columns.Count == 0)
            {
                dgvVentas.Columns.Add("Id", "ID");
                dgvVentas.Columns.Add("Nombre", "Nombre");
                dgvVentas.Columns.Add("Cantidad", "Cantidad");
                dgvVentas.Columns.Add("Precio", "Precio");

                dgvVentas.Columns.Add("Tipo", "Tipo");

                dgvVentas.ReadOnly = true;
                dgvVentas.AllowUserToAddRows = false;
                dgvVentas.AllowUserToDeleteRows = false;
            }

            LoadVentas();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbProdID.Text) || string.IsNullOrWhiteSpace(txtbCantVend.Text))
            {
                MessageBox.Show("Los campos deben estar completos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtbProdID.Text, out int productoId) || !int.TryParse(txtbCantVend.Text, out int cantidadVendida))
            {
                MessageBox.Show("ID y Cantidad deben ser numéricos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productoVendido = inventario.FirstOrDefault(p => p.Id == productoId);

            if (productoVendido == null)
            {
                MessageBox.Show("El ID no coincide con ningún producto", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productoVendido.Cantidad < cantidadVendida)
            {
                MessageBox.Show("La cantidad es mayor a la disponible", "Cantidad insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                productoVendido.Cantidad -= cantidadVendida;

                var nuevaVenta = new Venta(ventas.Count + 1, productoVendido, cantidadVendida, DateTime.Now);
                ventas.Add(nuevaVenta);

                MessageBox.Show("Venta Registrada");
                LoadVentas();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }

        private void LoadVentas()
        {
            dgvVentas.Rows.Clear();

            foreach (var venta in ventas)
            {
                string tipoProducto = venta.ProductoVendido is Ropa ? "Ropa" : "Joyeria";
                dgvVentas.Rows.Add(venta.ProductoVendido.Id, venta.ProductoVendido.Nombre, venta.CantidadVendida, venta.ProductoVendido.Precio, tipoProducto);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtbProdID.Clear();
            txtbCantVend.Clear();
        }
    }
}
