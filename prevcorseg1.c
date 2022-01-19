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
float h, x0, y0, y, yp, xfim,
      x, k1, k2, f0, f1, fp, erry;

 if ((outf = fopen("prevcor.dat", "w")) == NULL) 
   { 
   printf("\nProblemas na abertura do arquivo\n"); 
   } 
   
x0 = 0.0;
y0 = 1.0;

h = 0.1;

/* A variavel ERRY e' inicializada aqui mas seu   */
/* valor e' distituido de significado na primeira */
/* impressao */

erry = 0.0;

xfim = 3.0;

n = (int)((xfim - x0)/h);
   
x = x0;
y = y0;

fprintf(outf, "%e %e %e\n", x, y, erry);

for (i = 0; i < 1; i++) 
   {
   k1 = f(x, y);
   k2 = f(x + h, y + k1 * h);
   
   y = y + (h/2.0) * (k1 + k2);
  
   x = x + h;

   fprintf(outf, "%e %e %e\n", x, y, erry);
   }

for (i = 0; i < n; i++)
   {
   f1 = f(x, y);
   yp =  y + (h/2.0) * (3.0 * f1 - f0);

   x = x + h;
   
   fp = f(x, yp);

   y = y + (h/2.0) * (fp + f1);

   f0 = f1;

   erry = (yp - y)/6.0;

   fprintf(outf, "%e %e %e\n", x, y, erry);
   }

}
