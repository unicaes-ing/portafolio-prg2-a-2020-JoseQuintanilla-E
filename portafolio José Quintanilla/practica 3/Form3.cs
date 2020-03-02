using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
            
        {
            double tot = Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt3.Text);
            txtPor1.Text=Convert.ToString((((Convert.ToDouble(txt1.Text))/tot)*100).ToString("N2")) + "%";
            txtPor2.Text = Convert.ToString((((Convert.ToDouble(txt2.Text)) / tot) * 100).ToString("N2")) + "%";
            txtPor3.Text = Convert.ToString((((Convert.ToDouble(txt3.Text)) / tot) * 100).ToString("N2")) + "%";
            txtTotal.Text = tot.ToString("C2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txtPor1.Clear();
            txtPor2.Clear();
            txtPor3.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
