public class Cliente
{
    public const string tipo = "Pessoa";
    private string atributoNome;
    public string PropriedadeNome{
        get{return atributoNome;}
        set{atributoNome=value;}
    }

    private decimal limiteCredito;
    private uint clienteID;    

    public void saudacao(){
        Console.WriteLine("Olá");
    }

    public void AumentarLimite(decimal valor){
        limiteCredito += valor;
    }

    public decimal consultaLimite(){
        return limiteCredito;
    }

    public void MetodoNormal(int a, int b){
        b = a*200;
    }
    public void MetodoOut1(int a, out int b){
        b = a*200;
    }
    public void MetodoRef1(int a, ref int b){
        b += a;
    }

    public void MetodoParam(params int [] listaDeParametros){
        for(int i=0; i<listaDeParametros.Length; i++)
          Console.WriteLine("  param["+i+"]: "+listaDeParametros[i]);
    }
}