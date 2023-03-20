#include <stdio.h>

int main() {
    
    printf("Digite o numero");
    int x;
    scanf("%d",&x);
    //operador lógico '%' representa o resto de uma divisão. se um número divido por 2 não tem resto, significa que ele é par
    if(x%2==0)
    {
        printf("É par");
    }
    else
    {
        printf("é Ímpar");
    }
    return 0;
}