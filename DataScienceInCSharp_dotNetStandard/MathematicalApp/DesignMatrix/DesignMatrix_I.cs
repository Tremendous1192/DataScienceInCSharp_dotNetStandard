using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public static partial class DesignMatrix
    {


        /// <summary>
        /// 共分散行列の逆行列
        /// Calculate Inverse of the covariance matrix.
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static double[,] InverseVarianceCovarianceMatrix(double[,] designMatrix)
        {
            return Matrix.Inverse(DesignMatrix.VarianceCovariance(designMatrix));
        }


    }
}
