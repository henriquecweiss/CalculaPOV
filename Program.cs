using System.Security.Cryptography.X509Certificates;

public static class Program
{
    static void Main(string[] args)
    {
        static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) => (int)(totalNegociado / (1 - porcentagem) * porcentagem);
    }
}