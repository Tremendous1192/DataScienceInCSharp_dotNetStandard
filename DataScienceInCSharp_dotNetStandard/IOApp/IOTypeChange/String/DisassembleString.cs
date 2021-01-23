using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {



        /// <summary>
        /// ex) Change "a,b,c" to {"a","b","c"}
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] DisassembleStringByComma(string input)
        {
            return input.Split(',');
        }

        /// <summary>
        /// ex) Change {"a,b","c,d"} to { {"a","b"} ,{"c","d"} }
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[,] DisassembleStringByComma(string[] input)
        {
            int L0 = input.GetLength(0);
            int L1 = input[0].Split(',').GetLength(0);

            string[,] result = new string[L0, L1];

            for (int i = 0; i < L0; i++)
            {
                var L = input[i].Split(',');
                for (int j = 0; j < L1; j++)
                {
                    result[i, j] = L[j];
                }
            }
            return result;
        }


        /// <summary>
        /// 改行記号でstringを分割する
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] SplitStringByLineFeedCode(string input)
        {
            return input.Split('\n').ToArray();
        }



    }
}
