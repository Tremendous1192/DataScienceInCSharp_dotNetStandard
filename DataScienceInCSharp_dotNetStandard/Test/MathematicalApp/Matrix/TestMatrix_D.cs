using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestMatrix
    {

        public void TestDeterminant()
        {
            Console.WriteLine("行列式の計算を行うメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 2;
            A[0, 1] = 0;
            A[1, 0] = 0;
            A[1, 1] = 2;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double determinant = Matrix.Determinant(A);
            Console.WriteLine(nameof(A) + "の行列式 " + determinant);


        }


    }
}
