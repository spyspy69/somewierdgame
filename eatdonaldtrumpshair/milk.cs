using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eatdonaldtrumpshair
{
    public partial class milk : Form
    {
        public int milked = Settings1.Default.milkint;
        public milk()
        {
            InitializeComponent();
            InitTimer();
            Save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            milked++;
            label2.Text = milked.ToString();
        }
        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("saving...");
            Save();
        }

        private void Save()
        {
            Settings1.Default.milkint = milked;
            Console.WriteLine("saved");
        }
    }
}
