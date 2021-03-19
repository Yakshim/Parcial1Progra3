using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1Progra3
{
    class Prestamo
    {
        int carnet;
        string codigo;
        DateTime FechaPre;
        DateTime FechaDev;

        public int Carnet { get => carnet; set => carnet = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime FechaPre1 { get => FechaPre; set => FechaPre = value; }
        public DateTime FechaDev1 { get => FechaDev; set => FechaDev = value; }
    }
}
