using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1eje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal exa1, exa2, exa3, tot;
            exa1 = Convert.ToDecimal(txtExa1.Text);
            exa2 = Convert.ToDecimal(txtExa2.Text);
            exa3 = Convert.ToDecimal(txtExa3.Text);
            tot = (exa1 + exa2 + exa3)/3;
            txtProm.Text = Convert.ToString(tot);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExa1.Clear();
            txtExa2.Clear();
            txtExa3.Clear();
            txtProm.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
