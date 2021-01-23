using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {

        /// <summary>
        /// Replace Null
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <returns></returns>
        public static double ReplaceNull(double? input, double replaced)
        {
            if (input != null) { return (double)input; }
            return replaced;
        }


        /// <summary>
        /// Replace Null
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <returns></returns>
        public static double[] ReplaceNull(double?[] input, double replaced)
        {
            double[] result = new double[input.GetLength(0)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (input[i] != null) { result[i] = (double)input[i]; }
                else { result[i] = replaced; }
            }

            return result;
        }


        /// <summary>
        /// Replace Null
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <returns></returns>
        public static double[,] ReplaceNull(double?[,] input, double replaced)
        {
            double[,] result = new double[input.GetLength(0), input.GetLength(1)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] != null) { result[i, j] = (double)input[i, j]; }
                    else { result[i, j] = replaced; }
                }
            }

            return result;
        }


        /// <summary>
        /// Replace Null
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <returns></returns>
        public static double[,,] ReplaceNull(double?[,,] input, double replaced)
        {
            double[,,] result = new double[input.GetLength(0), input.GetLength(1), input.GetLength(2)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        if (input[i, j, k] != null) { result[i, j, k] = (double)input[i, j, k]; }
                        else { result[i, j, k] = replaced; }
                    }
                }
            }

            return result;
        }



        /// <summary>
        /// Replace Null
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <returns></returns>
        public static double[,,,] ReplaceNull(double?[,,,] input, double replaced)
        {
            double[,,,] result = new double[input.GetLength(0), input.GetLength(1), input.GetLength(2), input.GetLength(3)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int l = 0; l < input.GetLength(3); l++)
                        {
                            if (input[i, j, k, l] != null) { result[i, j, k, l] = (double)input[i, j, k, l]; }
                            else { result[i, j, k, l] = replaced; }
                        }
                    }
                }
            }

            return result;
        }


    }
}
