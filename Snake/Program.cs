﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //установки области экрана
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            //Отрисовка рамки
            HorisontalLine hLineUp = new HorisontalLine(1, 77, 0, '-');
            hLineUp.Draw();
            HorisontalLine hLineDown = new HorisontalLine(1, 77, 24, '-');
            hLineDown.Draw();
            VerticalLine vLineLeft = new VerticalLine(0, 24, 0, '|');
            vLineLeft.Draw();
            VerticalLine vLineRight = new VerticalLine(0, 24, 78, '|');
            vLineRight.Draw();

            //Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
