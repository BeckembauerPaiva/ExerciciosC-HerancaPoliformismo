using ExerciciosC_.Entities;
using System;
using System.Globalization;

namespace ExercicioHerancaPoliformisnoAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de pessoas a pagar:");

            int N = int.Parse(Console.ReadLine());
            List<Pessoa> Lista = new List<Pessoa>();

            for (int i = 1; i < N; i++)
            {
                Console.Write("Pessoa Fisica ou Juridica(f/j):");
                char Resposta = Char.Parse(Console.ReadLine());
                if (Resposta == 'f')
                {
                    Console.Write("Nome: ");
                    string Name = Console.ReadLine();
                    Console.Write("Renda: ");
                    double Renda = Double.Parse(Console.ReadLine());
                    Console.Write("Gastos médicos: ");
                    double GastosMedicos = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Lista.Add(new PessoaFisica(Name, Renda, GastosMedicos)); 
                }
                else if (Resposta == 'j')
                {
                    Console.Write("Nome: ");
                    string Name = Console.ReadLine();
                    Console.Write("Renda: ");
                    double Renda = Double.Parse(Console.ReadLine());
                    Console.Write("Numero de funcionarios: ");
                    int NumeroDeFuncionarios = int.Parse(Console.ReadLine());
                    Lista.Add(new PessoaJuridica(Name,Renda, NumeroDeFuncionarios));

                }


            }

            double Soma = 0;

            foreach(Pessoa Obj in Lista)
            {
                Soma += Obj.Imposto();

            }
            foreach (Pessoa pessoa in Lista) {
                Console.WriteLine(pessoa.Name + ": $ "+ pessoa.Imposto().ToString("F2",CultureInfo.InvariantCulture));
            
             
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL ARRECADADO; "+ Soma.ToString("F2",CultureInfo.InvariantCulture));

            

        }
    }
}