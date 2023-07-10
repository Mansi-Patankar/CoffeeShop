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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public async void DataFromCloud()
        {
            Cursor.Current = Cursors.WaitCursor;
            FirebaseClient fb = new FirebaseClient(fbconfig.url);
            Registerpojo obj = new Registerpojo();

            obj.Username1 = textBox1.Text; // Je fields ghetle login sathi
            obj.Password1 = textBox2.Text;
            var fbdata = await fb.Child("RegisterObj").OnceAsync<Registerpojo>();
            int id = 0;
            foreach (var data in fbdata)
            {
                Registerpojo rg = new Registerpojo(); // Class name
                rg.Username1 = data.Object.Username1;
                rg.Password1 = data.Object.Password1;

                if (rg.Username1 == textBox1.Text && rg.Password1 == textBox2.Text)
                {
                    id = 1;
                    //MessageBox.Show("Login Done Successfully");
                    log n = new log();
                    n.Show();
                    this.Hide();
                    

                    return;
                }

            }
            if (id == 0)
            {
                MessageBox.Show("Invalid User");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';


            }
            else
            {
                textBox2.PasswordChar = '*';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataFromCloud();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 c = new Form2();
            c.Show();
            this.Hide();
        }
    }
}
