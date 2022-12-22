using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatheQuiz
{
    
    public partial class Form1 : Form
    {
        string difficultyEasy;
        string difficultyMedium;
        string difficultyHard;
        public Form1()
        {
            InitializeComponent();

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string difficulty = "einfach";
            Properties.Settings.Default.Schwierigkeit = difficulty;
            Properties.Settings.Default.Save();
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
            string difficulty = "mittel";
             Properties.Settings.Default.Schwierigkeit = difficulty ;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string difficulty = "schwer";
            Properties.Settings.Default.Schwierigkeit = difficulty;
            Properties.Settings.Default.Save();
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
