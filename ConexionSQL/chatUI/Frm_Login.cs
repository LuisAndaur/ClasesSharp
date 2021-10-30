using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensajesEntidades;

namespace chatUI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.NombreUsuario = txtUsuario.Text;
            user.Pass = txtPassword.Text;

            Mensajeria.Loguear(user);
        }
    }
}
