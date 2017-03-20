using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.LinkList
{
    public class LinkList
    {
        #region Merge two ordered link list
        public ListNode MergeTwoOrderedLinkList(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            var head1 = l1;
            var head2 = l2;
            var dummy = new ListNode();
            var head = dummy;
            while (head1 != null && head2 != null)
            {
                if (head1.Val <= head2.Val)
                {
                    dummy.Next = head1;
                    head1 = head1.Next;
                }
                else
                {
                    dummy.Next = head2;
                    head2 = head2.Next;
                }
                dummy = dummy.Next;
            }

            if (head2 != null)
            {
                dummy.Next = head2;
            }
            if (head1 != null)
            {
                dummy.Next = head1;
            }


            return head.Next;
        }
        #endregion
    }
}
