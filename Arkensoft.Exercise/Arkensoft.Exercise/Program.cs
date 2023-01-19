
using Arkensoft.Exercise;
using System.Linq;

FrequencyQueries frequency = new FrequencyQueries();

SummaryRanges ranges = new SummaryRanges();
var summary = ranges.GetSummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 });

Console.WriteLine("[0, 1, 2, 4, 5, 7] --> " + string.Join(',', summary));

summary = ranges.GetSummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 });

Console.WriteLine("[0, 2, 3, 4, 6, 8, 9] --> " + string.Join(',', summary));


InvertBinaryTree binaryTree = new InvertBinaryTree();

TreeNode root = new TreeNode(4);
root.left = new TreeNode(2);
root.right = new TreeNode(7);
root.left.left = new TreeNode(1);
root.left.right = new TreeNode(3);
root.right.left = new TreeNode(6);
root.right.right = new TreeNode(9);


Console.WriteLine();

binaryTree.PrintRightToLeft(root);

binaryTree.InvertTree(root);

Console.WriteLine();

binaryTree.PrintRightToLeft(root);

Console.WriteLine();

Console.WriteLine("NumberOfLeaves -->" + binaryTree.NumberOfLeaves(root));

var palindrome = new PalindromeSolutions();
var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(2);
head.next.next.next.next = new ListNode(1);

palindrome.IsPalindrome(head);

palindrome.IsPalindrome2(head);

Console.WriteLine("End");

