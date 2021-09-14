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

namespace Clase_07_Encapsulamiento
{
    public partial class Form1 : Form
    {
        Guitarra guitarra1;
        Cliente cliente1;
        Cliente cliente2;
  
        public Form1()
        {
            InitializeComponent();
            guitarra1 = new Guitarra(EMarca.Gibson, "Les Paul", 253000.99);
            cliente1 = new Cliente("Parky");//no instancie guitarra entonces no puede acceder al precio
            cliente2 = new Cliente("Juana", guitarra1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == cliente1.Id.ToString())
            {
                txtNombre.Text = cliente2.Nombre;
                txtMarca.Text = cliente2.Guitarra.Marca.ToString();
                txtModelo.Text = cliente2.Guitarra.Modelo;
                txtPrecio.Text = $"$ {cliente2.Guitarra.Precio}";
            }
        }
    }
}
