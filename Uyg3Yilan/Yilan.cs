using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Yilan
{
    class Yilan
    {
        public int X = 1;
        public int Y = 1;
        char chr = '>';
        public int skor = 0;

        public void ciz(int a)
        {
            
          
            Console.Clear();
                Console.SetCursorPosition(X, Y);
            //for (int i = 0; i < a; i++) //problem var.
            //{ 
                Console.Write(chr);
              //  X++;
            //}
        }

        public void hareketEt(ConsoleKeyInfo basilanTus)
        {
           
            if (basilanTus.Key == ConsoleKey.RightArrow) X++;
            else if (basilanTus.Key == ConsoleKey.LeftArrow) X--;
            else if (basilanTus.Key == ConsoleKey.DownArrow) Y++;
            else if (basilanTus.Key == ConsoleKey.UpArrow) Y--;

            if (X < 1) X = 30;
            if (X > 30) X = 1;
            if (Y > 20) Y = 1;
            if (Y < 1) Y = 20;

        }

        public bool yemiYedimi(Yem y)
        {
           
            bool sonuc = false;
            if (X == y.X && Y == y.Y)
             sonuc = true;
                
            
            return sonuc;
        }

        public void skorYaz()
        {
            Console.SetCursorPosition(1, 22);
            Console.WriteLine("Skor:" + skor);
        }

        
    }
}
