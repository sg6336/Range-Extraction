// See https://aka.ms/new-console-template for more information

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
                result += seq[0] + "-" + seq[^1] + ",";
        }
        return result.TrimEnd(',');
    }
}
