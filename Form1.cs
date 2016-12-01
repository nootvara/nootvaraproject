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
    public partial class Form1 : Form
    {
        public static string name; //เมท็อดของตัวแปรname
        public static string id;//เมท็อดของตัวแปรid
        public Form1()
        {
            InitializeComponent();//คำสั่งสร้างคอมโพเน้น
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;//รับตัวแปรnameให้ไปแสดงที่textbox1
            id = textBox2.Text;//รับตัวแปรidให้ไปแสดงที่textbox2
            Form2 f2 = new Form2();//คำสั่งให้ไปแสดงที่หนาfrom2
            f2.Show();//คำสั่งให้ไปโชว์หน้าฟรอมของตัวแปร f2
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
