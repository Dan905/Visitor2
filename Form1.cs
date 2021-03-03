using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool buttonwasclicked = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("First name cannot be empty");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Last Name cannot be empty");
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Mobile Number cannot be empty");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Email ID cannot be empty");
                textBox4.BackColor = Color.Red;
                textBox4.Focus();
            }
            else if (numericUpDown1.Value == 0)
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time:");
            }
            else if (numericUpDown2.Value == 0)
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time:");
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select AM or PM");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any Meeting with");
            }
            else if (buttonwasclicked == false)
            {
                MessageBox.Show("Please select any Meeting aim");
            }
            listBox1.Items.Add("Name: " + textBox1.Text + " " + textBox2.Text);
            listBox1.Items.Add("Hours: " + numericUpDown1.Value + ":" + numericUpDown2.Value + " " + comboBox2.SelectedItem);
            listBox1.Items.Add("Meeting Aim: " + button1.Text);
            listBox1.Items.Add("Meeting with: " + comboBox1.Text);
            listBox1.Items.Add("----------------------------------------------------");

            textBox1.Text = ("");
            textBox1.BackColor = Color.White;
            textBox2.Text = ("");
            textBox2.BackColor = Color.White;
            textBox3.Text = ("");
            textBox3.BackColor = Color.White;
            textBox4.Text = ("");
            textBox4.BackColor = Color.White;
            numericUpDown1.Value = (1);
            numericUpDown1.BackColor = Color.White;
            numericUpDown2.Value = (0);
            numericUpDown2.BackColor = Color.White;
            comboBox1.Text = ("");
            comboBox1.BackColor = Color.White;
            comboBox2.Text = ("");
            comboBox2.BackColor = Color.White;
            button1.Text = ("Meeting aim");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sv = new Form2();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                buttonwasclicked = true;
                if (sv.radioButton1.Checked == true)
                {
                    button1.Text = sv.radioButton1.Text;
                }
                else if (sv.radioButton2.Checked == true)
                {
                    button1.Text = sv.radioButton2.Text;
                }
                else if (sv.radioButton3.Checked == true)
                {
                    button1.Text = sv.radioButton3.Text;
                }
                else if (sv.radioButton4.Checked == true)
                {
                    button1.Text = sv.radioButton4.Text;
                }
                else
                {
                    button1.Text = ("Meeting aim");
                    this.Close();
                }
            }
        }
        void resetfields()
        {
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.ResetText();

            numericUpDown1.Value = 0;
            numericUpDown1.ResetText();

            comboBox1.Text = "Select Interviewer";
            comboBox1.SelectedIndex = -1;
            comboBox1.ResetText();

            button1.ResetText();
            button1.Text = "Meeting aim";

            dateTimePicker1.ResetText();
            dateTimePicker1.Value = DateTime.Now;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
