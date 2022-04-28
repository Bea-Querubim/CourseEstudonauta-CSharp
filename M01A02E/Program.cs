using System;

namespace M01A02E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 3); // Mudar a posição do Console:

            Console.ForegroundColor = ConsoleColor.White; //comando para mudar a cor da letra:
            Console.BackgroundColor = ConsoleColor.DarkCyan; //comando para alterar o fundo

            Console.WriteLine("Olá querida EStudonauta!");
            Console.ResetColor(); //comando para resetar a cor  --- se nao resetar a tela toda continua com a cor

            Console.ReadKey(); //faz a "pausa dramatica"
            Console.Clear(); //Limpa a tela

            Console.ForegroundColor = ConsoleColor.DarkGreen; //comando para mudar a cor da letra:
            Console.BackgroundColor = ConsoleColor.White; //comando para alterar o fundo
            Console.SetCursorPosition(10, 5);  // Mudar a posição do Console:

            Console.WriteLine("Tudo bem com você??");
            Console.ResetColor(); //comando para resetar a cor  --- se nao resetar a tela toda continua com a cor

        }
    }
}
