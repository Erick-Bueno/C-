using System;

class Program{
    public static void Main(string[] args)
    {
        //varrer todos os elementos de um Enum
        foreach (var item in Enum.GetValues(typeof(profissoes)))
        {
            Console.WriteLine(item);
        }
        //valor especifico do enum
        profissoes profs = (profissoes)0;
        Console.Write(profs);
    }
    enum profissoes{progamador,medico,dentista}
}
