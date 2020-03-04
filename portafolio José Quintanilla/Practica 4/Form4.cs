using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int Número(int n1, int n2, int n3)
        {
            int num1, num2, num3;
            num1 = n1;
            num2 = n2;
            num3 = n3;
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        private void btnMayor_Click(object sender, EventArgs e)
        {
            int n, n1, n2, Nmayor;
            n = Convert.ToInt32(txtN1.Text);
            n1 = Convert.ToInt32(txtN2.Text);
            n2 = Convert.ToInt32(txtN3.Text);
            Nmayor = Número(n, n1, n2);
            lblResultado.Text = string.Format("{0}", Nmayor);
        }
    }
}
