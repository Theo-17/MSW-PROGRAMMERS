using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Aeroportuarios
{
    public class Variables
    {
        //MATEO
        static public int numAsientoArg = 1;
        static public int numAsientoChi = 1;
        static public int numAsientoBra = 1;

        public struct Destino
        {
            static public String paisSalida;
            static public String paisLLegada;
            static public double precio;
        }
        public struct Aerolinea
        {
            static public int asiento;
            static public String aerolinea;
            static public Destino destino;
        }

        static public Variables.Aerolinea Info;
    }
    
}
