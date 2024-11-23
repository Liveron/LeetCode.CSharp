namespace LeetCode;

public static partial class Solution
{
    // time complexity = O(1)
    // space complexity = O(1)
    public static void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
