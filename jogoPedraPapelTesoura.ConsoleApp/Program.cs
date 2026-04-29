using jogoPedraPapelTesoura.ConsoleApp.ENTIDADES;

namespace jogoPedraPapelTesoura.ConsoleApp;

class Program
{
    static void Main()
    {
        while (true)
        {
            int escolhaJogador = Jogador.ObterEscolhaJogador();

            int escolhaComputador = Computador.ObterEscolhaComputador();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}