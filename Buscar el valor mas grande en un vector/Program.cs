using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscar_el_valor_mas_grande_en_un_vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[5];
            int i,mayor =0, j=0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el valor de la posicion {0}: ", (i + 1));
                datos[i] = int.Parse(Console.ReadLine());
            }
            while (j < 5)
            {
                if (datos[j] > mayor)                
                    mayor = datos[j];
                    j++;                
            }
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("******************************");
            Console.WriteLine("El valor mayor es: {0}", mayor);
            Console.WriteLine("******************************");
            Console.ReadKey();
        }
    }
}
