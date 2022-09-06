using System;

class Calculos{
    public int Valor1;
    public int Valor2;

    public Calculos(int valor1, int valor2){
       Valor1 = valor1;
       Valor2 = valor2;
    }
    public int soma(){
        return Valor1 + Valor2;
    }
}
class program{
    public static void Main(string[] args)
    {
        Calculos v1 = new Calculos(1,2);
        Console.Write(v1.soma());
    }
}
