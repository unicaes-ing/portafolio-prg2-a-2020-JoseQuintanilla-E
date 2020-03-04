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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lon = Convert.ToDouble(txtConvert.Text);
            double res = 0;
            if (lstDe.SelectedItem.Equals("Pulgadas")) 
            {
                if (lstA.SelectedItem.Equals("Pulgadas"))
                {
                    res = lon;
                }
                else if (lstA.SelectedItem.Equals("Pies"))
                {
                    res = lon / 12;
                }
                else if (lstA.SelectedItem.Equals("Yardas")) 
                {
                    res = lon / 36;
                }
                txtConvertida.Text = Convert.ToString(res);
            }
            else if (lstDe.SelectedItem.Equals("Pies"))
            {
                if (lstA.SelectedItem.Equals("Pulgadas")) 
                {
                    res = lon * 12;
                }
                else if (lstA.SelectedItem.Equals("Pies")) 
                {
                    res = lon;
                }
                else if (lstA.SelectedItem.Equals("Yardas"))
                {
                    res = lon / 3;
                }
                txtConvertida.Text = Convert.ToString(res);
                
            }
            else if (lstDe.SelectedItem.Equals("Yardas"))
            {
                if (lstA.SelectedItem.Equals("Pulgadas"))
                {
                    res = lon / 12;
                }
                else if (lstA.SelectedItem.Equals("Pies"))
                {
                    res = lon * 3;
                }
                else if (lstA.SelectedItem.Equals("Yardas"))
                {
                    res = lon;
                }
                txtConvertida.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Debe seleccionar longitudes a convertir");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

