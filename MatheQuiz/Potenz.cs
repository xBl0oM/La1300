using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatheQuiz
{
    public partial class Potenz : Form
    {
        int A = 0;
        int B = 0;
        int i = 0;
        int c = 0;
        int result = 0;
        int solution = 0;


        
    
        public Potenz()
        {
            InitializeComponent();
            Random rnd = new Random();
             A = rnd.Next(1, 10);
             B = rnd.Next(3, 9);
            string stringA = A.ToString();
            string stringB = B.ToString();
            countA.Text = (stringA);
            countC.Text = (stringB);
            
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Potenz_end potenz_end= new Potenz_end();
            potenz_end.Show();
            Visible = false;
      
           
        }
    }
}
