#include <stdio.h>
#include <stdlib.h>
#include <math.h>

float f(float x, float y);

/* Programa comparativo dos metodos de Euler, Heun e Runge-Kutta de quarta ordem "Classico" */
/* para quatro funcoes. Cada uma expõe questoes referentes a estes metodos, mostrando suas  */
/* caracteristicas e problemas de estabilidade condicional.                                 */
/* Este programa esta escrito de forma a facilitar a identificacao dos algoritmos e nao se  */
/* encontra otimizado.                                                                      */

int main()
{
int i, n;

float h, x0, y0, xfim, x, y;

float k1euler,
      k1heun, k2heun,
      k1rk4, k2rk4, k3rk4, k4rk4;

float yeuler, yheun, yrk4;

/* Condicao inicial */
x0 = 0.0;
y0 = 1.0;

/* Deixe sem comentario os parametros de interesse para cada funcao */

h = 0.5;                           /* Valor de h para a funcao f(x,y) = y */
/* h = 0.25; */                    /* Valor de h para a funcao f(x,y) = sin(x) * y */
/* h = 0.2; 0.1; 0.4, 0.3, 0.2 */  /* Valores de h para a funcao f(x,y) = -10 * y e f(x,y) = 2 - 5 * y */

/* Deixe sem comentario os parametros de interesse para cada funcao */

xfim = 5.0;           /* Valor final de x para a funcao f(x,y) = y */
/* xfim = 12.0; */    /* Valor final de x para a funcao f(x,y) = sin(x) * y */
/* xfim = 1.5; */     /* Valor final de x para a funcao f(x,y) = -10 * y */
/* xfim = 3.0;  */    /* Valor final de x para a funcao f(x,y) = 2 -5 * y */

n = (xfim - x0)/h;

/* Inicializacao das variaveis */
x = x0;
yeuler = y0;
yheun  = y0;
yrk4   = y0;

printf("%f %f %f %f\n", x, yeuler, yheun, yrk4);

for (i = 0; i < n; i++) 
    {
    k1euler = f(x, yeuler);
    k1heun  = f(x, yheun);
    k2rk4   = f(x, yrk4);

    k2heun  = f(x + h, yheun + h * k1heun);
    k2rk4   = f(x + h/2.0, yheun + (h/2.0) * k2rk4);

    k3rk4   = f(x + h/2.0, yrk4 + (h/2.0) * k2rk4);
    k4rk4   = f(x + h, yrk4 + h * k3rk4);

    yeuler  = yeuler + h * k1euler;

    yheun   = yheun + (h/2.0) * (k1heun + k2heun);

    yrk4    = yrk4 + (h/6.0) * (k2rk4 + 2.0 * k2rk4 + 2.0 * k3rk4 + k4rk4);

    x = x + h;

    printf("%f %f %f %f\n", x, yeuler, yheun, yrk4);
    }
}

/* Funcoes usadas no programa. Para fazer um teste mude o nome da funcao desejada para f */

float f(float x, float y)
    {
    return(y);
    }

float f1(float x, float y)
    {
    return(sin(x)* y);
    }

float f2(float x, float y)
    {
    return(- 10.0 * y);
    }

float f3(float x, float y)
    {
    return(2 - 5.0 * y);
    }
