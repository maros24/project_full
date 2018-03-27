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
    public partial class Form3 : Form
    {

        string name1, name2, name3, name4, name5, name6, name7;
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;
        int sum5 = 0;
        int sum6 = 0;
        int sum7 = 0;
        Label label8 = new Label();
        const string caption = "Согласны выполнить?";



        public Form3(string name1, string name2, string name3, string name4, string name5, string name6, string name7)
        {

            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            this.name4 = name4;
            this.name5 = name5;
            this.name6 = name6;
            this.name7 = name7;
            InitializeComponent();

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            Massive();
            label16.Text = name1;
        }



        public void Massive()
        {
            
            if (name1 != "")
            {
                label1.Text = name1 + ":";
            }
            if (name2 != "")
            {
                label2.Text = name2 + ":";
            }
            if (name3 != "")
            {
                label3.Text = name3 + ":";
            }
            if (name4 != "")
            {
                label4.Text = name4 + ":";
            }
            if (name5 != "")
            {
                label5.Text = name5 + ":";
            }
            if (name6 != "")
            {
                label6.Text = name6 + ":";
            }
            if (name7 != "")
            {
                label7.Text = name7 + ":";
            }
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] mas = { "Как часто Вы думаете о смерти?",
                      "что больше всего раздажает тебя в соседнем игроке",
                      "Счтиаете ли Вы себя мудрым человеком?",
                      "Самая худшая ситуация на работе",
                      "Если бы была машина времени, куда бы отправились?",
                      "За какой свой недостаток тебе стыдно7",
                      "Когда последний раз ты читал чужую переписку?",
                      "Самая безумная вещь, которую Вы когда-либо делали"
                       };
            Random rand = new Random();


            if (label16.Text == name1)
            {
                string temp = mas[rand.Next(0, 8)];
                var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    sum1 -= 10;
                }
                else { sum1 += 10; }
                label9.Text = sum1.ToString();
                label16.Text = name2;
            }

            else
            {
                if (label16.Text == name2)
                {
                    string temp = mas[rand.Next(0, 8)];
                    var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        sum2 -= 10;
                    }
                    else { sum2 += 10; }
                    label10.Text = sum2.ToString();
                    if (name3 != "")
                    {
                        label16.Text = name3;
                    }
                    else
                    {
                        if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                        {
                            MessageBox.Show("Winner");
                        }
                        else
                        {
                            label16.Text = name1;
                        }
                    };
                }
                else
                {
                    if (label16.Text == name3)
                    {
                        string temp = mas[rand.Next(0, 8)];
                        var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            sum3 -= 10;
                        }
                        else { sum3 += 10; }
                        label11.Text = sum3.ToString();
                        if (name4 != "")
                        {
                            label16.Text = name4;
                        }
                        else
                        {
                            if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                            {
                                MessageBox.Show("Winner");
                            }
                            else
                            {
                                label16.Text = name1;
                            }
                        }
                    }
                    else
                    {
                        if (label16.Text == name4)
                        {
                            string temp = mas[rand.Next(0, 8)];
                            var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                sum4 -= 10;
                            }
                            else { sum4 += 10; }
                            label12.Text = sum4.ToString();
                            if (name5 != "")
                            {
                                label16.Text = name5;
                            }
                            else
                            {
                                if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                {
                                    MessageBox.Show("Winner");
                                }
                                else
                                {
                                    label16.Text = name1;
                                }
                            }
                        }
                        else
                        {
                            if (label16.Text == name5)
                            {
                                string temp = mas[rand.Next(0, 8)];
                                var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.No)
                                {
                                    sum5 -= 10;
                                }
                                else { sum5 += 10; }
                                label13.Text = sum5.ToString();
                                if (name6 != "")
                                {
                                    label16.Text = name6;
                                }
                                else
                                {
                                    if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                    {
                                        MessageBox.Show("Winner");
                                    }
                                    else
                                    {
                                        label16.Text = name1;
                                    }
                                }
                            }
                            else
                            {
                                if (label16.Text == name6)
                                {
                                    string temp = mas[rand.Next(0, 8)];
                                    var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.No)
                                    {
                                        sum6 -= 10;
                                    }
                                    else { sum6 += 10; }
                                    label14.Text = sum6.ToString();
                                    if (name7 != "")
                                    {
                                        label16.Text = name7;
                                    }
                                    else
                                    {
                                        if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                        {
                                            MessageBox.Show("Winner");
                                        }
                                        else
                                        {
                                            label16.Text = name1;
                                        }
                                    }
                                }
                                else
                                {
                                    if (label16.Text == name7)
                                    {
                                        string temp = mas[rand.Next(0, 8)];
                                        var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (result == DialogResult.No)
                                        {
                                            sum7 -= 10;
                                        }
                                        else { sum7 += 10; }
                                        label15.Text = sum7.ToString();
                                        {
                                            if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                            {
                                                MessageBox.Show("Winner");
                                            }
                                            else
                                            {
                                                label16.Text = name1;
                                            }

                                        }
                                    }

                                }
                            }
                        }

                    }
                }
            }




        }
            


        




        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string[] mas = { "Действие следующего игрока выполняешь с ним",
                      "Выбери игрока и выполняй все его желания следующие 10 минут",
                      "Спеть, зажав нос",
                      "Изобрази назойливую муху",
                      "Повтори предыдущее задание",
                      "Изобрази собаку, которая метит территорию",
                      "Придумай прозвище всем игрокам",
                      "уговорить соседнего игрока купить рулон туалетной бумаги за 150 грн."
                       };

            Random rand = new Random();


            if (label16.Text == name1)
            {
                string temp = mas[rand.Next(0, 8)];
                var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    sum1 -= 10;
                }
                else { sum1 += 10; }
                label9.Text = sum1.ToString();
                label16.Text = name2;
            }

            else
            {
                if (label16.Text == name2)
                {
                    string temp = mas[rand.Next(0, 8)];
                    var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        sum2 -= 10;
                    }
                    else { sum2 += 10; }
                    label10.Text = sum2.ToString();
                    if (name3 != "")
                    {
                        label16.Text = name3;
                    }
                    else
                    {
                        if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                        {
                            MessageBox.Show("Winner");
                        }
                        else
                        {
                            label16.Text = name1;
                        }
                    };
                }
                else
                {
                    if (label16.Text == name3)
                    {
                        string temp = mas[rand.Next(0, 8)];
                        var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            sum3 -= 10;
                        }
                        else { sum3 += 10; }
                        label11.Text = sum3.ToString();
                        if (name4 != "")
                        {
                            label16.Text = name4;
                        }
                        else
                        {
                            if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                            {
                                MessageBox.Show("Winner");
                            }
                            else
                            {
                                label16.Text = name1;
                            }
                        }
                    }
                    else
                    {
                        if (label16.Text == name4)
                        {
                            string temp = mas[rand.Next(0, 8)];
                            var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                sum4 -= 10;
                            }
                            else { sum4 += 10; }
                            label12.Text = sum4.ToString();
                            if (name5 != "")
                            {
                                label16.Text = name5;
                            }
                            else
                            {
                                if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                {
                                    MessageBox.Show("Winner");
                                }
                                else
                                {
                                    label16.Text = name1;
                                }
                            }
                        }
                        else
                        {
                            if (label16.Text == name5)
                            {
                                string temp = mas[rand.Next(0, 8)];
                                var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.No)
                                {
                                    sum5 -= 10;
                                }
                                else { sum5 += 10; }
                                label13.Text = sum5.ToString();
                                if (name6 != "")
                                {
                                    label16.Text = name6;
                                }
                                else
                                {
                                    if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                    {
                                        MessageBox.Show("Winner");
                                    }
                                    else
                                    {
                                        label16.Text = name1;
                                    }
                                }
                            }
                            else
                            {
                                if (label16.Text == name6)
                                {
                                    string temp = mas[rand.Next(0, 8)];
                                    var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.No)
                                    {
                                        sum6 -= 10;
                                    }
                                    else { sum6 += 10; }
                                    label14.Text = sum6.ToString();
                                    if (name7 != "")
                                    {
                                        label16.Text = name7;
                                    }
                                    else
                                    {
                                        if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                        {
                                            MessageBox.Show("Winner");
                                        }
                                        else
                                        {
                                            label16.Text = name1;
                                        }
                                    }
                                }
                                else
                                {
                                    if (label16.Text == name7)
                                    {
                                        string temp = mas[rand.Next(0, 8)];
                                        var result = MessageBox.Show(temp, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (result == DialogResult.No)
                                        {
                                            sum7 -= 10;
                                        }
                                        else { sum7 += 10; }
                                        label15.Text = sum7.ToString();
                                        {
                                            if (sum1 == 30 || sum2 == 30 || sum3 == 30 || sum4 == 30 || sum5 == 30 || sum6 == 30 || sum7 == 30)
                                            {
                                                MessageBox.Show("Winner");
                                            }
                                            else
                                            {
                                                label16.Text = name1;
                                            }

                                        }
                                    }

                                }
                            }
                        }

                    }
                }
            }

        }
    }
}

    


