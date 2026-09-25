using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Rectangle rect = new Rectangle();
            rect.x = 3; // задаем значение для свойства X
            rect.y = 2; // задаем значение для свойства Y
            rect.show();
            double p = rect.Perimetr();

            Console.WriteLine($"Периметр прямоугольника = {p}");
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        public double x;
        public double y;
        public void show()
        {
            Console.WriteLine("Данные о прямоугольнике:");
            Console.WriteLine($"Высота = {y}");
            Console.WriteLine($"Ширина = {x}");
        }
        public double Perimetr()
        {
            return 2 * y + 2 * x;
        }
        }
    }

