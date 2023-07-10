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
    
    public partial class ty : Form
    {
        int ticks;
        public ty()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 4)
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                timer1.Stop();
            }

        }
    }
}
