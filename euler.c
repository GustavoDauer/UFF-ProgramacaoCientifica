#include <stdio.h>
#include <stdlib.h>
#include <math.h>

float f(float x, float y)
   {
   return(y);	   
   }

int main(void)
{
FILE *outf;

int i, j, n;
float h, x0, y0, y, xfim,
      x, k1;

 if ((outf = fopen("eulerexplicito.dat", "w")) == NULL) 
   { 
   printf("\nProblemas na abertura do arquivo\n"); 
   } 
   
x0 = 0.0;
y0 = 1.0;

h = 0.1;

xfim = 3.0;

n = (int)((xfim - x0)/h);
   
x = x0;
y = y0;

fprintf(outf, "%e %e\n", x, y);

for (i = 0; i < n; i++) 
   {
   k1 = f(x, y);
   
   y = y + h * k1;
  
   x = x + h;

   fprintf(outf, "%e %e\n", x, y);
   }
}
