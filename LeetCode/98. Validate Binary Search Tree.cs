namespace LeetCode;

public static partial class Solution
{
    public static bool IsValidBST(TreeNode root)
    {
        return IsValidLeft(root.left, root.val, null) && 
            IsValidRight(root.right, root.val, null);

        bool IsValidLeft(TreeNode? node, int val, int? min)
        {
            if (node == null) return true;
            if (node.val >= val) return false;
            if (min != null && node.val <= min) return false;

            return IsValidLeft(node.left, node.val, min) && 
                IsValidRight(node.right, node.val, val);
        }

        bool IsValidRight(TreeNode? node, int val, int? max)
        {
            if (node == null) return true;
            if (node.val <= val) return false;
            if (max != null && node.val >= max) return false;

            return IsValidLeft(node.left, node.val, val) && 
                IsValidRight(node.right, node.val, max);
        }
    }
}
