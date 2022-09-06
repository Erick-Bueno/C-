using System;
class Program{
    static int moedas = 50;
    static int preço_perso = 50;
    static void Main(string[] args){
        if(preço_perso > moedas){
            Console.Write("voce não pode comprar o personagem");
        }else if(preço_perso< moedas){
            Console.Write("voce pode comprar o personagem");
        }else{
            Console.Write("voce perdera todas as suas moedas tem crtz disso?");
            string resposta = Console.ReadLine();
            if(resposta == "sim"){
                Console.WriteLine("ok personagem adiquirido");
            }else{
                Console.WriteLine("ok saindo da loja...");
            }
        }
    }
}
