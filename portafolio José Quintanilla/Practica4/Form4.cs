using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad, preci, sub, iva, tot;
            preci = double.Parse(this.txtPrecio.Text);
            cantidad = double.Parse(txtCantidad.Text);
            sub = cantidad * preci;
            txtSub.Text = sub.ToString();
            iva = sub * 0.13;
            txtiva.Text = iva.ToString();
            tot = sub + iva;
            txttot.Text = tot.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtiva.Clear();
            txtPrecio.Clear();
            txtSub.Clear();
            txttot.Clear();
        }
    }
}
