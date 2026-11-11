namespace exerHerancaPolimorfismo
{
    public class Veiculo
    {
        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($" a marca: {Marca} com o modelo: {Modelo}");
        }
    }
}