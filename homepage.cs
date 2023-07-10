using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cc
{
    public partial class homepage : Form
    {
        
        public homepage()
        {
            InitializeComponent();         
        }

      
        private void homepage_Load(object sender, EventArgs e)
        {

        }

        

        

        
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;

            // Iterate through all the checkboxes on the form
            foreach (CheckBox chkBox in this.Controls.OfType<CheckBox>())
            {
                // If the checkbox is checked, add its Tag value to the running total
                if (chkBox.Checked)
                {
                    total += int.Parse(chkBox.Tag.ToString());
                }
            }
            // Display the total in the TextBox control
            textBox1.Text = total.ToString();

            listBox1.Items.Clear();
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    listBox1.Items.Add(checkBox.Text);
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox1.Tag = 60;

            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                numericUpDown1.Text = "1";

            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Text = "0";

            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox2.Tag = 60;

            if (checkBox2.Checked == true)
            {
                numericUpDown2.Enabled = true;
                numericUpDown2.Text = "1";

            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Text = "0";

            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Tag = 65;
            if (checkBox3.Checked == true)
            {
                numericUpDown3.Enabled = true;
                numericUpDown3.Text = "1";

            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Text = "0";

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Tag = 50;
            if (checkBox4.Checked == true)
            {
                numericUpDown4.Enabled = true;
                numericUpDown4.Text = "1";

            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown4.Text = "0";

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Tag = 40;
            if (checkBox5.Checked == true)
            {
                numericUpDown5.Enabled = true;
                numericUpDown5.Text = "1";

            }
            else
            {
                numericUpDown5.Enabled = false;
                numericUpDown5.Text = "0";

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Tag = 40;
            if (checkBox6.Checked == true)
            {
                numericUpDown6.Enabled = true;
                numericUpDown6.Text = "1";

            }
            else
            {
                numericUpDown6.Enabled = false;
                numericUpDown6.Text = "0";

            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Tag = 70;
            if (checkBox12.Checked == true)
            {
                numericUpDown12.Enabled = true;
                numericUpDown12.Text = "1";

            }
            else
            {
                numericUpDown12.Enabled = false;
                numericUpDown12.Text = "0";

            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Tag = 60;
            if (checkBox11.Checked == true)
            {
                numericUpDown11.Enabled = true;
                numericUpDown11.Text = "1";

            }
            else
            {
                numericUpDown11.Enabled = false;
                numericUpDown11.Text = "0";

            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Tag = 60;
            if (checkBox10.Checked == true)
            {
                numericUpDown10.Enabled = true;
                numericUpDown10.Text = "1";

            }
            else
            {
                numericUpDown10.Enabled = false;
                numericUpDown10.Text = "0";

            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Tag = 50;
            if (checkBox9.Checked == true)
            {
                numericUpDown9.Enabled = true;
                numericUpDown9.Text = "1";

            }
            else
            {
                numericUpDown9.Enabled = false;
                numericUpDown9.Text = "0";

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Tag = 70;
            if (checkBox8.Checked == true)
            {
                numericUpDown8.Enabled = true;
                numericUpDown8.Text = "1";

            }
            else
            {
                numericUpDown8.Enabled = false;
                numericUpDown8.Text = "0";

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Tag = 60;
            if (checkBox7.Checked == true)
            {
                numericUpDown7.Enabled = true;
                numericUpDown7.Text = "1";

            }
            else
            {
                numericUpDown7.Enabled = false;
                numericUpDown7.Text = "0";

            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            checkBox18.Tag = 50;
            if (checkBox18.Checked == true)
            {
                numericUpDown18.Enabled = true;
                numericUpDown18.Text = "1";

            }
            else
            {
                numericUpDown18.Enabled = false;
                numericUpDown18.Text = "0";

            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Tag = 70;
            if (checkBox17.Checked == true)
            {
                numericUpDown17.Enabled = true;
                numericUpDown17.Text = "1";

            }
            else
            {
                numericUpDown17.Enabled = false;
                numericUpDown17.Text = "0";

            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox16.Tag = 50;
            if (checkBox16.Checked == true)
            {
                numericUpDown16.Enabled = true;
                numericUpDown16.Text = "1";

            }
            else
            {
                numericUpDown16.Enabled = false;
                numericUpDown16.Text = "0";

            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            checkBox15.Tag = 70;
            if (checkBox15.Checked == true)
            {
                numericUpDown15.Enabled = true;
                numericUpDown15.Text = "1";

            }
            else
            {
                numericUpDown15.Enabled = false;
                numericUpDown15.Text = "0";

            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Tag = 60;
            if (checkBox14.Checked == true)
            {
                numericUpDown14.Enabled = true;
                numericUpDown14.Text = "1";

            }
            else
            {
                numericUpDown14.Enabled = false;
                numericUpDown14.Text = "0";

            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox13.Tag = 60;
            if (checkBox13.Checked == true)
            {
                numericUpDown13.Enabled = true;
                numericUpDown13.Text = "1";
            }

            else
            {
                numericUpDown13.Enabled = false;
                numericUpDown13.Text = "0";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int total = 0;

            // Iterate through all the checkboxes on the form
            foreach (CheckBox chkBox in this.Controls.OfType<CheckBox>())
            {
                // If the checkbox is checked, add its Tag value to the running total
                if (chkBox.Checked)
                {
                    total += int.Parse(chkBox.Tag.ToString());
                }
            }
            // Display the total in the TextBox control
            textBox1.Text = total.ToString();

            listBox1.Items.Clear();
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    listBox1.Items.Add(checkBox.Text);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
