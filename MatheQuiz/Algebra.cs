using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatheQuiz
{
    public partial class Algebra : Form
    {
        int varA = 0;
        int varB = 0;
        int varC = 0;
        int varD = 0;
        int varE = 0;
        int varF = 0;

        int SolutionX = 0;
        int SolutionY = 0;
        int SolutionZ = 0;

        bool xVar = false;
        bool yVar = false;
        bool zVar = false;
        public Algebra()
        {
            InitializeComponent();
            Random rd = new Random();
            varA = rd.Next(1, 50);
            varB = rd.Next(1, 50);
            varC = rd.Next(1, 50);
            varD = rd.Next(1, 50);
            varE = rd.Next(1, 50);
            varF = rd.Next(1, 50);

            buttonFinish.Hide();
            algebra1.Text = (varA + "x + " + varB + "y + " + varC + "z + " + varD + "x + " + varE + "y + " + varF + "z = ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonFinish.Visible = false;
            try
            {
                string solutionX = solX.Text;
                SolutionX = Int32.Parse(solutionX);
            }
            catch
            {
                solX.BackColor = Color.Red;
            }
            try
            {
                string solutionY = solY.Text;
                SolutionY = Int32.Parse(solutionY);
            }
            catch 
            {
                solY.BackColor = Color.Red;
            }
            try
            {
                string solutionZ = solZ.Text;
                SolutionZ = Int32.Parse(solutionZ);
            }
            catch
            {
                solZ.BackColor = Color.Red;
            }
           
                if (SolutionX == varA + varD)
                {
                    xVar = true;
                    solX.BackColor = Color.Green;
                }
                else if (SolutionX != varA + varD)
                {
                    xVar = false;
                    solX.BackColor = Color.Red;
                }
                if (SolutionY == varB + varE)
                {
                    yVar = true;
                    solY.BackColor = Color.Green;
                }
                else if (SolutionY != varB + varE)
                {
                    yVar = false;
                    solY.BackColor = Color.Red;
                }

                if (SolutionZ == varC + varF)
                {
                    zVar = true;
                    solZ.BackColor = Color.Green;
                }
                else if (SolutionZ != varC + varF)
                {
                    zVar = false;
                    solZ.BackColor = Color.Red;
                }

                if (xVar == true && yVar == true && zVar == true)
                {
                    buttonFinish.Visible = true;
                    
                }
                else if (xVar == false && yVar == false && zVar == false)
                {
                    buttonFinish.Visible = false;
                }

            
        }
           


        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonFinish_Click_1(object sender, EventArgs e)
        {
            EndScreen end = new EndScreen();
            end.Show();
            Visible = false;
        }
    }
}
