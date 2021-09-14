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

namespace FormularioAlta
{
    public partial class Frm_Altas : Form
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public Frm_Altas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtDni.Text) && !String.IsNullOrEmpty(cmbGenero.SelectedItem.ToString()))
            {
                
                Usuario newUsuario = new Usuario(txtNombre.Text, txtApellido.Text, txtDni.Text, cmbGenero.SelectedItem.ToString(), chkEsArgentino.Checked);
                Usuario.CargarLista(newUsuario);
                usuarios = Usuario.ObtenerLista();
                //usuarios.Add(newUsuario);
                //List<Usuario> usuarios = new List<Usuario>();
                //usuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe completar los campos obligatorios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
