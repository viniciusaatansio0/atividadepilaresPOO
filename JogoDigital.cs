namespace exerHerancaPolimorfismo
{
    public class JogoDigital: Jogo
    {
        public string? TipoMidia { get; set; }

        public JogoDigital(string nome, string plataforma, string tipoMidia) : base(nome, plataforma)
        {
            TipoMidia = tipoMidia;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"o jogo {Nome}, está na plataforma {Plataforma}, do tipo {TipoMidia}");
        }
    }
}