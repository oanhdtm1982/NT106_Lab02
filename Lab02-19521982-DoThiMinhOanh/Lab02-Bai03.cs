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
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            MessageBox.Show("Chọn file input cần tính", "Chọn file input");

            string content;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                StreamReader streamReader = new StreamReader(fs);
                content = streamReader.ReadLine();
                while (content != null)
                {
                    string[] arr = content.Split('+', '-', '*', '/');
                    float index = 0;
                    string tong = "+";
                    string hieu = "-";
                    string tich = "*";
                    string thuong = "/";
                    for (int i = 0; i < arr.Length; i++)
                    {

                        if (i == 0)
                        {
                            index = float.Parse(arr[0].ToString());
                        }
                        else
                        {
                            if (content.Contains(tong) == true)
                            {
                                index += float.Parse(arr[i].ToString());
                            }
                            if (content.Contains(hieu) == true)
                            {
                                index -= float.Parse(arr[i].ToString());
                            }
                            if (content.Contains(tich) == true)
                            {
                                index *= float.Parse(arr[i].ToString());
                            }
                            if (content.Contains(thuong) == true)
                            {
                                index /= float.Parse(arr[i].ToString());
                            }
                        }
                    }
                    rtbOutput.Text = rtbOutput.Text + content + " = " + index + "\n";
                    content = streamReader.ReadLine();
                }
                }
            else
            {

            }
        }
    }
}
