namespace WuHaoHash
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPath = new TextBox();
            SelectBtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            PrintBtn = new Button();
            RichTxtBox = new RichTextBox();
            SelectBtn1 = new Button();
            textBox1 = new TextBox();
            SearchBtn1 = new Button();
            SearchBtn2 = new Button();
            AllFilesNumBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SameFilesBox = new TextBox();
            DifferentFilesBox = new TextBox();
            ShowAllBtn1 = new Button();
            ShowAllBtn2 = new Button();
            checkBox1 = new CheckBox();
            ShowDiffCbox = new CheckBox();
            ShowSameCbox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 17);
            label1.TabIndex = 0;
            label1.Text = "请选择要比对的两个文件夹路径";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 39);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(389, 23);
            txtPath.TabIndex = 1;
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(407, 39);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(75, 23);
            SelectBtn.TabIndex = 2;
            SelectBtn.Text = "选择";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += SelectBtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.Location = new Point(681, 108);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(107, 63);
            PrintBtn.TabIndex = 3;
            PrintBtn.Text = "比对两个文件";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // RichTxtBox
            // 
            RichTxtBox.Location = new Point(12, 177);
            RichTxtBox.Name = "RichTxtBox";
            RichTxtBox.ReadOnly = true;
            RichTxtBox.Size = new Size(776, 261);
            RichTxtBox.TabIndex = 4;
            RichTxtBox.Text = "";
            // 
            // SelectBtn1
            // 
            SelectBtn1.Location = new Point(407, 79);
            SelectBtn1.Name = "SelectBtn1";
            SelectBtn1.Size = new Size(75, 23);
            SelectBtn1.TabIndex = 7;
            SelectBtn1.Text = "选择";
            SelectBtn1.UseVisualStyleBackColor = true;
            SelectBtn1.Click += SelectBtn1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 23);
            textBox1.TabIndex = 6;
            // 
            // SearchBtn1
            // 
            SearchBtn1.Location = new Point(488, 39);
            SearchBtn1.Name = "SearchBtn1";
            SearchBtn1.Size = new Size(109, 23);
            SearchBtn1.TabIndex = 9;
            SearchBtn1.Text = "比对单个文件夹";
            SearchBtn1.UseVisualStyleBackColor = true;
            SearchBtn1.Click += SearchBtn1_Click;
            // 
            // SearchBtn2
            // 
            SearchBtn2.Location = new Point(488, 79);
            SearchBtn2.Name = "SearchBtn2";
            SearchBtn2.Size = new Size(109, 23);
            SearchBtn2.TabIndex = 10;
            SearchBtn2.Text = "比对单个文件夹";
            SearchBtn2.UseVisualStyleBackColor = true;
            SearchBtn2.Click += SearchBtn2_Click;
            // 
            // AllFilesNumBox
            // 
            AllFilesNumBox.Location = new Point(74, 119);
            AllFilesNumBox.Name = "AllFilesNumBox";
            AllFilesNumBox.ReadOnly = true;
            AllFilesNumBox.Size = new Size(111, 23);
            AllFilesNumBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 12;
            label3.Text = "总文件数";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 122);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 13;
            label4.Text = "相同的SHA256";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 122);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 14;
            label5.Text = "不同的SHA256";
            label5.Visible = false;
            // 
            // SameFilesBox
            // 
            SameFilesBox.Location = new Point(287, 119);
            SameFilesBox.Name = "SameFilesBox";
            SameFilesBox.ReadOnly = true;
            SameFilesBox.Size = new Size(76, 23);
            SameFilesBox.TabIndex = 15;
            // 
            // DifferentFilesBox
            // 
            DifferentFilesBox.Location = new Point(464, 119);
            DifferentFilesBox.Name = "DifferentFilesBox";
            DifferentFilesBox.ReadOnly = true;
            DifferentFilesBox.Size = new Size(81, 23);
            DifferentFilesBox.TabIndex = 16;
            DifferentFilesBox.Visible = false;
            // 
            // ShowAllBtn1
            // 
            ShowAllBtn1.Location = new Point(603, 39);
            ShowAllBtn1.Name = "ShowAllBtn1";
            ShowAllBtn1.Size = new Size(185, 23);
            ShowAllBtn1.TabIndex = 17;
            ShowAllBtn1.Text = "显示所有文件的SHA256";
            ShowAllBtn1.UseVisualStyleBackColor = true;
            ShowAllBtn1.Click += ShowAllBtn1_Click;
            // 
            // ShowAllBtn2
            // 
            ShowAllBtn2.Location = new Point(603, 79);
            ShowAllBtn2.Name = "ShowAllBtn2";
            ShowAllBtn2.Size = new Size(185, 23);
            ShowAllBtn2.TabIndex = 18;
            ShowAllBtn2.Text = "显示所有文件的SHA256";
            ShowAllBtn2.UseVisualStyleBackColor = true;
            ShowAllBtn2.Click += ShowAllBtn2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(573, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 21);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "显示路径";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ShowDiffCbox
            // 
            ShowDiffCbox.AutoSize = true;
            ShowDiffCbox.Location = new Point(148, 156);
            ShowDiffCbox.Name = "ShowDiffCbox";
            ShowDiffCbox.Size = new Size(132, 21);
            ShowDiffCbox.TabIndex = 20;
            ShowDiffCbox.Text = "SHA256不同的文件";
            ShowDiffCbox.UseVisualStyleBackColor = true;
            ShowDiffCbox.CheckedChanged += ShowDiffCbox_CheckedChanged;
            // 
            // ShowSameCbox
            // 
            ShowSameCbox.AutoSize = true;
            ShowSameCbox.Checked = true;
            ShowSameCbox.CheckState = CheckState.Checked;
            ShowSameCbox.Location = new Point(12, 156);
            ShowSameCbox.Name = "ShowSameCbox";
            ShowSameCbox.Size = new Size(132, 21);
            ShowSameCbox.TabIndex = 21;
            ShowSameCbox.Text = "SHA256相同的文件";
            ShowSameCbox.UseVisualStyleBackColor = true;
            ShowSameCbox.CheckedChanged += ShowSameCbox_CheckedChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowSameCbox);
            Controls.Add(ShowDiffCbox);
            Controls.Add(checkBox1);
            Controls.Add(ShowAllBtn2);
            Controls.Add(ShowAllBtn1);
            Controls.Add(DifferentFilesBox);
            Controls.Add(SameFilesBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AllFilesNumBox);
            Controls.Add(SearchBtn2);
            Controls.Add(SearchBtn1);
            Controls.Add(SelectBtn1);
            Controls.Add(textBox1);
            Controls.Add(RichTxtBox);
            Controls.Add(PrintBtn);
            Controls.Add(SelectBtn);
            Controls.Add(txtPath);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "FrmMain";
            Text = "比较SHA256哈希值";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPath;
        private Button SelectBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button PrintBtn;
        private RichTextBox RichTxtBox;
        private Button SelectBtn1;
        private TextBox textBox1;
        private Button SearchBtn1;
        private Button SearchBtn2;
        private TextBox AllFilesNumBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox SameFilesBox;
        private TextBox DifferentFilesBox;
        private Button ShowAllBtn1;
        private Button ShowAllBtn2;
        private CheckBox checkBox1;
        private CheckBox ShowDiffCbox;
        private CheckBox ShowSameCbox;
    }
}