using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class PalindromeSolutions
    {
        /// <summary>
        /// 234. Palindrome Linked List
        /// Given the head of a singly linked list, return true if it is a palindrome or false otherwise
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            bool isPalnd = true;
            List<int> list = new List<int>();

            var temp = head;

            while (temp != null)
            {
                list.Add(temp.val);
                temp = temp.next;
            }

            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - i-1])
                {
                    isPalnd = false;
                    break;
                }
            }

            return isPalnd;
        }

        public bool IsPalindrome2(ListNode head)
        {
            bool isPalnd = true;
            List<int> list = new List<int>();

            var temp = head;

            while (temp != null)
            {
                list.Add(temp.val);
                temp = temp.next;
            }

            int front = 0; 
            int back = list.Count - 1;

            while (front < back)
            {
                if (list[front] != list[back])
                {
                    isPalnd = false;
                    break;
                }

                front++;
                back--;
            }

            return isPalnd;
        }
    }
}
