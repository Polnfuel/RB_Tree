using System;

namespace RB_Tree
{
    public enum NodeColor
    {
        Red, Black
    }
    public class RB_Node<T> where T : IComparable<T>
    {
        public T Key;
        public RB_Node<T> Parent;
        public RB_Node<T> Left;
        public RB_Node<T> Right;
        public NodeColor Color;
        public RB_Node()
        {

        }
        public RB_Node(T key)
        {
            this.Key = key;
            this.Left = null;
            this.Right = null;
            this.Parent = null;
        }
    }
}
