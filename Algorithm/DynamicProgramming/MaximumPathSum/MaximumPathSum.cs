//Reference : http://www.geeksforgeeks.org/find-maximum-path-sum-in-a-binary-tree/
using System;

namespace Algorithm.DynamicProgramming.MaximumPathSum
{
    public class Node
    {

        public int Value;
        public Node Left, Right;

        public Node(int item)
        {
            Value = item;
            Left = Right = null;
        }
    }

    class Res
    {
        public int Val;
    }

    public class MaximumPathSum
    {
        Node _root;
        int FindMaxUtil(Node node, Res res)
        {
            if (node == null) return 0;
            int l = FindMaxUtil(node.Left, res);
            int r = FindMaxUtil(node.Right, res);
            int maxSingle = Math.Max(Math.Max(l, r) + node.Value, node.Value);
            int maxTop = Math.Max(maxSingle, l + r + node.Value);
            res.Val = Math.Max(res.Val, maxTop);
            return maxSingle;
        }

        int FindMaxSum()
        {
            return FindMaxSum(_root);
        }

        int FindMaxSum(Node node)
        {
            Res res = new Res {Val = Int32.MinValue};
            FindMaxUtil(node, res);
            return res.Val;
        }

        public static int Main()
        {
            MaximumPathSum tree = new MaximumPathSum
            {
                _root = new Node(10)
                {
                    Left = new Node(2),
                    Right = new Node(10)
                }
            };
            tree._root.Left.Left = new Node(20);
            tree._root.Left.Right = new Node(1);
            tree._root.Right.Right = new Node(-25)
            {
                Left = new Node(3),
                Right = new Node(4)
            };
            return tree.FindMaxSum();
        }
    }
}
