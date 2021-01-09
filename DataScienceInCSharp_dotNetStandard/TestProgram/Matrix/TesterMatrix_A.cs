using System;
using System.Collections.Generic;
using System.Text;

namespace DataScienceInCSharp_dotNetStandard
{
    public partial class Tester
    {
        public void TestMatrix_Add()
        {
            double[,] A = new double[2, 2];
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[1, 0] = 2;
            A[1, 1] = 3;
            Tester.WriteLineMatrix(A, nameof(A));

            double[,] B = new double[2, 2];
            B[0, 0] = 1;
            B[0, 1] = 2;
            B[1, 0] = 3;
            B[1, 1] = 4;
            Tester.WriteLineMatrix(B, nameof(B));


            double[,] C = Matrix.Add(A, B);
            Tester.WriteLineMatrix(C, nameof(A) + " + " + nameof(B));

        }


    }
}
