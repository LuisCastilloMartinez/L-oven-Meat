using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_oven_Meat
{
    internal class Login_code
    {
        public string User, Password;
        public string claveB;
        public string NomC, NumT, Correo, hora;
        public int[] mesaS = new int[21];
        public Random PagoMesa = new Random();
        public bool[] mesasDisponibles = new bool[20];
       public double[] MESA = new double[4];
    }
}
