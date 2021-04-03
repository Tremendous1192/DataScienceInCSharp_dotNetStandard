using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public class SigmoidIVectorFunction : IVectorFunction
    {

        public double[,] Calculate_f_u(double[,] input)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = 1.0 / (1.0 + Math.Exp(-input[i, j]));
                }
            }

            return result;
        }

        public double[,] Calculate_f_u_dash(double[,] input)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];

            double denominator = 0;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    denominator = (1 + Math.Exp(-input[i, j])) * (1 + Math.Exp(-input[i, j]));
                    result[i, j] = Math.Exp(-input[i, j]) / denominator;
                }
            }

            return result;
        }



    }
}
