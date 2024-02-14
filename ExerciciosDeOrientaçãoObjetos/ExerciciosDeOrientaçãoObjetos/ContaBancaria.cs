using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeOrientaçãoObjetos
{
    internal class ContaBancaria
    {
        ///atributos e auto properties
        private int _numeroConta { get; set; }
        private string _titular { get; set; } = string.Empty;

        private double _saldo { get; set; }
  

        //Construtor
        public ContaBancaria(int numeroConta, string titular, double saldo) {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldo;
        }

        //metodos
        public override string ToString()
        {
            return $"Conta: {_numeroConta}, Titular: {_titular}, Saldo: {_saldo}";
        }

        public void Depositar(double valor)
        {
            if (valor > 0) {
                _saldo += valor;
                Console.WriteLine("Dados da conta atulizado");
                Console.WriteLine(ToString());

            }
        
        }

        public void Saque(double valor)
        {
            if (valor > 0) {
                if (_saldo > valor)
                {
                    _saldo -= valor;
                    Console.WriteLine("Dados da conta atulizado");
                    Console.WriteLine(ToString());

                }
            }
            else
            {
                Console.WriteLine("Digite um valor maior que 0");
            }
           
         
        }






    }
}
