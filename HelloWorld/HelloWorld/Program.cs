using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        int numero = 7;
        long numero2 = 7;
        uint numero3 = 7;

        //datas e horas

        DateOnly dia = new DateOnly(2000, 12, 10);

        string diaEmTexto = dia.ToString("D", new CultureInfo("pt-BR"));

        Console.WriteLine(diaEmTexto);
    }
}