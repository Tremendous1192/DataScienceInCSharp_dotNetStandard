using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard;


namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard
{
    public partial class TestMatrix
    {
        public void TestClone()
        {
            Console.WriteLine("行列をコピーするメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] B = Matrix.Clone(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "の各要素をコピーした行列" + nameof(B));
        }



        public void TestColumnVector()
        {
            Console.WriteLine("行列から列ベクトルを取り出すメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] b = Matrix.ColumnVector(A, 1);
            TestMatrix.WriteLineMatrix(b, nameof(A) + "の第1列を取り出した列ベクトル" + nameof(b));

        }

    }
}
