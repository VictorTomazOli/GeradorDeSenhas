using System.Security.Cryptography;

namespace GeradorDeSenhas;

public abstract class Senha
{
    private static string Numeros { get; set; } = "0123456789";
    private static string Maiusculas { get; set; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static string Minúsculas { get; set; } = "abcdefghijklmnopqrstuvwxyz";
    private static string Especiais { get; set; } = "!\"#$%'()*+,-./:;<=>?@[\\]^_`{|}~";

    public static string CriarSenha(string opcoesSelecionadas, int tamanhoSenha)
    => RandomNumberGenerator.GetString(opcoesSelecionadas, tamanhoSenha);

    public static string OpcoesDeSenha(string numeros, string maiúsculas, string minúsculas, string especiais)
    {
        string opcoes = "";

        if (Opcao(numeros) is true)
            opcoes += Numeros;

        if (Opcao(maiúsculas) is true)
            opcoes += Maiusculas;

        if (Opcao(minúsculas) is true)
            opcoes += Minúsculas;

        if (Opcao(especiais) is true)
            opcoes += Especiais;

        return opcoes;
    }

    private static bool Opcao(string opcao)
        => opcao switch
        {
            "S" => true,
            "N" => false,
            _ => false,
        };
}