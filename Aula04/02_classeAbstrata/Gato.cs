public class Gato: Animal{
    public Gato(){
        Console.WriteLine("O construtor do gato");        
    }

    public override void emitirSom(){
        Console.WriteLine("miau");
    }
    
}