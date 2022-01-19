using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2PC
{
    class MetodoExplicito
    {
        private int constanteK;
        private double deltaT;
        private double deltaX;
        private double tamanhoBarra;
        private double ro;
        private double r;
        private double constantek;
        public double[,] U { get; set; } //matriz dos Us
        private double gama;
        private double C; 

         




        public MetodoExplicito(double deltaT, double deltaX, double tamanhoBarra, double ro, double r, double constantek, double tInferior, double tSuperior, double xInferior, double xSuperior, double C)
        {
            this.constantek = constantek;
            this.deltaT = deltaT;
            this.deltaX = deltaX;
            this.tamanhoBarra = tamanhoBarra;
            this.ro = ro;
            this.r = r;
            this.C = C;

            this.gama = calculaGama(deltaX,deltaT,constantek);

            int tempoDiscretizacao = (int)((tSuperior-tInferior)/deltaT);
            int espacoDiscretizacao = (int)((xSuperior-xInferior)/deltaX);
            U = new double[tempoDiscretizacao,espacoDiscretizacao];
            
        }

        public void calculaExplicito() {
            for (int t = 0; t < U.GetLength(0); t++) {

                if (t * deltaT == 0)
                {
                    for (int i = 0; i < U.GetLength(1); i++)
                    {
                        U[t, i] = Math.Sin(Math.PI * i * deltaX) / tamanhoBarra;
                        Console.Write(U[t, i]);
                        Console.Write("\t");
                    }
                }
                else {

                    for (int i = 0; i < U.GetLength(1); i++) {
                        if ( (i * deltaX >= tamanhoBarra || i * deltaX <= 0) && t*deltaT != 0)
                        {
                            U[t, i] = 0;
                            Console.Write(U[t, i]);
                            Console.Write("\t");
                        }                      

                        else {
                            U[t, i] = calculaProximoComValorAtual(t-1,i);
                            Console.Write(U[t, i]);
                            Console.Write("\t");
                        }
                    }                
                }
                Console.WriteLine("\n");
            }             

            
        }


        private double calculaProximoComValorAtual(int k, int i)
        {
            double gama = calculaGama(deltaX, deltaT, constanteK);

            double proximopasso;
            double nextstep = (i + 1)*deltaX;
                if ((nextstep >= tamanhoBarra) )
                {
                    proximopasso = 0;                    
                }                
                else {
                    proximopasso = U[k, i + 1];
                }

                
            
            return (1 - 2 * gama) * U[k,i] + gama * U[k,i - 1] + gama * proximopasso + (deltaT * r) / (ro * C);


        }

        private double calculaGama(double deltaX, double deltaT, double k)
        {
            return k * Math.Pow(deltaX, 2) / Math.Pow(deltaT, 2);
        }

        

    }
}
