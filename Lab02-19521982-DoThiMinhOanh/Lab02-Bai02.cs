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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                StreamReader streamReader = new StreamReader(fileStream);

                string content = streamReader.ReadToEnd();
                rtbFile.Text = content;
                fileStream.Close();
                tbTenFile.Text = openFileDialog.SafeFileName.ToString();
                tbUrl.Text = fileStream.Name.ToString();

                int lineCount = 0;
                content = content.Replace("\r\n", "\r");
                lineCount = rtbFile.Lines.Count();
                tbDong.Text = lineCount.ToString();

                int wordCount = 0;
                string[] sourceWord = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount = sourceWord.Count();
                tbTu.Text = wordCount.ToString();

                int charCount = 0;
                string text = rtbFile.Text.Trim();
                int index = 0;
                while (index < text.Length)
                {
                    index++;
                    charCount++;
                }
                tbKyTu.Text = charCount.ToString();
                fileStream.Close();
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rtbFile.Text = null;
            tbDong.Text = null;
            tbUrl.Text = null;
            tbKyTu.Text = null;
            tbTu.Text = null;
            tbTenFile.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
