using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreClinica
{
    public class ConfiguracionApp
    {
        string rutaBase;
        bool darkMode;
        string tituloApp;

        public ConfiguracionApp(string rutaBase, bool darkMode, string tituloApp)
        {
            this.rutaBase = rutaBase;
            this.darkMode = darkMode;
            this.tituloApp = tituloApp;
        }

        public string RutaBase { get => rutaBase; set => rutaBase = value; }
        public bool DarkMode { get => darkMode; set => darkMode = value; }
        public string TituloApp { get => tituloApp; set => tituloApp = value; }
    }
}
