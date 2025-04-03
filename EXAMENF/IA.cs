using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENF
{
    class  IA
    {    
        
     

        public void rellenartablero(List<string> tablero)
        {
            Random random = new Random();
            int valor = random.Next(0, 8);
            if (tablero[valor] == "")
            {
                tablero[valor] = "O";
            }
            else if (tablero.Contains("")){
                rellenartablero(tablero);
            }
            else
            {
                return;
            }
        }



    }
}
