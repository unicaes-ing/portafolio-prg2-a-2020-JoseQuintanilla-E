using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            err.Clear();
            if (txtCorreo.TextLength <= 0)
            {
                err.SetError(txtCorreo, "Ingrese su correo");
                valido = false;
            }
            else
            {
                    string patron= @"^[^@]+@[^@]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txtContra.Text,patron))
                {
                    err.SetError(txtCorreo, "Ingrese su correo correctamente");
                    valido = false;
                }
            }
            if (txtContra.TextLength<=0)
            {
                err.SetError(txtContra, "Ingrese la contraseña");
                valido = true;
            }
            else
            {
                string PatronContra = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
                if (!Regex.IsMatch(txtContra.Text, PatronContra))
                {
                    err.SetError(txtContra, "Formato de contraseña no valido");
                    valido = false;
                }
            }
            if(!Equals(txtContra.Text, txtConfirmacion.Text)|| txtConfirmacion.TextLength<=0)
            {
                err.SetError(txtConfirmacion, "La contraseña no coinciden");
                valido = false;
            }
            if (valido)
            {
                MessageBox.Show("Los Datos fueron validos correctamente", "Loign", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
