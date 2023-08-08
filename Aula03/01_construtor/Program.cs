namespace _01_construtor;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine(c);

        Console.WriteLine("Nome do cliente: "+c.PropriedadeNome);
        Console.WriteLine("Limite do cliente: "+c.ConsultaLimite());
        Console.WriteLine("UID do cliente: "+c.ConsultaClienteID());

        //Exploração de sobrecarga
        Data d2 = new Data(8,8,2023);
        d2.print();

        Data d1=new();
        d1.print();

        d1=new(d2);
        d1.print();

        d1=new(8,10,"1976");
        d1.print();

        Data.imprimeAlgo();

        Data d3 = d1+d2; // operator+(d1,d2)
        Console.WriteLine("//-=-=-=-=-=-=-");
        Console.WriteLine("//D1");
        d1.print();
        Console.WriteLine("//D2");
        d2.print();
        Console.WriteLine("//D3");
        d3.print();

        d3 = d1 + 2;
        d3.print();


        //-=-=-=-=-=-=-
        Animal a = new();
        Console.WriteLine(a.toString());
        a.EmiteSom();
        //-=-=-=-=-=-=-
        Felino g = new Felino("Persa");
        Console.WriteLine(g.toString());
        g.EmiteSom();
        g.algumaCoisa();
    }
}
