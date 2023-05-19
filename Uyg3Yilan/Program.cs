using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Yilan
{
    class Program
    {
        static void Main(string[] args)
        {
            Duvar duvar = new Duvar();
            
            Yem y = new Yem();
            y.uret();
            y.ciz();
            Yilan snake = new Yilan();
            snake.ciz(snake.skor);
            ConsoleKeyInfo tus;
            do 
            {
                duvar.insa();
                tus = Console.ReadKey();
                snake.hareketEt(tus);
                if (snake.yemiYedimi(y))
                {
                    snake.skor++;
                    y.uret();
                }
                snake.ciz(snake.skor);
                y.ciz();
                snake.skorYaz();
            }
            while (tus.Key != ConsoleKey.Escape);
        
        for(int a=0;a<30;a++)
            {

            }        
        
        }
    }
}
