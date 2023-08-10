public class Cachorro: Animal
{
    public Cachorro(){
        Console.WriteLine("Construtor de um cachorro");        
    }
    
    public override void emitirSom(){
        Console.WriteLine("au au au");
    }
}