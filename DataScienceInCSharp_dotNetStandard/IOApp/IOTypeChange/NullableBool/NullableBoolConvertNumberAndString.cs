using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {


        /// <summary>
        /// Change string to bool
        /// </summary>random
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool? StringToNullableBool(string input)
        {
            bool parsed;
            if (bool.TryParse(input, out parsed)) { return (bool?)parsed; }
            return null;
        }

        /// <summary>
        /// Change bool? to string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string BoolToString(bool? input)
        {
            return input.ToString();
        }


        /// <summary>
        /// Change string[] to bool[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool?[] StringToNullableBool(string[] input)
        {
            bool?[] result = new bool?[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                result[i] = bool.TryParse(input[i], out bool num) ? (bool?)num : null;
            }
            return result;
        }

        /// <summary>
        /// Change bool?[] to string[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] BoolToString(bool?[] input)
        {

            string[] result = new string[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                result[i] = input[i].ToString();
            }
            return result;
        }



        /// <summary>
        /// Change string[,] to bool[,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool?[,] StringToNullableBool(string[,] input)
        {
            bool?[,] result = new bool?[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = bool.TryParse(input[i, j], out bool num) ? (bool?)num : null;
                }

            }
            return result;
        }

        /// <summary>
        /// Change bool?[,] to string[,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,] BoolToString(bool?[,] input)
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
        /// Change string[,,] to bool?[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool?[,,] StringToNullableBool(string[,,] input)
        {
            bool?[,,] result = new bool?[input.GetLength(0), input.GetLength(1), input.GetLength(2)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        result[i, j, k] = bool.TryParse(input[i, j, k], out bool num) ? (bool?)num : null;
                    }

                }

            }
            return result;
        }


        /// <summary>
        /// Change bool?[,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,] BoolToString(bool?[,,] input)
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
        /// Change string[,,,] to bool?[,,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool?[,,,] StringToNullableBool(string[,,,] input)
        {
            bool?[,,,] result = new bool?[input.GetLength(0), input.GetLength(1), input.GetLength(2), input.GetLength(3)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int m = 0; m < input.GetLength(3); m++)
                        {
                            result[i, j, k, m] = bool.TryParse(input[i, j, k, m], out bool num) ? (bool?)num : null;
                        }
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// Change bool?[,,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,,] BoolToString(bool?[,,,] input)
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
