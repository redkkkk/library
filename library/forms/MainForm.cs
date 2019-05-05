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
            userControls.UC_Main gb = new userControls.UC_Main();
            AddControlsToPanel(gb);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width += 155;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 155;
                if (panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void Button5_Click(object sender, EventArgs e) // Главная
        {
            moveSidePanel(button5);
            userControls.UC_Main mn = new userControls.UC_Main();
            AddControlsToPanel(mn);
        }

        private void Button1_Click(object sender, EventArgs e) // Выдача
        {
            moveSidePanel(button1);
            userControls.UC_GiveBook gb = new userControls.UC_GiveBook();
            AddControlsToPanel(gb);
        }

        private void Button2_Click(object sender, EventArgs e) // Получение
        {
            moveSidePanel(button2);
        }

        private void Button3_Click(object sender, EventArgs e) // Читатели
        {
            moveSidePanel(button3);
        }

        private void Button4_Click(object sender, EventArgs e) // Отчет
        {
            moveSidePanel(button4);
        }

        private void Button9_Click(object sender, EventArgs e) // Выход
        {
            timer1.Start();
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
