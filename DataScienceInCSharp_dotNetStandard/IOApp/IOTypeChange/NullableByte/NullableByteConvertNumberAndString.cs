﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {
        /// <summary>
        /// Change string to byte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte? StringToNullableByte(string input)
        {
            byte parsed;
            if (byte.TryParse(input, out parsed)) { return (byte?)parsed; }
            return null;
        }

        /// <summary>
        /// Change byte? to string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string NumberToString(byte? input)
        {
            return input.ToString();
        }

        /// <summary>
        /// Change string[] to byte[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte?[] StringToNullableByte(string[] input)
        {
            byte?[] result = new byte?[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                result[i] = byte.TryParse(input[i], out byte num) ? (byte?)num : null;
            }
            return result;
        }

        /// <summary>
        /// Change byte?[] to string[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] NumberToString(byte?[] input)
        {
            string[] result = new string[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                result[i] = input[i].ToString();
            }
            return result;
        }


        /// <summary>
        /// Change string[,] to byte[,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte?[,] StringToNullableByte(string[,] input)
        {
            byte?[,] result = new byte?[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    result[i, j] = byte.TryParse(input[i, j], out byte num) ? (byte?)num : null;
                }

            }
            return result;
        }

        /// <summary>
        /// Change byte?[,] to string[,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,] NumberToString(byte?[,] input)
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
        /// Change string[,,] to byte?[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte?[,,] StringToNullableByte(string[,,] input)
        {
            byte?[,,] result = new byte?[input.GetLength(0), input.GetLength(1), input.GetLength(2)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        result[i, j, k] = byte.TryParse(input[i, j, k], out byte num) ? (byte?)num : null;
                    }

                }

            }
            return result;
        }


        /// <summary>
        /// Change byte?[,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,] NumberToString(byte?[,,] input)
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
        /// Change string[,,,] to byte?[,,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte?[,,,] StringToNullableByte(string[,,,] input)
        {
            byte?[,,,] result = new byte?[input.GetLength(0), input.GetLength(1), input.GetLength(2), input.GetLength(3)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int m = 0; m < input.GetLength(3); m++)
                        {
                            result[i, j, k, m] = byte.TryParse(input[i, j, k, m], out byte num) ? (byte?)num : null;
                        }
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// Change byte?[,,,] to string[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,,,] NumberToString(byte?[,,,] input)
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
