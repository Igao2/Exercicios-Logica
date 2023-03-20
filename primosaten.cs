//Faça um programa que exiba os numeros primos de 1 até o número digitado pelo usuário

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Valor do número");
        // variável de atribuição para o número
        int b = int.Parse(Console.ReadLine());
        for(int i = 1;i<=b;i++)
        {
            //  variável para contar quantas divisões o número foi capaz de realizar. números primos só são divisiveis por um ou por ele mesmo. Guardamos a posição do número com o i do for e testamos se ele é divisivel
           int contador = 0;
            for(int j = 1;j<=i;j++)
            {
                // o operador % serve para resultados do resto da divisão. quando o resto é 0, significa que o número é divisivel por tal número
                if(i%j==0)
                {
                    contador++;
                }
            }
                if(contador == 2)
                {
                    //se o número só for divisível 2 vezes(por ele mesmo e por um), significa que ele é primo. Então é impresso o valor
                    Console.WriteLine(i);
                }
            
        }
    }
}