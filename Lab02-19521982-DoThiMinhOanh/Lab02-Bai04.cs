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
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab02_19521982_DoThiMinhOanh
{
    public partial class Lab02_Bai04 : Form
    {
        public Lab02_Bai04()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Mssv = tbMssv.Text;
            student.HoTen = tbHoTen.Text;
            student.Sđt = tbSđt.Text;
            student.toan = float.Parse(tbToan.Text); 
            student.van = float.Parse(tbVan.Text);
            students.Add(student);
            LoadData();
        }
        private void LoadData()
        {
            listView.Items.Clear();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.Mssv);
                item.SubItems.Add(student.HoTen);
                item.SubItems.Add(student.Sđt);
                item.SubItems.Add(student.toan.ToString());
                item.SubItems.Add(student.van.ToString());
                listView.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student TempStudent = new Student();
                TempStudent.SetSt(tbMssv.Text, tbHoTen.Text, tbSđt.Text, float.Parse(tbToan.Text.Trim()), float.Parse(tbVan.Text.Trim()));
                students.Add(TempStudent);
                FileStream fi = new FileStream("input.txt", FileMode.OpenOrCreate);
                BinaryFormatter bi = new BinaryFormatter();
                bi.Serialize(fi, students);
                fi.Close();
                MessageBox.Show("Học viên đã được lưu vào file input.txt. Nhấn button Tính để tính ĐTB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            rtbFile.Clear();
            FileStream fi = null;
            try
            {
                fi = new FileStream("output.txt", FileMode.Open);
                BinaryFormatter bi = new BinaryFormatter();
                List<Student> list = new List<Student>();
                list = (List<Student>)bi.Deserialize(fi);
                foreach (Student St in list)
                {
                    rtbFile.Text = rtbFile.Text + St.GetSt().ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbHoTen.Text = null;
            tbMssv.Text = null;
            tbSđt.Text = null;
            tbToan.Text = null;
            tbVan.Text = null;
            listView.Items.Clear();
            rtbFile.Text=null; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Student St in students)
                {
                    St.Tinh();
                }
                FileStream fi = new FileStream("output.txt", FileMode.Create);
                BinaryFormatter bi = new BinaryFormatter();
                bi.Serialize(fi, students);
                fi.Close();
                MessageBox.Show("ĐTB đã được lưu vào file output.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
