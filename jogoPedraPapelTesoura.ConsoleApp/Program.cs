using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Pedra, Papel e Tesoura ===");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");

            Console.Write("Sua escolha: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int escolhaJogador) || escolhaJogador < 1 || escolhaJogador > 3)
            {
                Console.WriteLine("Entrada inválida!");
                Console.ReadKey();
                continue;
            }

            // Jogada do computador
            Random random = new Random();
            int escolhaComputador = random.Next(1, 4);

            string jogadaJogador = ConverterJogada(escolhaJogador);
            string jogadaComputador = ConverterJogada(escolhaComputador);

            // Resultado
            string resultado = DeterminarVencedor(escolhaJogador, escolhaComputador);

            // Exibir resultado
            Console.WriteLine($"\nVocê escolheu: {jogadaJogador}");
            Console.WriteLine($"Computador escolheu: {jogadaComputador}");
            Console.WriteLine($"Resultado: {resultado}");

            // Jogar novamente
            Console.WriteLine("\nDeseja jogar novamente? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
                continuar = false;
        }
    }

    static string ConverterJogada(int escolha)
    {
        switch (escolha)
        {
            case 1: return "Pedra";
            case 2: return "Papel";
            case 3: return "Tesoura";
            default: return "";
        }
    }

    static string DeterminarVencedor(int jogador, int computador)
    {
        if (jogador == computador)
            return "Empate!";

        if (
            (jogador == 1 && computador == 3) ||
            (jogador == 2 && computador == 1) ||
            (jogador == 3 && computador == 2)
        )
            return "Você venceu!";

        return "Computador venceu!";
    }
}