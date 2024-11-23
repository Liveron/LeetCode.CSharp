using System.Text;

namespace LeetCode;

public static partial class Solution
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineLetters = new Dictionary<char, int>();

        foreach (char item in magazine)
        {
            int currentCount = magazineLetters.GetValueOrDefault(item);
            magazineLetters.Remove(item);
            magazineLetters.Add(item, currentCount + 1);
        }

        foreach (char item in ransomNote)
        {
            int currentCount = magazineLetters.GetValueOrDefault(item);

            if (currentCount == 0) 
                return false;

            magazineLetters.Remove(item);
            magazineLetters.Add(item, currentCount - 1);
        }

        return true;
    }
}
