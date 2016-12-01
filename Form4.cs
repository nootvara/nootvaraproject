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
    public partial class Form4 : Form
    {
        public static double value;
        public Form4()
        {
            Random ran = new Random();
            InitializeComponent();
            GroupBox[] gp = { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10 };
            Point[] point = { groupBox1.Location, groupBox2.Location, groupBox3.Location, groupBox4.Location, groupBox5.Location, groupBox6.Location, groupBox7.Location, groupBox8.Location, groupBox9.Location, groupBox10.Location, };
            int[] getR = new int[gp.Length];
            int x = ran.Next(gp.Length - 1);
            for (int i = 0; i < getR.Length; i++)
            {
                getR[i] = x;
                x--;
                if (x == -1)
                    x = gp.Length - 1;

            }
            for (int i = 0; i < point.Length; i++)
            {
                gp[i].SetBounds(point[getR[i]].X, point[getR[i]].Y, gp[i].Width, gp[i].Height);
            }
            button1.SetBounds(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            b();
        }
        public void b()
        {
            double i = 0;
            if (radioButton3.Checked) { i += 1; }
            if (radioButton5.Checked) { i += 1; }
            if (radioButton9.Checked) { i += 1; }
            if (radioButton13.Checked) { i += 1; }
            if (radioButton18.Checked) { i += 1; }
            if (radioButton21.Checked) { i += 1; }
            if (radioButton27.Checked) { i += 1; }
            if (radioButton30.Checked) { i += 1; }
            if (radioButton37.Checked) { i += 1; }
            if (radioButton3.Checked) { i += 1; }
            value = Convert.ToInt32(i);
            new Form6().Show();

        }

    
        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
  }

