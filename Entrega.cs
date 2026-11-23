namespace exerHerancaPolimorfismo
{
    public abstract class Entrega
    {
        public int Distancia { get; set; }
        public abstract double CalcularFrete();

    }
}