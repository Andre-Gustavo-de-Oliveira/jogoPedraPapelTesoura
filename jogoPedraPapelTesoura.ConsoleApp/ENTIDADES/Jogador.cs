namespace jogoPedraPapelTesoura.ConsoleApp.ENTIDADES;

public static class Jogador
{
    public static int ObterEscolhaJogador()
    {
        int escolhaJogador;

        do
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pedra, Papel, Tesoura");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("-----------------------------");

            Console.Write("Digite uma opção válida: ");
            string? strEscolhaJogador = Console.ReadLine();

            Console.WriteLine("-----------------------------");

            if (strEscolhaJogador == "1" || strEscolhaJogador == "2" || strEscolhaJogador == "3")
            {
                escolhaJogador = Convert.ToInt32(strEscolhaJogador);
                break;
            }

        } while (true);

        return escolhaJogador;
    }
}