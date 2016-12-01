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
    public partial class Form3 : Form
    {
        public static double value = 0;
        
        Random ran = new Random();
        public Form3()
        {
            Random ran = new Random();
            InitializeComponent();
            GroupBox[] gp = {groupBox1,groupBox2,groupBox3,groupBox4,groupBox5,groupBox6,groupBox7,groupBox8,groupBox9,groupBox10};
            Point[] point = { groupBox1.Location,   groupBox2.Location , groupBox3.Location ,groupBox4.Location, groupBox5.Location, groupBox6.Location, groupBox7.Location, groupBox8.Location, groupBox9.Location, groupBox10.Location, };//เก็บตำแหน่ง ของกรุ๊ปบล็อก
            int[] getR = new int[gp.Length];
            int y = ran.Next(gp.Length - 1);
            for (int i = 0; i < getR.Length; i++)
            {
                getR[i] = y;
                y--;
                if(y == -1)
                y = gp.Length - 1;
                
            }
            for(int i = 0; i < point.Length; i++)
            {
                gp[i].SetBounds(point[getR[i]].X, point[getR[i]].Y, gp[i].Width, gp[i].Height);
            }
            button1.SetBounds(button1.Location.X,button1.Location.Y,button1.Width, button1.Height);
      
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            m();//รับค่าทั้งหมดในเมท็อดมาแสดงที่ button1
        }
        public void m()
        {

            double y = 0;//จำหนดตัวแปรให้เป็น0
            if (radioButton3.Checked) { y += 1; }//เงื่อนไขถ้า y บวกหรือเท่ากับ1 ให้ไปแสดงที่ radioButton3
            if (radioButton6.Checked) { y += 1; }//เงื่อนไขถ้า y บวกหรือเท่ากับ1 ให้ไปแสดงที่ radioButton6
            if (radioButton10.Checked)
            {
                y += 1; //เงื่อนไขถ้า y บวกหรือเท่ากับ1 ให้ไปแสดงที่ radioButton10
                if (radioButton14.Checked) { y += 1; }
                if (radioButton20.Checked) { y += 1; }
                if (radioButton23.Checked) { y += 1; }
                if (radioButton28.Checked) { y += 1; }
                if (radioButton29.Checked) { y += 1; }
                if (radioButton35.Checked) { y += 1; }
                if (radioButton37.Checked) { y += 1; }
                value = Convert.ToInt32(y); //แปลงขอมูลของy
                new Form6().Show();//คำสั่งให้ไปโชว์ที่from6


            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    }

