using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.LinkList;

namespace AlgorithmsLeet.Test.LinkList
{
    [TestClass]
    public class LinkListTest
    {
        [TestMethod]
        public void MergeTwoOrderedLinkList_Given_Two_Orders_LinkList()
        {
            ListNode l1 = new ListNode();
            var l1head = l1;
            l1.Val = 5;
            ListNode l12 = new ListNode();
            l12.Val = 15;
            l1.Next = l12;

            ListNode l2 = new ListNode();
            var l2head = l2;
            l2.Val = 10;
            ListNode l22 = new ListNode();
            l22.Val = 15;
            l2.Next = l22;
            ListNode l23 = new ListNode();
            l23.Val = 20;
            l22.Next = l23;

            var list = new AlgorithmsLeet.LinkList.LinkList();

            var result = list.MergeTwoOrderedLinkList(l1head, l2head);

            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Val);
            Assert.AreEqual(10, result.Next.Val);
            Assert.AreEqual(15, result.Next.Next.Val);
            Assert.AreEqual(15, result.Next.Next.Next.Val);
            Assert.AreEqual(20, result.Next.Next.Next.Next.Val);
            Assert.AreEqual(5, l1head.Val);
            Assert.AreEqual(10, l2head.Val);
        }

        [TestMethod]
        public void CircleLength()
        {
            var list = new AlgorithmsLeet.LinkList.LinkList();
            var node3 = new ListNode(3);
            var head = node3;
            var node8 = new ListNode(8);
            node3.Next = node8;
            var node7 = new ListNode(7);
            node8.Next = node7;
            var node1 = new ListNode(1);
            node7.Next = node1;
            var node2 = new ListNode(2);
            node1.Next = node2;
            var nodeSecond3 = new ListNode(3);
            node2.Next = nodeSecond3;
            var node4 = new ListNode(4);
            nodeSecond3.Next = node4;
            var node5 = new ListNode(5);
            node4.Next = node5;
            node5.Next = node1; 

            var result = list.CircleLength(head);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ReverseRecur_Given_LinkList_Return_Reversed_LinkList()
        {
            var list = new AlgorithmsLeet.LinkList.LinkList();
            var node2 = new ListNode(2);
            var head = node2;
            var node3 = new ListNode(3);
            node2.Next = node3;
            var node4 = new ListNode(4);
            node3.Next = node4;
            var node5 = new ListNode(5);
            node4.Next = node5;

            var result = list.ReverseRecur(head);

            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Val);
            Assert.AreEqual(4, result.Next.Val);
            Assert.AreEqual(3, result.Next.Next.Val);
            Assert.AreEqual(2, result.Next.Next.Next.Val);

        }

        [TestMethod]
        public void ReverseIter_Given_LinkList_Return_Reversed_LinkList()
        {
            var list = new AlgorithmsLeet.LinkList.LinkList();
            var node2 = new ListNode(2);
            var head = node2;
            var node3 = new ListNode(3);
            node2.Next = node3;
            var node4 = new ListNode(4);
            node3.Next = node4;
            var node5 = new ListNode(5);
            node4.Next = node5;

            var result = list.ReverseIter(head);

            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Val);
            Assert.AreEqual(4, result.Next.Val);
            Assert.AreEqual(3, result.Next.Next.Val);
            Assert.AreEqual(2, result.Next.Next.Next.Val);

        }

        [TestMethod]
        public void Add_Given_Two_Integers_Link_List_Return_Sum_Link_List()
        {
            var list = new AlgorithmsLeet.LinkList.LinkList();
            var l1 = new ListNode(2);
            var l1head = l1;
            l1.Next = new ListNode(4);
            l1 = l1.Next;
            l1.Next = new ListNode(6);

            var l2 = new ListNode(5);
            var l2head = l2;
            l2.Next = new ListNode(6);
            l2 = l2.Next;
            l2.Next = new ListNode(4);

            var result = list.Add(l1head, l2head);

            Assert.AreEqual(7, result.Val);
            Assert.AreEqual(0, result.Next.Val);
            Assert.AreEqual(1, result.Next.Next.Val);
            Assert.AreEqual(1, result.Next.Next.Next.Val);
        }

        [TestMethod]
        public void Partition_Given_Integer_List_With_Target_Return_Partitioned_List()
        {
            var l = new ListNode(4);
            var head = l;
            l.Next = new ListNode(3);
            l = l.Next;
            l.Next = new ListNode(2);
            l = l.Next;
            l.Next = new ListNode(1);
            l = l.Next;
            l.Next = new ListNode(2);
            l = l.Next;
            l.Next = new ListNode(5);
            var list = new AlgorithmsLeet.LinkList.LinkList();

            var result = list.Partition(head, 3);

            Assert.AreEqual(2, result.Val);
            Assert.AreEqual(1, result.Next.Val);
            Assert.AreEqual(2, result.Next.Next.Val);
            Assert.AreEqual(4, result.Next.Next.Next.Val);
            Assert.AreEqual(3, result.Next.Next.Next.Next.Val);
            Assert.AreEqual(5, result.Next.Next.Next.Next.Next.Val);
        }
    }
}
