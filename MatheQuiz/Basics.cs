using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatheQuiz
{
   
    public partial class Basics : Form
    {
        int varA = 0;
        int varB = 0;
        public Basics()
        {
            InitializeComponent();
            Random rd = new Random();
            varA = rd.Next(1, 50);
            varB = rd.Next(1, 50);
            string varAstring = varA.ToString();
            string varBstring = varB.ToString();
            questionA.Text = (varAstring + "+" + varBstring + "=");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void solution1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string solutionString = solution1.Text;
            int solution = Int32.Parse(solutionString);
            if (solution == varA + varB)
            {
                EndScreen end = new EndScreen();
                end.Show();
                Visible = false;
            }
            else if (solution != varA + varB) 
            {
                popUpWrong wrong = new popUpWrong();
                wrong.Show();
            }
        }
    }
}
