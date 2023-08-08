public class Cliente
{

    public Cliente(){
        atributoNome="João Ninguém";
        limiteCredito=-1;
        clienteID=1;
    }

    public const string tipo = "Pessoa";
    private string atributoNome;
    public string PropriedadeNome{
        get{return atributoNome;}
        set{atributoNome=value;}
    }

    private decimal limiteCredito;
    private uint clienteID;    

    public decimal ConsultaLimite(){
        return limiteCredito;
    }

    public uint ConsultaClienteID(){
        return clienteID;
    }

}