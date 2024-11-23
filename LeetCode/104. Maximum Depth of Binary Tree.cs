namespace LeetCode;

public static partial class Solution
{
    public static int MaxDepth(TreeNode? root)
    {
        if (root == null) return 0;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;
    }
}
