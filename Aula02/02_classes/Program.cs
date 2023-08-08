namespace _02_classes;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine(c);

        //-=-=-=-=-=- 
        //Acessando uma constante
        //Console.WriteLine(c.tipo); // Causou erro de compilação...
        Console.WriteLine(Cliente.tipo);

        //Acessando um método publico da classe Cliente
        c.saudacao();
        //Cliente.saudacao(); // Causou um erro de compilação

        //Acessando o método para manipulação do limite de crédito
        Console.WriteLine("O limite de crédito é " + c.consultaLimite());
        Console.WriteLine("Adicionando R$ 50,00 de limite ");
        c.AumentarLimite(50);
        Console.WriteLine("O limite de crédito é " + c.consultaLimite());

        //-=-=-=-=-=
        // Explorando método com parametro out
        int a=10;
        int b;

        //TRECHO NÃO FUNCIONA POIS A VARIAVEL B NÃO FOI INICIALIZADA
        /*
        Console.WriteLine("Antes da chamada do método com out");
        Console.WriteLine("  O valor de a é :" + a);
        c.MetodoNormal(a,b);
        Console.WriteLine("Depois da chamada do método com out");
        Console.WriteLine("  O valor de a é :" + a);
        Console.WriteLine("  O valor de b é :" + b);
        */

        Console.WriteLine("Antes da chamada do método com out");
        Console.WriteLine("  O valor de a é :" + a);
        c.MetodoOut1(a,out b);
        Console.WriteLine("Depois da chamada do método com out");
        Console.WriteLine("  O valor de a é :" + a);
        Console.WriteLine("  O valor de b é :" + b);

        Console.WriteLine("Antes da chamada do método com out");
        Console.WriteLine("  O valor de a é :" + a);
        c.MetodoOut1(a,out b);
        Console.WriteLine("Depois da chamada do método com out");
        Console.WriteLine("  O valor de a é :" + a);
        Console.WriteLine("  O valor de b é :" + b);

        Console.WriteLine("Antes da chamada do método com ref");
        Console.WriteLine("  O valor de a é :" + a);
        c.MetodoRef1(a,ref b);
        Console.WriteLine("Depois da chamada do método com ref");
        Console.WriteLine("  O valor de a é :" + a);
        Console.WriteLine("  O valor de b é :" + b);

        Console.WriteLine("Método com nro dinamico de parametros");
        Console.WriteLine("  Uma lista de fato");
        int [] minhaLista = new int[4] {1,2,3,4};
        c.MetodoParam(minhaLista);

        Console.WriteLine("  Chamada com N parametros");
        c.MetodoParam(5,6,7,8,9,10);

        //-=-=-=-=-=-=-
        //manipulação de propriedade
        Console.WriteLine("Manipulação de propriedades");
        Console.WriteLine("Nome do cliente é: "+c.PropriedadeNome);
        c.PropriedadeNome="Edson Moreno";
        Console.WriteLine("Nome do cliente é: "+c.PropriedadeNome);

        

        
    }
}
