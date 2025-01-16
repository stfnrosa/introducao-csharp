using System.Globalization;

namespace HelloWorld;

class Program
{
    //tipo enum
    enum NivelDeDificuldade
    {
        Baixo,
        Medio,
        Alto
    }
    static void Main()
    {
        //TIPOS DE DADOS:

        int numero = 7;
        long numero2 = 7;
        uint numero3 = 7;

        //datas e horas

        DateOnly dia = new DateOnly(2000, 12, 10);

        string diaEmTexto = dia.ToString("D", new CultureInfo("pt-BR"));

        Console.WriteLine(diaEmTexto);

        //usando enum
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;

        Console.WriteLine(nivel);

        //COLEÇÕES:

        int[] inteiros = new int[10];

        inteiros[0] = 1;
        inteiros[1] = 10;
        inteiros[2] = 100;

        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros[1]);
        Console.WriteLine(inteiros[2]);
    }
}