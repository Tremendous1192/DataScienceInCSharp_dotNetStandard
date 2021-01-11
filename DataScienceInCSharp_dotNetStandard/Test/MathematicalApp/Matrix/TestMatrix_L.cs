using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestMatrix
    {
        public void TestL1Norm()
        {
            Console.WriteLine("L1の計算を行うメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double d = Matrix.L1Norm(A);
            Console.WriteLine(nameof(A) + "のL1ノルムは" + d);

        }

        public void TestL2Norm()
        {
            Console.WriteLine("L2の計算を行うメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double d = Matrix.L2Norm(A);
            Console.WriteLine(nameof(A) + "のL2ノルムは" + d);

        }

        public void TestLInfinityNorm()
        {
            Console.WriteLine("L∞の計算を行うメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double d = Matrix.LInfinityNorm(A);
            Console.WriteLine(nameof(A) + "のL∞ノルムは" + d);

        }

    }
}
