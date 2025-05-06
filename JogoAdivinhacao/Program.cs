using System;

class JogoAdivinhacao
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Número entre 1 e 100
        int tentativa = 0;
        int chute;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

        do
        {
            Console.Write("Digite seu palpite: ");
            bool valido = int.TryParse(Console.ReadLine(), out chute);

            if (!valido || chute < 1 || chute > 100)
            {
                Console.WriteLine("Por favor, digite um número válido entre 1 e 100.");
                continue;
            }

            tentativa++;

            if (chute < numeroSecreto)
            {
                Console.WriteLine("O número secreto é MAIOR.");
            }
            else if (chute > numeroSecreto)
            {
                Console.WriteLine("O número secreto é MENOR.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou em {tentativa} tentativas.");
            }

        } while (chute != numeroSecreto);
    }
}

