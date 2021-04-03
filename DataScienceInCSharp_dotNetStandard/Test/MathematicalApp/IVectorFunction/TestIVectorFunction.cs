using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;


namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public class TestIVectorFunction
    {

        public void TestIVectorFunctions()
        {
            Console.WriteLine("ベクトル値関数のテストを行います。列ベクトルを想定していますが、行ベクトルでも使用できます.");

            double[,] input = new double[5, 1];
            input[0, 0] = -2;
            input[1, 0] = -1;
            input[2, 0] = 0;
            input[3, 0] = 1;
            input[4, 0] = 2;
            Console.WriteLine("入力ベクトル");
            for (int i=0;i<input.GetLength(0);i++)
            {
                Console.WriteLine(input[i, 0]);
            }
            Console.WriteLine("");


            GaussianIVectorFunction givf = new GaussianIVectorFunction();
            double[,] output = givf.Calculate_f_u(input);
            Console.WriteLine("ガウス関数のベクトル値関数の出力");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");

            output = givf.Calculate_f_u_dash(input);
            Console.WriteLine("ガウス関数のベクトル値関数の微分係数");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");


            HyperbolicTangentIVectorFunction htivf = new HyperbolicTangentIVectorFunction();
            output = htivf.Calculate_f_u(input);
            Console.WriteLine("ハイパボリックタンジェント関数のベクトル値関数の出力");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");

            output = htivf.Calculate_f_u_dash(input);
            Console.WriteLine("ハイパボリックタンジェント関数のベクトル値関数の微分係数");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");


            SigmoidIVectorFunction sivf = new SigmoidIVectorFunction();
            output = sivf.Calculate_f_u(input);
            Console.WriteLine("シグモイド関数のベクトル値関数の出力");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");

            output = sivf.Calculate_f_u_dash(input);
            Console.WriteLine("シグモイド関数のベクトル値関数の微分係数");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");


            SwishIVectorFunction swivf = new SwishIVectorFunction();
            output = swivf.Calculate_f_u(input);
            Console.WriteLine("Swish関数のベクトル値関数の出力");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");

            output = swivf.Calculate_f_u_dash(input);
            Console.WriteLine("Swish関数のベクトル値関数の微分係数");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");



            input = new double[3, 1];
            input[0, 0] = 0.2;
            input[1, 0] = 0.4;
            input[2, 0] = 0;
            Console.WriteLine("SoftMax関数用の入力ベクトル");
            for (int i = 0; i < input.GetLength(0); i++)
            {
                Console.WriteLine(input[i, 0]);
            }
            Console.WriteLine("");


            SoftMaxIVectorFunction smivf = new SoftMaxIVectorFunction();
            output = smivf.Calculate_f_u(input);
            Console.WriteLine("Swish関数のベクトル値関数の出力");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");

            output = smivf.Calculate_f_u_dash(input);
            Console.WriteLine("Swish関数のベクトル値関数の微分係数");
            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine(output[i, 0]);
            }
            Console.WriteLine("");

        }
    }
}
