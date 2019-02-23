using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            var currLeftNode = l1;
            var currRigthNode = l2;
            ListNode head;

            if (currLeftNode != null && (currRigthNode == null || currLeftNode.val < currRigthNode.val))
            {
                head = currLeftNode;
                currLeftNode = head.next;
            }
            else
            {
                head = currRigthNode;
                currRigthNode = head.next;
            }

            ListNode currNode;
            currNode = head;
            while (currLeftNode!=null || currRigthNode != null)
            {
                if (currLeftNode != null && (currRigthNode == null || currLeftNode.val < currRigthNode.val))
                {
                    currNode.next = currLeftNode;
                    currLeftNode = currLeftNode.next;
                }
                else
                {
                    currNode.next = currRigthNode;
                    currRigthNode = currRigthNode.next;
                }
                currNode = currNode.next;
            }

            return head;
        }

        static void Main(string[] args)
        {
            MergeTwoLists(
                new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(4)
                        {
                            next = null
                        }
                    }
                },
                new ListNode(1)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = null
                        }
                    }
                });

        }
    }
}
