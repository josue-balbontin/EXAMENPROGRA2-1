using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENF
{
    class Jugador
    {

        public bool rellenartablero(List<string> tablero)
        {   Console.WriteLine("Ingrese su fila");
            int fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su columna");
            int columna = Convert.ToInt32(Console.ReadLine());
            if (tablero[(fila - 1) * 3 + columna - 1] == "")
            {
                tablero[(fila - 1) * 3 + columna - 1] = "X";
                return true;
            }
            else if (tablero.Contains(""))
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
