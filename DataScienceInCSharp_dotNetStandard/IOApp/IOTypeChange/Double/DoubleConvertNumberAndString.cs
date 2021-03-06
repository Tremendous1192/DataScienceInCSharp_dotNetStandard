﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {

        /// <summary>
        /// Change double to string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string NumberToString(double input)
        {
            return input.ToString("G12");
        }



        /// <summary>
        /// Change double[] to string[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] NumberToString(double[] input)
        {

            string[] result = new string[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                result[i] = input[i].ToString("G12");
            }
            return result;
        }

        /// <summary>
        /// Change double[,] to string[,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,] NumberToString(double[,] input)
        {

            string[,] result = new string[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = input[i, j].ToString("G12");
                }

            }
            return result;
        }

        /// <summary>
        /// Change double[,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,] NumberToString(double[,,] input)
        {
            string[,,] result = new string[input.GetLength(0), input.GetLength(1), input.GetLength(2)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        result[i, j, k] = input[i, j, k].ToString("G12");
                    }
                }

            }
            return result;
        }


        /// <summary>
        /// Change double[,,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,,] NumberToString(double[,,,] input)
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
                            result[i, j, k, L] = input[i, j, k, L].ToString("G12");
                        }
                    }
                }
            }
            return result;
        }




    }
}
