namespace TiposDeDados;
class Carro
{
    public required string Modelo { get; set; }
    public DateOnly DataLancamento { get; set; }
    public Cor Cor { get; set; }

    public Carro(Cor cor)
    {
        Cor = cor; 
    }

    public Carro()
    {
    }

    public void NomeDoModelo() => Console.WriteLine(Modelo);
}
