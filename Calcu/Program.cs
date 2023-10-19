using System;
using System.Collections.Generic;

namespace MiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Miniräknaren!");

            List<string> resultHistory = new List<string>();

            while (true)
            {
                try
                {
                    Console.Write("Ange det första talet: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ange en matematisk operator (+, -, *, /): ");
                    char operatorChar = Convert.ToChar(Console.ReadLine());

                    Console.Write("Ange det andra talet: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (operatorChar)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Ogiltig inmatning! Du kan inte dela med 0.");
                                continue;
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Ogiltig operator! Försök igen.");
                            continue;
                    }

                    resultHistory.Add($"{num1} {operatorChar} {num2} = {result}");

                    Console.WriteLine($"Resultat: {result}");

                    Console.Write("Vill du visa tidigare resultat? (Ja/Nej): ");
                    string showHistory = Console.ReadLine();
                    if (showHistory.ToLower() == "ja")
                    {
                        Console.WriteLine("Tidigare resultat:");
                        foreach (var entry in resultHistory)
                        {
                            Console.WriteLine(entry);
                        }
                    }

                    Console.Write("Vill du göra en annan beräkning? (Ja/Nej): ");
                    string anotherCalculation = Console.ReadLine();
                    if (anotherCalculation.ToLower() != "ja")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ogiltig inmatning! Var vänlig och ange numeriska värden.");
                }
            }
        }
    }
}
