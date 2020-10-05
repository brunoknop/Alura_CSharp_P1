using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 4000.0;
        
        
        //SOLUÇÃO COM IF'S
        if (salario >= 0 && salario < 1900.0)
            Console.WriteLine("Você não precisa efetuar declaração");
        else if (salario >= 1900.0 && salario <= 2800.0)
            Console.WriteLine("o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
        else if (salario >= 2800.01 && salario <= 3751.0)
            Console.WriteLine("o IR é de 15% e pode deduzir R$ 350");
        else if (salario >= 3751.01 && salario <= 4664.00)
            Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636");
        else
            Console.WriteLine("O Salário é maior que R$ 4.664" + "\ne não possui insrtução para isso na alura," + "\nmas provavelmente você está lascado!");
    }
}