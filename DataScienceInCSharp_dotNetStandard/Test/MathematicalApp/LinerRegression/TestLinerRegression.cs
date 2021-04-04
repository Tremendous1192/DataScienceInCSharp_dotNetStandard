using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.MathematicalApp
{
    public partial class TestLinerRegression
    {

        public void Test()
        {
            Console.WriteLine("線形回帰のテストです。" + "\n");


            //簡単な直線の学習
            Console.WriteLine("\n" + "簡単のため,まずは1次元で確認します。");
            Console.WriteLine("次の教師データを学習させてみます。");

            double[,] x = new double[3, 1];
            double[,] t = new double[3, 1];

            x[0, 0] = 0;
            x[1, 0] = 1;
            x[2, 0] = 2;

            t[0, 0] = 1;
            t[1, 0] = 2;
            t[2, 0] = 3;
            Console.WriteLine("変数x" + "\t" + "回答t" );
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine(x[i, 0] + "\t" + t[i, 0]);
            }


            //学習する
            double[,] w = LinerRegression.Learn(x, t);


            //推定する
            x = new double[5, 1];
            t = new double[5, 1];

            x[0, 0] = 0;
            x[1, 0] = 1;
            x[2, 0] = 2;
            x[3, 0] = 3;
            x[4, 0] = 4;

            t[0, 0] = 1;
            t[1, 0] = 2;
            t[2, 0] = 3;
            t[3, 0] = 4;
            t[4, 0] = 5;

            double[,] y = LinerRegression.Regression(x, w);
            Console.WriteLine("\n" + "教師データを学習させました。");
            Console.WriteLine("回帰分析の目的は戻り値の予測です。学習に使用していないデータを追加して,予測精度を確認します。");
            Console.WriteLine("この例では上手くいったようです。");
            Console.WriteLine("変数x" + "\t" + "回答t"+"\t"+"予測y");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine(x[i, 0] + "\t" + t[i, 0] + "\t" + y[i, 0]);
            }




            //曲線の学習に関して
            x = new double[3, 1];
            t = new double[3, 1];

            x[0, 0] = -2;
            x[1, 0] = 0;
            x[2, 0] = 2;

            t[0, 0] = 4;
            t[1, 0] = 0;
            t[2, 0] = 4;
            Console.WriteLine("\n\n" + "次の例です。");
            Console.WriteLine("変数x" + "\t" + "回答t");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine(x[i, 0] + "\t" + t[i, 0]);
            }

            //学習する
            w = LinerRegression.Learn(x, t);


            //推定する
            x = new double[5, 1];
            t = new double[5, 1];

            x[0, 0] = -2;
            x[1, 0] = 0;
            x[2, 0] = 2;
            x[3, 0] = -3;
            x[4, 0] = 3;

            t[0, 0] = 4;
            t[1, 0] = 0;
            t[2, 0] = 4;
            t[3, 0] = 9;
            t[4, 0] = 9;

            y = LinerRegression.Regression(x, w);
            Console.WriteLine("\n" + "学習結果を下記に表示します。こちらは上手くいっていません。");
            Console.WriteLine("変数x" + "\t" + "回答t" + "\t" + "予測y");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine(x[i, 0] + "\t" + t[i, 0] + "\t" + y[i, 0].ToString("G2"));
            }



            Console.WriteLine("\n" + "線形回帰は、変数xと回答tとの関係が直線であることを前提にしています。");
            Console.WriteLine("今回は,1次元の変数xを,2次元の変数(x , x^2)に変換して,新しい計画行列とします.");

            x = new double[3, 2];
            x[0, 0] = -2;
            x[1, 0] = 0;
            x[2, 0] = 2;

            x[0, 1] = x[0, 0]* x[0, 0];
            x[1, 1] = x[1, 0] * x[1, 0];
            x[2, 1] = x[2, 0] * x[2, 0];

            t = new double[3, 1];
            t[0, 0] = 4;
            t[1, 0] = 0;
            t[2, 0] = 4;

            w = LinerRegression.Learn(x, t);


            x = new double[5, 2];
            x[0, 0] = -2;
            x[1, 0] = 0;
            x[2, 0] = 2;
            x[3, 0] = -3;
            x[4, 0] = 3;

            x[0, 1] = x[0, 0] * x[0, 0];
            x[1, 1] = x[1, 0] * x[1, 0];
            x[2, 1] = x[2, 0] * x[2, 0];
            x[3, 1] = x[3, 0] * x[3, 0];
            x[4, 1] = x[4, 0] * x[4, 0];


            t = new double[5, 1];
            t[0, 0] = 4;
            t[1, 0] = 0;
            t[2, 0] = 4;
            t[3, 0] = 9;
            t[4, 0] = 9;

            Console.WriteLine("変数変換を行った結果,上手く推定できました。");
            Console.WriteLine("直線の推定が難しい場合、ご自身で変数変換を行うことで,予測の精度を上げられる場合があります。(※2021/4/3時点では,変数変換の自動化は搭載していません)");
            y = LinerRegression.Regression(x, w);
            Console.WriteLine("変数x" + "\t" + "x^2" + "\t" + "回答t" + "\t" + "予測y");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine(x[i, 0] + "\t"+ x[i, 1]+"\t" + t[i, 0] + "\t" + y[i, 0].ToString("G2"));
            }


            Console.WriteLine("\n\n\n"+"Ridge回帰のテストはありません。良い例が見つかりませんでした(2021/4/4時点)");


        }

    }
}
