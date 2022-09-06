using System;


public class Animal{
    public string cor;
    public string nome;

    public Animal(string nome, string cor){
        this.cor = cor;
        this.nome = nome;
    }
}




public class Jogadores{
    public string nome;
    public int vida;
    
    public Jogadores(string nome, int vida){
        this.nome = nome;
        this.vida = vida;
    }
}
class program{
    public static void Main(string[] args)
    {
        Animal a1 = new Animal("gersu","preto");
        Console.WriteLine($"o gato {a1.nome} tem a cor {a1.cor} ");
       
    }
}
