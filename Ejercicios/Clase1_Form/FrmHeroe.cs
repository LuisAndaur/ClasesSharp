using EjercicioHeroe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroeApp
{
    

    public partial class FrmHeroe : Form
    {
        Heroe heroe;

        public FrmHeroe()
        {
            //MessageBox.Show("New");
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.heroe = new Heroe (this.txtNombre.Text, this.cmbPoder.SelectedItem.ToString(), (int)this.numNivelFuerza.Value);
            heroe.SetEsAyudante(this.chkEsAyudante.Checked);

            MessageBox.Show(heroe.HeroeToString());
        }

        private void FrmHeroe_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Activated");
        }

        private void FrmHeroe_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Load");
        }
    }
}
