using System;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (forms.MainForm mf = new forms.MainForm())
            {
                mf.ShowDialog();
            }
        }
    }
}
