using System;
using System.Collections.Generic;
using System.Text;
namespace Tremendous1192.SelfEmployed.DataScienceInCSharp_dotNetStandard.IOApp
{
    public static partial class IOTypeChange
    {


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(bool? input)
        {
            List<int[]> result = new List<int[]>();

            if (input != null) { }
            else
            {
                int[] index = new int[1] { 0 };
                result.Add(index);
            }

            return result;
        }

        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(string input)
        {
            List<int[]> result = new List<int[]>();

            if (bool.TryParse(input, out bool parsed)) { }
            else
            {
                int[] index = new int[1] { 0 };
                result.Add(index);
            }

            return result;
        }


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(bool?[] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (input[i] != null) { }
                else
                {
                    int[] index = new int[1] { i };
                    result.Add(index);
                }
            }

            return result;
        }


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(string[] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (bool.TryParse(input[i], out bool parsed)) { }
                else
                {
                    int[] index = new int[1] { i };
                    result.Add(index);
                }
            }

            return result;
        }




        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(bool?[,] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] != null) { }
                    else
                    {
                        int[] index = new int[2] { i, j };
                        result.Add(index);
                    }
                }
            }

            return result;
        }


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(string[,] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (bool.TryParse(input[i, j], out bool parsed)) { }
                    else
                    {
                        int[] index = new int[2] { i, j };
                        result.Add(index);
                    }
                }
            }

            return result;
        }


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(bool?[,,] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        if (input[i, j, k] != null) { }
                        else
                        {
                            int[] index = new int[3] { i, j, k };
                            result.Add(index);
                        }
                    }
                }
            }

            return result;
        }


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(string[,,] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        if (bool.TryParse(input[i, j, k], out bool parsed)) { }
                        else
                        {
                            int[] index = new int[3] { i, j, k };
                            result.Add(index);
                        }
                    }
                }
            }

            return result;
        }





        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(bool?[,,,] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int l = 0; l < input.GetLength(3); l++)
                        {
                            if (input[i, j, k, l] != null) { }
                            else
                            {
                                int[] index = new int[4] { i, j, k, l };
                                result.Add(index);
                            }
                        }
                    }
                }
            }

            return result;
        }


        /// <summary>
        /// Report index of null.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int[]> ReportNullableBoolIndex(string[,,,] input)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int l = 0; l < input.GetLength(3); l++)
                        {
                            if (bool.TryParse(input[i, j, k, l], out bool parsed)) { }
                            else
                            {
                                int[] index = new int[4] { i, j, k, l };
                                result.Add(index);
                            }
                        }
                    }
                }
            }

            return result;
        }




    }
}
