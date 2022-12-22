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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Titel.Text = ("Welches Thema wollen Sie in der stufe " + Properties.Settings.Default.Schwierigkeit + " spielen?");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basics basics = new Basics();
            basics.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Potenz potenz= new Potenz();
            potenz.Show();
            Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Algebra alg = new Algebra();
            alg.Show();
            Visible= false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
