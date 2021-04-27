using System;
using System.Globalization;
using System.Collections.Generic;
using Metodos_Abstratos.Entities;
using Metodos_Abstratos.Entities.Enums;

namespace Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }
        }
    }
}
