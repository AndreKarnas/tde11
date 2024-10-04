public class Moto : Veiculo
{
    private bool TemBagageiro;

    public void DarGrau()
    {
        Console.WriteLine("Randandandandan");
    }
    public void ExibirInformacoes()
    {
         Console.WriteLine($"{Marca}, modelo da moto {Modelo}, Tem bagageiro? {TemBagageiro} o ano é {Ano}");
    }
    public Moto(string Marca, string Modelo, int Ano, bool Bagageiro) : base(Marca, Modelo, Ano)
{
    TemBagageiro = Bagageiro;
}
}