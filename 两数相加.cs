using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public static ListNode Create (int[] arrayVals)
        {
            ListNode node = new ListNode(0,null);
            ListNode root = node;
            for (int i = 0;i < arrayVals.Length; i++)
            {
                node.val = arrayVals[i];
                if(i + 1 < arrayVals.Length)
                {
                    node.next = new ListNode(0,null);
                    node = node.next;
                }
            }
            return root;
        }
    }
    public class 两数相加
    {

        public static void Test()
        {
            int[] l1 = new int[] { 9};
            int[] l2 = new int[] { 9,9,9,9 };
            ListNode retNode = AddTwoNumbers(ListNode.Create(l1), ListNode.Create(l2));
            while (null != retNode)
            {
                Console.WriteLine(retNode.val);
                retNode = retNode.next;
            }
            Console.ReadKey();
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode();
            ListNode root = node;
            ListNode parent = null;
            ListNode l1Tmp = l1;
            ListNode l2Tmp = l2;
            int uperVal = 0;
            while (true)
            {
                if (null == l1Tmp && null == l2Tmp)
                {
                    if (uperVal != 0)
                        node.val = uperVal;
                    if (null != node && node.val == 0)
                    {
                        parent.next = null;
                    }
                    return root;
                }
                int l1TmpVal = null != l1Tmp ? l1Tmp.val : 0;
                int l2TmpVal = null != l2Tmp ? l2Tmp.val : 0;
                int val = (l1TmpVal + l2TmpVal + uperVal) % 10;
                uperVal = (l1TmpVal + l2TmpVal + uperVal) / 10;
                node.val = val;
                parent = node;
                node.next = new ListNode();
                node = node.next;
                if (null != l1Tmp)
                    l1Tmp = l1Tmp.next;
                if (null != l2Tmp)
                    l2Tmp = l2Tmp.next;
            }
            return root;
        }
    }
}
