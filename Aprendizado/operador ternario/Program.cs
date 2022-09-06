using System;
class Program{
    static int n1 = 10;
    static int n2 = 20;
    static void Main(string [] args){
        //estrutura: condição ? se for verdade para nesse valor : se for falso para nesse valor
        var cond = n1>n2?"acertou":"errou";
        Console.Write(cond);
    }
}
