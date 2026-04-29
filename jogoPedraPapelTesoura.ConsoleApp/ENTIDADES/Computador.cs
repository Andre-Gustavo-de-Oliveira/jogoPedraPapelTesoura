using System.Security.Cryptography;

namespace jogoPedraPapelTesoura.ConsoleApp.ENTIDADES;

public static class Computador
{
    public static int ObterEscolhaComputador()
    {
        return RandomNumberGenerator.GetInt32(1, 4);
    }
}