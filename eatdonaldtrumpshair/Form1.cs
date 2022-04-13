using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace eatdonaldtrumpshair
{
    public partial class wtf : Form
    {
        public int hE = 0;
        public int T = Settings1.Default.lastTroopCount;
        public int nkHP = 100;
        public int nkHPBase = 100;
        public int nkHPBF = 100;
        public float howCloseIsTheMilk = 0.0000000000000000000000000000000001f;
        public bool isMilkOut = Settings1.Default.milkUpdateOut;
        public wtf()
        {
            InitializeComponent();
            InitTimer();
            Save();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            form.TopMost = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            hE++;
            label5.Text = hE.ToString();
            button1.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(3));
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (hE >= 10)
            {
                hE = hE - 10;
                label5.Text = hE.ToString();
                T++;
                label6.Text = T.ToString();
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while(T != 0)
            {
                nkHP = nkHP - 10;
                T = T - 1;
                label6.Text = T.ToString();
            }
            if (nkHP <= 0)
            {
                nkHPBase = nkHPBase + 100;
                nkHP = nkHP + nkHPBase;
                label9.Text = nkHP.ToString();
                nkHPBF = nkHP;
            }
            else
            {
                nkHP = nkHPBF;
                label9.Text = nkHP.ToString();
            }
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
            Settings1.Default.lastTroopCount = T;
            Console.WriteLine("saved");
        }
    }
}
