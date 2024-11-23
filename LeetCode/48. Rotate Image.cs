namespace LeetCode;

public static partial class Solution
{
    // time complextity = O(row * col)
    // space complexity = O(1)
    public static void Rotate(int[][] matrix)
    {
        int row = matrix.Length;

        for (int i = 0; i < row; i++)
            for (int j = 0; j <= i; j++)
                (matrix[i][j], matrix[j][i]) =
                    (matrix[j][i], matrix[i][j]);

        foreach (int[] i in matrix)
            Array.Reverse(i);
    }
}
