using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOText
    {


        /// <summary>
        /// 絶対パスを作成する
        /// </summary>
        /// <param name="pathOrFileName"></param>
        /// <returns></returns>
        public static string MakeFullPath(string pathOrFileName)
        {
            string result = pathOrFileName;
            if (System.IO.Path.GetExtension(pathOrFileName) == ".txt")
            { }
            else
            {
                result += ".txt";
            }
            if (pathOrFileName.Contains("\\"))
            { }
            else
            {
                result = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), result);
            }
            return result;
        }


    }
}
