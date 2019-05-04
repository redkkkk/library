using System;
using System.Windows.Forms;

namespace library.forms
{
    public partial class MainForm : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public MainForm()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width += 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if (panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void Button1_Click(object sender, EventArgs e) // Выдача
        {
            moveSidePanel(button1);
        }

        private void Button2_Click(object sender, EventArgs e) // Получение
        {
            moveSidePanel(button2);
        }

        private void Button3_Click(object sender, EventArgs e) // Читатели
        {
            moveSidePanel(button3);
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            moveSidePanel(button4);
        }
    }
}
