using System;

namespace ConsoleApp1
{
    class RIN
    {
        int min = 0;    
        int max = 100;  
        public string info = "число"; 
        public bool n_bool; 

        
        int n;
        public int N   
        {
            get { return n; }
            set
            {
                if (value < min)
                {
                    n = min;
                    n_bool = false;
                }
                else if (value > max)
                {
                    n = max;
                    n_bool = false;
                }
                else
                {
                    n = value;
                    n_bool = true;
                }
            }
        }
        public RIN(string n_st, int n_min, int n_max, int n_def, string n_info)
        {
            min = n_min;
            max = n_max;
            info = n_info;
            n_bool = true;
            try
            {
                N = Convert.ToInt32(n_st);
                if (!n_bool)
                {
                    info = "Ошибка ввода параметра << " + info + " >>. Число вне диапазона. Автоматически присваивается нижняя/верхняя граница. Для изменения введите целое число от " + min.ToString() + " до " + max.ToString();
                }
            }
            catch
            {
                info = "Ошибка ввода параметра << " + info + " >>. Введите целое число от " + min.ToString() + " до " + max.ToString() + ". По умолчанию параметр =  " + n_def.ToString(); ;
                n = n_def;
                n_bool = false;
            }
        }
    }   

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Введите число а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            c = Convert.ToInt32(Console.ReadLine());
            d = (a + b + c) / 3;
            Console.WriteLine( "среднее арифметическое =" + d);

            Console.ReadKey();
        }
    }
}
