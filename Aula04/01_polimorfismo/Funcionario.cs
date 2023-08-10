public class Funcionario: Pessoa{

    public decimal salario{get;}
    private const decimal SALARIO_MINIMO = 1300.25M;

    public Funcionario(string nome, int idade, decimal valorDoSalario)
        :base(nome, idade)
    {
        this.salario=valorDoSalario;        
    }

    public Funcionario(decimal valorDoSalario):this("Joao Ninguem", -1, valorDoSalario){ }

    public override string? ToString(){
        string texto = base.ToString();
        texto += $"  Salário:  R$ {this.salario}\n";
        return texto;
    }

    public string satisfacaoSalarial(){
        Random r = new();
        if(r.Next()%10<3)
            return "insatisfeito";
        else
            return "satisfeito";
    }
    
}