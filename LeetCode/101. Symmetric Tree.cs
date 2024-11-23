namespace LeetCode;

public static partial class Solution
{
    public static bool IsSymmetric(TreeNode root)
    {
        return IsMirror(root.left, root.right);

        static bool IsMirror(TreeNode? left, TreeNode? right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.val == right.val && 
                IsMirror(left.left, right.right) && 
                IsMirror(left.right, right.left);
        }
    }
}
