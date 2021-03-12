using System;

namespace ConsoleApp1._2
{
    class Program
    {
        delegate int Add(int x, int y);
        delegate int Sub(int x, int y);
        delegate int Mul(int x, int y);
        delegate int Div(int x, int y);
        static void Main(string[] args)
        {
            int a, b;
            // Add
            Console.WriteLine("Введите число (а) для оператора Add");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число (b) для оператора Add");
            b = Convert.ToInt32(Console.ReadLine());
            Add add = (x, y) => x + y;
            Console.WriteLine(add(a,b) + " - Оператор Add-добавдения");
            int c, d;
            // Sub
            Console.WriteLine("Введите число (c) для оператора Sub");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число (b) для оператора Sub");
            d = Convert.ToInt32(Console.ReadLine());
            Sub sub = (x, y) => x - y;
            Console.WriteLine(sub(c, d) + " - Оператор Sub-вычетания");
            int e, f;
            // Mul
            Console.WriteLine("Введите число (e) для оператора Mul");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число (f) для оператора Mul");
            f = Convert.ToInt32(Console.ReadLine());
            Mul mul = (x, y) => x * y;
            Console.WriteLine(mul(e, f) + " - Оператор Mul-умножения");
            int g, i;
            // Div
            Console.WriteLine("Введите число (g) для оператора Div");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число (i) для оператора Div");
            i = Convert.ToInt32(Console.ReadLine());
            Div div = (x, y) => x / y;
            Console.WriteLine(mul(g, i) + " - Оператор Div-деления");
              try
              {
                Console.WriteLine(g / i);
              }
              catch (DivideByZeroException)
              {
                Console.WriteLine("Division of {0} by zero.", g);
              }

            Console.ReadLine();
        }
        
    }
}
