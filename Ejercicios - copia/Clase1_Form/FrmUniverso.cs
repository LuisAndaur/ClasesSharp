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
    public partial class FrmUniverso : Form
    {
        Universo universo;

        public FrmUniverso()
        {
            InitializeComponent();
            
        }

        private void btnNuevoHeroe_Click(object sender, EventArgs e)
        {
            FrmHeroe frmHeroe = new FrmHeroe();
            frmHeroe.Show();
        }
    }
}
