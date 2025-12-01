using System;
class Program
{
    static void Main(string[] args)
    {
        bool jogarNovamente = true;
        string[] opcoes = { "pedra", "papel", "tesoura" };
        Random random = new Random();


        while (jogarNovamente)
        {
            Console.WriteLine("Pedra, Papel e Tesoura");
            Console.Write("Escolha (pedra/papel/tesoura): ");
            string escolhaUsuario = Console.ReadLine().ToLower();


            if (!Array.Exists(opcoes, x => x == escolhaUsuario))
            {
                Console.WriteLine("Opção inválida!\n");
                continue;
            }


            int escolhaPCIndex = random.Next(0, 3);
            string escolhaPC = opcoes[escolhaPCIndex];


            Console.WriteLine($"Computador escolheu: {escolhaPC}");


            if (escolhaUsuario == escolhaPC)
            {
                Console.WriteLine("Empate!");
            }
            else if (
            (escolhaUsuario == "pedra" && escolhaPC == "tesoura") ||
            (escolhaUsuario == "papel" && escolhaPC == "pedra") ||
            (escolhaUsuario == "tesoura" && escolhaPC == "papel")
            )
            {
                Console.WriteLine("Você venceu!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }


            Console.Write("\nDeseja jogar novamente? (s/n): ");
            string resposta = Console.ReadLine().ToLower();
            jogarNovamente = resposta == "s";


            Console.Clear();
        }


        Console.WriteLine("Obrigado por jogar! Até mais!");
    }
}