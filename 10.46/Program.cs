using System;

namespace _10._46
{
    class Program
    {
        static void Main(string[] args)
        {
            double storona, storona2;
            double ugol;
            double oblast;

            while (true)
            {
                Console.Write("Введите значение большей трапеции:");
                storona = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Введите значение меньшей трапеции:");
                storona2 = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Введите значение угла при большей трапеции:");
                ugol = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (storona <= storona2)
                    Console.WriteLine("Введите значения еще раз");
                else
                    break;
            }

            oblast = (((storona * storona) - (storona2 * storona2)) * Math.Tan(ugol)) / 4;

            Console.WriteLine("Площадь трапеции = {0:0.00} ", oblast);
            Console.ReadLine();
        }
    }

}
