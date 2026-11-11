namespace exerHerancaPolimorfismo
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        

        public Ebook(string nome, int preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"nome: {Nome} - Preço: {Preco:C} - quantidade de Paginas:{QuantidadePaginas}");
        }
    }
}