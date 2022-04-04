using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_19521982_DoThiMinhOanh
{
    public partial class FileAndStreamIO : Form
    {
        public FileAndStreamIO()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Form Bai01 = new Lab02_Bai01();
            Bai01.ShowDialog();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {

            Form Bai02 = new Lab02_Bai02();
            Bai02.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {

            Form Bai03 = new Lab02_Bai03();
            Bai03.ShowDialog();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {

            Form Bai04 = new Lab02_Bai04();
            Bai04.ShowDialog();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {

            Form Bai05 = new Lab02_Bai05();
            Bai05.ShowDialog();
        }
    }
}
