using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {

        /// <summary>
        /// Change int to string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string NumberToString(int input)
        {
            return input.ToString();
        }



        /// <summary>
        /// Change int[] to string[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] NumberToString(int[] input)
        {
            string[] result = new string[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                result[i] = input[i].ToString();
            }
            return result;
        }


        /// <summary>
        /// Change int[,] to string[,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,] NumberToString(int[,] input)
        {
            string[,] result = new string[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = input[i, j].ToString();
                }

            }
            return result;
        }



        /// <summary>
        /// Change int[,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,] NumberToString(int[,,] input)
        {
            string[,,] result = new string[input.GetLength(0), input.GetLength(1), input.GetLength(2)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        result[i, j, k] = input[i, j, k].ToString();
                    }
                }

            }
            return result;
        }


        /// <summary>
        /// Change int[,,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,,] NumberToString(int[,,,] input)
        {
            string[,,,] result = new string[input.GetLength(0), input.GetLength(1), input.GetLength(2), input.GetLength(3)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int L = 0; L < input.GetLength(3); L++)
                        {
                            result[i, j, k, L] = input[i, j, k, L].ToString();
                        }
                    }
                }
            }
            return result;
        }





    }
}
