using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ezen_mulik_minden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Bardi János számológépe, hogy ne bukjon meg");

                    Console.Write("Add meg az elso szamot: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Add meg a szamolast (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    Console.Write("Add meg a masodik szamot: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    // innenstol megy a matek
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Hiba: nullaval nem osztunk, masodikba megtanultad ocsi");
                                continue;
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Ilyen egyenlet nem letezik, probald ujra hatha osszejon most");
                            continue;
                    }

                    // itten irja az eredmenyt abban az esetben ha jot irt a felhasznalo, meg lehet masik szamolast inditani
                    Console.WriteLine("Az eredmeny: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hiba: Egy kurva szamot kerek, nem a jozsef attilatol a mama elso 2 verszakat, probald ujra.");
                    continue;
                }

                Console.Write("Akarsz masik szamolast csinalni? (i/n): ");
                if (Console.ReadLine().ToLower() != "i")
                {
                    break;
                }
            }
        }
    }
}
