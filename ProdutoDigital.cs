namespace exerHerancaPolimorfismo
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }

        public int Preco { get; set; }

        public ProdutoDigital(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} - Preço: {Preco:C}");
        }
    }
}