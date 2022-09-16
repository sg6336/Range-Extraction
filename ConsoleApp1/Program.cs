using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RangeExtraction.Extract(new[] { 1, 2, 3 });
        }
    }

    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            string result = "";

            for (var i = 0; i < args.Length; i++)
            {
                List<int> seq = new List<int> { args[i] };
                while (i < args.Length - 1 && args[i + 1] == args[i] + 1)
                    seq.Add(args[++i]);
                if (seq.Count < 3)
                    result = seq.Aggregate(result, (s, n) => s + (n + ","));
                else
                    result += seq[0] + "-" + seq[seq.Count-1] + ",";
            }
            return result.TrimEnd(',');
        }
    }
}