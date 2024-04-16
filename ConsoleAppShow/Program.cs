using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vtotal = 0;
            int ing_total = 0;
            int ing_meia = 0;
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("É estudante [S/N]: ");
                string est = Console.ReadLine().ToLower() ;
                if(i <= 10 && est == "s") {
                    vtotal += 50;
                    ing_meia++;
                    Console.WriteLine("Ingresso Vendido");
                }else if(i <= 10)
                {
                    vtotal += 100;
                    ing_total++;
                    Console.WriteLine("Ingresso Vendido ");
                }
                else if(i <= 20 && est == "s")
                {
                    vtotal += 75;
                    ing_meia++;
                    Console.WriteLine("Ingresso Vendido ");
                }
                else if (i <= 20)
                {
                    vtotal += 150;
                    ing_total++;
                    Console.WriteLine("Ingresso Vendido ");
                }
                else if (i <= 30 && est == "s")
                {
                    vtotal += 100;
                    ing_meia++;
                    Console.WriteLine("Ingresso Vendido ");
                }
                else
                {
                    vtotal += 200;
                    ing_total++;
                    Console.WriteLine("Ingresso Vendido ");
                }
            }
            Console.Clear();
            Console.WriteLine("O faturamento total foi " + vtotal.ToString("C"));
            Console.WriteLine("A quantidade de ingressos pagos integralmente foi " + ing_total);
            Console.WriteLine("A quantidade de ingressos pagos metade foi " + ing_meia);
            Console.ReadKey();
        }
    }
}
