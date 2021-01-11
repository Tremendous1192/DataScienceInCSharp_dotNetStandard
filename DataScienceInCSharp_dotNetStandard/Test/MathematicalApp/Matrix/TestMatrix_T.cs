using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestMatrix
    {

        public void TestTrace()
        {
            Console.WriteLine("正方行列の跡を計算するメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 1;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));

            double d = Matrix.Trace(A);
            Console.WriteLine(nameof(A) + "の跡は" + d);
        }



        public void TestTranspose()
        {
            Console.WriteLine("行列の転置行列を返すメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] B = Matrix.Transpose(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "のの転置行列" + nameof(B));
        }

    }
}
