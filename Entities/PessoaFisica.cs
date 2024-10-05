using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosC_.Entities
{
    internal class PessoaFisica:Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string name,double renda,double gastosSaude):base(name,renda) {
         GastosSaude = gastosSaude;
        }



        public override double Imposto()
        {
            if (Renda >= 20000.00 && GastosSaude == null)
            {
                return (Renda * 25) / 100;
            }
            else if (Renda >= 20000.00)
            {
                return ((Renda*25 )/ 100) - ((GastosSaude*50)/100);
            }
            else
            {
                return (Renda*15) / 100;
            }
        }
    }
}
