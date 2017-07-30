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
            HorisontalLine hLine = new HorisontalLine(3, 105, 3, '-');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(4, 24, 3, '|');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
