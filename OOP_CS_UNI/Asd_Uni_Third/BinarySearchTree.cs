

using System;

namespace Asd_Uni_Third
{
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        public T value{get;set;}
        public BinaryTreeNode<T> leftChild { get; set; }
        public BinaryTreeNode<T> rightChild { get; set; }

        public BinaryTreeNode(T _value)
        {
            value = _value;
        }

        internal class BinarySearchtree<T> where T : IComparable<T>
        {
            public BinaryTreeNode<T> root {get;set;}
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }
    }
}