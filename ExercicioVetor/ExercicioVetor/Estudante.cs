using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    internal class Estudante
    {
        private string _nome { get; set; } = String.Empty;
        private string _email { get; set; } = String.Empty;


        public Estudante(string nome, string email) {
            _nome = nome;
            _email = email;
        }
        public override string ToString()
        {
            return $"Nome: {_nome}, E-mail: {_email}";
        }

    }
}
