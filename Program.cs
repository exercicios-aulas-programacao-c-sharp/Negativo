using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroDigitado;
            bool numeroValido;

            Console.Write("Digite um número: ");
            
            numeroDigitado = Console.ReadLine();
            numeroValido = Int32.TryParse(numeroDigitado, out numero);

            if (numeroValido && numero < 0){
                Console.WriteLine("Você digitou um número negativo.");
            }
        }
    }
}
