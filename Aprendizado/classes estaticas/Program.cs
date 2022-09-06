using System;

static public class Player{
        static public string nome = "erick";
        static public string falar(){
        return $"meu {nome} é erick";
        
    }
}
class Program{
    public static void Main(string[] args)
    {
        Console.Write(Player.falar());
    }
}
