namespace LeetCode;

public static partial class Solution
{
    public static bool IsValidSudoku(char[][] board)
    {
        int N = 9;

        var rows = new HashSet<char>[N];
        var cols = new HashSet<char>[N];
        var blocks = new HashSet<char>[N];

        for (int r = 0; r < N; r++)
        {
            rows[r] = [];
            cols[r] = [];
            blocks[r] = [];
        }

        for (int r = 0; r < N; r++)
        {
            for (int c = 0; c < N; c++)
            {
                char val = board[r][c];

                if (val == '.')
                    continue;

                if (rows[r].Contains(val))
                    return false;
                rows[r].Add(val);

                if (cols[c].Contains(val))
                    return false;
                cols[c].Add(val);

                int idx = r / 3 * 3 + c / 3;

                if (blocks[idx].Contains(val))
                    return false;
                blocks[idx].Add(val);
            }
        }

        return true;
    }
}
