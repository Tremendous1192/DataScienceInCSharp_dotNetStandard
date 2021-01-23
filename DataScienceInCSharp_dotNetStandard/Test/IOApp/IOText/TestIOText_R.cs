using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public partial class TestIOText
    {

        public void TestReadText()
        {
            Console.WriteLine("アプリを保存しているディレクトリの.txtファイルを読み込みます。");
            Console.WriteLine("System.Text.Encoding.CodePagesのインストールを求められることがあります。\n\n");


            DateTime now = DateTime.Now;
            string filenameArray2dim = "TestWriteTextArray2dim" + now.Year + now.Month + now.Day;
            Console.WriteLine("\n\n" + "読み込むためのファイル「" + filenameArray2dim + "」を作成します。");
            Console.WriteLine("下記の2重配列をカンマ区切りで保存しました。");
            string[,] array2dim = new string[3, 3];
            for (int i = 0; i < array2dim.GetLength(0); i++)
            {
                for (int j = 0; j < array2dim.GetLength(1); j++)
                {
                    Console.Write(i + "行" + j + "列" + "\t");
                    array2dim[i, j] = i + "行" + j + "列";
                }
                Console.WriteLine();
            }
            IOText.WriteText(filenameArray2dim, array2dim,false);



            string[] readText = IOText.ReadText(filenameArray2dim);
            Console.WriteLine("\n\n" + "改行で要素を区切った配列として読み込みました。読み込んだ配列は下記のとおりです。");
            foreach (string s in readText) { Console.WriteLine(s); }


            string[,] readText2dim = IOText.ReadTextSplitedByComma(filenameArray2dim);
            Console.WriteLine("\n\n" + "改行とカンマで要素を区切った2重配列として読み込みました。列をそろえないとエラーになります。");
            for (int i=0;i<readText2dim.GetLength(0);i++)
            {
                for (int j=0;j<readText2dim.GetLength(1);j++)
                {
                    Console.Write(readText2dim[i, j] + "\t");
                }
                Console.WriteLine();
            }





        }



    }
}
