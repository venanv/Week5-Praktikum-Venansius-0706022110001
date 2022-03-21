using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbn.Items.Contains(tb1.Text))
            {
                MessageBox.Show("Input Ulang");
            }
            else
            {
                lbn.Items.Add(tb1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputlabel.Text = lbn.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                if (rb1.Checked = true && rb2.Checked == false)
                {
                    outputlabel.ForeColor = Color.Red;
                }
                else if (rb2.Checked == true && rb1.Checked == false)
                {
                    outputlabel.ForeColor = Color.Blue;
                }
            }
            else if (cb1.Checked == false)
            {

                outputlabel.ForeColor = Color.Black;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                if (rb1.Checked = true && rb2.Checked == false)
                {
                    outputlabel.ForeColor = Color.Red;
                }
                else if (rb2.Checked == true && rb1.Checked == false)
                {
                    outputlabel.ForeColor = Color.Blue;
                }
            }
            else if (cb1.Checked == false)
            {

                outputlabel.ForeColor = Color.Black;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                if (rb1.Checked = true && rb2.Checked == false)
                {
                    outputlabel.ForeColor = Color.Red;
                }
                else if (rb2.Checked == true && rb1.Checked == false)
                {
                    outputlabel.ForeColor = Color.Blue;
                }
            }
            else if (cb1.Checked == false)
            {

                outputlabel.ForeColor = Color.Black;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputlabel.Text = ("");
            cb1.Checked = false;
            rb1.Checked = false;
            rb2.Checked = false;
        }
    }
}
