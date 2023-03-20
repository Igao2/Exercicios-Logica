//Faca um programa que receba dois valores do usuario e exiba apenas o maior na tela//

import java.util.Scanner;
public class maior {
	
public static void main(String [] args) {	
	int maior = 0;
	//Declaracao de variaveis
	int arrayvalores[] = 
	{
	    0,0
	};
	System.out.printf("Digite o primeiro valor");
	Scanner s = new Scanner(System.in);
	//vetores sempre comecam na posicao 0!
	arrayvalores[0]=s.nextInt();
	System.out.printf("Digite o segundo valor");
	arrayvalores[1]=s.nextInt();
	
	for(int i = 0; i<arrayvalores.length;i++)
	{
	 //estrutura condicional que vai verificar em cada posicao do array se ele e maior que a posicao anterior   
	    if(arrayvalores[i]>maior)
	    {
	        maior = arrayvalores[i];
	    }
	}
	 
		System.out.printf("Maior = %d\n",maior);
		
	 }
	}