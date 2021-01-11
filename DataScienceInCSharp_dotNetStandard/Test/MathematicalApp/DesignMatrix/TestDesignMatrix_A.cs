using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestDesignMatrix
    {
        public void TestAverage()
        {
            Console.WriteLine("計画行列の平均ベクトル(行ベクトル)を返すメソッドのテストです。");

            double[,] A = new double[3, 2];
            A[0, 0] = 0;
            A[0, 1] = 2;
            A[1, 0] = 1;
            A[1, 1] = 4;
            A[2, 0] = 2;
            A[2, 1] = 6;
            TestMatrix.WriteLineMatrix(A, "計画行列"+nameof(A));


            double[,] B = DesignMatrix.Average(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "の平均ベクトル" + nameof(B));
        }


    }
}
