using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }
        protected string Plataforma;

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"o jogo {Nome}, está na plataforma {Plataforma}");
        }

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        
    }
}