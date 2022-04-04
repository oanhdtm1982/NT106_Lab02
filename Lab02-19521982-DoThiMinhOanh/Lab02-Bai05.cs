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

namespace Lab02_19521982_DoThiMinhOanh
{
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }
        
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                labelPath.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath); 
                FileInfo[] files = directoryInfo.GetFiles();
                listView.Columns.Add("Tên File", 300, HorizontalAlignment.Left);
                listView.Columns.Add("Kích Thước", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Đuôi mở rộng", 120, HorizontalAlignment.Left);
                listView.Columns.Add("Ngày tạo", 200, HorizontalAlignment.Left);
                listView.View = View.Details;
                listView.GridLines = true;
                foreach (FileInfo file in files)
                {
                    string [] row = {file.Name, file.Length.ToString(), Path.GetExtension(file.Name), file.LastWriteTime.ToString()};
                    ListViewItem listViewItem = new ListViewItem(row);
                    listView.Items.Add(listViewItem);
                }
            }
            else { MessageBox.Show("Chọn folder"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
