using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestMatrix
    {
        public void TestHadamardMultiply()
        {

            Console.WriteLine("アダマール積を行うメソッドのテストです。");

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


            double[,] C = Matrix.HadamardMultiply(A, B);
            TestMatrix.WriteLineMatrix(C, nameof(A) + " ◦ " + nameof(B));

        }


        public void TestHadamardDivide()
        {
            Console.WriteLine("アダマール積風の除算を行うメソッドのテストです。");

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


            double[,] C = Matrix.HadamardDivide(A, B);
            TestMatrix.WriteLineMatrix(C, nameof(A) + "の各要素を" + nameof(B) + "の各要素で割った行列");



        }


    }
}
