using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public class HyperbolicTangentIVectorFunction : IVectorFunction
    {


        public double[,] Calculate_f_u(double[,] input)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = Math.Tanh(input[i, j]);
                }
            }
            return result;
        }

        public double[,] Calculate_f_u_dash(double[,] input)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];
            double denominator = 1.0;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    //result[j, k] = 1.0 / Math.Cosh(input[j, k]) / Math.Cosh(input[j, k]);
                    denominator = Math.Cosh(input[i, j]) * Math.Cosh(input[i, j]);
                    result[i, j] = 1.0 / denominator;
                }
            }
            return result;
        }



    }
}
