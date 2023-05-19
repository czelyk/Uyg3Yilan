using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Yilan
{
     class Duvar
    {
        public int X = 0, Y = 0;
        public char chaaaar = '#';
        public void insa() 
        {
            
            
            for(int i = 0; i < 22; i++)
            {
                Y = i;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(chaaaar);
            }
        X = 90;
            for (int i = 0;i < 22; i++)
            {
                Y = i;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(chaaaar);
            }
            Y = 0;
            for(int i = 1;i<90 ; i++)
            {
                X = i;
                Console.SetCursorPosition(X, Y);    
                Console.WriteLine(chaaaar);
            }
            Y = 21;
            for(int i = 0; i < 90; i++)
            {
                X= i;
                Console.SetCursorPosition(X, Y);    
                Console.WriteLine(chaaaar);
            }
        X = 0;
        Y = 0;
        }
    }
}
