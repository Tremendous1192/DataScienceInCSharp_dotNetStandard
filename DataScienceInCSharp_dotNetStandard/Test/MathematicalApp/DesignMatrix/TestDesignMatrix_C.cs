using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestDesignMatrix
    {


        public void TestCorelation()
        {
            Console.WriteLine("計画行列の相関係数行列を返すメソッドのテストです。");

            double[,] A = new double[3, 2];
            A[0, 0] = -1;
            A[0, 1] = 8;

            A[1, 0] = 0;
            A[1, 1] = 4;
            
            A[2, 0] = 1;
            A[2, 1] = -4;
            TestMatrix.WriteLineMatrix(A, "計画行列" + nameof(A));


            double[,] B = DesignMatrix.Corelation(A);
            TestMatrix.WriteLineMatrix(B, nameof(A) + "の相関係数行列" + nameof(B));
        }



    }
}
