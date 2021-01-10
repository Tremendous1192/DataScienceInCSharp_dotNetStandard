using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp.DataScienceInCSharp_dotNetStandard
{
    public partial class TestMatrix
    {
        public void TestAdd()
        {
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


            double[,] C = Matrix.Add(A, B);
            TestMatrix.WriteLineMatrix(C, nameof(A) + " + " + nameof(B));

        }


    }
}
