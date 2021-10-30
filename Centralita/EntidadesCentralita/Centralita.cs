using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCentralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial) : this()
        {            
            this.razonSocial = razonSocial;
        }

        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float costoLlamada = 0;

            foreach (Llamada tipo in listaDeLlamadas)
            {
                switch (tipoLlamada)
                {
                    case Llamada.TipoLlamada.Local:
                        if (tipo is Local)
                        {
                            costoLlamada += ((Local)tipo).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (tipo is Provincial)
                        {
                            costoLlamada += ((Provincial)tipo).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (tipo is Local)
                        {
                            costoLlamada += ((Local)tipo).CostoLlamada;
                        }
                        else
                        {
                            if (tipo is Provincial)
                            {
                                costoLlamada += ((Provincial)tipo).CostoLlamada;
                            }
                        }
                        break;
                }
            }
            return costoLlamada;
        }

        public string Mostrar()
        {
            StringBuilder centralita = new StringBuilder();
            centralita.AppendLine($"Nombre de la empresa: {razonSocial}");
            centralita.AppendLine($"Ganancia total: {GananciasPorTotal}");
            centralita.AppendLine($"Ganancia por llamados Locales: {GananciasPorLocal}, Provinciales: {GananciasPorProvincial}");
            centralita.AppendLine($"Lista de llamadas: ");
            foreach (Llamada item in Llamadas)
            {
                centralita.AppendLine(item.Mostrar());
            }
            return centralita.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
