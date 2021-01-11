using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestMatrix
    {


        public void TestZeroMatrix()
        {
            Console.WriteLine("零行列を作成するメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] B = Matrix.ZeroMatrix(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "と同じ行列数の零行列" + nameof(B));


            double[,] C = Matrix.ZeroMatrix(3, 5);
            TestMatrix.WriteLineMatrix(C, "3行5列の零行列" + nameof(C));


        }

    }
}
