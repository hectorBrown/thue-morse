using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace PosNegNegPos
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = "1";
            while (true)
            {
                current = PosNegNegPos(current);
                Console.Clear();
                Console.WriteLine(current);
                Console.WriteLine(current.Length);
                //if (current.Length == 256)
                //{
                //    ExportToCsv("output.csv", current);
                //    Console.WriteLine("Saved!");
                //}
                ExportToTxt("output2.csv", current);
                Thread.Sleep(1000);
            }
        }
        static string PosNegNegPos(string input)
        {
            string inverted = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] == '1')
                {
                    inverted += "0";
                }
                else
                {
                    inverted += "1";
                }
            }
            string output = input + inverted + inverted + input;
            return output;
        }
        static void ExportToCsv(string path, string input)
        {
            StreamWriter strW = new StreamWriter(path);
            for (int i = 0; i <= input.Length - 1; i++)
            {
                strW.WriteLine(input[i] + ",");
            }
            strW.Close();
        }
        static void ExportToTxt(string path, string input)
        {
            StreamWriter strW = new StreamWriter(path);
            strW.WriteLine(input);
            strW.Close();
        }
    }
}
