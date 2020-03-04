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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtAgregar.Text);
                listBox1.Items.Add(num);
                txtAgregar.Clear();
                txtBuscar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
                txtAgregar.SelectAll();
                txtAgregar.Focus();
            }
        }
        public static int buscar(int NumeroBuscar, ListBox NumeroEc)
        {
            int cont = 0;
            foreach (int n in NumeroEc.Items)
            {
                if (n == NumeroBuscar) cont++;
            }
            return cont;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtBuscar.Text);
                int cantidad = buscar(num, listBox1);
                MessageBox.Show("Se encuentra " + cantidad + " de veces ");
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo numero");
                txtBuscar.SelectAll();
                txtBuscar.Focus();
            }
        }
    }
}
