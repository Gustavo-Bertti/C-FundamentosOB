using ExercicioVetor;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudante[] quartos = new Estudante[9];

        for (int i = 0; i < quartos.Length; i++)
        {
            Console.WriteLine("Digite qual numero de quarto você vai querer(temos 10): ");
            int? numeroDoQuarto = int.Parse(Console.ReadLine());
   
             int numeroEscolhido = numeroDoQuarto - 1 ?? i;
            if (quartos[numeroEscolhido] == null) { 
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite seu e-mail: ");
                string email = Console.ReadLine();

                quartos[numeroEscolhido] = new Estudante(nome, email);
            }
            else
            {
                Console.WriteLine($"O quarto {numeroEscolhido+1} já foi alugado, você vai ficar com o {numeroEscolhido + 1}");
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite seu e-mail: ");
                string email = Console.ReadLine();

                quartos[numeroEscolhido+1] = new Estudante(nome, email);
            }
            

            Console.WriteLine("deseja alugar para mais alguem?digite s ou n");
            string contnue = Console.ReadLine();
            if (contnue == "n")
                i = 11;
        }
        Console.WriteLine("Exibindo quartos alugados: ");
        for (int i = 0; i < quartos.Length; i++)
        {
            if (quartos[i] == null)
                Console.WriteLine($"{i + 1} -- Quarto não alugado");

            else
                Console.WriteLine(quartos[i]);
          
        }
    }
}