using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorisontalLine hLineUp = new HorisontalLine(1, 77, 0, '-');
            hLineUp.Draw();
            HorisontalLine hLineDown = new HorisontalLine(1, 77, 24, '-');
            hLineDown.Draw();

            VerticalLine vLineLeft = new VerticalLine(0, 24, 0, '|');
            vLineLeft.Draw();
            VerticalLine vLineRight = new VerticalLine(0, 24, 78, '|');
            vLineRight.Draw();

            Console.ReadLine();
        }
    }
}
