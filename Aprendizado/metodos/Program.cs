using System;

class program{
    int num1 = 10;
    int num2 = 12;
    static void Main(string[] args){
        //metodos normais
        program objeto1 = new program();
        objeto1.soma();
        objeto1.multi(1,2);
        //metodo estatico é acessado sem a necessidade de uma instancia da classe(objeto)
        sub(2,2);
    } 
    void soma(){
        int resultado = num1 + num2;
        Console.WriteLine(resultado);
    }
    void multi(int n1, int n2){
        int resultado = n1 * n2;
        Console.WriteLine(resultado);
        
    }
    static int sub(int n1, int n2){
        int resultado = n1 - n2;
        Console.WriteLine($"a subtração entre {n1} e {n2} foi de {resultado}");
        return resultado;
        
    }
}
