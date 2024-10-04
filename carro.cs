public class Carro : Veiculo
{
    private int numDePortas;

    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"{Marca}, modelo do carro {Modelo}, número de portas {numDePortas} ano é: {Ano}");
    }

    public Carro(string Marca, string Modelo, int Ano, int numDePortas) : base(Marca, Modelo, Ano)
    {
        this.numDePortas = numDePortas;
    }
}