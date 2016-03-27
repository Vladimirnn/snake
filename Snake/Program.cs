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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(3, 7, '%');
            p2.Draw();

            Point p4 = new Point(6, 9, '&');
            p2.Draw();

            Point p5 = new Point(5, 8, '$');
            p2.Draw();

            Point p6 = new Point(7, 2, '@');
            p2.Draw();


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);



            Console.ReadLine();
        }
    }
}
