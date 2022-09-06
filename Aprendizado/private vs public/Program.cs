using System;

class Inimigo{
    private int Energia;
    private string Nome;

    public Inimigo(int energia, string nome){
        Energia = energia;
        Nome = nome;
    }

    public string getNome(){
        return Nome;
    }
    public  void  setNome(string nome){
        Nome = nome.ToUpper();
    }
}
class Jogador{
    public int Energia;
    public string Nome;

    public Jogador(int energia, string nome){
        Energia = energia;
        Nome = nome;
    }
}
class Program{
    public static void Main(string[] args)
    {
       Jogador player1 = new Jogador(100, "erick");
       Inimigo inimigo1 = new Inimigo(100, "alfredo");
       inimigo1.setNome("alfredo");
       Console.Write(inimigo1.getNome());
    }
}
