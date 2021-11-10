﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosDelegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Click += Mostrar;
        }

        private void Mostrar(object sender, EventArgs e)
        {
            int num = 0;
            MessageBox.Show($"Estoy en {((Control)sender).Name}");

            if (num == 0)
            {
                this.button1.Click -= Mostrar;
                this.button2.Click += Mostrar;
                num = 1;
            }

            if (num == 1)
            {
                this.button2.Click -= Mostrar;
                this.button3.Click += Mostrar;
                num = 2;
            }

            if (num == 2)
            {
                this.button3.Click -= Mostrar;
                this.button4.Click += Mostrar;
                num = 0;
            }
            
        }
    }
}
