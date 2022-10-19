using System;
using System.Text.RegularExpressions;


namespace NumerosPrimos
{
    public class IdentifyString
    {
        //verifição se é número
        public static void Main()
        {
            string teste;

            Console.WriteLine("escreva um numero");
            teste = Console.ReadLine();

            if (Regex.IsMatch(teste, @"^[0-9]+$"))
            {
                int testeint = int.Parse(teste);
                Primo(testeint);
            }
            else
            {
                Console.WriteLine("O caracter não é numero.");
                Console.ReadLine();
            }
        }

        //verifição se é primo
        public static void Primo(int n)
        { 
            int i;
            int c = 0;

            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                    i = n;
                    i++;
                }
            }
            if (c == 0) {Console.WriteLine("O número " + n + " é primo");
            }
            else
            {
                Console.WriteLine(n + "Não é primo");
            }
            Console.ReadLine();
        }
    }

}