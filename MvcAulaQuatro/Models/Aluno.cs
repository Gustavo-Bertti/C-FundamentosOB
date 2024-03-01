namespace _2TDSB.Models
{
    public class Aluno : Usuario
    {
        public int Id { get; set; }

        private string Name { get; set; }

        public int Rm { get; set; }

        public void DefinirNome(string nome)
        {

            if (nome.Length< 3)
            {
                Console.WriteLine($"O nome {nome} devera ter mais do que 3 carac");
            }

            Name = nome;
        }

        public string RecuperarNome()
        {
            return Name;
        }
    }
}
