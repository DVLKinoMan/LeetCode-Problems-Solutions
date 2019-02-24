using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_k_Sorted_Lists
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //My version. Right but it is better not to create List
        //public static ListNode MergeKLists(ListNode[] lists)
        //{
        //    var list = lists.ToList();
        //    while (list.Count > 1)
        //    {
        //        var first = list.ElementAt(0);
        //        var second = list.ElementAt(1);
        //        var merged = MergeTwoLists(first, second);
        //        list.RemoveAt(0);
        //        list.RemoveAt(0);
        //        list.Add(merged);
        //    }

        //    return list.Count == 0 ? null : list.First();
        //}

        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
                return null;

            int interval = 1;
            while (interval < lists.Length)
            {
                for (int i = 0; i < lists.Length; i += interval*2)
                    if (i + interval < lists.Length)
                        lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
                interval *= 2;
            }

            return lists[0];
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
            while (currLeftNode != null || currRigthNode != null)
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
            MergeKLists(
                new ListNode[]
                {
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
                },
                new ListNode(6)
                {
                    next = new ListNode(8)
                    {
                        next = new ListNode(12)
                        {
                            next = null
                        }
                    }
                },
                }
                );
        }
    }
}
