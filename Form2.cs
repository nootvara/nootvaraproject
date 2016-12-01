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
    public partial class Form2 : Form
    {
        public static int choose;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choose = 0; 
            Form4 f4 = new Form4();// คำสั้งที่ให้มันโชว์ ในฟอม4
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choose = 1;
            Form3 f3 = new Form3();// คำสั้งที่ให้มันโชว์ ในฟอม3
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
