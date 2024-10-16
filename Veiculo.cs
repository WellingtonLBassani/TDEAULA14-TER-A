public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public abstract void Ligar();
    public void Desligado()
    {
        Console.WriteLine("O veiculo está desligado...");
    }
    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}