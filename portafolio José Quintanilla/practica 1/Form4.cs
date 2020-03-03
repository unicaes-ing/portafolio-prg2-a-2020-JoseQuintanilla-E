using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double precio, sub, iva, tot, cantidad;
            precio = double.Parse(txtPrecio.Text);
            cantidad = double.Parse(txtcantidad.Text);
            sub = cantidad * precio;
            this.txtSub.Text = sub.ToString();
            iva = sub * 0.13;
            this.txtIva.Text = iva.ToString();
            tot = sub + iva;
            this.txtTot.Text = tot.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIva.Clear(); txtcantidad.Clear(); txtPrecio.Clear(); txtTot.Clear(); txtSub.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
