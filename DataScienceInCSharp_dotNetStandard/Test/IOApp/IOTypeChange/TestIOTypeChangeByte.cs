﻿using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public partial class TestIOTypeChange
    {

        public void TestByte()
        {



            Console.WriteLine("byteの型変換などに関するテストメソッドです。");
            Console.WriteLine("byte -> string はありますが、string -> byte はありません。");
            Console.WriteLine("string -> byte? -> byte の順番にする必要があります。\n");



            Console.WriteLine("次のbyte[8]をstring[8]に変換します");
            byte[] testArray = new byte[8] { 1, 0b10, 11, 0b11111, 0b1001, 22, 33, 0b1001 };
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + testArray[i]);
            }


            Console.WriteLine("\n" + "string[8]に戻します。");
            string[] convertBack = IOTypeChange.NumberToString(testArray);
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < convertBack.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + convertBack[i]);
            }


            Console.WriteLine("\n\n\n" + "byte[8]をbyte[2,4]に変換します");
            byte[,] array2Dimension = IOTypeChange.ChangeArray1dimTo2dim(testArray, 2, 4);
            for (int i = 0; i < array2Dimension.GetLength(0); i++)
            {
                for (int j = 0; j < array2Dimension.GetLength(1); j++)
                {
                    Console.Write(array2Dimension[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n" + "多次元への拡張を意識して、要素番号とともにbyte[2,4]を記載します。");
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array2Dimension.GetLength(0); i++)
            {
                for (int j = 0; j < array2Dimension.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + array2Dimension[i, j]);
                }
            }
            Console.WriteLine("\n" + "元のbyte[8]に戻せることを確認します。");
            byte[] array1Dimension = IOTypeChange.ChangeArray2dimTo1dim(array2Dimension);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array1Dimension.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + array1Dimension[i]);
            }


            Console.WriteLine("\n" + "byte[8]をbyte[2,2,2]に変換します");
            byte[,,] array3Dimension = IOTypeChange.ChangeArray1dimTo3dim(testArray, 2, 2, 2);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array3Dimension.GetLength(0); i++)
            {
                for (int j = 0; j < array3Dimension.GetLength(1); j++)
                {
                    for (int k = 0; k < array3Dimension.GetLength(2); k++)
                    {
                        Console.WriteLine("[" + i + "," + j + "," + k + "]" + "\t\t" + array3Dimension[i, j, k]);
                    }
                }
            }
            Console.WriteLine("\n" + "元のbyte[8]に戻せることを確認します。");
            array1Dimension = IOTypeChange.ChangeArray3dimTo1dim(array3Dimension);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array1Dimension.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + array1Dimension[i]);
            }


            Console.WriteLine("\n" + "byte[8]をbyte[2,2,2,1]に変換します");
            byte[,,,] array4Dimension = IOTypeChange.ChangeArray1dimTo4dim(testArray, 2, 2, 2, 1);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array4Dimension.GetLength(0); i++)
            {
                for (int j = 0; j < array4Dimension.GetLength(1); j++)
                {
                    for (int k = 0; k < array4Dimension.GetLength(2); k++)
                    {
                        for (int dim4 = 0; dim4 < array4Dimension.GetLength(3); dim4++)
                        {
                            Console.WriteLine("[" + i + "," + j + "," + k + "," + dim4 + "]" + "\t\t" + array4Dimension[i, j, k, dim4]);
                        }
                    }
                }
            }
            Console.WriteLine("\n" + "元のbyte[8]に戻せることを確認します。");
            array1Dimension = IOTypeChange.ChangeArray4dimTo1dim(array4Dimension);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array1Dimension.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t" + array1Dimension[i]);
            }







            Console.WriteLine("\n\n\n" + "次のstring[2,4]をbyte[2,4]に変換します");
            byte[,] testArray2 = new byte[2, 4] { { 1, 0b10, 11, 0b11111 }, { 0b1001, 22, 33, 0b1001 } };
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < testArray2.GetLength(0); i++)
            {
                for (int j = 0; j < testArray2.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + testArray2[i, j]);
                }
            }

            Console.WriteLine("\n" + "string[2,4]に変換します");
            string[,] convertBack2 = IOTypeChange.NumberToString(testArray2);
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < convertBack2.GetLength(0); i++)
            {
                for (int j = 0; j < convertBack2.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + convertBack2[i, j]);
                }
            }



            Console.WriteLine("\n\n\n" + "次のstring[2,2,2]をbyte[2,2,2]に変換します");
            byte[,,] testArray3 = new byte[2, 2, 2] { { { 1, 0b10 }, { 11, 0b11111 } }, { { 0b1001, 22 }, { 33, 0b1001 } } };
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < testArray3.GetLength(0); i++)
            {
                for (int j = 0; j < testArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < testArray3.GetLength(2); k++)
                    {
                        Console.WriteLine("[" + i + "," + j + "," + k + "]" + "\t\t" + testArray3[i, j, k]);
                    }
                }
            }

            Console.WriteLine("\n" + "string[2,2,2]に変換します");
            string[,,] convertBack3 = IOTypeChange.NumberToString(testArray3);
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < convertBack3.GetLength(0); i++)
            {
                for (int j = 0; j < convertBack3.GetLength(1); j++)
                {
                    for (int k = 0; k < convertBack3.GetLength(2); k++)
                    {
                        Console.WriteLine("[" + i + "," + j + "," + k + "]" + "\t\t" + convertBack3[i, j, k]);
                    }
                }
            }



            Console.WriteLine("\n\n\n" + "次のstring[2,2,2,1]をbyte[2,2,2,1]に変換します");
            byte[,,,] testArray4 = new byte[2, 2, 2, 1] { { { { 1 }, { 0b10 } }, { { 11 }, { 0b11111 } } }, { { { 0b1001 }, { 22 } }, { { 33 }, { 0b1001 } } } };
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < testArray4.GetLength(0); i++)
            {
                for (int j = 0; j < testArray4.GetLength(1); j++)
                {
                    for (int k = 0; k < testArray4.GetLength(2); k++)
                    {
                        for (int dim4 = 0; dim4 < testArray4.GetLength(3); dim4++)
                        {
                            Console.WriteLine("[" + i + "," + j + "," + k + "," + dim4 + "]" + "\t\t" + testArray4[i, j, k, dim4]);
                        }
                    }
                }
            }

            Console.WriteLine("\n" + "string[2,2,2,1]に変換します。");
            string[,,,] convertBack4 = IOTypeChange.NumberToString(testArray4);
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < convertBack4.GetLength(0); i++)
            {
                for (int j = 0; j < convertBack4.GetLength(1); j++)
                {
                    for (int k = 0; k < convertBack4.GetLength(2); k++)
                    {
                        for (int dim4 = 0; dim4 < convertBack4.GetLength(3); dim4++)
                        {
                            Console.WriteLine("[" + i + "," + j + "," + k + "," + dim4 + "]" + "\t\t" + convertBack4[i, j, k, dim4]);
                        }
                    }
                }
            }




        }
    }
}
