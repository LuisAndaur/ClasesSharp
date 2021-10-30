using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido
    {
        private Equipo equipoLocal;
        private Equipo equipoVisitante;
        private int golesLocal;
        private int golesVisitante;
        private bool partidoJugado;
        private Random random;
        private EResultado resultadoEquipoLocal;

        private Partido()
        {

        }

        public Partido(Equipo local, Equipo visitante)
        {
            this.equipoLocal = local;
            this.equipoVisitante = visitante;
            this.random = new Random();
        }

        public void SimularPartido()
        {
            golesLocal = random.Next(0, 10);
            golesVisitante = random.Next(0, 10);
            partidoJugado = true;

            if ( golesLocal < golesVisitante )
            {
                equipoLocal.Estadistica.Actualizar(EResultado.Derrota, golesLocal, golesVisitante);
                equipoVisitante.Estadistica.Actualizar(EResultado.Victoria, golesVisitante, golesLocal);
            }
            else
            {
                if (golesLocal > golesVisitante)
                {
                    equipoLocal.Estadistica.Actualizar(EResultado.Victoria, golesLocal, golesVisitante);
                    equipoVisitante.Estadistica.Actualizar(EResultado.Derrota, golesVisitante, golesLocal);
                }
                else
                {
                    equipoLocal.Estadistica.Actualizar(EResultado.Empate, golesLocal, golesVisitante);
                    equipoVisitante.Estadistica.Actualizar(EResultado.Empate, golesVisitante, golesLocal);
                }
            }

        }

    }
}
