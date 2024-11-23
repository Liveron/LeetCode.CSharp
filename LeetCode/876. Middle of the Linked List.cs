namespace LeetCode;

public static partial class Solution
{
    public static ListNode? MiddleNode(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;
        }

        return slow;
    }
}
