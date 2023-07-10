using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace cc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public async void Register_Obj()
        {
            Cursor.Current = Cursors.WaitCursor;
            FirebaseClient fb = new FirebaseClient(fbconfig.url);
            Registerpojo obj = new Registerpojo();   // Name of class in the class file
            obj.Name1 = textBox1.Text;
            obj.Username1 = textBox2.Text;
            obj.Contact1 = textBox3.Text;
            obj.Email1 = textBox4.Text;
            obj.Password1 = textBox5.Text;
            

            try
            {
                await fb.Child("RegisterObj").PostAsync(obj);
                //  MessageBox.Show("Registration Done Successfully");
                re c = new re();
                c.Show();
                this.Hide();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Name ");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter UserName ");
                return;
            }
            if (textBox3.TextLength != 10)
            {
                MessageBox.Show("Please enter valid contact number");
            }
            if (textBox4.Text.Trim() == "")
            {

                if (textBox4.Text.Contains("@") == false || textBox4.Text.Contains(".") == false)
                {
                    MessageBox.Show("Please enter valid email");
                }
            }
            Register_Obj();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.PasswordChar = '\0';


            }
            else
            {
                textBox5.PasswordChar = '*';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Show();
            this.Hide();
        }
    }
}
