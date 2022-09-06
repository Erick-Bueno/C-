using System;

class program{


    static void Main(string[] args){
        program s = new program();
        Console.WriteLine(s.soma(2,2));
        Console.WriteLine(s.frase());
    }
    int soma(int n1, int n2){
        int resultado = n1 + n2;
        return resultado;
    }
    string frase(){
        Console.Write("digite uma frase:");
        string fr = Console.ReadLine();
        return fr;
    }
}
