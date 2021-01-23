using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{

    /// <summary>
    /// 型変換を行うクラス
    /// </summary>
    public static partial class IOTypeChange
    {

        /// <summary>
        /// Make Null index report (string[] data)
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public static string[] MakeNullIndexReportWrittenByString(List<int[]> report)
        {
            string[] result = new string[Math.Max(1, report.Count)];
            for (int i=0;i<report.Count;i++)
            {
                string text = "";
                for (int j = 0; j < report[i].Length - 1; j++)
                {
                    text += report[i][j] + ",";
                }
                text += report[i][report[i].Length - 1];
                result[i] = text;
            }

            return result;
        }

    }
}
