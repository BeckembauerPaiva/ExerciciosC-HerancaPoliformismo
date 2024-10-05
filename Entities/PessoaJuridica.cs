using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosC_.Entities
{
    internal class PessoaJuridica:Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string name,double renda,int numeroFuncionarios) : base(name, renda)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            if (NumeroFuncionarios >= 10)
            {
                return (Renda * 14) / 100;
            }
            else
            {
                return (Renda * 16) / 100;
            }
        }

    }
}
