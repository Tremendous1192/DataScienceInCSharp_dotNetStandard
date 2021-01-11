using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestDesignMatrix
    {

        public void TestL2Norm()
        {
            Console.WriteLine("計画行列のL2ノルムに関するメソッドのテストです。");

            double[,] A = new double[3, 2];
            A[0, 0] = 0;
            A[0, 1] = 2;
            A[1, 0] = 1;
            A[1, 1] = 4;
            A[2, 0] = 2;
            A[2, 1] = 6;
            TestMatrix.WriteLineMatrix(A, "計画行列" + nameof(A));


            double[] B = DesignMatrix.L2Norms(A);
            Console.WriteLine("計画行列" + nameof(A) + "の各行ベクトルのL2ノルムを返す");
            foreach (double d in B) { Console.WriteLine(d); }
            Console.WriteLine("");


            double bmax = DesignMatrix.L2NormMaximum(A);
            Console.WriteLine("計画行列" + nameof(A) + "の各行ベクトルのL2ノルムの最大値");
            Console.WriteLine(bmax);
            Console.WriteLine("");

            int bmaxInt = DesignMatrix.L2NormMaximumIndex(A);
            Console.WriteLine("計画行列" + nameof(A) + "の各行ベクトルのL2ノルムの最大値の要素番号");
            Console.WriteLine(bmaxInt);
            Console.WriteLine("");


            double bmin = DesignMatrix.L2NormMinimum(A);
            Console.WriteLine("計画行列" + nameof(A) + "の各行ベクトルのL2ノルムの最小値");
            Console.WriteLine(bmin);
            Console.WriteLine("");

            int bminInt = DesignMatrix.L2NormMinimumIndex(A);
            Console.WriteLine("計画行列" + nameof(A) + "の各行ベクトルのL2ノルムの最小値の要素番号");
            Console.WriteLine(bminInt);
            Console.WriteLine("");

        }

    }
}
