﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {


        /// <summary>
        /// Chnage int[,] to int[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] ChangeArray2dimTo1dim(int[,] input)
        {
            int row = input.GetLength(0);
            int colmun = input.GetLength(1);

            int[] result = new int[row * colmun];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colmun; j++)
                {
                    result[i * colmun + j] = input[i, j];
                }
            }
            return result;
        }



        /// <summary>
        /// Chnage int[,,] to int[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] ChangeArray3dimTo1dim(int[,,] input)
        {
            int row = input.GetLength(0);
            int colmun = input.GetLength(1);
            int depth = input.GetLength(2);

            int[] result = new int[row * colmun*depth];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colmun; j++)
                {
                    for (int k = 0; k < depth; k++)
                    {
                        result[i * colmun * depth + j * depth + k] = input[i, j, k];
                    }
                }
            }
            return result;
        }



        /// <summary>
        /// Chnage int[,,] to int[]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] ChangeArray4dimTo1dim(int[,,,] input)
        {
            int row = input.GetLength(0);
            int colmun = input.GetLength(1);
            int depth = input.GetLength(2);
            int dim4 = input.GetLength(3);

            int[] result = new int[row * colmun*depth*dim4];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colmun; j++)
                {
                    for (int k = 0; k < depth; k++)
                    {
                        for (int l = 0; l < dim4; l++)
                        {
                            result[i * colmun * depth * dim4 + j * depth * dim4 + k * dim4 + l] = input[i, j, k, l];
                        }
                    }
                }
            }
            return result;
        }



        /// <summary>
        ///  Chnage int[] to int[,]
        /// </summary>
        /// <param name="input"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static int[,] ChangeArray1dimTo2dim(int[] input, int row, int column)
        {
            if (input.GetLength(0) != row * column)
            {
                throw new FormatException
                    ("Length of input array " + input.Length + " must be equal " +
                    " row " + row + " x " + " column " + column);
            }

            int[,] result = new int[row, column];

            int i = 0;
            foreach (int d in input)
            {
                result[i / column, i % column] = d;
                i++;
            }

            return result;
        }





        /// <summary>
        /// Chnage int[] to int[,,]
        /// </summary>
        /// <param name="input"></param>
        /// <param name="column"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static int[,,] ChangeArray1dimTo3dim(int[] input, int row, int column, int depth)
        {
            if (input.GetLength(0) != (row * column * depth))
            {
                throw new FormatException
                    ("Length of input array " + input.Length + " must be equal " +
                    " row " + row + " x column " + column + " x depth " + depth);
            }


            int[,,] result = new int[row, column, depth];

            int i = 0;
            foreach (int d in input)
            {
                result[i / (column * depth), (i % (column * depth)) / depth,
                    (i % (column * depth)) % depth] = d;
                i++;
            }

            return result;
        }



        /// <summary>
        /// Chnage int[] to int[,,,]
        /// </summary>
        /// <param name="input"></param>
        /// <param name="column"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static int[,,,] ChangeArray1dimTo4dim(int[] input, int row, int column, int depth, int dim4)
        {
            if (input.GetLength(0) != (row * column * depth * dim4))
            {
                throw new FormatException
                    ("Length of input array " + input.Length + " must be equal " +
                    " row " + row + " x column " + column + " x depth " + depth + " x dim4 " + dim4);
            }


            int[,,,] result = new int[row, column, depth, dim4];

            int i = 0;
            foreach (int d in input)
            {
                result[i / (column * depth * dim4), (i % (column * depth * dim4)) / (depth * dim4),
                    ((i % (column * depth * dim4)) % (depth * dim4)) / dim4, ((i % (column * depth * dim4)) % (depth * dim4)) % dim4] = d;
                i++;
            }

            return result;
        }





    }
}
