using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_2_Evaluacion
{

    /*********************************
         Autor: Daniel de la Rosa Romero
         Fecha creación: 02/02/2018
         Última modificación: xx/xx/xxxx
         Versión: x.xx
        ***********************************/

    class Semaforo
    {
        int tiempo;
        enum opciones { ambar, verde, rojo }

        public Semaforo(int UnTiempo, string UnEstado)
        {
            this.tiempo = UnTiempo;
            this.estado = "Ambar";

            tiempo = 0;
        }
        public int Tiempo
        {
            get
            {
                return tiempo;
            }
            set
            {
                tiempo = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        
    }
}
