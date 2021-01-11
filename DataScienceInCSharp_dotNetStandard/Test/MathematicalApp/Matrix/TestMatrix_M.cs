using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestMatrix
    {

        public void TestMultiply()
        {
            Console.WriteLine("行列の積を行うメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double[,] B = new double[2, 2];
            B[0, 0] = 1;
            B[0, 1] = 2;
            B[1, 0] = 3;
            B[1, 1] = 4;
            TestMatrix.WriteLineMatrix(B, nameof(B));


            double[,] C = Matrix.Multiply(A, B);
            TestMatrix.WriteLineMatrix(C, nameof(A) + nameof(B));

        }


        public void TestMultiplyByScalar()
        {
            Console.WriteLine("行列のスカラー積を行うメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double b = 10;

            double[,] C = Matrix.MultiplyByScalar(A, b);

            TestMatrix.WriteLineMatrix(C, nameof(b) + nameof(A));

        }


    }
}
