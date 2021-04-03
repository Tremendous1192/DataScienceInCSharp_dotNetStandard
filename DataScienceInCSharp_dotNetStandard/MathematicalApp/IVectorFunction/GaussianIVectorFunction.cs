using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public class GaussianIVectorFunction : IVectorFunction
    {


        public double[,] Calculate_f_u(double[,] input)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];

            double denominator = Math.Sqrt(2 * Math.PI);

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = Math.Exp(-input[i, j] * input[i, j] / 2) / denominator;
                }
            }

            return result;
        }

        public double[,] Calculate_f_u_dash(double[,] input)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];

            double denominator = Math.Sqrt(2 * Math.PI);

            for (int j = 0; j < input.GetLength(0); j++)
            {
                for (int k = 0; k < input.GetLength(1); k++)
                {
                    result[j, k] = -input[j, k] * Math.Exp(-input[j, k] * input[j, k] / 2) / denominator;
                }
            }

            return result;
        }




    }
}
