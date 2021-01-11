using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard
{
    public static partial class Matrix
    {

        /// <summary>
        /// 絶対値の和。Manhattan norm
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double L1Norm(double[,] matrix)
        {
            double norm = 0;
            foreach (double d in matrix)
            {
                norm += Math.Abs(d);
            }
            return norm;
        }

        /// <summary>
        /// 二乗和の平方根。Euclid norm
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double L2Norm(double[,] matrix)
        {
            double norm = 0;
            foreach (double d in matrix)
            {
                norm += d * d;
            }
            return Math.Sqrt(norm);
        }


        /// <summary>
        /// L∞ノルムを返す。
        /// 絶対値の最大値を返す.
        /// Returns the maximum absolute value .
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double LInfinityNorm(double[,] matrix)
        {
            double norm = 0.0;
            foreach (double d in matrix)
            {
                norm = norm < Math.Abs(d) ? Math.Abs(d) : norm;
            }
            return norm;
        }



    }
}
