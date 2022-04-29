using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NakaharaPDV.Interfaz
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void CORTE_Click(object sender, EventArgs e)
        {
            FormCorte corte = new FormCorte();
            corte.Show();
        }

        private void INVENTARIO_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
        }

        private void CONFIGURACION_Click(object sender, EventArgs e)
        {
            FormConfiguraciones configuraciones = new FormConfiguraciones();
            configuraciones.Show();
        }

        private void PRODUCTOS_Click(object sender, EventArgs e)
        {
            FormProductos productos = new FormProductos();
            productos.Show();
        }


    }
}
