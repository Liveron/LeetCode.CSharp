namespace LeetCode;

public static partial class Solution
{
    // time complexity = O(n)
    // space complexity = O(1)
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        int counter = 0;
        ListNode? start = head;
        ListNode? end = head;

        while (counter < n)
        {
            end = end?.next;
            counter++;
        }

        while (end?.next != null)
        {
            start = start?.next;
            end = end.next;
        }

        if (end == null) return start?.next;
        else start.next = start?.next?.next;
        
        return head;
    }
}
