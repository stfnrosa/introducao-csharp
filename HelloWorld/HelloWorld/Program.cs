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

        //Array
        int[] inteiros = new int[10];

        inteiros[0] = 1;
        inteiros[1] = 10;
        inteiros[2] = 100;

        Console.WriteLine("O número de itens no meu array é de: " + inteiros.Length);


        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros[1]);
        Console.WriteLine(inteiros[2]);

        //Lista
        List<int> listaInteiros = new List<int>();

        listaInteiros.Add(1);
        listaInteiros.Add(2);
        listaInteiros.Add(3);

        Console.WriteLine("O número de itens na minha lista é de: " + listaInteiros.Count);

        Console.WriteLine(listaInteiros[0]);
        Console.WriteLine(listaInteiros[1]);
        Console.WriteLine(listaInteiros[2]);

        listaInteiros.RemoveAt(0); //Remove um elemento indicando o index;

        Console.WriteLine(listaInteiros.Count);

        listaInteiros.Clear(); //Remove todos os elementos da lista;

        //Dicionario
        Dictionary<int, string> funcionario = new Dictionary<int, string>();

        funcionario.Add(22, "Maria");
        funcionario.Add(27, "Joanna");

        string valor = funcionario[22]; //Resgatando valores pela chave;

        Console.WriteLine(valor);

        bool existe = funcionario.ContainsKey(27); //Valida se a chave já existe;

        Console.WriteLine(existe);
    }
}