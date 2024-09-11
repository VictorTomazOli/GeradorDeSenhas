using GeradorDeSenhas.Telas;

namespace GeradorDeSenhas;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao gerador de senhas");
        Console.WriteLine("Aperte qualquer botão para continuar");
        Console.ReadKey();
        MenuTela.Iniciar();
    }
}