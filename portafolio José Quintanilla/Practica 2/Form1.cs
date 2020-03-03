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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConveritr_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
                string rom = "";
                if (num>= 1&& num<=10)
                {
                    if (num == 1)
                    {
                        rom = "I";
                    }
                    else if (num == 2)
                    {
                        rom = "II";
                    }
                    else if (num == 3)
                    {
                        rom = "III";

                    }
                    else if (num == 4)
                    {
                        rom = "IV";
                    }
                    else if (num == 5)
                    {
                        rom = "V";
                    }
                    else if (num == 6)
                    {
                        rom = "VI";
                    }
                    else if (num == 7)
                    {
                        rom = "VII";
                    }
                    else if (num == 8)
                    {
                        rom = "VIII";
                    }
                    else if (num==9)
                    {
                        rom = "IX";
                    }
                   
                    else if (num==10)
                    {
                        rom = "X";
                    }
                    lblNaCon.Text = "El número equivale a " + rom +   " en romano ";
                }
                else
                {
                    txtNumero.Focus();
                    txtNumero.SelectAll();
                    lblNaCon.Text = "Ingrese un numero del 1 al 10";
                }
            }

            catch (Exception)
            {

                txtNumero.Focus();
                txtNumero.SelectAll();
                lblNaCon.Text = "Ingrese solo número";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
