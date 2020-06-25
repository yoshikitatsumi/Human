using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student Ali = new Student();
            Student Yoshi = new Student();
            Teacher T1 = new Teacher();

            int num1 = 90;
            int num2 = 20;

            T1.Marking(Ali, num1);
            T1.Marking(Yoshi, num2);

            textBox1.Text = "Ali's Mark: " + Ali.Marks + "";
            textBox2.Text = "Yoshi's Mark: " + Yoshi.Marks + "";
        }
    }
}
