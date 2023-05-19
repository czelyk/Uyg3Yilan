using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Yilan
{
    class Yem
    {
        public int X;
        public int Y;
        char chr = '*';

        public void uret()
        {
            Random sayiGen = new Random();
            X = sayiGen.Next(1, 31);
            Y = sayiGen.Next(1, 21);
        }

        public void ciz()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(chr);
        }

    }
}
