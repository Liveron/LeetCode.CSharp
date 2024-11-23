using System.Text;

namespace LeetCode;

public static partial class Solution
{
    public static IList<string> FizzBuzz(int n)
    {
        var answer = new List<string>(n);

        var sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
                sb.Append("Fizz");
            if (i % 5 == 0)
                sb.Append("Buzz");

            if (sb.Length > 0)
            {
                answer.Add(sb.ToString());
                sb.Clear();
            }
            else answer.Add(i.ToString());
        }

        return answer;
    }
}
