using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosC_.Entities
{
    internal abstract class Pessoa
    {
        public string Name { get; set; }
        public double Renda { get; set; }

        public Pessoa(string name,double renda) {
            Name = name;
            Renda = renda;
        
        }

        public abstract double Imposto();
    }
}
