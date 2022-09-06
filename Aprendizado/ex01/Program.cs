using System;

class Program{
    static void Main(string[] args){
        Program ipn = new Program();
        Console.Write(ipn.IPN(5));
    }
    string IPN(int num){
        string impar = "impar";
        string par = "par";
        string nulo = "Null";
        if(num%2 == 0){
            return par;
        }
        else if(num%2 == 1){
            return impar;
        }
        else{
            return nulo;
        }
    }
}
