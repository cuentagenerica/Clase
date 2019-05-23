using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGit
{
    class tarea
    {
        public int suma;

        public long Ejercicio()
        {

            long val = 0;
            

            for (long i = 0; i < 10000000000; i++)
            {

                val += i;
            }

            return val;
        }
    }
}