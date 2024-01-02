using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQ
{
    public partial class Form1 : Form
    {
        public int userAnswer = 1;
        public int correctAnswer = 1;
        public int markObtained = 1;
        public String ansMessage = "Correct Answer!";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 4;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userAnswer == correctAnswer)
            {
                markObtained = 1;
            }
            else
            {
                markObtained = 0;
                ansMessage = "Wrong Answer! Answer is " + correctAnswer;
            }
        }
    }
}
