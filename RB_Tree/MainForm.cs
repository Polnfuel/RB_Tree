using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace RB_Tree
{
    public partial class MainForm : Form
    {
        private RB_Tree<int> tree;
        private TreeDraw<int> drawing;
        private string logpath;
        public MainForm()
        {
            InitializeComponent();
            tree = new RB_Tree<int>();
            drawing = new TreeDraw<int>(DrawPanel, NodeCountLabel, TreeDepthLabel, BlackDepthLabel, tree);
            HideButtons();
            InitButtonsLocations();
            Manual_Insert(null, null);
            NodeCountLabel.Text = "0";
            TreeDepthLabel.Text = "0";
            BlackDepthLabel.Text = "0";
            label8.Text = string.Empty;
            logpath = "tree.log";
            if (!File.Exists(logpath)) 
                File.Create(logpath).Close();
            InitToolTip();
            DrawPanel.Size = new Size(this.ClientSize.Width - 20, DrawPanel.Height);
        }

        private void InitButtonsLocations()
        {
            label1.Location = new Point(this.ClientSize.Width / 2 - 74, label1.Location.Y);
            InsertTextBox.Location = new Point(this.ClientSize.Width / 2, InsertTextBox.Location.Y);
            FromFileButton.Location = new Point(this.ClientSize.Width / 2, FromFileButton.Location.Y);
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
            FromFileButton.Visible = false;
            RandomButton.Visible = false;
            Numeric.Visible = false;
            label2.Visible = false;
            DeleteTextBox.Visible = false;
            label7.Visible = false;
            SearchTextBox.Visible = false;
            label8.Visible = false;
        }
        private void InitToolTip()
        {
            toolTip1.SetToolTip(ManInsertButton, "Вставить узел");
            toolTip1.SetToolTip(FileInsertButton, "Вставить узлы из файла");
            toolTip1.SetToolTip(RandInsertButton, "Вставить случайные узлы");
            toolTip1.SetToolTip(ManDeleteButton, "Удалить узел");
            toolTip1.SetToolTip(AllDeleteButton, "Очистить поле");
            toolTip1.SetToolTip(SearchButton, "Найти узел");
            toolTip1.SetToolTip(OpenLogButton, "Открыть файл журнала");
        }
        
        private void InsertTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int key = Convert.ToInt32(InsertTextBox.Text);
                    if (key < 1000 && key > -100)
                    {
                        tree.Insert(key);
                        drawing.Update();
                        InsertTextBox.Text = string.Empty;
                        AddLog("вставка узла", key.ToString());
                    }
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
                    AddLog("удаление узла", key.ToString());
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
                        AddLog("поиск узла", key.ToString(), " - найден");
                    }
                    else
                    {
                        label8.Text = "Узел не найден!";
                        AddLog("поиск узла", key.ToString(), " - не найден");
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
                string[] nums = new string[strs.Length];
                int i = 0;
                foreach (string str in strs)
                {
                    int num = Convert.ToInt32(str);
                    if (num > -100 && num < 1000)
                    {
                        nums[i++] = str;
                        tree.Insert(num);
                    }
                }
                AddLog($"вставка узлов из файла {Path.GetFileName(filename)}", string.Join(",", nums, 0, i), " - успешно");
                drawing.Update();
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка при извлечении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int count = Convert.ToInt32(Numeric.Value);
            int[] nums = new int[count];
            for (int i = 0; i < count; i++)
            {
                int num = rand.Next(0, 1000);
                nums[i] = num;
                tree.Insert(num);
            }
            AddLog("вставка случайных узлов", string.Join(",", nums));
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

        private void Manual_Insert(object sender, EventArgs e)
        {
            HideButtons();
            label1.Visible = true;
            InsertTextBox.Visible = true;
            InsertInfo();
        }
        private void FromFile_Insert(object sender, EventArgs e)
        {
            HideButtons();
            FromFileButton.Visible = true;
            InsertInfo();
        }
        private void Random_Insert(object sender, EventArgs e)
        {
            HideButtons();
            RandomButton.Visible = true;
            Numeric.Visible = true;
            InsertInfo();
        }
        private void Manual_Delete(object sender, EventArgs e)
        {
            HideButtons();
            label2.Visible = true;
            DeleteTextBox.Visible = true;
            DeleteInfo();
        }
        private void All_Delete(object sender, EventArgs e)
        {
            tree.ClearAll();
            drawing.Update();
            AddLog("дерево очищено", "");
        }
        private void Manual_Search(object sender, EventArgs e)
        {
            HideButtons();
            label7.Visible = true;
            SearchTextBox.Visible = true;
            label8.Visible = true;
            label8.Text = string.Empty;
            label9.Text = "Поиск узла в красно-черном дереве выполняется за O(log n)";
        }

        private void About_Program(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }
        private void OpenLog(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", logpath);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл журнала не существует", "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddLog(string op, string num, string other="")
        {
            StreamWriter sw = File.AppendText(logpath);
            string log = $"{DateTime.Now.ToLocalTime()}  {op} {num}";
            if (other != "")
            {
                log = string.Concat(log, other);
            }
            sw.WriteLine(log);
            sw.Close();
        }
    }
}
