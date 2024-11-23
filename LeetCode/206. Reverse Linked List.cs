namespace LeetCode;

public static partial class Solution
{
    // time complexity = O(n)
    // space complexity = O(1)
    public static ListNode? ReverseList(ListNode? head)
    {
        if (head?.next == null) return head;

        ListNode? next = head.next;
        ListNode? nextNext;
        head.next = null;

        while (next != null)
        {
            nextNext = next?.next;
            next.next = head;
            head = next;
            next = nextNext;
        }

        return head;
    }
}
