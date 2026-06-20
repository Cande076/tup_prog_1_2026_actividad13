using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad13
{
    internal class Alumno
    {
        public int LU;
        public string Nombre;
        public double Nota;
        public Alumno(int lu,string nombre,double nota) 
        {
            LU = lu;
            Nombre = nombre;
            Nota = nota;
        }
        public Alumno(){ }
    }
}
