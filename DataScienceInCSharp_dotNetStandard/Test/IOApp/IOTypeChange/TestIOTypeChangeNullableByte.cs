using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp;

namespace Test.Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public partial class TestIOTypeChange
    {

        public void TestNullableByte()
        {



            Console.WriteLine("Nullable byteの型変換などに関するテストメソッドです。\n");


            Console.WriteLine("次のstring[8]の型を変換します");
            string[] testArray = new string[8] { "1", "-2", "1.1", "-3.1", "--", "2.2", "33", "ss" };
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + testArray[i]);
            }


            Console.WriteLine("\n" + "byte?[8]に変換します");
            byte?[] converted = IOTypeChange.StringToNullableByte(testArray);
            Console.WriteLine("要素番号" + "\t" + "変換された数");
            for (int i = 0; i < converted.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + converted[i]);
            }


            Console.WriteLine("\n" + "元のstring[8]に戻します。nullは戻りません");
            string[] convertBack = IOTypeChange.NumberToString(converted);
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < convertBack.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + convertBack[i]);
            }


            Console.WriteLine("\n\n\n" + "byte?[8]をbyte?[2,4]に変換します");
            byte?[,] array2Dimension = IOTypeChange.ChangeArray1dimTo2dim(converted, 2, 4);
            for (int i = 0; i < array2Dimension.GetLength(0); i++)
            {
                for (int j = 0; j < array2Dimension.GetLength(1); j++)
                {
                    Console.Write(array2Dimension[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n" + "多次元への拡張を意識して、要素番号とともにbyte?[2,4]を記載します。");
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array2Dimension.GetLength(0); i++)
            {
                for (int j = 0; j < array2Dimension.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + array2Dimension[i, j]);
                }
            }
            Console.WriteLine("\n" + "元のbyte?[8]に戻せることを確認します。");
            byte?[] array1Dimension = IOTypeChange.ChangeArray2dimTo1dim(array2Dimension);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array1Dimension.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + array1Dimension[i]);
            }


            Console.WriteLine("\n" + "byte?[8]をbyte?[2,2,2]に変換します");
            byte?[,,] array3Dimension = IOTypeChange.ChangeArray1dimTo3dim(converted, 2, 2, 2);
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
            Console.WriteLine("\n" + "元のbyte?[8]に戻せることを確認します。");
            array1Dimension = IOTypeChange.ChangeArray3dimTo1dim(array3Dimension);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array1Dimension.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + array1Dimension[i]);
            }


            Console.WriteLine("\n" + "byte?[8]をbyte?[2,2,2,1]に変換します");
            byte?[,,,] array4Dimension = IOTypeChange.ChangeArray1dimTo4dim(converted, 2, 2, 2, 1);
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
            Console.WriteLine("\n" + "元のbyte?[8]に戻せることを確認します。");
            array1Dimension = IOTypeChange.ChangeArray4dimTo1dim(array4Dimension);
            Console.WriteLine("要素番号" + "\t" + "値");
            for (int i = 0; i < array1Dimension.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t" + array1Dimension[i]);
            }



            Console.WriteLine("\n\n\n" + "byte?[8]のnullの要素番号を示します");
            List<int[]> reportIndex = IOTypeChange.ReportNullableByteIndex(converted);
            Console.WriteLine("要素番号" + "\t" + "変換できなかった文字列");
            for (int i = 0; i < reportIndex.Count; i++)
            {
                Console.Write("[");
                for (int j = 0; j < reportIndex[i].GetLength(0) - 1; j++)
                {
                    Console.Write(reportIndex[i][j] + ",");
                }
                Console.WriteLine(reportIndex[i][reportIndex[i].GetLength(0) - 1] + "]"
                    + "\t\t" + testArray[reportIndex[i][0]]);
            }

            byte replacement = 0b1001;
            Console.WriteLine("\n" + "byte?[8]のnullを" + replacement + "に変換します");
            byte[] replaced = IOTypeChange.ReplaceNull(converted, replacement);
            Console.WriteLine("要素番号" + "\t" + "変換された数");
            for (int i = 0; i < converted.GetLength(0); i++)
            {
                Console.WriteLine("[" + i + "]" + "\t\t" + replaced[i]);
            }





            Console.WriteLine("\n\n\n" + "次のstring[2,4]をbyte?[2,4]に変換します");
            string[,] testArray2 = new string[2, 4] { { "1", "-2", "1.1", "-3.1" }, { "--", "2.2", "33", "ss" } };
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < testArray2.GetLength(0); i++)
            {
                for (int j = 0; j < testArray2.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + testArray2[i, j]);
                }
            }
            Console.WriteLine("\n" + "byte?[2,4]を表示します");
            byte?[,] converted2 = IOTypeChange.StringToNullableByte(testArray2);
            for (int i = 0; i < converted2.GetLength(0); i++)
            {
                for (int j = 0; j < converted2.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + converted2[i, j]);
                }
            }
            Console.WriteLine("\n" + "byte?[2,4]のnullの要素番号を示します");
            reportIndex = IOTypeChange.ReportNullableByteIndex(converted2);
            Console.WriteLine("要素番号" + "\t" + "変換できなかった文字列");
            for (int i = 0; i < reportIndex.Count; i++)
            {
                Console.Write("[");
                for (int j = 0; j < reportIndex[i].GetLength(0) - 1; j++)
                {
                    Console.Write(reportIndex[i][j] + ",");
                }
                Console.WriteLine(reportIndex[i][reportIndex[i].GetLength(0) - 1] + "]"
                    + "\t\t" + testArray2[reportIndex[i][0], reportIndex[i][1]]);
            }
            Console.WriteLine("\n" + "byte?[2,4]のnullを" + replacement + "に変換します");
            byte[,] replaced2 = IOTypeChange.ReplaceNull(converted2, replacement);
            Console.WriteLine("要素番号" + "\t" + "変換された数");
            for (int i = 0; i < converted2.GetLength(0); i++)
            {
                for (int j = 0; j < converted2.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + replaced2[i, j]);
                }
            }

            Console.WriteLine("\n" + "元のstring[2,4]に戻します。nullは戻りません");
            string[,] convertBack2 = IOTypeChange.NumberToString(converted2);
            Console.WriteLine("要素番号" + "\t" + "文字列");
            for (int i = 0; i < convertBack2.GetLength(0); i++)
            {
                for (int j = 0; j < convertBack2.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]" + "\t\t" + convertBack2[i, j]);
                }
            }


            Console.WriteLine("\n\n\n" + "次のstring[2,2,2]をbyte?[2,2,2]に変換します");
            string[,,] testArray3 = new string[2, 2, 2] { { { "1", "-2" }, { "1.1", "-3.1" } }, { { "--", "2.2" }, { "33", "ss" } } };
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
            Console.WriteLine("\n" + "byte?[2,2,2]を表示します");
            byte?[,,] converted3 = IOTypeChange.StringToNullableByte(testArray3);
            for (int i = 0; i < converted3.GetLength(0); i++)
            {
                for (int j = 0; j < converted3.GetLength(1); j++)
                {
                    for (int k = 0; k < converted3.GetLength(2); k++)
                    {
                        Console.WriteLine("[" + i + "," + j + "," + k + "]" + "\t\t" + converted3[i, j, k]);
                    }
                }
            }
            Console.WriteLine("\n" + "byte?[2,2,2]のnullの要素番号を示します");
            reportIndex = IOTypeChange.ReportNullableByteIndex(converted3);
            Console.WriteLine("要素番号" + "\t" + "変換できなかった文字列");
            for (int i = 0; i < reportIndex.Count; i++)
            {
                Console.Write("[");
                for (int j = 0; j < reportIndex[i].GetLength(0) - 1; j++)
                {
                    Console.Write(reportIndex[i][j] + ",");
                }
                Console.WriteLine(reportIndex[i][reportIndex[i].GetLength(0) - 1] + "]"
                    + "\t\t" + testArray3[reportIndex[i][0], reportIndex[i][1], reportIndex[i][2]]);
            }
            Console.WriteLine("\n" + "byte?[2,2,2]のnullを" + replacement + "に変換します");
            byte[,,] replaced3 = IOTypeChange.ReplaceNull(converted3, replacement);
            Console.WriteLine("要素番号" + "\t" + "変換された数");
            for (int i = 0; i < converted3.GetLength(0); i++)
            {
                for (int j = 0; j < converted3.GetLength(1); j++)
                {
                    for (int k = 0; k < converted3.GetLength(2); k++)
                    {
                        Console.WriteLine("[" + i + "," + j + "," + k + "]" + "\t\t" + replaced3[i, j, k]);
                    }
                }
            }


            Console.WriteLine("\n" + "元のstring[2,2,2]に戻します。nullは戻りません");
            string[,,] convertBack3 = IOTypeChange.NumberToString(converted3);
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



            Console.WriteLine("\n\n\n" + "次のstring[2,2,2,1]をbyte?[2,2,2]に変換します");
            string[,,,] testArray4 = new string[2, 2, 2, 1] { { { { "1" }, { "-2" } }, { { "1.1" }, { "-3.1" } } }, { { { "--" }, { "2.2" } }, { { "33" }, { "ss" } } } };
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
            Console.WriteLine("\n" + "byte?[2,2,2,1]を表示します");
            byte?[,,,] converted4 = IOTypeChange.StringToNullableByte(testArray4);
            for (int i = 0; i < converted4.GetLength(0); i++)
            {
                for (int j = 0; j < converted4.GetLength(1); j++)
                {
                    for (int k = 0; k < converted4.GetLength(2); k++)
                    {
                        for (int dim4 = 0; dim4 < converted4.GetLength(3); dim4++)
                        {
                            Console.WriteLine("[" + i + "," + j + "," + k + "," + dim4 + "]" + "\t\t" + converted4[i, j, k, dim4]);
                        }
                    }
                }
            }
            Console.WriteLine("\n" + "byte?[2,2,2,1]のnullの要素番号を示します");
            reportIndex = IOTypeChange.ReportNullableByteIndex(converted4);
            Console.WriteLine("要素番号" + "\t" + "変換できなかった文字列");
            for (int i = 0; i < reportIndex.Count; i++)
            {
                Console.Write("[");
                for (int j = 0; j < reportIndex[i].GetLength(0) - 1; j++)
                {
                    Console.Write(reportIndex[i][j] + ",");
                }
                Console.WriteLine(reportIndex[i][reportIndex[i].GetLength(0) - 1] + "]"
                    + "\t\t" + testArray4[reportIndex[i][0], reportIndex[i][1], reportIndex[i][2], reportIndex[i][3]]);
            }
            Console.WriteLine("\n" + "byte?[2,2,2,1]のnullを" + replacement + "に変換します");
            byte[,,,] replaced4 = IOTypeChange.ReplaceNull(converted4, replacement);
            Console.WriteLine("要素番号" + "\t" + "変換された数");
            for (int i = 0; i < converted4.GetLength(0); i++)
            {
                for (int j = 0; j < converted4.GetLength(1); j++)
                {
                    for (int k = 0; k < converted4.GetLength(2); k++)
                    {
                        for (int dim4 = 0; dim4 < converted4.GetLength(3); dim4++)
                        {
                            Console.WriteLine("[" + i + "," + j + "," + k + "," + dim4 + "]" + "\t\t" + replaced4[i, j, k, dim4]);
                        }
                    }
                }
            }


            Console.WriteLine("\n" + "元のstring[2,2,2,1]に戻します。nullは戻りません");
            string[,,,] convertBack4 = IOTypeChange.NumberToString(converted4);
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
