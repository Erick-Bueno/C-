using System;

class program{
  
    static void Main(string[] args){
        program calculo = new program();
        calculo.calcular_vida(40,10,100);
    }
    int calcular_vida(int vida_atual,int atack_enemy, int vida_player){
           int resultado = (vida_player-vida_atual)/atack_enemy;
           Console.Write($"voce recebeu {resultado} ataques");
           return resultado;
    
            
    }
}
