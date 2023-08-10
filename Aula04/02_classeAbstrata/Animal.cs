public abstract class Animal{
    public decimal peso;
    public decimal altura;

    public Animal(){
        this.peso=-1;
        this.altura=-1;
        Console.WriteLine("Construtora da classe Animal");
    }

    public override string? ToString(){
        return $"peso({this.peso}); altura({this.altura})";
    }

    public abstract void emitirSom();
    
}