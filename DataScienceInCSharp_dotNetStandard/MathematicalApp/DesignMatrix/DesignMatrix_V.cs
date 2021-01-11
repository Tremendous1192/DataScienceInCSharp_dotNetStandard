using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public static partial class DesignMatrix
    {


        /// <summary>
        /// 相関係数の行列を得る
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static double[,] VarianceCovariance(double[,] designMatrix)
        {

            double[] sum = new double[designMatrix.GetLength(1)];
            for (int i = 0; i < designMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < designMatrix.GetLength(1); j++)
                {
                    sum[j] += designMatrix[i, j];
                }
            }


            double[,] sumMultiply = new double[designMatrix.GetLength(1), designMatrix.GetLength(1)];
            for (int i = 0; i < designMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < designMatrix.GetLength(1); j++)
                {
                    for (int j2 = j; j2 < designMatrix.GetLength(1); j2++)
                    {
                        sumMultiply[j, j2] += designMatrix[i, j] * designMatrix[i, j2];
                    }
                }
            }

            //共分散行列
            double[,] varianceCovarianceMatrix = new double[designMatrix.GetLength(1), designMatrix.GetLength(1)];
            for (int j = 0; j < designMatrix.GetLength(1); j++)
            {
                for (int j2 = j; j2 < designMatrix.GetLength(1); j2++)
                {
                    //varianceCovarianceMatrix[j, j2] = sumMultiply[j, j2] / designMatrix.GetLength(0) - sum[j] * sum[j2] / designMatrix.GetLength(0) / designMatrix.GetLength(0);
                    //丸め込み誤差対策
                    varianceCovarianceMatrix[j, j2] = (sumMultiply[j, j2] - sum[j] * sum[j2] / designMatrix.GetLength(0)) / designMatrix.GetLength(0);
                    varianceCovarianceMatrix[j2, j] = varianceCovarianceMatrix[j, j2];
                }
            }

            return varianceCovarianceMatrix;

        }



    }
}
