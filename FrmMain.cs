namespace WuHaoHash
{
    public partial class FrmMain : Form
    {

        public struct TheFile
        {
            public string Name;
            public string HashValue;
            public string FilePath;
        };

        public struct MyFile
        {
            public string FileName;
            public string FilePath;
        };
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择文件夹";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (txtPath.Text.Length > 0) folderBrowserDialog1.SelectedPath = txtPath.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void SelectBtn1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择文件夹";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (textBox1.Text.Length > 0) folderBrowserDialog1.SelectedPath = textBox1.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            RichTxtBox.Text = null;
            int SameNum = 0, AllNum;
            TheFile[]? file1 = HashDirectory.Main(txtPath.Text);
            TheFile[]? file2 = HashDirectory.Main(textBox1.Text);
            if (file1 != null && file2 != null)
                AllNum = file1.Length + file2.Length;
            else
            {
                RichTxtBox.Text = "路径文件为空或路径有误。";
                SameFilesBox.Text = "0";
                AllFilesNumBox.Text = "0";
                DifferentFilesBox.Text = "0";
                return;
            }
            AllFilesNumBox.Text = AllNum.ToString();
            List<TheFile> resultFile = new List<TheFile>();
            Dictionary<string, List<MyFile>> dic = new Dictionary<string, List<MyFile>>();  //相同的结果字典
            List<string> allSsameKeys = new List<string>();
            foreach (var file in file1)
            {
                MyFile myFile = new MyFile();
                myFile.FileName = file.Name;
                myFile.FilePath = file.FilePath;
                if (dic.ContainsKey(file.HashValue))
                {
                    dic[file.HashValue].Add(myFile);
                    if (!allSsameKeys.Contains(file.HashValue))
                        allSsameKeys.Add(file.HashValue);
                }
                else
                    dic[file.HashValue] = new List<MyFile> { myFile };
            }
            foreach (var file in file2)
            {
                MyFile myFile = new MyFile();
                myFile.FileName = file.Name;
                myFile.FilePath = file.FilePath;
                if (dic.ContainsKey(file.HashValue))
                {
                    dic[file.HashValue].Add(myFile);
                    if (!allSsameKeys.Contains(file.HashValue))
                        allSsameKeys.Add(file.HashValue);
                }
                else
                    dic[file.HashValue] = new List<MyFile> { myFile };
            }



            if (ShowSameCbox.Checked)
            {
                foreach (var s in dic)
                {
                    if (s.Value.Count > 1)
                    {
                        RichTxtBox.Text += s.Key;
                        SameNum++;
                        foreach (var f in s.Value)
                        {
                            if (checkBox1.Checked)
                                RichTxtBox.Text += f.FilePath + "\n";
                            else
                                RichTxtBox.Text += f.FileName + "\n";
                        }
                    }
                }
                SameFilesBox.Text = SameNum.ToString();
                DifferentFilesBox.Text = (AllNum - SameNum).ToString();
                if (SameNum == 0)
                {
                    RichTxtBox.Text = "未找到相同的文件";
                }
            }
            else if (ShowDiffCbox.Checked)
            {
                foreach (var f in file1)
                {
                    if (!allSsameKeys.Contains(f.HashValue))
                    {
                        if (checkBox1.Checked)
                            RichTxtBox.Text += f.FilePath + "：" + f.HashValue;
                        else
                            RichTxtBox.Text += f.Name + "：" + f.HashValue;
                    }
                }
                foreach (var f in file2)
                {
                    if (!allSsameKeys.Contains(f.HashValue))
                    {
                        if (checkBox1.Checked)
                            RichTxtBox.Text += f.FilePath + "：" + f.HashValue;
                        else
                            RichTxtBox.Text += f.Name + "：" + f.HashValue;
                    }
                }
            }
        }

        private void SearchBtn1_Click(object sender, EventArgs e)
        {
            SearchButton(txtPath.Text);
        }
        private void SearchBtn2_Click(object sender, EventArgs e)
        {
            SearchButton(textBox1.Text);
        }
        private void ShowAllBtn1_Click(object sender, EventArgs e)
        {
            RichTxtBox.Text = null;
            TheFile[]? file1 = HashDirectory.Main(txtPath.Text);
            SameFilesBox.Text = null;
            AllFilesNumBox.Text = null;
            DifferentFilesBox.Text = null;
            if (file1 != null)
            {
                AllFilesNumBox.Text = file1.Length.ToString();
                foreach (var f in file1)
                {
                    RichTxtBox.Text += f.Name + ": " + f.HashValue;
                }
            }
            else
            {
                RichTxtBox.Text = "路径文件为空或路径有误。";
            }
        }
        private void ShowAllBtn2_Click(object sender, EventArgs e)
        {
            RichTxtBox.Text = null;
            TheFile[]? file1 = HashDirectory.Main(textBox1.Text);
            SameFilesBox.Text = null;
            AllFilesNumBox.Text = null;
            DifferentFilesBox.Text = null;
            if (file1 != null)
            {
                AllFilesNumBox.Text = file1.Length.ToString();
                foreach (var f in file1)
                {
                    RichTxtBox.Text += f.Name + ": " + f.HashValue;
                }
            }
            else
            {
                RichTxtBox.Text = "路径文件为空或路径有误。";
            }
        }
        private void SearchButton(string filePath)
        {
            RichTxtBox.Text = null;
            int AllNum, SameNum = 0;
            TheFile[]? file1 = HashDirectory.Main(filePath);
            if (file1 != null)
            {
                List<string> AllSamefilesList = new List<string>();
                AllNum = file1.Length;
                AllFilesNumBox.Text = AllNum.ToString();
                Dictionary<string, List<MyFile>> tsf = SingeFindSameFiles(file1, out AllSamefilesList);
                SameNum = tsf.Keys.Count;
                SameFilesBox.Text = SameNum.ToString();
                DifferentFilesBox.Text = (AllNum - SameNum).ToString();
                if (ShowSameCbox.Checked)
                {
                    if (SameNum > 0)
                        foreach (var s in tsf)
                        {
                            RichTxtBox.Text += s.Key;
                            foreach (var s2 in s.Value)
                            {
                                if (checkBox1.Checked)
                                    RichTxtBox.Text += s2.FilePath + "\n";
                                else
                                    RichTxtBox.Text += s2.FileName + "\n";
                            }
                        }
                    else
                        RichTxtBox.Text = "没有找到相同的文件";
                }
                else if (ShowDiffCbox.Checked)
                {
                    foreach (var f in file1)
                    {
                        if (!AllSamefilesList.Contains(f.HashValue))
                        {
                            if (checkBox1.Checked)
                                RichTxtBox.Text += f.FilePath + ": " + f.HashValue;
                            else
                                RichTxtBox.Text += f.Name + ": " + f.HashValue;
                        }
                    }
                }

            }
            else
            {
                RichTxtBox.Text = "路径文件为空或路径有误。";
                SameFilesBox.Text = "0";
                AllFilesNumBox.Text = "0";
                DifferentFilesBox.Text = "0";
            }
        }
        private Dictionary<string, List<MyFile>> SingeFindSameFiles(TheFile[] theFile, out List<string> allsameFile)
        {
            List<TheFile> list = new List<TheFile>();
            HashSet<string> files = new HashSet<string>();
            Dictionary<string, List<MyFile>> hash = new Dictionary<string, List<MyFile>>();
            Dictionary<string, List<MyFile>> res = new Dictionary<string, List<MyFile>>();
            List<string> AllSameFile = new List<string>();
            foreach (var f in theFile)
            {
                MyFile myFile = new MyFile();
                myFile.FileName = f.Name;
                myFile.FilePath = f.FilePath;
                if (hash.ContainsKey(f.HashValue))
                {
                    hash[f.HashValue].Add(myFile);
                    if (!AllSameFile.Contains(f.HashValue))
                        AllSameFile.Add(f.HashValue);
                }
                else
                {
                    hash[f.HashValue] = new List<MyFile> { myFile };
                }
            }


            foreach (var h in hash)
            {

                if (h.Value.Count > 1)
                {
                    List<MyFile> strs = new List<MyFile>();
                    foreach (var f in h.Value)
                    {
                        strs.Add(f);
                    }
                    res[h.Key] = strs;
                }
            }
            allsameFile = AllSameFile;
            return res;
        }

        private void ShowSameCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowSameCbox.Checked)
            {
                ShowDiffCbox.Checked = false;
            }
        }

        private void ShowDiffCbox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowDiffCbox.Checked)
            {
                ShowSameCbox.Checked = false;
            }
        }
    }
}