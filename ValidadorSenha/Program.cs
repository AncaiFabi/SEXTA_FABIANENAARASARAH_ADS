using System;
using System.Text.RegularExpressions;

class ValidadorSenha
{
    static void Main()
    {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        if (ValidarSenha(senha))
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha fraca. A senha deve conter no mínimo:");
            Console.WriteLine("- 8 caracteres");
            Console.WriteLine("- 1 letra maiúscula");
            Console.WriteLine("- 1 número");
            Console.WriteLine("- 1 caractere especial (ex: !, @, #)");
        }
    }

    static bool ValidarSenha(string senha)
    {
        if (senha.Length < 8)
            return false;

        bool temMaiuscula = false;
        bool temNumero = false;
        bool temEspecial = false;

        foreach (char c in senha)
        {
            if (char.IsUpper(c))
                temMaiuscula = true;
            else if (char.IsDigit(c))
                temNumero = true;
            else if (!char.IsLetterOrDigit(c))
                temEspecial = true;
        }

        return temMaiuscula && temNumero && temEspecial;
    }
}

