public class Bicicleta: Veiculo, IAceleravel
{
   public Bicicleta(string marca, string modelo):base(marca,modelo)
   {

   }
   public void Acelerar()
   {
    Console.WriteLine($"A {Marca} e {Modelo} está pedalando mais rapido...."); 
    }

    public override void Ligar()
    {
        Console.WriteLine($"A {Marca}, e o {Modelo}, está pronto para o uso...");
    }
}