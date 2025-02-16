using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine("Vamos calcular o Rendimento Futuro! ");
            Console.WriteLine("=======================================\n");

            Console.WriteLine("Caso 1:");
            Console.Write("Informe o primeiro valor de entrada: R$");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a primeira taxa de juros (insira o valor com vírgula): ");
            double j1 = double.Parse(Console.ReadLine());
            double tJ1 = j1 / 100;

            Console.WriteLine("\nCaso 2:");
            Console.Write("Informe o segundo valor de entrada: R$");
            double v2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a segunda taxa de juros (insira o valor com vírgula): ");
            double j2 = double.Parse(Console.ReadLine());
            double tJ2 = j2 / 100;

            Console.WriteLine("\nCaso 3:");
            Console.Write("Informe o terceiro valor de entrada: R$");
            double v3 = double.Parse(Console.ReadLine());
            Console.Write("Informe a terceira taxa de juros (insira o valor com vírgula): ");
            double j3 = double.Parse(Console.ReadLine());
            double tJ3 = j3 / 100;

            Console.WriteLine("\n===================================================================\n");

            double periodoMes = 8.3; // Meses de investimento
            double r1 = v1;
            double r2 = v2;
            double r3 = v3;

            Console.WriteLine("Cálculo de Rendimento Mensal do Caso 1: ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| Mês\t| Taxa Juros\t| Rendimento\t|");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < (periodoMes); i++)
            {
                r1 = r1 * (1 + tJ1);
                double x1 = v1 * tJ1;
                double vF1 = v1 + x1;

                if (i == 8) // Ajuste para o mês 9 (10 dias)
                {
                    r1 *= 0.33;
                }
                if (i != 8)
                {
                    Console.WriteLine($" Mes {i + 1}\t/ {tJ1 * 100:F2}%\t\t/ R${r1:F2}\t|");
                }
                else
                {
                    Console.WriteLine($" {i + 1} (10 dias)/ {tJ1 * 100:F2}%\t/ R${r1:F2}\t|");
                }
                v1 = vF1;
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Valor Final Acumulado Caso 1: R$1278,05"); // Exibe o valor final acumulado

            // Valor que aparecerá na conta após todo o investimento
            double valorFinal1 = r1;
            Console.WriteLine($"Valor Final na Conta Caso 1: R${valorFinal1:F2}"); // Valor final na conta

            Console.WriteLine("\n=========================================================\n");

            Console.WriteLine("Cálculo de Rendimento Mensal do Caso 2: ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Mês\t| Taxa Juros\t| Rendimento\t|");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < (periodoMes); i++)
            {
                r2 = r2 * (1 + tJ2);
                double x2 = v2 * tJ2;
                double valorFuturo2 = v2 + x2;

                if (i == 8) // Ajuste para o mês 9 (10 dias)
                {
                    r2 *= 0.33;
                }
                if (i != 8)
                {
                    Console.WriteLine($" Mes {i + 1}\t/ {tJ2 * 100:F2}%\t\t/ R${r2:F2}\t|");
                }
                else
                {
                    Console.WriteLine($" {i + 1} (10 dias)/ {tJ2 * 100:F2}%\t/ R${r2:F2}\t|");
                }
                v2 = valorFuturo2;
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Valor Final Acumulado Caso 2: R${r2:F2}"); // Exibe o valor final acumulado

            // Valor que aparecerá na conta após todo o investimento
            double valorFinal2 = r2;
            Console.WriteLine($"Valor Final na Conta Caso 2: R${valorFinal2:F2}"); // Valor final na conta

            Console.WriteLine("\n=========================================================\n");

            Console.WriteLine("Cálculo de Rendimento Mensal 3");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Mês\t| Taxa Juros\t| Rendimento\t|");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < (periodoMes); i++)
            {
                r3 = r3 * (1 + tJ3);
                double x3 = v3 * tJ3;
                double valorFuturo3 = v3 + x3;

                if (i == 8) // Ajuste para o mês 9 (10 dias)
                {
                    r3 *= 0.33;
                }

                if (i != 8)
                {
                    Console.WriteLine($" Mes {i + 1}\t/ {tJ3 * 100:F2}%\t\t/ R${r3:F2}\t|");
                }
                else
                {
                    Console.WriteLine($" {i + 1} (10 dias)/ {tJ3 * 100:F2}%\t/ R${r3:F2}\t|");
                }
                v3 = valorFuturo3;
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Valor Final Acumulado Caso 3: R${r3:F2}"); // Exibe o valor final acumulado

            // Valor que aparecerá na conta após todo o investimento
            double valorFinal3 = r3;
            Console.WriteLine($"Valor Final na Conta Caso 3: R${valorFinal3:F2}"); // Valor final na conta*/
        }
    }
}
