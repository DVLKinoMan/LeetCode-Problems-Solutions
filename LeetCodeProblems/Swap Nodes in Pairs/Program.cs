using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Nodes_in_Pairs
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null)
                return null;

            var prevNode = head;
            var result = prevNode.next ?? prevNode;

            ListNode prevPrevNode = null;
            while (prevNode != null)
            {
                var nextNode = prevNode.next;
                if (nextNode != null)
                {
                    if (prevPrevNode != null)
                        prevPrevNode.next = nextNode;
                    prevNode.next = nextNode.next;
                    nextNode.next = prevNode;
                    prevPrevNode = prevNode;
                }
                prevNode = prevNode.next;
            }

            return result;
        }
        static void Main(string[] args)
        {
            SwapPairs(new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = null
                        }
                    }
                }
            });
        }
    }
}
