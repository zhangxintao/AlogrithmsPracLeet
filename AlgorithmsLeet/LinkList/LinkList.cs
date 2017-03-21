using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        #region cicle length

        public int CircleLength(ListNode head)
        {
            if (head == null || head.Next == null)
            {
                return 0;
            }

            var slow = head;
            var fast = head.Next;

            while (slow != null && fast != null)
            {
                if (slow == fast)
                {
                    break;
                }
                else
                {
                    slow = slow.Next;

                    if (fast.Next == null)
                    {
                        return 0;
                    }
                    else
                    {
                        fast = fast.Next.Next;
                    }
                }
            }

            if (slow != fast)
            {
                return 0;
            }

            int length = 1;
            var found = slow;
            slow = slow.Next;
            while (slow != found)
            {
                slow = slow.Next;
                length++;
            }

            return length;
        }

        #endregion

        #region Reverse

        public ListNode ReverseRecur(ListNode head)
        {
            if (head.Next == null)
            {
                return head;
            }

            var newHead = ReverseRecur(head.Next);
            head.Next.Next = head;
            head.Next = null;

            return newHead;
        }

        public ListNode ReverseIter(ListNode head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            while (head.Next != null)
            {
                var next = head.Next;
                head.Next = null;
                next.Next = head;
                head = next;
            }

            return head;
        }
        #endregion

        #region Add two integers

        public ListNode Add(ListNode l1, ListNode l2)
        {
            ListNode l3 = new ListNode(0);
            var head = l3;
            int carry = 0;
            var l1Value = 0;
            var l2Value = 0;
            var l1Head = l1;
            var l2Head = l2;

            while (l1Head != null || l2Head != null || carry > 0)
            {
                l1Value = l1Head == null ? 0 : l1Head.Val;
                l2Value = l2Head == null ? 0 : l2Head.Val;

                l3.Next = new ListNode((l1Value + l2Value + carry)%10);
                carry = (l1Value + l2Value + carry)/10;
                l3 = l3.Next;

                l1Head = l1Head == null ? null : l1Head.Next;
                l2Head = l2Head == null ? null : l2Head.Next;
            }

            return head.Next;
        }

        #endregion

        #region Partition

        public ListNode Partition(ListNode l, int target)
        {
            var dummyFirst = new ListNode(0);
            var firstHead = dummyFirst;
            var dummySec = new ListNode(0);
            var secHead = dummySec;

            while (l != null)
            {
                if (l.Val < target)
                {
                    dummyFirst.Next = new ListNode(l.Val);
                    dummyFirst = dummyFirst.Next;
                }
                else
                {
                    dummySec.Next = new ListNode(l.Val);
                    dummySec = dummySec.Next;
                }
                l = l.Next;
            }
            dummyFirst.Next = secHead.Next;

            return firstHead.Next;
        }

        #endregion

        #region remove duplicates

        public ListNode RemoveDuplicates(ListNode l)
        {
            if (l == null || l.Next == null)
            {
                return l;
            }

            ListNode prev = l;
            ListNode iter = l.Next;
            ListNode head = new ListNode(prev.Val);
            ListNode resulthead = head;

            while (iter != null)
            {
                if (iter.Val != prev.Val)
                {
                    head.Next = new ListNode(iter.Val);
                    head = head.Next;
                    prev = iter;
                }
                iter = iter.Next;
            }

            return resulthead;
        }

        #endregion
    }
}
