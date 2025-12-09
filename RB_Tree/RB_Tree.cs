namespace RB_Tree
{
    public class RB_Tree<T> where T : IComparable<T>
    {
        public RB_Node<T> root;
        public RB_Node<T> nil;
        public RB_Tree()
        {
            this.nil = new RB_Node<T>();
            this.nil.Color = NodeColor.Black;
            this.root = this.nil;
            this.root.Parent = nil;
        }
        public void Insert(T key)
        {
            RB_Node<T> z = new RB_Node<T>(key);
            RB_Node<T> y = nil;
            RB_Node<T> x = this.root;
            while (x != nil)
            {
                y = x;
                if (z.Key.CompareTo(x.Key) < 0)
                    x = x.Left;
                else
                    x = x.Right;
            }
            z.Parent = y;
            if (y == nil)
                this.root = z;
            else if (z.Key.CompareTo(y.Key) < 0)
                y.Left = z;
            else
                y.Right = z;
            z.Left = nil;
            z.Right = nil;
            z.Color = NodeColor.Red;
            InsertBalance(z);
        }
        private void LeftRotate(RB_Node<T> x)
        {
            if (x.Right == nil) return;

            RB_Node<T> y = x.Right;
            x.Right = y.Left;
            if (y.Left != nil)
                y.Left.Parent = x;
            y.Parent = x.Parent;
            if (x.Parent == nil)
                this.root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else
                x.Parent.Right = y;
            y.Left = x;
            x.Parent = y;
        }
        private void RightRotate(RB_Node<T> x)
        {
            if (x.Left == nil) return;

            RB_Node<T> y = x.Left;
            x.Left = y.Right;
            if (y.Right != nil)
                y.Right.Parent = x;
            y.Parent = x.Parent;
            if (x.Parent == nil)
                this.root = y;
            else if (x == x.Parent.Right)
                x.Parent.Right = y;
            else
                x.Parent.Left = y;
            y.Right = x;
            x.Parent = y;
        }
        private void InsertBalance(RB_Node<T> z)
        {
            RB_Node<T> y;
            while (z.Parent.Color == NodeColor.Red)
            {
                if (z.Parent == z.Parent.Parent.Left)
                {
                    y = z.Parent.Parent.Right;
                    if (y.Color == NodeColor.Red)
                    {
                        z.Parent.Color = NodeColor.Black;
                        y.Color = NodeColor.Black;
                        z.Parent.Parent.Color = NodeColor.Red;
                        z = z.Parent.Parent;
                    }
                    else
                    {
                        if (z == z.Parent.Right)
                        {
                            z = z.Parent;
                            LeftRotate(z);
                        }
                        z.Parent.Color = NodeColor.Black;
                        z.Parent.Parent.Color = NodeColor.Red;
                        RightRotate(z.Parent.Parent);
                    }
                }
                else
                {
                    y = z.Parent.Parent.Left;
                    if (y.Color == NodeColor.Red)
                    {
                        z.Parent.Color = NodeColor.Black;
                        y.Color = NodeColor.Black;
                        z.Parent.Parent.Color = NodeColor.Red;
                        z = z.Parent.Parent;
                    }
                    else
                    {
                        if (z == z.Parent.Left)
                        {
                            z = z.Parent;
                            RightRotate(z);
                        }
                        z.Parent.Color = NodeColor.Black;
                        z.Parent.Parent.Color = NodeColor.Red;
                        LeftRotate(z.Parent.Parent);
                    }
                }
            }
            this.root.Color = NodeColor.Black;
        }

        private RB_Node<T> Successor(RB_Node<T> x)
        {
            if (x.Right != nil)
            {
                RB_Node<T> z = x.Right;
                while (z.Left != nil)
                    z = z.Left;
                return z;
            }
            RB_Node<T> y = x.Parent;
            while (y != nil && x == y.Right)
            {
                x = y;
                y = y.Parent;
            }
            return y;
        }
        public RB_Node<T> Search(RB_Node<T> node, T key)
        {
            if (node == nil || key.CompareTo(node.Key) == 0)
                return node;
            if (key.CompareTo(node.Key) == -1)
                return Search(node.Left, key);
            else
                return Search(node.Right, key);
        }
        public void ClearAll()
        {
            this.root = nil;
            this.root.Parent = nil;
        }
        public void Delete(T key)
        {
            RB_Node<T> node = Search(root, key);
            if (node == nil) return;

            RB_Node<T> y, x;
            if (node.Left == nil || node.Right == nil)
                y = node;
            else
                y = Successor(node);
            if (y.Left != nil)
                x = y.Left;
            else
                x = y.Right;
            x.Parent = y.Parent;
            if (y.Parent == nil)
                root = x;
            else if (y == y.Parent.Left)
                y.Parent.Left = x;
            else
                y.Parent.Right = x;
            if (y != node)
                node.Key = y.Key;
            if (y.Color == NodeColor.Black)
                DeleteBalance(x);
        }
        private void DeleteBalance(RB_Node<T> x)
        {
            while (x != root && x.Color == NodeColor.Black)
            {
                if (x == x.Parent.Left)
                {
                    RB_Node<T> w = x.Parent.Right;
                    if (w.Color == NodeColor.Red)
                    {
                        w.Color = NodeColor.Black;
                        x.Parent.Color = NodeColor.Red;
                        LeftRotate(x.Parent);
                        w = x.Parent.Right;
                    }
                    if (w.Left.Color == NodeColor.Black && w.Right.Color == NodeColor.Black)
                    {
                        w.Color = NodeColor.Red;
                        x = x.Parent;
                    }
                    else
                    {
                        if (w.Right.Color == NodeColor.Black)
                        {
                            w.Left.Color = NodeColor.Black;
                            w.Color = NodeColor.Red;
                            RightRotate(w);
                            w = x.Parent.Right;
                        }
                        w.Color = x.Parent.Color;
                        x.Parent.Color = NodeColor.Black;
                        w.Right.Color = NodeColor.Black;
                        LeftRotate(x.Parent);
                        x = root;
                    }
                }
                else
                {
                    RB_Node<T> w = x.Parent.Left;
                    if (w.Color == NodeColor.Red)
                    {
                        w.Color = NodeColor.Black;
                        x.Parent.Color = NodeColor.Red;
                        RightRotate(x.Parent);
                        w = x.Parent.Left;
                    }
                    if (w.Right.Color == NodeColor.Black && w.Left.Color == NodeColor.Black)
                    {
                        w.Color = NodeColor.Red;
                        x = x.Parent;
                    }
                    else
                    {
                        if (w.Left.Color == NodeColor.Black)
                        {
                            w.Right.Color = NodeColor.Black;
                            w.Color = NodeColor.Red;
                            LeftRotate(w);
                            w = x.Parent.Left;
                        }
                        w.Color = x.Parent.Color;
                        x.Parent.Color = NodeColor.Black;
                        w.Left.Color = NodeColor.Black;
                        RightRotate(x.Parent);
                        x = root;
                    }
                }
            }
            x.Color = NodeColor.Black;
        }
    }
}
