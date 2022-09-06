using System;
class program{
    static void Main(string[] args){
        Console.Write("informe a sua altura:");
        float altura = float.Parse(Console.ReadLine());
        Console.Write("informe o seu peso:");
        float peso = float.Parse(Console.ReadLine());
        float imc = peso/(altura*altura)*10000;
        Console.WriteLine("seu imc é de {0}", imc.ToString("N2"));
        
    }
}
