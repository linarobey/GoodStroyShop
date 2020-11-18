using System;

namespace OneParth
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculate();
            Console.WriteLine("Введите размеры в формате: \nДлина \nШирина");
            var totalArea = calculate.TotalArea(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Полная площадь: {0}", totalArea);
        }
    }
    
    public class Calculate
    {
        public double TotalArea(double length, double width)
        {
            return length * width;
        }
    }
}
