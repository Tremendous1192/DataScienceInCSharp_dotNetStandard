using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{


    public static partial class Matrix
    {


        /// <summary>
        /// 同じ要素を持つインスタンスの生成.
        /// Creating instances with the same elements as input .
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double[,] Clone(double[,] matrix)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// 列ベクトルを取り出す.
        /// Get column vector.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="column_index"></param>
        /// <returns></returns>
        public static double[,] ColumnVector(double[,] matrix, uint column_index)
        {
            if (column_index >= matrix.GetLength(1))
            {
                throw new FormatException("column " + column_index + " must be less than matrix colmun " + matrix.GetLength(1));
            }

            double[,] result = new double[matrix.GetLength(0), 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result[i, 0] = matrix[i, column_index];
            }
            return result;
        }


    }



}
