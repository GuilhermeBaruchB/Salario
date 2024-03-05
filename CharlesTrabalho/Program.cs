using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu salario bruto? ");
            SalBruto = Console.ReadLine(); 

            Console.WriteLine("Qual o valor do seu vale alimentação? ");
            VR = Console.ReadLine();

            Console.WriteLine("Quantos filhos você tem? ");
            Filho = Console.ReadLine();

            Console.WriteLine("Quanto a sua empresa te disponibiliza de acrécimo por filho? ");
            ValorFilho = Console.ReadLine();

            Console.WriteLine("Quantos horas extras você fez? ");
            Horas = Console.ReadLine();

            Console.WriteLine("Qual o valor da hora extra da sua empresa? ");
            ValorHora = Console.ReadLine();

            Console.WriteLine("Qual é o desconto do seu INSS? ");
            INSS = Console.ReadLine();

            Console.WriteLine("Quanto é descontado do seu salario para o IRPF?");
            Imposto = Console.ReadLine();

            int SalBruto2 = SalBruto - INSS - Imposto;

            int SalLiquido = SalBruto2 + VR + (Filho * ValorFilho) + (Hora * ValorHora);

        }
    }
}
