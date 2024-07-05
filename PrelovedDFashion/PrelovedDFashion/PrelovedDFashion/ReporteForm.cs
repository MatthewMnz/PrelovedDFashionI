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
    public partial class ReporteForm : Form
    {
        private readonly List<Venta> ventas;

        public ReporteForm(List<Venta> ventas)
        {
            InitializeComponent();
            this.ventas = ventas ?? new List<Venta>();
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {
            if (dgvReporte.Columns.Count == 0)
            {
                dgvReporte.Columns.Add("Categoria", "Categoría");
                dgvReporte.Columns.Add("TotalCantidad", "Total Cantidad");
                dgvReporte.Columns.Add("TotalPrecio", "Total Precio");

                dgvReporte.ReadOnly = true;
                dgvReporte.AllowUserToAddRows = false;
                dgvReporte.AllowUserToDeleteRows = false;
                dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            txtbTotal.ReadOnly = true;
            CalcularYMostrarTotales();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
             decimal totalGeneral = ventas.Sum(venta => venta.CalcularTotal());
            txtbTotal.Text = $"Total General: {totalGeneral} C$";
        }

        private void CalcularYMostrarTotales()
        {
            int totalCantidadRopa = 0;
            decimal totalPrecioRopa = 0;

            int totalCantidadJoyeria = 0;
            decimal totalPrecioJoyeria = 0;

            foreach (var venta in ventas)
            {
                if (venta.ProductoVendido is Ropa)
                {
                    totalCantidadRopa += venta.CantidadVendida;
                    totalPrecioRopa += venta.CalcularTotal();
                }
                else if (venta.ProductoVendido is Joyeria)
                {
                    totalCantidadJoyeria += venta.CantidadVendida;
                    totalPrecioJoyeria += venta.CalcularTotal();
                }
            }

            decimal totalGeneral = totalPrecioRopa + totalPrecioJoyeria;

            dgvReporte.Rows.Clear();
            dgvReporte.Rows.Add("Ropa", totalCantidadRopa, $"{totalPrecioRopa} C$");
            dgvReporte.Rows.Add("Joyería", totalCantidadJoyeria, $"{totalPrecioJoyeria} C$");

            txtbTotal.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
