using System;

namespace CalculatorApp
{
    class Program
    {
        static int data_type;
        static string first_number;
        static string second_number;
        static int number1;
        static int number2;
        static void Main(string[] args)
        {
            Console.Write("Введите 1 число: ");
            first_number = Console.ReadLine();
            int.TryParse(first_number, out number1);

            Console.Write("Введите 2 число: ");
            second_number = Console.ReadLine();
            int.TryParse(second_number, out number2);

            Console.WriteLine("1\t-\tint\t1");
            Console.WriteLine("2\t-\tdouble\t1.0");

            Console.Write("Введите тип данных: ");
            data_type = Convert.ToInt32(Console.ReadLine());
            if (data_type == 1)
            {
                int sumint = GetIntSum();
                Console.WriteLine(sumint);
            }
            else if (data_type == 2)
            {
                double sumtdouble = GetDoubleSum();
                Console.WriteLine(sumtdouble);
            }
        }

        static int GetIntSum()
        {
            return number1 + number2;
        }

        static double GetDoubleSum()
        {
            double a1 = double.Parse(first_number);
            double a2 = double.Parse(second_number);
            return a1 + a2;
        }
    }
}