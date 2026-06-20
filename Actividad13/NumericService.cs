using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad13
{
    internal class NumericService
    {
        public int contador;
        public Alumno[] Alumnos = new Alumno [100];
        public NumericService() {contador = 0;}

        public void RegistrarAlumno(int lu, string nombre,double nota)
        {
            if (contador < Alumnos.Length)
            {
                Alumno nueva = new Alumno();
                nueva.LU = lu;
                nueva.Nombre = nombre;
                nueva.Nota = nota;
                Alumnos [contador] = nueva;
                contador++;
            }
        }

        public Alumno VerAlumno(int idx)
        {
            if (idx >= contador)
            {
                return null;
            }
            return Alumnos [idx];
        }

        public int BuscarPorLUSecuencial(int lu)
        {
            int idx = -1;
            int cont = 0;

            while (idx == -1 && cont < Alumnos.Length)
            {
                if (Alumnos[cont].LU == lu)
                {
                    idx = cont;
                }
                cont++;
            }
            return idx;
        }

        public int BuscarPorLUBinario(int lu)
        {
            int izq = 0;
            int der = contador - 1;
            int medio;

            while (izq < der)
            {
                medio = (izq + der)/ 2;

                if (Alumnos[medio].LU == lu)
                {
                    return medio;
                }
                else if (lu < Alumnos[medio].LU)
                {
                    der = medio-1;
                }
                else if (lu  > Alumnos[medio].LU)
                {
                    izq = medio+1;
                }
            }
            return -1;
        }

        private void Intercambiar(int i, int j)
        {
            Alumno aux = Alumnos[i];
            Alumnos[i] = Alumnos[j];
            Alumnos[j] = aux;
        }

        public void OrdenarPorLUBurbuja()
        {
            for (int i = 0; i < contador-1; i++)
            {
                for (int j = i+1; j < contador; j++)
                {
                    if (Alumnos[i].LU > Alumnos[j].LU)
                    {
                        Intercambiar(i, j);
                    }
                }
            }
        }

        public void OrdenarPorLUQuickSort(int i, int f)
        {
            int p = i; //es el pivote [0]
            int izq = p + 1; //puntero izquierdo (arranca un paso adelante del pivote)
            int der = f; // puntero derecho (arranca en el final del todo)

            
            while (izq < der) 
            {
                //1.INSPECTOR IZQUIERDO:
                //Mientras mi LU de pivote sea MENOR al LU del alumno izquierdo...
                //Significa que ese alumno es grande, esta bien ubicado a la izquierda. Avanza un paso.
                while (Alumnos[p].LU < Alumnos[izq].LU)
                {
                    izq++;
                }

                //1.INSPECTOR DERECHO:
                //Mientras mi LU de pivote sea MAYOR al LU del alumno derecho...
                //Significa que ese alumno es bajito, esta bien ubicado a la derecha. Retrocedo un paso.
                while (Alumnos[p].LU > Alumnos[der].LU)
                {
                    der--;
                }

                //EL INTERCAMBIO:
                //Si los "INSPECTORES" se detuvieron, es porque encontraron a dos alumnos que estan en el lado equivocado.
                //Verificamos que los inspectores no se hayan cruzado y si todo esta bien, los cambiamos de lugar.
                if (izq < der)
                {
                    Intercambiar(der, izq);
                }
                //trabajo terminado
            }

            //acomodamos al pivote donde tiene que ir 
            if (der > p)
            {
                Intercambiar(der, p);
            }
            //hacemos la recursividad para el siguiente pivote:
            if (i < der - 1) //primero agarramos un grupo y lo mandamos a ordenar hasta que quede por completo ordenado y asi pase al otro grupo
            {
                OrdenarPorLUQuickSort(i, der - 1);
            }

            if (der + 1 < f)//este es el otro grupo que pasamos a ordenar cuando ya ordenamos el de arriba 
            {
                OrdenarPorLUQuickSort(der + 1, f);
            }
        }

        public double CalcularPromedio()
        {
            double promedio = 0;
            double total = 0;
            for (int i = 0; i < contador; i++)
            {
                total += Alumnos[i].Nota;
            }
            if (contador!= 0)
            {
                promedio = total/contador;
            }
            return promedio;
            
        }

        public Alumno[] AlumnosQueSuperanElPromedio(out int cantidad)//al hacer out si o si tenemos que llenar la variable cantidad
        {
            cantidad = 0;
            double promedio = CalcularPromedio();

            Alumno[] Filtrados = new Alumno[contador];

            for (int n=0; n<contador; n++)
            {
                if (Alumnos[n].Nota>=promedio) 
                {
                    Filtrados[cantidad] = Alumnos[n];
                    cantidad++;
                }
                
            }
            return Filtrados;
        }
    }
}
