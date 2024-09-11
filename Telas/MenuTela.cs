namespace GeradorDeSenhas.Telas;

public class MenuTela
{
    public static void Iniciar()
    {
        Console.Clear();

        Console.WriteLine("Tamanho da senha: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Deseja incluir números? S/N");
        string? numeros = Console.ReadLine()?.ToUpper();
        Console.WriteLine("Deseja incluir caracteres maiúsculos? S/N");
        string? maiúsculas = Console.ReadLine()?.ToUpper();
        Console.WriteLine("Deseja incluir caracteres minúsculos? S/N");
        string? minúsculas = Console.ReadLine()?.ToUpper();
        Console.WriteLine("Deseja incluir caracteres especiais? S/N");
        string? especiais = Console.ReadLine()?.ToUpper();

        ConsoleKeyInfo tecla;
        var opcoesSelecionadas = Senha.OpcoesDeSenha(numeros, maiúsculas, minúsculas, especiais);

        if (opcoesSelecionadas is "")
        {
            Console.WriteLine("É necessário escolher uma das opções, tente novamente");
            Console.ReadKey();
            Iniciar();
        }

        do
        {
            Console.Clear();
            var senhaForte = Senha.CriarSenha(opcoesSelecionadas, tamanho);
            Console.WriteLine(senhaForte);
            Console.WriteLine("Aperte qualquer tecla para gerar outra senha ou [ESC] para sair");
            tecla = Console.ReadKey();

        } while (tecla.Key != ConsoleKey.Escape);
        Environment.Exit(0);
    }
}