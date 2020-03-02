using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtDecimal.Text);
            string bin = "";
            while (A > 0)
            {
                bin = A % 2 + bin;
                A = A / 2;
            }
            txtbinario.Text = bin;
            int B = int.Parse(txtDecimal.Text);
            string octal = "";
            double resi = 0;
            do
            {
                resi = ((double)(B)) / 8;
                B = B / 8;
                resi = (resi - B) * 8;
                octal = resi + octal;
            } while (B != 0);
            txtOctal.Text = octal;
            int C = int.Parse(txtDecimal.Text);
            string hexa = "";
            double residuo = 0;
            do
            {
                residuo = ((double)(C)) / 16;
                C = C / 16;
                residuo = (residuo - C) * 16;
                if (residuo == 10)
                    hexa = "A" + hexa;
                else if (residuo == 11)
                    hexa = "B" + hexa;
                else if (residuo == 12)
                    hexa = "C" + hexa;
                else if (residuo == 13)
                    hexa = "D" + hexa;
                else if (residuo == 14)
                    hexa = "E" + hexa;
                else if (residuo == 15)
                    hexa = "F" + hexa;
                else
                    hexa = residuo + hexa;
            } while (C != 0);
            txtHexa.Text = hexa;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Clear();
            txtbinario.Clear();
            txtHexa.Clear();
            txtOctal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
