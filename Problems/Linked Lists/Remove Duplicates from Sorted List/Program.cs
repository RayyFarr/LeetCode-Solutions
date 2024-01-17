ListNode DeleteDuplicates(ListNode head)
{
    if (head == null) return head;
    if (head.next != null && head.val == head.next.val)
    {
        if (head.next.next != null) head.next = head.next.next;
        else head.next = null;
        DeleteDuplicates(head);
    }
    else if (head.next != null)
        DeleteDuplicates(head.next);
    return head;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}