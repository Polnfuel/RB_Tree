namespace RB_Tree
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openlogToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            manualToolStripMenuItem = new ToolStripMenuItem();
            fromfileToolStripMenuItem = new ToolStripMenuItem();
            randomToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            deleteallToolStripMenuItem = new ToolStripMenuItem();
            searchtoolStripMenuItem3 = new ToolStripMenuItem();
            ToolStripMenuItem4 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            DrawPanel = new Panel();
            InsertTextBox = new TextBox();
            label1 = new Label();
            FromFileButton = new Button();
            InsertDialog = new OpenFileDialog();
            RandomButton = new Button();
            Numeric = new NumericUpDown();
            DeleteTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NodeCountLabel = new Label();
            label5 = new Label();
            TreeDepthLabel = new Label();
            label6 = new Label();
            BlackDepthLabel = new Label();
            label7 = new Label();
            SearchTextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            OpenLogButton = new Button();
            ManInsertButton = new Button();
            SearchButton = new Button();
            FileInsertButton = new Button();
            AllDeleteButton = new Button();
            RandInsertButton = new Button();
            ManDeleteButton = new Button();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Numeric).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, ToolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1382, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openlogToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // openlogToolStripMenuItem
            // 
            openlogToolStripMenuItem.Name = "openlogToolStripMenuItem";
            openlogToolStripMenuItem.Size = new Size(206, 26);
            openlogToolStripMenuItem.Text = "Открыть журнал";
            openlogToolStripMenuItem.Click += OpenLog;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem1, ToolStripMenuItem2, searchtoolStripMenuItem3 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(74, 24);
            editToolStripMenuItem.Text = "Правка";
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { manualToolStripMenuItem, fromfileToolStripMenuItem, randomToolStripMenuItem });
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(159, 26);
            ToolStripMenuItem1.Text = "Вставка";
            // 
            // manualToolStripMenuItem
            // 
            manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            manualToolStripMenuItem.Size = new Size(159, 26);
            manualToolStripMenuItem.Text = "Вручную";
            manualToolStripMenuItem.Click += Manual_Insert;
            // 
            // fromfileToolStripMenuItem
            // 
            fromfileToolStripMenuItem.Name = "fromfileToolStripMenuItem";
            fromfileToolStripMenuItem.Size = new Size(159, 26);
            fromfileToolStripMenuItem.Text = "Из файла";
            fromfileToolStripMenuItem.Click += FromFile_Insert;
            // 
            // randomToolStripMenuItem
            // 
            randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            randomToolStripMenuItem.Size = new Size(159, 26);
            randomToolStripMenuItem.Text = "Случайно";
            randomToolStripMenuItem.Click += Random_Insert;
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, deleteallToolStripMenuItem });
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(159, 26);
            ToolStripMenuItem2.Text = "Удаление";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(175, 26);
            deleteToolStripMenuItem.Text = "Вручную";
            deleteToolStripMenuItem.Click += Manual_Delete;
            // 
            // deleteallToolStripMenuItem
            // 
            deleteallToolStripMenuItem.Name = "deleteallToolStripMenuItem";
            deleteallToolStripMenuItem.Size = new Size(175, 26);
            deleteallToolStripMenuItem.Text = "Удалить все";
            deleteallToolStripMenuItem.Click += All_Delete;
            // 
            // searchtoolStripMenuItem3
            // 
            searchtoolStripMenuItem3.Name = "searchtoolStripMenuItem3";
            searchtoolStripMenuItem3.Size = new Size(159, 26);
            searchtoolStripMenuItem3.Text = "Поиск";
            searchtoolStripMenuItem3.Click += Manual_Search;
            // 
            // ToolStripMenuItem4
            // 
            ToolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            ToolStripMenuItem4.Size = new Size(81, 24);
            ToolStripMenuItem4.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(187, 26);
            aboutToolStripMenuItem.Text = "О программе";
            aboutToolStripMenuItem.Click += About_Program;
            // 
            // DrawPanel
            // 
            DrawPanel.AutoScroll = true;
            DrawPanel.AutoSize = true;
            DrawPanel.BackColor = Color.White;
            DrawPanel.BorderStyle = BorderStyle.FixedSingle;
            DrawPanel.Location = new Point(12, 111);
            DrawPanel.Margin = new Padding(3, 2, 3, 2);
            DrawPanel.Name = "DrawPanel";
            DrawPanel.Size = new Size(1358, 482);
            DrawPanel.TabIndex = 2;
            // 
            // InsertTextBox
            // 
            InsertTextBox.Location = new Point(260, 801);
            InsertTextBox.Margin = new Padding(3, 2, 3, 2);
            InsertTextBox.Name = "InsertTextBox";
            InsertTextBox.Size = new Size(77, 27);
            InsertTextBox.TabIndex = 3;
            InsertTextBox.KeyDown += InsertTextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 806);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Вставить";
            // 
            // FromFileButton
            // 
            FromFileButton.Location = new Point(388, 795);
            FromFileButton.Margin = new Padding(3, 2, 3, 2);
            FromFileButton.Name = "FromFileButton";
            FromFileButton.Size = new Size(120, 41);
            FromFileButton.TabIndex = 5;
            FromFileButton.Text = "Выбрать файл";
            FromFileButton.UseVisualStyleBackColor = true;
            FromFileButton.Click += InsertButton_Click;
            // 
            // RandomButton
            // 
            RandomButton.Location = new Point(545, 795);
            RandomButton.Margin = new Padding(3, 2, 3, 2);
            RandomButton.Name = "RandomButton";
            RandomButton.Size = new Size(85, 41);
            RandomButton.TabIndex = 7;
            RandomButton.Text = "Случайно";
            RandomButton.UseVisualStyleBackColor = true;
            RandomButton.Click += RandomButton_Click;
            // 
            // Numeric
            // 
            Numeric.Location = new Point(636, 803);
            Numeric.Margin = new Padding(3, 2, 3, 2);
            Numeric.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            Numeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Numeric.Name = "Numeric";
            Numeric.Size = new Size(53, 27);
            Numeric.TabIndex = 8;
            Numeric.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // DeleteTextBox
            // 
            DeleteTextBox.Location = new Point(799, 798);
            DeleteTextBox.Margin = new Padding(3, 2, 3, 2);
            DeleteTextBox.Name = "DeleteTextBox";
            DeleteTextBox.Size = new Size(80, 27);
            DeleteTextBox.TabIndex = 9;
            DeleteTextBox.KeyDown += DeleteTextBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(731, 803);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 10;
            label2.Text = "Удалить";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(699, 607);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 11;
            label3.Text = "Статистика";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(615, 638);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 12;
            label4.Text = "Узлов: ";
            // 
            // NodeCountLabel
            // 
            NodeCountLabel.AutoSize = true;
            NodeCountLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NodeCountLabel.Location = new Point(727, 638);
            NodeCountLabel.Name = "NodeCountLabel";
            NodeCountLabel.Size = new Size(46, 18);
            NodeCountLabel.TabIndex = 13;
            NodeCountLabel.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(552, 672);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 14;
            label5.Text = "Высота дерева:";
            // 
            // TreeDepthLabel
            // 
            TreeDepthLabel.AutoSize = true;
            TreeDepthLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TreeDepthLabel.Location = new Point(727, 675);
            TreeDepthLabel.Name = "TreeDepthLabel";
            TreeDepthLabel.Size = new Size(46, 18);
            TreeDepthLabel.TabIndex = 15;
            TreeDepthLabel.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(552, 712);
            label6.Name = "label6";
            label6.Size = new Size(117, 18);
            label6.TabIndex = 16;
            label6.Text = "Черная высота:";
            // 
            // BlackDepthLabel
            // 
            BlackDepthLabel.AutoSize = true;
            BlackDepthLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BlackDepthLabel.Location = new Point(727, 712);
            BlackDepthLabel.Name = "BlackDepthLabel";
            BlackDepthLabel.Size = new Size(46, 18);
            BlackDepthLabel.TabIndex = 17;
            BlackDepthLabel.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(931, 806);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 18;
            label7.Text = "Найти";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(989, 798);
            SearchTextBox.Margin = new Padding(4, 5, 4, 5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(81, 27);
            SearchTextBox.TabIndex = 19;
            SearchTextBox.KeyDown += SearchTextBox_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(726, 752);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 20;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(1121, 803);
            label9.Name = "label9";
            label9.Size = new Size(46, 18);
            label9.TabIndex = 21;
            label9.Text = "label9";
            // 
            // panel1
            // 
            panel1.Controls.Add(OpenLogButton);
            panel1.Controls.Add(ManInsertButton);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(FileInsertButton);
            panel1.Controls.Add(AllDeleteButton);
            panel1.Controls.Add(RandInsertButton);
            panel1.Controls.Add(ManDeleteButton);
            panel1.Location = new Point(12, 39);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 66);
            panel1.TabIndex = 22;
            // 
            // OpenLogButton
            // 
            OpenLogButton.BackgroundImage = (Image)resources.GetObject("OpenLogButton.BackgroundImage");
            OpenLogButton.BackgroundImageLayout = ImageLayout.Zoom;
            OpenLogButton.Cursor = Cursors.Hand;
            OpenLogButton.FlatAppearance.BorderSize = 0;
            OpenLogButton.FlatStyle = FlatStyle.Flat;
            OpenLogButton.Location = new Point(420, 14);
            OpenLogButton.Margin = new Padding(3, 4, 3, 4);
            OpenLogButton.Name = "OpenLogButton";
            OpenLogButton.Size = new Size(35, 38);
            OpenLogButton.TabIndex = 34;
            OpenLogButton.TextImageRelation = TextImageRelation.ImageAboveText;
            OpenLogButton.UseVisualStyleBackColor = true;
            OpenLogButton.Click += OpenLog;
            // 
            // ManInsertButton
            // 
            ManInsertButton.BackgroundImage = (Image)resources.GetObject("ManInsertButton.BackgroundImage");
            ManInsertButton.BackgroundImageLayout = ImageLayout.Zoom;
            ManInsertButton.Cursor = Cursors.Hand;
            ManInsertButton.FlatAppearance.BorderSize = 0;
            ManInsertButton.FlatStyle = FlatStyle.Flat;
            ManInsertButton.Location = new Point(58, 14);
            ManInsertButton.Margin = new Padding(3, 4, 3, 4);
            ManInsertButton.Name = "ManInsertButton";
            ManInsertButton.Size = new Size(35, 38);
            ManInsertButton.TabIndex = 28;
            ManInsertButton.Tag = "";
            ManInsertButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ManInsertButton.UseVisualStyleBackColor = true;
            ManInsertButton.Click += Manual_Insert;
            // 
            // SearchButton
            // 
            SearchButton.BackgroundImage = (Image)resources.GetObject("SearchButton.BackgroundImage");
            SearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Location = new Point(348, 14);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(35, 38);
            SearchButton.TabIndex = 33;
            SearchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += Manual_Search;
            // 
            // FileInsertButton
            // 
            FileInsertButton.BackgroundImage = (Image)resources.GetObject("FileInsertButton.BackgroundImage");
            FileInsertButton.BackgroundImageLayout = ImageLayout.Zoom;
            FileInsertButton.Cursor = Cursors.Hand;
            FileInsertButton.FlatAppearance.BorderSize = 0;
            FileInsertButton.FlatStyle = FlatStyle.Flat;
            FileInsertButton.Location = new Point(107, 14);
            FileInsertButton.Margin = new Padding(3, 4, 3, 4);
            FileInsertButton.Name = "FileInsertButton";
            FileInsertButton.Size = new Size(35, 38);
            FileInsertButton.TabIndex = 29;
            FileInsertButton.TextImageRelation = TextImageRelation.ImageAboveText;
            FileInsertButton.UseVisualStyleBackColor = true;
            FileInsertButton.Click += FromFile_Insert;
            // 
            // AllDeleteButton
            // 
            AllDeleteButton.BackgroundImage = (Image)resources.GetObject("AllDeleteButton.BackgroundImage");
            AllDeleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            AllDeleteButton.Cursor = Cursors.Hand;
            AllDeleteButton.FlatAppearance.BorderSize = 0;
            AllDeleteButton.FlatStyle = FlatStyle.Flat;
            AllDeleteButton.Location = new Point(277, 14);
            AllDeleteButton.Margin = new Padding(3, 4, 3, 4);
            AllDeleteButton.Name = "AllDeleteButton";
            AllDeleteButton.Size = new Size(35, 38);
            AllDeleteButton.TabIndex = 32;
            AllDeleteButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AllDeleteButton.UseVisualStyleBackColor = true;
            AllDeleteButton.Click += All_Delete;
            // 
            // RandInsertButton
            // 
            RandInsertButton.BackgroundImage = (Image)resources.GetObject("RandInsertButton.BackgroundImage");
            RandInsertButton.BackgroundImageLayout = ImageLayout.Zoom;
            RandInsertButton.Cursor = Cursors.Hand;
            RandInsertButton.FlatAppearance.BorderSize = 0;
            RandInsertButton.FlatStyle = FlatStyle.Flat;
            RandInsertButton.Location = new Point(152, 14);
            RandInsertButton.Margin = new Padding(3, 4, 3, 4);
            RandInsertButton.Name = "RandInsertButton";
            RandInsertButton.Size = new Size(35, 38);
            RandInsertButton.TabIndex = 30;
            RandInsertButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RandInsertButton.UseVisualStyleBackColor = true;
            RandInsertButton.Click += Random_Insert;
            // 
            // ManDeleteButton
            // 
            ManDeleteButton.BackgroundImage = (Image)resources.GetObject("ManDeleteButton.BackgroundImage");
            ManDeleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            ManDeleteButton.Cursor = Cursors.Hand;
            ManDeleteButton.FlatAppearance.BorderSize = 0;
            ManDeleteButton.FlatStyle = FlatStyle.Flat;
            ManDeleteButton.Location = new Point(226, 14);
            ManDeleteButton.Margin = new Padding(3, 4, 3, 4);
            ManDeleteButton.Name = "ManDeleteButton";
            ManDeleteButton.Size = new Size(35, 38);
            ManDeleteButton.TabIndex = 31;
            ManDeleteButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ManDeleteButton.UseVisualStyleBackColor = true;
            ManDeleteButton.Click += Manual_Delete;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(SearchTextBox);
            Controls.Add(label7);
            Controls.Add(BlackDepthLabel);
            Controls.Add(label6);
            Controls.Add(TreeDepthLabel);
            Controls.Add(label5);
            Controls.Add(NodeCountLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DeleteTextBox);
            Controls.Add(Numeric);
            Controls.Add(RandomButton);
            Controls.Add(FromFileButton);
            Controls.Add(label1);
            Controls.Add(InsertTextBox);
            Controls.Add(DrawPanel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Красно-черные деревья";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Numeric).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.TextBox InsertTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FromFileButton;
        private System.Windows.Forms.OpenFileDialog InsertDialog;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.NumericUpDown Numeric;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NodeCountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TreeDepthLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BlackDepthLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteallToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManInsertButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button FileInsertButton;
        private System.Windows.Forms.Button AllDeleteButton;
        private System.Windows.Forms.Button RandInsertButton;
        private System.Windows.Forms.Button ManDeleteButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem openlogToolStripMenuItem;
        private System.Windows.Forms.Button OpenLogButton;
    }
}

