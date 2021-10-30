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

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
            string palabra = string.Empty;
            int flag = 1;
            int len = rtxPalabras.Text.Length;

            for (int i = 0; i < rtxPalabras.Text.Length; i++)
            {
                bool coincidencia = false;
                palabra += rtxPalabras.Text[i];
                palabra = palabra.Trim(new Char[] { ' ', '*', ',', ';','.' });
                palabra = palabra.Trim();
                if (rtxPalabras.Text[i] == ' ' || rtxPalabras.Text[i] == '.' || rtxPalabras.Text[i] == ',' || i == len - 1)
                {
                    if (flag == 1)
                    {                        
                        int contadorInicial = 0;
                        contadorPalabras.Add(palabra, contadorInicial);
                        flag = 0;
                    }
                    foreach (KeyValuePair<string, int> item in contadorPalabras)
                    {
                        if (item.Key == palabra)
                        {                            
                            int contador = item.Value;
                            contador++;
                            contadorPalabras[item.Key] = contador;
                            coincidencia = true;
                        }
                    }
                    if (coincidencia == false)
                    {                        
                        int contadorSecundario = 1;
                        contadorPalabras.Add(palabra, contadorSecundario);
                    }
                    palabra = null;
                }
            }
            foreach (KeyValuePair<string, int> item in contadorPalabras)
            {
                MessageBox.Show($"La palabra {item.Key} esta {item.Value} veces.");
            }
        }
    }
}
