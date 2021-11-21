using System;
using System.Linq;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int lar, alt, c, i;
            Console.WriteLine("--- Tamanho do Retangulo ---");
            inicio:
            Console.Write("Largura..: ");
            lar = int.Parse(Console.ReadLine());
            Console.Write("Altura...: ");
            alt = int.Parse(Console.ReadLine());

            c = 1;
            i = 1;
            if(lar > 0 && lar <= 10 && alt > 0 && alt <= 10)
            {
                while(c <= alt)
                {
                    if(c == 1 || c == alt)
                    {
                        string ret = string.Concat(Enumerable.Repeat("*",lar));
                        Console.WriteLine(ret);
                    }
                    else
                    {
                        while (i <= alt-2)
                        {
                            string ret = string.Concat(Enumerable.Repeat(" ",lar-2));
                            Console.WriteLine($"*{ret}*");
                            i++;                        
                        }
                    }
                    c++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite ambos valores entre 1 e 10");
                Console.ResetColor();
                goto inicio;
            }
        }
    }
}
