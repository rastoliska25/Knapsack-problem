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

        private void tbRecursion_Click(object sender, EventArgs e)
        {
            int[] inputNumbers; //označenia nechavam rovnako ako čísla
            int result;

            inputNumbers = new int[6];

            //input test
            inputNumbers[0] = 8;
            inputNumbers[1] = 9;
            inputNumbers[2] = 7;
            inputNumbers[3] = 6;
            inputNumbers[4] = 5;
            inputNumbers[5] = 4;

            Recursion recursion = new Recursion();
            result = (recursion.knapsack(inputNumbers, inputNumbers, 38, 0));
            rtbInformation.Text = result.ToString();
        }
    }
}
