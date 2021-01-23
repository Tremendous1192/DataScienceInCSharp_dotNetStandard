using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public partial class TestIOText
    {

        public void TestWriteText()
        {
            Console.WriteLine("アプリを保存しているディレクトリに.txtファイルを作成します。");
            Console.WriteLine("System.Text.Encoding.CodePagesのインストールを求められることがあります。\n\n");


            DateTime now = DateTime.Now;

            string filename = "TestWriteText" + now.Year + now.Month + now.Day;
            Console.WriteLine("ファイル名「" + filename + "」を作成します。");
            Console.WriteLine("このファイルには「1行のstringを" + now.Year + now.Month + now.Day + "_" + now.Hour + now.Minute + "に保存しました。」と書いてあります。");
            IOText.WriteText(filename, "1行のstringを" + now.Year + now.Month + now.Day + "_" + now.Hour + now.Minute + "に保存しました。", false);


            string filenameArray = "TestWriteTextArray" + now.Year + now.Month + now.Day;
            Console.WriteLine("\n\n" + "ファイル名「" + filenameArray + "」を作成します。");
            Console.WriteLine("下記の配列を保存します。");
            string[] array = new string[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + "行目";
            }
            foreach (string s in array) { Console.WriteLine(s); }
            IOText.WriteText(filenameArray, array, false);


            string filenameList = "TestWriteTextList" + now.Year + now.Month + now.Day;
            Console.WriteLine("\n\n" + "ファイル名「" + filenameList + "」を作成します。");
            Console.WriteLine("下記のリストを保存します。");
            List<string> list = new List<string>();
            for (int i = 0; i < array.Length * 2; i++)
            {
                list.Add(i + "行目");
            }
            foreach (string s in list) { Console.WriteLine(s); }
            IOText.WriteText(filenameArray, list, false);



            string filenameArray2dim = "TestWriteTextArray2dim" + now.Year + now.Month + now.Day;
            Console.WriteLine("\n\n" + "ファイル名「" + filenameArray2dim + "」を作成します。");
            Console.WriteLine("下記の2重配列をカンマ区切りで保存します。");
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
            IOText.WriteText(filenameArray2dim, array2dim, false);




        }


    }
}
