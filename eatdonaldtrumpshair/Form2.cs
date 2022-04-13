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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
#if !DEBUG
            MessageBox.Show("HAH, did you think i was that stupid to leave this in here?");
#else
            Form milk = new milk();
            if (Application.OpenForms["milk"] != null)
            {
                MessageBox.Show("no");
            }
            else
            {
                milk.Show();
            }
#endif
        }
    }
}
