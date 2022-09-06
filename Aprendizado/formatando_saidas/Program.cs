using System;

class program{
    static void Main(string[] args){
        int n1 = 1;
        int n2 = 2;
        int n3 = 3;
        double ValorCompra = 6.50;
        double ValorVenda = 0;
        double lucro = 0.1;
        string produto = "coxinha";
        ValorVenda = ValorCompra +(ValorCompra*lucro);
        Console.WriteLine(" Produto: {0,20}\n Lucro:{1,23:p}\n CompraValor:{2,17:c}\n CompraVenda: {3,16:c} ",produto, lucro, ValorCompra, ValorVenda);
        //{indice referente a variavel, espaço q vai ter entre o texto e o valor da variavel no texto:c = formatação para valor monetario, :p = formatação pra porcentagem}
    }
}
