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
        public static byte ReplaceNull(byte? input, byte replaced)
        {
            if (input != null) { return (byte)input; }
            return replaced;
        }


        /// <summary>
        /// Replace Null
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <returns></returns>
        public static byte[] ReplaceNull(byte?[] input, byte replaced)
        {
            byte[] result = new byte[input.GetLength(0)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (input[i] != null) { result[i] = (byte)input[i]; }
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
        public static byte[,] ReplaceNull(byte?[,] input, byte replaced)
        {
            byte[,] result = new byte[input.GetLength(0), input.GetLength(1)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] != null) { result[i, j] = (byte)input[i, j]; }
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
        public static byte[,,] ReplaceNull(byte?[,,] input, byte replaced)
        {
            byte[,,] result = new byte[input.GetLength(0), input.GetLength(1), input.GetLength(2)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        if (input[i, j, k] != null) { result[i, j, k] = (byte)input[i, j, k]; }
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
        public static byte[,,,] ReplaceNull(byte?[,,,] input, byte replaced)
        {
            byte[,,,] result = new byte[input.GetLength(0), input.GetLength(1), input.GetLength(2), input.GetLength(3)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int l = 0; l < input.GetLength(3); l++)
                        {
                            if (input[i, j, k, l] != null) { result[i, j, k, l] = (byte)input[i, j, k, l]; }
                            else { result[i, j, k, l] = replaced; }
                        }
                    }
                }
            }

            return result;
        }



    }
}
