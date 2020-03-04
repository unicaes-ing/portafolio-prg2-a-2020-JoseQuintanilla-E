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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvTabla.Size = new Size(210, 220);
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.ScrollBars = ScrollBars.None;
            dgvTabla.ColumnCount = 10;
            dgvTabla.ColumnHeadersVisible = false;
            dgvTabla.RowHeadersVisible = false;
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                dgvTabla.Rows.Add();
                for (int C = 0; C < 10; C++)
                {
                    dgvTabla.Rows[i].Cells[C].Value = r.Next(10, 100);
                    dgvTabla.Rows[i].Cells[C].Style.BackColor = Color.Red;
                }
            }
            dgvTabla.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
                for (int f = 0; f < 10; f++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (dgvTabla.Rows[f].Cells[i].Value.Equals(num))
                        {
                            dgvTabla.Rows[f].Cells[i].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dgvTabla.Rows[f].Cells[i].Style.BackColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el número");
            }
        }
    }
}
