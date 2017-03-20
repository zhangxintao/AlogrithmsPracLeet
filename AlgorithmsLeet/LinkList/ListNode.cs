using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.LinkList
{
    public class ListNode
    {
        public ListNode()
        {

        }

        public ListNode(int val)
        {
            this.Val = val;
        }
        public int Val { get; set; }
        public ListNode Next { get; set; }
    }
}
