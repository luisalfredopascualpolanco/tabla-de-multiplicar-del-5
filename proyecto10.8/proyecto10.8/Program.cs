using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero;

                for (int i = 0; i < 50; i++)
                {
                    numero = i + 1;
                    Console.WriteLine(numero+" x 5 = "+(numero*5));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido");
            }
            Console.ReadKey();
        }
    }
}
