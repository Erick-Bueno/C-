using System;

class Program{
    public static void Main(string[] args)
    {   //pegando maior valor
        int valor_maximo = 0;    
        int[] numeros = new int[5]{10,5,100,50,1};
        List<int> numero2 = new List<int>();
        for(int c = 0; c < numeros.Length; c = c+1){
            if (numeros[c] > valor_maximo){
                valor_maximo = numeros[c];
            }
            
            
        }
        for(int i = 0; i < valor_maximo + 1; i = i +1){
            for(int d = 0; d < numeros.Length; d = d + 1){
                if(numeros[d] == i){
                    numero2.Add(i);
                    
                }
            }
        }foreach (var item in numero2)
            {
                Console.WriteLine(item);
            }
    }
}
