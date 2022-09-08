using System;

class Escrever{
    public virtual void frase(){
        Console.Write("escrevendo algo");
    }
}

class Lapis:Escrever{
    public override void frase(){
        Console.Write("escrevendo algo2");
    }
}
class Program{
    public static void Main(string[] args)
    {
        Lapis lapis = new Lapis();
        lapis.frase();
    }
}
