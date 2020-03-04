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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nom = Convert.ToString(txtNombre.Text);
            int h = Convert.ToInt32(txtHdeT.Text);
            double v = Convert.ToDouble(txtVdeHor.Text);
            double sub, tot, iva;
            sub = h * v;
            iva = sub * 0.13;
            tot = sub + iva;
            dataGridView1.Rows.Add(nom, h, v, sub, iva, tot);
            dataGridView1.ClearSelection();
            int tot1 = 0;
            for (int i=0; i<dataGridView1.Rows.Count;i++)
            {
                tot1 += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                lblTot.Text = string.Format("{0:C2}", tot);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHdeT.Clear(); txtNombre.Clear(); txtVdeHor.Clear(); lblTot.ResetText(); 
        }
    }
}
