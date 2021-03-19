using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1Progra3
{
    class Estudiante
    {
        int carnet;
        string nombre;
        string direccion;

        public int Carnet { get => carnet; set => carnet = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
