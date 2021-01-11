using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard;


namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard
{
    public partial class TestMatrix
    {

        public void TestSubMatrix()
        {
            Console.WriteLine("行列をコピーするメソッドのテストです。");

            double[,] A = new double[3, 3];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[0, 2] = 2;
            A[1, 0] = 3;
            A[1, 1] = 4;
            A[1, 2] = 5;
            A[2, 0] = 6;
            A[2, 1] = 7;
            A[2, 2] = 8;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] B = Matrix.SubMatrix(A, 1, 2, 2, 1);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "の(1,2)成分を起点に、2行1列を取り出した行列" + nameof(B));
        }


        public void TestSubtract()
        {

            Console.WriteLine("行列の減算を行うメソッドのテストです。");

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


            double[,] C = Matrix.Subtract(A, B);
            TestMatrix.WriteLineMatrix(C, nameof(A) + " - " + nameof(B));

        }


        public void TestSign()
        {

            Console.WriteLine("行列の各要素の符号を±1で表すメソッドのテストです。(ただし0.0は0を返す)");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = -2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] B = Matrix.Sign(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "の各要素の符号を±1で表した行列" + nameof(B));

        }


        public void TestSum()
        {
            Console.WriteLine("行列の各要素の和を返すメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double d = Matrix.Sum(A);
            Console.WriteLine(nameof(A) + "の行列の各要素の和は" + d);

        }


    }
}
