using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            label7.Text = Form1.name;//แสดงชื่อ 
            label8.Text = Form1.id;//แสดงid
            if (Form2.choose == 1)
            {
                label6.Text = "เรื่องที่ 1 กำเนิดอาเซียน";

                label9.Text = Convert.ToString(Form3.value); // แปลงค่า x เป็น string แล้วแสดงบน label9
                if (Form3.value >= 8)
                {
                    label10.Text = "ผ่าน";
                }
                else label10.Text = "ไม่ผ่าน";
            }
            else if (Form2.choose == 0)
            {
                label6.Text = "เรื่องที่ 2 เกร็ดความรู้ ASEAN";

                label9.Text = Convert.ToString(Form4.value); // แปลงค่า x เป็น string แล้วแสดงบน label9
                if (Form4.value >= 8)
                {
                    label10.Text = "ผ่าน";
                }
                else label10.Text = "ไม่ผ่าน";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
