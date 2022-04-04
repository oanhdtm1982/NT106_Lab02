using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_19521982_DoThiMinhOanh
{
    [Serializable]
    public class Student
    {
        public string Mssv { get; set; }
        public string HoTen { get; set; }
        public string Sđt { get; set; }
        public float toan { get; set; }
        public float van { get; set; }
        public float dtb;
        public void SetSt(string mssv, string ht, string dt, float dToan, float dVan)
        {
            Mssv = mssv;
            HoTen = ht;
            Sđt = dt;
            toan = dToan;
            van = dVan;
        }
        public string GetSt()
        {
            string content = "";
            content = Mssv + "\n" + HoTen + "\n" + Sđt + "\n" + toan.ToString() + "\n" + van.ToString() + "\n";
            if (dtb != null)
            {
                content += ((float)dtb).ToString();
            }
            content += "\n";
            return content;
        }
        public float Tinh()
        {
            dtb = (toan + van) / 2;
            return dtb;
        }
    }
}
