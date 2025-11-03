using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RB_Tree
{
    public partial class MainForm : Form
    {
        RB_Tree<int> tree;
        TreeDraw<int> drawing;
        public MainForm()
        {
            InitializeComponent();
            tree = new RB_Tree<int>();
            drawing = new TreeDraw<int>(drawPanel, NodeCountLabel, TreeDepthLabel, BlackDepthLabel, tree);
            HideButtons();
            InitButtonsLocations();
            manualToolStripMenuItem_Click(null, null);
            NodeCountLabel.Text = "0";
            TreeDepthLabel.Text = "0";
            BlackDepthLabel.Text = "0";
            label8.Text = string.Empty;
        }

        private void InitButtonsLocations()
        {
            label1.Location = new Point(this.ClientSize.Width / 2 - 74, label1.Location.Y);
            InsertTextBox.Location = new Point(this.ClientSize.Width / 2, InsertTextBox.Location.Y);
            InsertButton.Location = new Point(this.ClientSize.Width / 2, InsertButton.Location.Y);
            RandomButton.Location = new Point(this.ClientSize.Width / 2 - 40, RandomButton.Location.Y);
            Numeric.Location = new Point(this.ClientSize.Width / 2 + 40, Numeric.Location.Y);
            label2.Location = new Point(this.ClientSize.Width / 2 - 74, label2.Location.Y);
            DeleteTextBox.Location = new Point(this.ClientSize.Width / 2, DeleteTextBox.Location.Y);
            label7.Location = new Point(this.ClientSize.Width / 2 - 74, label7.Location.Y);
            SearchTextBox.Location = new Point(this.ClientSize.Width / 2, SearchTextBox.Location.Y);
            label9.Location = new Point(60, label9.Location.Y);
        }
        private void HideButtons()
        {
            label1.Visible = false;
            InsertTextBox.Visible = false;
            InsertButton.Visible = false;
            RandomButton.Visible = false;
            Numeric.Visible = false;
            label2.Visible = false;
            DeleteTextBox.Visible = false;
            label7.Visible = false;
            SearchTextBox.Visible = false;
            label8.Visible = false;
        }
        
        private void insertTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int key = Convert.ToInt32(InsertTextBox.Text);
                    tree.Insert(key);
                    drawing.Update();
                    InsertTextBox.Text = string.Empty;
                }
                catch
                {
                    return;
                }
            }
        }
        private void DeleteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int key = Convert.ToInt32(DeleteTextBox.Text);
                    tree.Delete(key);
                    drawing.Update();
                    DeleteTextBox.Text = string.Empty;
                }
                catch
                {
                    return;
                }
            }
        }
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int key = Convert.ToInt32(SearchTextBox.Text);
                    RB_Node<int> node = tree.Search(tree.root, key);
                    drawing.MarkNode(node);
                    if (node != tree.nil)
                    {
                        label8.Text = "Узел найден";
                    }
                    else
                    {
                        label8.Text = "Узел не найден!";
                    }
                    SearchTextBox.Text = string.Empty;
                }
                catch
                {
                    return;
                }
            }
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            string filename;
            InsertDialog.Filter = "Text File(*.txt)|*.txt";
            if (InsertDialog.ShowDialog() == DialogResult.OK)
            {
                filename = InsertDialog.FileName;
                LoadFromFile(filename);
            }
        }
        private void LoadFromFile(string filename)
        {
            string text = File.ReadAllText(filename);
            try
            {
                string[] strs = text.Trim().Split(',');
                int[] nums = new int[strs.Length];
                for (int i = 0; i < strs.Length; i++)
                {
                    nums[i] = Convert.ToInt32(strs[i]);
                }
                foreach (int num in nums)
                {
                    tree.Insert(num);
                }
                drawing.Update();
            }
            catch
            {
                MessageBox.Show("Wrong symbols in file", "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int count = Convert.ToInt32(Numeric.Value);
            for (int i = 0; i < count; i++)
            {
                tree.Insert(rand.Next(0, 100));
            }
            drawing.Update();
        }

        private void InsertInfo()
        {
            label9.Text = "Вставка узла в красно-черное дерево выполняется за O(log n)";
        }
        private void DeleteInfo()
        {
            label9.Text = "Удаление узла из красно-черного дерева выполняется за O(log n)";
        }
        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideButtons();
            label1.Visible = true;
            InsertTextBox.Visible = true;
            InsertInfo();
        }

        private void fromfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideButtons();
            InsertButton.Visible = true;
            InsertInfo();
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideButtons();
            RandomButton.Visible = true;
            Numeric.Visible = true;
            InsertInfo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideButtons();
            label2.Visible = true;
            DeleteTextBox.Visible = true;
            DeleteInfo();
        }
        private void deleteallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.ClearAll();
            drawing.Update();
        }

        private void searchtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideButtons();
            label7.Visible = true;
            SearchTextBox.Visible = true;
            label8.Visible = true;
            label8.Text = string.Empty;
            label9.Text = "Поиск узла в красно-черном дереве выполняется за O(log n)";
        }

        
    }
}
