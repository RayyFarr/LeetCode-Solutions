
using System.Numerics;

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    string a = l1.val.ToString();
    string b = l2.val.ToString();
    while (l1.next != null)
    {
        a += l1.next.val;
        l1 = l1.next;
    }

    while (l2.next != null)
    {
        b += l2.next.val;
        l2 = l2.next;
    }
    a = Reverse(a);
    b = Reverse(b);
    string result = (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    return StringToList(result);

}

ListNode StringToList(string x)
{
    char[] chars = x.ToCharArray();
    int i = 1;
    Array.Reverse(chars);
    ListNode list = new ListNode(int.Parse(chars[0].ToString()));
    ListNode current = list;
    while (i < chars.Count())
    {
        current.next = new ListNode(int.Parse(chars[i].ToString()));
        current = current.next;
        i++;
    }
    return list;
}

string Reverse(string s)
{
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);

}
class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}