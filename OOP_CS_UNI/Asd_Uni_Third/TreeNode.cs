using System;
using System.Collections.Generic;

namespace Asd_Uni_Third
{
    public class TreeNode<T>
    {
        public T value { get; set; }
        public List<TreeNode<T>> children = new List<TreeNode<T>>();


        public TreeNode(T _value)
        {
            value = _value;
            this.children = new List<TreeNode<T>>();
        }
        public void AddChild(TreeNode<T> child)
        {
            children.Add(child);
        }
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }

    
}

