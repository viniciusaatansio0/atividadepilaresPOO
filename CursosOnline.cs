using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public class CursosOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursosOnline(string nome, int preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"nome: {Nome} - Preço: {Preco:C} - horas do curso: {CargaHoraria}");
        }
    }
}