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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.InsertTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.searchtoolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1427, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.fromfileToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.toolStripMenuItem1.Text = "Вставка";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.manualToolStripMenuItem.Text = "Вручную";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // fromfileToolStripMenuItem
            // 
            this.fromfileToolStripMenuItem.Name = "fromfileToolStripMenuItem";
            this.fromfileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.fromfileToolStripMenuItem.Text = "Из файла";
            this.fromfileToolStripMenuItem.Click += new System.EventHandler(this.fromfileToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.randomToolStripMenuItem.Text = "Случайно";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.deleteallToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 24);
            this.toolStripMenuItem2.Text = "Удаление";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.deleteToolStripMenuItem.Text = "Вручную";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteallToolStripMenuItem
            // 
            this.deleteallToolStripMenuItem.Name = "deleteallToolStripMenuItem";
            this.deleteallToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.deleteallToolStripMenuItem.Text = "Удалить все";
            this.deleteallToolStripMenuItem.Click += new System.EventHandler(this.deleteallToolStripMenuItem_Click);
            // 
            // searchtoolStripMenuItem3
            // 
            this.searchtoolStripMenuItem3.Name = "searchtoolStripMenuItem3";
            this.searchtoolStripMenuItem3.Size = new System.Drawing.Size(66, 24);
            this.searchtoolStripMenuItem3.Text = "Поиск";
            this.searchtoolStripMenuItem3.Click += new System.EventHandler(this.searchtoolStripMenuItem3_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.AutoScroll = true;
            this.drawPanel.AutoSize = true;
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(12, 31);
            this.drawPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(1403, 434);
            this.drawPanel.TabIndex = 2;
            // 
            // InsertTextBox
            // 
            this.InsertTextBox.Location = new System.Drawing.Point(260, 620);
            this.InsertTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertTextBox.Name = "InsertTextBox";
            this.InsertTextBox.Size = new System.Drawing.Size(77, 22);
            this.InsertTextBox.TabIndex = 3;
            this.InsertTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.insertTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вставить";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(388, 615);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(120, 33);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Выбрать файл";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(545, 615);
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
            this.Numeric.Location = new System.Drawing.Point(636, 622);
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
            this.DeleteTextBox.Location = new System.Drawing.Point(799, 618);
            this.DeleteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(80, 22);
            this.DeleteTextBox.TabIndex = 9;
            this.DeleteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Удалить";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(659, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Статистика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(575, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Узлов: ";
            // 
            // NodeCountLabel
            // 
            this.NodeCountLabel.AutoSize = true;
            this.NodeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NodeCountLabel.Location = new System.Drawing.Point(687, 494);
            this.NodeCountLabel.Name = "NodeCountLabel";
            this.NodeCountLabel.Size = new System.Drawing.Size(46, 18);
            this.NodeCountLabel.TabIndex = 13;
            this.NodeCountLabel.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(512, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Высота дерева:";
            // 
            // TreeDepthLabel
            // 
            this.TreeDepthLabel.AutoSize = true;
            this.TreeDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeDepthLabel.Location = new System.Drawing.Point(687, 523);
            this.TreeDepthLabel.Name = "TreeDepthLabel";
            this.TreeDepthLabel.Size = new System.Drawing.Size(46, 18);
            this.TreeDepthLabel.TabIndex = 15;
            this.TreeDepthLabel.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(512, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Черная высота:";
            // 
            // BlackDepthLabel
            // 
            this.BlackDepthLabel.AutoSize = true;
            this.BlackDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlackDepthLabel.Location = new System.Drawing.Point(687, 553);
            this.BlackDepthLabel.Name = "BlackDepthLabel";
            this.BlackDepthLabel.Size = new System.Drawing.Size(46, 18);
            this.BlackDepthLabel.TabIndex = 17;
            this.BlackDepthLabel.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(931, 624);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Найти";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(989, 618);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(81, 22);
            this.SearchTextBox.TabIndex = 19;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(686, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1121, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "label9";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 667);
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
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertTextBox);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Красно-черные деревья";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.TextBox InsertTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.OpenFileDialog InsertDialog;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.NumericUpDown Numeric;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
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
    }
}

