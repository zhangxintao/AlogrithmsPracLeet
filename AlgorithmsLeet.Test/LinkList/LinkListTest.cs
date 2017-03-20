using System;
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

            AlgorithmsLeet.LinkList.LinkList list = new AlgorithmsLeet.LinkList.LinkList();

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
    }
}
