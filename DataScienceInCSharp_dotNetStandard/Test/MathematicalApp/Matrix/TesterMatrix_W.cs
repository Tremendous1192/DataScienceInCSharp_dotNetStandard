using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard
{
    public partial class TestMatrix
    {

        /// <summary>
        /// 行列の要素をコンソールに表示する。
        /// </summary>
        /// <param name="matrix"></param>
        public static void WriteLineMatrix(double[,] matrix, string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine(matrix[i, matrix.GetLength(1) - 1]);
            }
            Console.WriteLine(" ");
        }


    }
}
