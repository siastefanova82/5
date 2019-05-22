using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        private static bool t(int[] array, int x)
        {
            int a;
            for (int i = 0; i < array.Length; i++)
            {
                a = array[i];
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] + array[j] == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Брой елеметни:");
            int x = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Сума на елементите:");
            int y = Convert.ToInt32((Console.ReadLine())); ;
            int[] array = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Въведи елементите {i}: ");
                int c = Convert.ToInt32(Console.ReadLine());
                array[i] = c;
            }
            if (t(array, x))
            {
                Console.WriteLine($"Има сума = {x}");
            }
            else
            {
                Console.WriteLine($"Няма сума = {x}");
            }
        }
    }
}