using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENF
{
     class Juego
    { private List<string> tablero;
    

        public  Juego()
        {
            tablero = new List<string>();
            tablero.AddRange(new string[] { "", "", "", "", "", "", "", "", "" });
            
        }

            
        public void empezar()
        {
            logica logica = new logica();
            Console.WriteLine("Bienvenido a tres en raya tu eres X ");
            while (true)
            {
                Console.WriteLine();
                imprimirtablero();
                Console.WriteLine("Ingrese su fila");
                int fila = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su columna");
                int columna = Convert.ToInt32(Console.ReadLine());
                if(logica.rellenar(fila,columna, obtenertablero()) == false)
                {   Console.Clear();
                    Console.WriteLine("Posicion ocupada");
                    continue;
                }
                logica.rellenarIA(obtenertablero());
                int ganador = logica.verificarganador(obtenertablero());
                if (ganador == 1)
                {   Console.Clear();
                    imprimirtablero();
                    Console.WriteLine("Ganaste");
                    break;
                }
                else if (ganador == 2)
                {
                    Console.Clear();
                    imprimirtablero();
                    Console.WriteLine("Perdiste");
                    break;
                }
                else if (ganador == 3)
                {
                    Console.Clear();
                    imprimirtablero();
                    Console.WriteLine("Empate");
                    break;
                }

                Console.Clear();

            }
        

        }
        public void imprimirtablero()
        {   Console.WriteLine(" 1 2 3");
            int valor = 1;
            for (int i = 0; i < 9; i++)
            {   if(i % 3 == 0)
                {
                    Console.Write(valor);
                }
                    if(tablero[i] == "")
                    {
                        Console.Write(" "+"|");
                    }
                    else
                    {
                        Console.Write(tablero[i] + "|");
                    }
                   
                if ((i+1) % 3 == 0)
                {
                    Console.WriteLine();
                    valor++;
                }
            }

        }

        public List<string> obtenertablero()
        {
            return tablero;
        }

        private class logica
        {
            public bool rellenar(int fila,int columna, List<string> tablero)
            {
                if (tablero[(fila - 1) * 3 + columna - 1] == "")
                {
                    tablero[(fila - 1) * 3 + columna - 1] = "X";
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void rellenarIA(List<string> tablero)
            {   IA ia = new IA();
                ia.rellenartablero(tablero);

            }
            public int verificarganador(List<string>tablero)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i] == "X" && tablero[i + 3] == "X" && tablero[i + 6] == "X")
                    {
                        return 1;
                    }
                    if (tablero[i] == "O" && tablero[i + 3] == "O" && tablero[i + 6] == "O")
                    {
                        return 2;
                    }
                    if (tablero[i * 3] == "X" && tablero[i * 3 + 1] == "X" && tablero[i * 3 + 2] == "X")
                    {
                        return 1;
                    }
                    if (tablero[i * 3] == "O" && tablero[i * 3 + 1] == "O" && tablero[i * 3 + 2] == "O")
                    {
                        return 2;
                    }
                    if ((tablero[8]=="X" && tablero[4]=="X" && tablero[0]=="X") || (tablero[2] == "X" && tablero[4] == "X" && tablero[6]=="X"))
                    {
                        return 1;
                    }
                    if ((tablero[8] == "O" && tablero[4] == "O" && tablero[0] == "O") || (tablero[2] == "O" && tablero[4] == "O" && tablero[6] == "O"))
                    {
                        return 2;
                    }
                }
                if (tablero.Contains(""))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }

            }

        }






    }
}
