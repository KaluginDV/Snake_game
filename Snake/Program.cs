﻿using System;
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
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(6, 8, '&');
            Point p4 = new Point(10, 10, 'H');

            List<Point> numList = new List<Point>();
            numList.Add(p1);
            numList.Add(p2);
            numList.Add(p3);
            numList.Add(p4);

            foreach (Point point in numList)
            {
                point.Draw();
            }

            Console.ReadLine();
        }
    }
}
