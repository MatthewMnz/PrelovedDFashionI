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
    public partial class MainForm : Form
    {
        private List<Producto> inventario;
        private List<Venta> ventas;

        public MainForm()
        {
            InitializeComponent();
            inventario = new List<Producto>();
            ventas = new List<Venta>();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            var inventarioForm = new InventarioForm(inventario);
            inventarioForm.Show();
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            var ventasForm = new VentasForm(inventario, ventas);
            ventasForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LOAD
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            var reporteForm = new ReporteForm(ventas);
            reporteForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
