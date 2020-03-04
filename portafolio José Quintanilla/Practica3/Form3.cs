using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int E= 0;
            lstNumero.Items.Clear();
            for (int i = 1; i <= 5000; i++)
            {
                int num = n.Next(1, 7);
                lstNumero.Items.Add(num);
                if (num == 6) E++;
            }
            MessageBox.Show("Se contaron" + " " + E + " " + "el numero 6");
        }
    }
}
