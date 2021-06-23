using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cleaning
{
    public partial class Cleaning_Process : Form
    {
        public Cleaning_Process(int Process_Temp, int Process_Value, int Process_Cycles, int Process_Time)
        {
            InitializeComponent();
            this.Test_label.Text = Convert.ToString(Process_Temp);
        }
        private void Cleaning_Process_Load(object sender, EventArgs e)
        {
            {
                
                timer1.Interval = 500; // 500 миллисекунд
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
            }
            // обработчик события Tick таймера
            void timer1_Tick(object sender, EventArgs e)
            {
                progressBar1.PerformStep();
            }
        }
    }
}
