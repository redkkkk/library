using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.userControls
{
    public partial class UC_Main : UserControl
    {
        public UC_Main()
        {
            InitializeComponent();
            // чтение из базы
            label4.Text = "150"; // выдано книг
            label1.Text = "150"; // осталось книг
            label5.Text = "150"; // читателей
            circularProgressBar1.Value = 50; // % выданных книг
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // чтение из базы
            label4.Text = "150"; // выдано книг
            label1.Text = "150"; // осталось книг
            label5.Text = "150"; // читателей
            circularProgressBar1.Value = 50; // % выданных книг
        }
    }
}
