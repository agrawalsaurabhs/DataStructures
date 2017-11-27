namespace DataStructures.LinkedList
{
    public class IdentialLinkedList
    {
        public static bool IsIdentical(Node head1, Node head2)
        {
            if (head1 == null || head2 == null)
            {
                return false;
            }
            //only on element left
            if (head1.Next == null && head2.Next == null)
            {
                return head1.Data == head2.Data;
            }

            return (head1.Data == head2.Data) && IsIdentical(head1.Next, head2.Next);
        }
    }
}