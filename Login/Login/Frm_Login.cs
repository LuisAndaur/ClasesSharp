using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Dictionary<string, int> usuarios = new Dictionary<string, int>(usuario.Diccionario());
            bool esIgual = false;

            foreach (KeyValuePair<string, int> item in usuarios)
            {
                int.TryParse(txt_Pass.Text, out int pass);
                if (item.Key == txt_Usuario.Text && item.Value == pass)
                {
                    esIgual = true;
                    this.Close();
                }
            }

            if (!esIgual)
            {
                MessageBox.Show("ATENCIÓN!\n Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
