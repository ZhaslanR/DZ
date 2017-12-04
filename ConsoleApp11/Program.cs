using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex, lastIndex;

            RangeOfArray array = new RangeOfArray();

            Console.WriteLine("Ведите нижнию границу массива: ");
            if (!(int.TryParse(Console.ReadLine(),out firstIndex)))
            {
                Console.Clear();
                Console.WriteLine("Ведите нижнию границу массива: ");
            }
            else
            {
                array.FirstIndex = firstIndex;
            }

            Console.WriteLine("Ведите верхнию границу массива: ");
            if (!(int.TryParse(Console.ReadLine(), out lastIndex)))
            {
                Console.Clear();
                Console.WriteLine("Ведите вехнию границу массива: ");
            }
            else
            {
                array.LastIndex = lastIndex;
            }
            array.Show();
        }
    }
}
