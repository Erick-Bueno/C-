using System;

class Program{
    public static void Main(string[] args)
    {
        int[] num1 = new int[5];
        int[] num2 = new int[5];
        int[] num3 = new int[5];
        int[] num4 = new int[5];
        //adicionando numeros aleatorios no array
        Random random = new Random();
        for(int c = 0; c<num1.Length; c = c +1){
            num1[c] = random.Next(10);
            Console.WriteLine(num1[c]);
        }
        //BinarySearch(array,valor) : procura valor no array e retorna a posição dele caso seja encontrado;
        int pos = Array.BinarySearch(num1,5);
        Console.WriteLine(pos);
        
        //Array.Copy(array_origem, array_destino,quantidade): copiar os elementos de um array e adicionar em outro;
        int copia = Array.Copy(num1, num2,num1.Length);
        foreach (var item in num2)
        {
            Console.WriteLine(item);
        }
        //vetor.GetLowerBound(0) = retorna menor indice do array;
        int menor_index = num1.GetLowerBound(0);
        Console.WriteLine(menor_index);
        //vetor.GetUpperBound(0) = retorna maior indice do array;
        int maior_indice = num1.GetUpperBound(0);
        Console.WriteLine(maior_indice);
        //Array.indexOf(vetor,valor): retorna posição do primeiro valor encontrado no array passado;
        int posicao = Array.IndexOf(num1, 5);
        Console.WriteLine(posicao);
        //Array.reverse(vetor) : retorna o vetor invertido;
        Array.Reverse(num1);
        foreach (var item in num1)
        {   
            Console.WriteLine(item);
            
        }
        //Array.sort(vetor):ordena o vetor em ordem crescente
        Array.Sort(num1);
        foreach (var item in num1)
        {
            Console.WriteLine(item);
        }
    }
        
}
