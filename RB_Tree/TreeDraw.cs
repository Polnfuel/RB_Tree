using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RB_Tree
{
    public class TreeDraw<T> where T : IComparable<T>
    {
        private Graphics g;
        private Font font;
        private Panel drawpanel;
        private RB_Tree<T> tree;

        private Label countlabel;
        private Label depthlabel;
        private Label blackdepthlabel;

        private Dictionary<RB_Node<T>, Point> positions;
        private int totalwidth;
        public TreeDraw(Panel panel, Label count, Label depth, Label blackdepth, RB_Tree<T> rb_tree)
        {
            font = new Font("Segoe UI", 12, FontStyle.Bold);
            drawpanel = panel;
            drawpanel.Paint += new PaintEventHandler(DrawPanel_Paint);
            countlabel = count;
            depthlabel = depth;
            blackdepthlabel = blackdepth;
            g = drawpanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            tree = rb_tree;
            positions = new Dictionary<RB_Node<T>, Point>();
        }
        
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            if (tree.root != tree.nil)
                DrawTree();
        }
        public void Update()
        {
            positions.Clear();
            totalwidth = CalculateNodePosition(tree.root, 0, 0);
            drawpanel.Invalidate();
            UpdateStatistics();
        }
        
        private const int NODE_RADIUS = 15;
        private const int VERTICAL_SPACING = 35;
        private int CalculateNodePosition(RB_Node<T> node, int offset, int depth)
        {
            if (node == tree.nil) return 0;

            int nodewidth = NODE_RADIUS + 2; 

            int left = CalculateNodePosition(node.Left, offset, depth + 1);
            int right = CalculateNodePosition(node.Right, offset + left + nodewidth, depth + 1);

            int curx = offset + left + nodewidth / 2;
            int cury = depth * VERTICAL_SPACING + 40;

            positions[node] = new Point(curx, cury);

            return left + nodewidth + right;
        }

        private void DrawTree()
        {
            g.Clear(Color.White);

            int xoffset = (drawpanel.Width - totalwidth) / 2;

            foreach (var kvp in positions)
            {
                var node = kvp.Key;
                Point pos = kvp.Value;
                int x = pos.X + xoffset;
                int y = pos.Y;

                if (node.Left != tree.nil && positions.ContainsKey(node.Left))
                {
                    Point leftpos = positions[node.Left];
                    g.DrawLine(Pens.Black, x, y, leftpos.X + xoffset, leftpos.Y);
                }

                if (node.Right != tree.nil && positions.ContainsKey(node.Right))
                {
                    Point rightpos = positions[node.Right];
                    g.DrawLine(Pens.Black, x, y, rightpos.X + xoffset, rightpos.Y);
                }
            }

            foreach (var kvp in positions)
            {
                var node = kvp.Key;
                Point pos = kvp.Value;
                int x = pos.X + xoffset;
                int y = pos.Y;

                Brush brush = node.Color == NodeColor.Red ? Brushes.Red : Brushes.Black;

                g.FillEllipse(brush, x - NODE_RADIUS, y - NODE_RADIUS, NODE_RADIUS * 2, NODE_RADIUS * 2);

                string keystring = node.Key.ToString();
                int textwidth = (int)g.MeasureString(keystring, font).Width;
                int textheight = (int)g.MeasureString(keystring, font).Height;
                g.DrawString(keystring, font, Brushes.White, x - textwidth / 2, y - textheight / 2);
            }
        }

        private int SubTreeDepth(RB_Node<T> node)
        {
            if (node == tree.nil) return 0;

            int left = SubTreeDepth(node.Left) + 1;
            int right = SubTreeDepth(node.Right) + 1;

            return Math.Max(left, right);
        }
        private void SubTreeCount(RB_Node<T> node, ref int count)
        {
            if (node != tree.nil)
            {
                SubTreeCount(node.Left, ref count);
                count++;
                SubTreeCount(node.Right, ref count);
            }
        }
        private void TreeBlackDepth(RB_Node<T> node, ref int count)
        {
            if (node != tree.nil)
            {
                TreeBlackDepth(node.Left, ref count);
                if (node.Color == NodeColor.Black) count++;
            }
        }
        private void UpdateStatistics()
        {
            int nodecount = 0;
            SubTreeCount(tree.root, ref nodecount);
            int depth = SubTreeDepth(tree.root);
            int blackdepth = 0;
            TreeBlackDepth(tree.root, ref blackdepth);
            countlabel.Text = nodecount.ToString();
            depthlabel.Text = depth.ToString();
            blackdepthlabel.Text = blackdepth.ToString();
        }
        public void MarkNode(RB_Node<T> node)
        {
            DrawTree();
            foreach (var kvp in positions)
            {
                if (kvp.Key == node)
                {
                    Point pos = kvp.Value;
                    pos.X = (drawpanel.Width - totalwidth) / 2 + pos.X;
                    Pen pen = new Pen(Color.Gold, 3.0f);
                    g.DrawEllipse(pen, pos.X - NODE_RADIUS - pen.Width / 2, pos.Y - NODE_RADIUS - pen.Width / 2, (NODE_RADIUS) * 2 + pen.Width, (NODE_RADIUS) * 2 + pen.Width);
                    break;
                }
            }
            
        }
    }
}
