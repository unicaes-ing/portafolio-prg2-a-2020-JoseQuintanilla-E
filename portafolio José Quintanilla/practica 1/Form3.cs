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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double I1, I2, I3, Tot;
            I1 = Convert.ToDouble(txt1.Text); I2 = Convert.ToDouble(txt2.Text); I3= Convert.ToDouble(txt3.Text);
            Tot = I1 + I2 + I3;
            txtpor1.Text = Convert.ToString(((I1 / Tot) * 100).ToString("N2")) + " %";
            txtPor2.Text = Convert.ToString(((I2 / Tot) * 100).ToString("N2")) + " %";
            txtPor3.Text = Convert.ToString(((I3 / Tot) * 100).ToString("N2")) + " %";
            txtTot.Text = "$ " + Tot.ToString("N2");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear(); txt2.Clear(); txt3.Clear(); txtpor1.Clear(); txtPor2.Clear(); txtPor3.Clear();txtTot.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
