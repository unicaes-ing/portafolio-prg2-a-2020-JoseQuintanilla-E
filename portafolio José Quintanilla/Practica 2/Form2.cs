using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tot, descuento;
            if (radioButton1.Checked)
            {
                descuento = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text) * 8;
                tot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text) - descuento;
                txtDescuento.Text = descuento.ToString("C2");
                txtTot.Text = tot.ToString("C2");
            }
            else if (radioButton2.Checked)
            {
                descuento = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text) * 0.05;
                tot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text) - descuento;
                txtDescuento.Text = descuento.ToString("C2");
                txtTot.Text = tot.ToString("C2");
            }
            else if (radioButton3.Checked)

            {
                descuento = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text) * 0.10;
                tot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text) - descuento;
                txtDescuento.Text = descuento.ToString("C2");
                txtTot.Text = tot.ToString("C2");
            }
            else if (radioButton4.Checked)

            {
                descuento = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text) * 0.15;
                tot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text) - descuento;
                txtDescuento.Text = descuento.ToString("C2");
                txtTot.Text = tot.ToString("C2");
            }
            else if (radioButton5.Checked)
            {
                descuento = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text) * 0.20;
                tot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text) - descuento;
                txtDescuento.Text = descuento.ToString("C2");
                txtTot.Text = tot.ToString("C2");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtDescuento.Clear();
            txtPrecio.Clear();
            txtTot.Clear();
            txtCantidad.Focus();
            groupBox1.Focus();
        }
    }
}
