using System;

namespace Projeto_de_Console_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Digite o primeiro número.");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma operação.");
            string operacao = Console.ReadLine();

                switch(operacao){
                case "soma":
               float resultado = num1+num2;
                break;

                case "subtracao":
               float resultado = num1-num2;
                break;

                case "divisao":
               float resultado = num1/num2;
                break;

                case "multiplicacao":
               float resultado = num1*num2;
                break;

                default:
                Console.WriteLine("Operação Inválida!");
                break;
            }
                Console.WriteLine("O resultado é:"+resultado);
        }

    }
}
