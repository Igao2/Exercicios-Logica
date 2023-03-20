//Faça um programa que exiba um menu de opções com as operaçoes basicas da matematica, em seguida peça duas entradas ao usuario e realize a operaçao escolhida

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Bem vindo!");
        Console.WriteLine("Por favor escolha uma das opções a baixo:"
        +"\n 1-Soma"
        +"\n 2-Subtração"
        +"\n 3-Divisão"
        +"\n 4-Multiplicação");
        int escolha = int.Parse(Console.ReadLine());
        //switch case se aplica melhor a esse caso pois saõ muitas opções.
        switch(escolha)
        {
            case 1:
            //chamando a função correspondente
            soma();
            break;
            case 2:
            subtracao();
            break;
            case 3: 
            divisao();
            break;
            case 4:
            multiplicacao();
            break;
            
        }
        //
        void soma()
        {
            Console.WriteLine("Digite o primeiro número:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int x2 = int.Parse(Console.ReadLine());
            //A variável resultado não precisaria existir, mas coloquei por uma questão de melhora na compreensão do código e de boas práticas
            int resultado = x1+x2;
            Console.WriteLine("Resultado da soma: "+resultado);
        }
        void subtracao()
        {
            Console.WriteLine("Digite o valor do minuendo:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do subtraendo:");
            int x2 = int.Parse(Console.ReadLine());
            int resultado = x1-x2;
            Console.WriteLine("Resultado da subtração: "+resultado);
        }
        void divisao()
        {
            Console.WriteLine("Digite o valor do dividendo:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do divisor:");
            int x2 = int.Parse(Console.ReadLine());
            int resultado = x1/x2;
            Console.WriteLine("Resultado da divisão: "+resultado);
        }
        void multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int x2 = int.Parse(Console.ReadLine());
            int resultado = x1*x2;
            Console.WriteLine("Resultado da multiplicacao: "+resultado);
        }
        
    }