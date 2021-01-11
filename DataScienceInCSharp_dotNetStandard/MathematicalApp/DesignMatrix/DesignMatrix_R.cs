using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public static partial class DesignMatrix
    {


        /// <summary>
        /// 行ベクトルを取り出す.
        /// Get row vector
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static double[,] RowVector(double[,] designMatrix, int rowIndex)
        {
            if (rowIndex < 0)
            {
                throw new FormatException("row " + rowIndex + " must be equal or higer than 0 ");
            }
            else if (rowIndex >= designMatrix.GetLength(0))
            {
                throw new FormatException("row " + rowIndex + " must be less than " + nameof(designMatrix) + " row " + designMatrix.GetLength(0));
            }

            double[,] result = new double[1, designMatrix.GetLength(1)];
            for (int j = 0; j < designMatrix.GetLength(1); j++)
            {
                result[0, j] = designMatrix[rowIndex, j];
            }

            return result;
        }

    }
}
