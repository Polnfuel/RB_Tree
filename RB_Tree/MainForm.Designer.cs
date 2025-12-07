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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.InsertTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FromFileButton = new System.Windows.Forms.Button();
            this.InsertDialog = new System.Windows.Forms.OpenFileDialog();
            this.RandomButton = new System.Windows.Forms.Button();
            this.Numeric = new System.Windows.Forms.NumericUpDown();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NodeCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TreeDepthLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BlackDepthLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenLogButton = new System.Windows.Forms.Button();
            this.ManInsertButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FileInsertButton = new System.Windows.Forms.Button();
            this.AllDeleteButton = new System.Windows.Forms.Button();
            this.RandInsertButton = new System.Windows.Forms.Button();
            this.ManDeleteButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ToolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1624, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openlogToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openlogToolStripMenuItem
            // 
            this.openlogToolStripMenuItem.Name = "openlogToolStripMenuItem";
            this.openlogToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.openlogToolStripMenuItem.Text = "Открыть журнал";
            this.openlogToolStripMenuItem.Click += new System.EventHandler(this.OpenLog);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.searchtoolStripMenuItem3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.fromfileToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItem1.Text = "Вставка";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.manualToolStripMenuItem.Text = "Вручную";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.Manual_Insert);
            // 
            // fromfileToolStripMenuItem
            // 
            this.fromfileToolStripMenuItem.Name = "fromfileToolStripMenuItem";
            this.fromfileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.fromfileToolStripMenuItem.Text = "Из файла";
            this.fromfileToolStripMenuItem.Click += new System.EventHandler(this.FromFile_Insert);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.randomToolStripMenuItem.Text = "Случайно";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.Random_Insert);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.deleteallToolStripMenuItem});
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItem2.Text = "Удаление";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.deleteToolStripMenuItem.Text = "Вручную";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Manual_Delete);
            // 
            // deleteallToolStripMenuItem
            // 
            this.deleteallToolStripMenuItem.Name = "deleteallToolStripMenuItem";
            this.deleteallToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.deleteallToolStripMenuItem.Text = "Удалить все";
            this.deleteallToolStripMenuItem.Click += new System.EventHandler(this.All_Delete);
            // 
            // searchtoolStripMenuItem3
            // 
            this.searchtoolStripMenuItem3.Name = "searchtoolStripMenuItem3";
            this.searchtoolStripMenuItem3.Size = new System.Drawing.Size(159, 26);
            this.searchtoolStripMenuItem3.Text = "Поиск";
            this.searchtoolStripMenuItem3.Click += new System.EventHandler(this.Manual_Search);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(81, 24);
            this.ToolStripMenuItem4.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Program);
            // 
            // DrawPanel
            // 
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.AutoSize = true;
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Location = new System.Drawing.Point(12, 89);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1600, 487);
            this.DrawPanel.TabIndex = 2;
            // 
            // InsertTextBox
            // 
            this.InsertTextBox.Location = new System.Drawing.Point(260, 747);
            this.InsertTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertTextBox.Name = "InsertTextBox";
            this.InsertTextBox.Size = new System.Drawing.Size(77, 22);
            this.InsertTextBox.TabIndex = 3;
            this.InsertTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsertTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 751);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вставить";
            // 
            // FromFileButton
            // 
            this.FromFileButton.Location = new System.Drawing.Point(388, 742);
            this.FromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromFileButton.Name = "FromFileButton";
            this.FromFileButton.Size = new System.Drawing.Size(120, 33);
            this.FromFileButton.TabIndex = 5;
            this.FromFileButton.Text = "Выбрать файл";
            this.FromFileButton.UseVisualStyleBackColor = true;
            this.FromFileButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(545, 742);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(85, 33);
            this.RandomButton.TabIndex = 7;
            this.RandomButton.Text = "Случайно";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // Numeric
            // 
            this.Numeric.Location = new System.Drawing.Point(636, 749);
            this.Numeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Numeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric.Name = "Numeric";
            this.Numeric.Size = new System.Drawing.Size(53, 22);
            this.Numeric.TabIndex = 8;
            this.Numeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(799, 745);
            this.DeleteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(80, 22);
            this.DeleteTextBox.TabIndex = 9;
            this.DeleteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Удалить";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(766, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Статистика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(682, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Узлов: ";
            // 
            // NodeCountLabel
            // 
            this.NodeCountLabel.AutoSize = true;
            this.NodeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NodeCountLabel.Location = new System.Drawing.Point(794, 617);
            this.NodeCountLabel.Name = "NodeCountLabel";
            this.NodeCountLabel.Size = new System.Drawing.Size(46, 18);
            this.NodeCountLabel.TabIndex = 13;
            this.NodeCountLabel.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(619, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Высота дерева:";
            // 
            // TreeDepthLabel
            // 
            this.TreeDepthLabel.AutoSize = true;
            this.TreeDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeDepthLabel.Location = new System.Drawing.Point(794, 646);
            this.TreeDepthLabel.Name = "TreeDepthLabel";
            this.TreeDepthLabel.Size = new System.Drawing.Size(46, 18);
            this.TreeDepthLabel.TabIndex = 15;
            this.TreeDepthLabel.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(619, 676);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Черная высота:";
            // 
            // BlackDepthLabel
            // 
            this.BlackDepthLabel.AutoSize = true;
            this.BlackDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlackDepthLabel.Location = new System.Drawing.Point(794, 676);
            this.BlackDepthLabel.Name = "BlackDepthLabel";
            this.BlackDepthLabel.Size = new System.Drawing.Size(46, 18);
            this.BlackDepthLabel.TabIndex = 17;
            this.BlackDepthLabel.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(931, 751);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Найти";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(989, 745);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(81, 22);
            this.SearchTextBox.TabIndex = 19;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(793, 708);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1121, 749);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "label9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpenLogButton);
            this.panel1.Controls.Add(this.ManInsertButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.FileInsertButton);
            this.panel1.Controls.Add(this.AllDeleteButton);
            this.panel1.Controls.Add(this.RandInsertButton);
            this.panel1.Controls.Add(this.ManDeleteButton);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 53);
            this.panel1.TabIndex = 22;
            // 
            // OpenLogButton
            // 
            this.OpenLogButton.BackgroundImage = global::RB_Tree.Properties.Resources.log_data;
            this.OpenLogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenLogButton.FlatAppearance.BorderSize = 0;
            this.OpenLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLogButton.Location = new System.Drawing.Point(420, 11);
            this.OpenLogButton.Name = "OpenLogButton";
            this.OpenLogButton.Size = new System.Drawing.Size(35, 30);
            this.OpenLogButton.TabIndex = 34;
            this.OpenLogButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenLogButton.UseVisualStyleBackColor = true;
            this.OpenLogButton.Click += new System.EventHandler(this.OpenLog);
            // 
            // ManInsertButton
            // 
            this.ManInsertButton.BackgroundImage = global::RB_Tree.Properties.Resources.insert;
            this.ManInsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManInsertButton.FlatAppearance.BorderSize = 0;
            this.ManInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManInsertButton.Location = new System.Drawing.Point(58, 11);
            this.ManInsertButton.Name = "ManInsertButton";
            this.ManInsertButton.Size = new System.Drawing.Size(35, 30);
            this.ManInsertButton.TabIndex = 28;
            this.ManInsertButton.Tag = "";
            this.ManInsertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManInsertButton.UseVisualStyleBackColor = true;
            this.ManInsertButton.Click += new System.EventHandler(this.Manual_Insert);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::RB_Tree.Properties.Resources.loupe;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(348, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(35, 30);
            this.SearchButton.TabIndex = 33;
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Manual_Search);
            // 
            // FileInsertButton
            // 
            this.FileInsertButton.BackgroundImage = global::RB_Tree.Properties.Resources.file;
            this.FileInsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FileInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileInsertButton.FlatAppearance.BorderSize = 0;
            this.FileInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileInsertButton.Location = new System.Drawing.Point(107, 11);
            this.FileInsertButton.Name = "FileInsertButton";
            this.FileInsertButton.Size = new System.Drawing.Size(35, 30);
            this.FileInsertButton.TabIndex = 29;
            this.FileInsertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FileInsertButton.UseVisualStyleBackColor = true;
            this.FileInsertButton.Click += new System.EventHandler(this.FromFile_Insert);
            // 
            // AllDeleteButton
            // 
            this.AllDeleteButton.BackgroundImage = global::RB_Tree.Properties.Resources.eraser;
            this.AllDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllDeleteButton.FlatAppearance.BorderSize = 0;
            this.AllDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllDeleteButton.Location = new System.Drawing.Point(277, 11);
            this.AllDeleteButton.Name = "AllDeleteButton";
            this.AllDeleteButton.Size = new System.Drawing.Size(35, 30);
            this.AllDeleteButton.TabIndex = 32;
            this.AllDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AllDeleteButton.UseVisualStyleBackColor = true;
            this.AllDeleteButton.Click += new System.EventHandler(this.All_Delete);
            // 
            // RandInsertButton
            // 
            this.RandInsertButton.BackgroundImage = global::RB_Tree.Properties.Resources.shuffle;
            this.RandInsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandInsertButton.FlatAppearance.BorderSize = 0;
            this.RandInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandInsertButton.Location = new System.Drawing.Point(152, 11);
            this.RandInsertButton.Name = "RandInsertButton";
            this.RandInsertButton.Size = new System.Drawing.Size(35, 30);
            this.RandInsertButton.TabIndex = 30;
            this.RandInsertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RandInsertButton.UseVisualStyleBackColor = true;
            this.RandInsertButton.Click += new System.EventHandler(this.Random_Insert);
            // 
            // ManDeleteButton
            // 
            this.ManDeleteButton.BackgroundImage = global::RB_Tree.Properties.Resources.close;
            this.ManDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManDeleteButton.FlatAppearance.BorderSize = 0;
            this.ManDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManDeleteButton.Location = new System.Drawing.Point(226, 11);
            this.ManDeleteButton.Name = "ManDeleteButton";
            this.ManDeleteButton.Size = new System.Drawing.Size(35, 30);
            this.ManDeleteButton.TabIndex = 31;
            this.ManDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManDeleteButton.UseVisualStyleBackColor = true;
            this.ManDeleteButton.Click += new System.EventHandler(this.Manual_Delete);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 806);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BlackDepthLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TreeDepthLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NodeCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.Numeric);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.FromFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertTextBox);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Красно-черные деревья";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

