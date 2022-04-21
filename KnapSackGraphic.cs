using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knapsack_problem
{
    public partial class KnapSackGraphic : Form
    {
        ProcessorUsage processorUsage;
        public KnapSackGraphic()
        {
            InitializeComponent();
        }

        private void btShowCpuUsage_Click(object sender, EventArgs e)
        {
            ProcessorUsage processorUsage = new ProcessorUsage();
            this.processorUsage = processorUsage;

            //lbProcessorUsage.Text = "Processor usage : " + processorUsage.getCurrentCpuUsage();
            timerCpu.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbProcessorUsage.Text =  processorUsage.getCurrentCpuUsage();
        }
    }
}
