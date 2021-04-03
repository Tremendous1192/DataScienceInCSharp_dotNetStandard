using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public class SoftMaxIVectorFunction : IVectorFunction
    {

        public double[,] Calculate_f_u(double[,] input)
        {

            double max = double.MinValue;
            foreach (double d in input)
            {
                max = Math.Max(max, d);
            }


            double[,] exponents = new double[input.GetLength(0), input.GetLength(1)];
            double exp = 1.0;
            double sum = 0;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    exp = Math.Exp(input[i, j] - max);
                    exponents[i, j] = exp;
                    sum += exp;
                }
            }


            double[,] result = new double[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = exponents[i, j] / sum;
                }
            }

            return result;
        }

        public double[,] Calculate_f_u_dash(double[,] input)
        {

            double max = double.MinValue;
            foreach (double d in input)
            {
                max = Math.Max(max, d);
            }

            double[,] exponents = new double[input.GetLength(0), input.GetLength(1)];
            double exp = 1.0;
            double sum = 0;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    exp = Math.Exp(input[i, j] - max);
                    exponents[i, j] = exp;
                    sum += exp;
                }
            }

            double[,] result = new double[input.GetLength(0), input.GetLength(1)];
            double denominator = sum * sum;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = exponents[i, j] * (sum - exponents[i, j]) / denominator;
                }
            }
            return result;
        }


    }
}
