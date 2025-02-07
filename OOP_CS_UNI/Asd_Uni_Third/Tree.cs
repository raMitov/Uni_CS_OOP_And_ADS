using System;
using System.Collections.Generic;

namespace Asd_Uni_Third
{
    public class Tree<T>
    {
        public TreeNode<T> Root {get; set;}
        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }

        public Tree(T value, params Tree<T>[] subTrees) : this(value)
        {
            foreach (var child in subTrees)
            {
                this.Root.AddChild(child.Root);
            }
        }

        public void DFS()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(this.Root);
            while (stack.Count > 0)
            {
                TreeNode<T> node = stack.Pop();
                Console.Write(node.value);
                for (int i = 0; i < node.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = node.GetChild(i);

                    stack.Push(childNode);
                }
            }
        }
    }
}