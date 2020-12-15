using System;

namespace lacos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Bem vindo ao nosso sistema de calculadora virtual ---");
            Console.Write("Que conta de divisão deseja ver? ");
            float resposta = float.Parse(Console.ReadLine());

            float divisao;

            for (int contador = 0; contador <=20; contador++){
            divisao = resposta / contador;
            Console.WriteLine($"{resposta} / {contador} = {divisao}");

            }

        }
    }
}
