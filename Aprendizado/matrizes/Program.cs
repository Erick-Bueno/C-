using System;

class Program{
    public static void Main(string[] args)
    {
        int[,] num = new int[2,2];
        num[0,0] = 2;
        num[1,0] = 2;
        num[0,1]=  2;
        num[1,0]=  2;
        
        Console.Write(num[0,0]);

    }
}
