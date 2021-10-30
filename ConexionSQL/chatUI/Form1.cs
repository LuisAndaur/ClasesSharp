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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensajeria.BuscarUsuarios();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = txtNombre.Text;
            nuevoUsuario.Pass = txtPassword.Text;
            nuevoUsuario.NombreUsuario = txtNombreUsuario.Text;
            Mensajeria.InsertarUsuario(nuevoUsuario);
        }
    }
}
