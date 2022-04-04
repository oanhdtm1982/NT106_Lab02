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
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
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
            }
            else 
            { 
                MessageBox.Show("Cancel");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rtbFile.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.ShowDialog();
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(rtbFile.Text.ToUpper());
                streamWriter.Flush();
                fileStream.Close();
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
