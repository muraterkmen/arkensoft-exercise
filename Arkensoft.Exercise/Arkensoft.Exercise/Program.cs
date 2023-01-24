
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


Anagram anagram = new Anagram();
bool isAnagram = anagram.IsAnagram("anagram", "nagaram");

Console.WriteLine("isAnagram", isAnagram);

MissingNumber missingNumber = new MissingNumber();
var mNymber = missingNumber.FindMissingNumber(new int[] { 3, 0, 1 });

Console.WriteLine("MissingNumber [3,0,1] --> ", mNymber);

mNymber = missingNumber.FindMissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });

Console.WriteLine("MissingNumber [9,6,4,2,3,5,7,0,1] --> ", mNymber);


CountBits count = new CountBits();

int n = 2;
var bits = count.GetCountBits(n);

Console.WriteLine("Bits Count for " + n + " --> " + string.Join(",", bits));

n = 5;
bits = count.GetCountBits(n);

Console.WriteLine("Bits Count for " + n + " --> " + string.Join(",", bits));

MyAtoi myAtoi = new MyAtoi();
var atoi = myAtoi.GetMyAtoi("3.45646");

Console.WriteLine("atoi --> " + atoi);

IntersectionofTwoArrays intersectionofTwo = new IntersectionofTwoArrays();
var result = intersectionofTwo.Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });

Console.WriteLine("Intersection(new int[] { 4, 9, 5 },new int[] { 9, 4, 9, 8, 4 }) --> " + string.Join(",", result));

int num = 104976;
PerfectSquare perfectSquare = new PerfectSquare();
var isPerfect = perfectSquare.IsPerfectSquare(num);

Console.WriteLine($"{num} is perfect square ? Answer is {isPerfect}");

string str = "ee";
FirstUniqChar firstUniqChar = new FirstUniqChar();
var index = firstUniqChar.FindFirstUniqChar(str);
Console.WriteLine($"{str} first unique charackter index is {index}");