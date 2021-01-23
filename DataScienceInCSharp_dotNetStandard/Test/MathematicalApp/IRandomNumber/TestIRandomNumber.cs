using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;
using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp;


namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestIRandomNumber
    {

        public void TestRandomNumbers()
        {
            Console.WriteLine("乱数のテストを行います。起動しているプログラムと同じディレクトリに結果のテキストファイルを作成します。");


            int number = 1000;

            UniformDistributionIRandomNumber uDIRM = new UniformDistributionIRandomNumber(1);
            string[] resultUDIRM = new string[number];


            NormalDistributionIRandomNumber nDIRM = new NormalDistributionIRandomNumber(1, 2);
            string[] resultNDIRM = new string[number];


            HalfNormalDistributionIRandomNumber hNDIRN = new HalfNormalDistributionIRandomNumber(1, 2);
            string[] resultHNDIRN = new string[number];


            LogNormalDistributionIRandomNumber lNDIRN = new LogNormalDistributionIRandomNumber(1, 2);
            string[] resultlNDIRN = new string[number];


            CauchyDistributionIRandomNumber cDITN = new CauchyDistributionIRandomNumber(1, 2);
            string[] resultCDIRN = new string[number];

            for (int i=0;i<number;i++)
            {
                resultUDIRM[i] = uDIRM.NextDouble().ToString();

                resultNDIRM[i] = nDIRM.NextDouble().ToString();

                resultHNDIRN[i] = hNDIRN.NextDouble().ToString();

                resultlNDIRN[i] = lNDIRN.NextDouble().ToString();

                resultCDIRN[i] = cDITN.NextDouble().ToString();
            }



            IOText.WriteText("TestUniformDistributionIRandomNumber.txt", resultUDIRM, false);

            IOText.WriteText("TestNormalDistributionIRandomNumber.txt", resultNDIRM, false);

            IOText.WriteText("TestHalfNormalDistributionIRandomNumber.txt", resultHNDIRN, false);

            IOText.WriteText("TestLogNormalDistributionIRandomNumber.txt", resultlNDIRN, false);

            IOText.WriteText("TestCauchyDistributionIRandomNumber.txt", resultCDIRN, false);


        }


    }
}
