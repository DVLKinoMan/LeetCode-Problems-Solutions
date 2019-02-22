using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Nth_Node_From_End_of_List
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var nodes = new List<ListNode>();
            var currNode = head;
            while (currNode != null)
            {
                nodes.Add(currNode);
                currNode = currNode.next;
            }
            if (nodes.Count - n - 1 >= 0)
                nodes.ElementAt(nodes.Count - n - 1).next = n != 1 ? nodes.ElementAt(nodes.Count - (n - 1)) : null;
            else
                return nodes.Count - (n - 1) >= nodes.Count ? null : nodes.ElementAt(nodes.Count - (n - 1));

            return head;
        }

        static void Main(string[] args)
        {
        }
    }
}
