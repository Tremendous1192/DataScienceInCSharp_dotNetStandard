using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard;


namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard
{
    public partial class TestMatrix
    {


        public void TestNaturalLogarithm()
        {
            Console.WriteLine("行列の各要素の自然対数を計算するメソッドのテストです。");

            double[,] A = new double[2, 2];
            A[0, 0] = 1;
            A[0, 1] = Math.E;
            A[1, 0] = Math.E * Math.E;
            A[1, 1] = 4;
            TestMatrix.WriteLineMatrix(A, nameof(A));


            double[,] B = Matrix.NaturalLogarithm(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "の各要素の自然対数に変換した行列" + nameof(B));
        }




    }
}
