using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CampusDefender
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //taskkill /im /f Name
          
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ntsd -c q -pn 
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入有效的进程名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ProcessName = textBox1.Text;
            bool Way = radioButton1.Checked;
            string result;
            if (Way)
            {
                Cmd c = new Cmd();
                result = c.RunCmd("ntsd -c q -pn " + ProcessName);
            }
            else
            {
                Cmd c = new Cmd();
                result = c.RunCmd("taskkill /im /f " + ProcessName);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
