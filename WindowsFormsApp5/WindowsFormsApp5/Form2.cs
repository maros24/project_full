using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            this.button1.Click += new EventHandler(firstAction);
            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {


        }

        TextBox textBox3 = new TextBox();
        private void firstAction(object sender, EventArgs e)
        {
            
            Point currentLocation = textBox2.Location;
            TextBox text = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation.X, currentLocation.Y += 35)
            };
            text.BackColor = Color.DodgerBlue;
            text.Font = new Font(text.Font, text.Font.Style | FontStyle.Bold);
            this.button1.Click -= new EventHandler(firstAction);
            this.button1.Click += new EventHandler(secondAction);
            this.Controls.Add(text);
            textBox3 = text;

        }
        TextBox textBox4 = new TextBox();
        private void secondAction(object sender, EventArgs e)
        {
            Point currentLocation1 = textBox2.Location;
            TextBox text1 = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation1.X, currentLocation1.Y += 70)
            };
            text1.BackColor = Color.DodgerBlue;
            text1.Font = new Font(text1.Font, text1.Font.Style | FontStyle.Bold);
            this.Controls.Add(text1);
            this.button1.Click -= new EventHandler(secondAction);
            this.button1.Click += new EventHandler(thirdAction);
            textBox4 = text1;
        }

        TextBox textBox5 = new TextBox();
        private void thirdAction(object sender, EventArgs e)
        {
            Point currentLocation2 = textBox2.Location;
            TextBox text2 = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation2.X, currentLocation2.Y += 105)
            };
            text2.BackColor = Color.DodgerBlue;
            text2.Font = new Font(text2.Font, text2.Font.Style | FontStyle.Bold);
            this.Controls.Add(text2);
            this.button1.Click -= new EventHandler(thirdAction);
            this.button1.Click += new EventHandler(fourthAction);
            textBox5 = text2;
        }

        TextBox textBox6 = new TextBox();
        private void fourthAction(object sender, EventArgs e)
        {
            Point currentLocation3 = textBox2.Location;
            TextBox text3 = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation3.X, currentLocation3.Y += 140)
            };
            text3.BackColor = Color.DodgerBlue;
            text3.Font = new Font(text3.Font, text3.Font.Style | FontStyle.Bold);
            this.Controls.Add(text3);
            this.button1.Click -= new EventHandler(fourthAction);
            this.button1.Click += new EventHandler(fifthAction);
            textBox6 = text3;
        }

        TextBox textBox7 = new TextBox();
        private void fifthAction(object sender, EventArgs e)
        {
            Point currentLocation4 = textBox2.Location;
            TextBox text4 = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation4.X, currentLocation4.Y += 175)
            };
            text4.BackColor = Color.DodgerBlue;
            text4.Font = new Font(text4.Font, text4.Font.Style | FontStyle.Bold);
            this.Controls.Add(text4);
            this.button1.Click -= new EventHandler(fifthAction);
            textBox7 = text4;
        }





        
        public void button2_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3(
                this.textBox1.Text, 
                this.textBox2.Text,
                this.textBox3.Text, 
                this.textBox4.Text,
                this.textBox5.Text,
                this.textBox6.Text,
                this.textBox7.Text);
                this.Hide();
                form3.Show();
            
          

    }
        
    };
}

