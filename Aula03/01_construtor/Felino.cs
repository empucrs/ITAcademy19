public class Felino: Animal
{
    private string raca;

    public Felino(string _raca):base("bichano",1970,20,10){
        raca=_raca;
        peso=5;
    }

    public override void EmiteSom(){
        Console.WriteLine("Ronronar");
    }

    public override string toString(){        
        return "-=-=-=-=\n"+base.toString()+"\nA raça do gato é:"+raca;
    }
}