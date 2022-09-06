using System;

public class Animal{
    private string Nome;
    public string Cor;

    public string getNome(){
        return Nome;
    }
    public void setNome(string nome){
        Nome = nome;
    }
    public Animal(string nome, string cor){
        Cor = cor;
        Nome = nome;
    }

    public string falar(){
        return $"{Nome} falou";
    }
}
public class Gato:Animal{
    private string Tamanho;
    
    public string getTamanho(){
        return Tamanho;
    }
    public void setTamanho(string tamanho){
        Tamanho = tamanho;
    }
   public Gato(string tamanho, string nome, string cor) : base(nome, cor)
   {
    Tamanho = tamanho;
   }
}

public class Persa:Gato{
    public string Raça;

    public Persa(string raça, string tamanho, string nome, string cor):base(tamanho, nome, cor)
    {
        Raça = raça;
    }
}


class Program{
    public static void Main(string[] args)
    {
        
        Persa gerso = new Persa("persa", "alto", "gerso", "preto");
        Console.Write(gerso.getTamanho());
        

      
          
        
        
    }
}
