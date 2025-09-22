using System;
using System.Linq;
using System.Text;

namespace Omkeren
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doorgaan = true;

            while (doorgaan)
            {
                Console.Clear();
                Console.WriteLine("=== String Omkeren ===");
                Console.Write("Geef een string in (leeg = stoppen): ");
                string input = Console.ReadLine() ?? "";

                
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Lege invoer — programma stopt. Tot ziens!");
                    return;
                }

                Console.WriteLine("\nKies een methode om de string om te keren:");
                Console.WriteLine("1. For-loop");
                Console.WriteLine("2. While-loop");
                Console.WriteLine("3. Do-while-loop");
                Console.WriteLine("4. Recursie");
                Console.WriteLine("5. Stoppen");
                Console.Write("Uw keuze: ");

                string keuze = Console.ReadLine() ?? "";
                string result = "";

                switch (keuze.Trim())
                {
                    case "1":
                        result = OmkerenFor(input);
                        break;
                    case "2":
                        result = OmkerenWhile(input);
                        break;
                    case "3":
                        result = OmkerenDoWhile(input);
                        break;
                    case "4":
                        result = OmkerenRecursie(input);
                        break;
                    case "5":
                        doorgaan = false;
                        continue;
                    default:
                        Console.WriteLine("Ongeldige keuze — probeer opnieuw.");
                        Console.WriteLine("Druk op een toets...");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine($"\nOrigineel:  {input}");
                Console.WriteLine($"Omgekeerd: {result}");
                Console.WriteLine("\nDruk op een toets om verder te gaan...");
                Console.ReadKey();
            }
        }

        static string OmkerenFor(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var sb = new StringBuilder(s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(s[i]);
            return sb.ToString();
        }

        static string OmkerenWhile(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var sb = new StringBuilder(s.Length);
            int i = s.Length - 1;
            while (i >= 0)
            {
                sb.Append(s[i]);
                i--;
            }
            return sb.ToString();
        }

        static string OmkerenDoWhile(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var sb = new StringBuilder(s.Length);
            int i = s.Length - 1;
            do
            {
                sb.Append(s[i]);
                i--;
            } while (i >= 0);
            return sb.ToString();
        }

        static string OmkerenRecursie(string s)
        {
            // voorbeeld met Last() uit de hint
            if (string.IsNullOrEmpty(s)) return s;
            if (s.Length == 1) return s;
            return s.Last() + OmkerenRecursie(s.Substring(0, s.Length - 1));
        }
    }
}
