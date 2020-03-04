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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtTablas.Text, out n))
            {
                listTabla.Items.Clear();
                for (int i = 0; i <= 10; i++)
                {
                    listTabla.Items.Add(n + "*" + i + "=" + n * i);
                }
            }
        }

            
    }
}
