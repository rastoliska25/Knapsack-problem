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
            lbProcessorUsage.Text = processorUsage.getCurrentCpuUsage();
            lbRamUsage.Text = processorUsage.getAvailableRAM();
        }

        private void tbRecursion_Click(object sender, EventArgs e)
        {
            int[] inputNumbers;
            string inputNumbersS = "";
            string result;
            int i = 10;

            Random random = new Random();
            inputNumbers = new int[i];

            //input
            for (int j = 0; j < inputNumbers.Length; j++)
            {
                inputNumbers[j] = random.Next(100, 800);
                inputNumbersS = inputNumbersS + "   " + inputNumbers[j].ToString();
            }

            Recursion recursion = new Recursion();
            result = (recursion.itemsUsed(inputNumbers, 3500, 0));
            rtbInformation.Text = "Inserted numbers: " + inputNumbersS + "\n\n" + result;
        }

        private void KnapSackGraphic_Load(object sender, EventArgs e)
        {
            lbProcessorUsage.Text = "";
            lbRamUsage.Text = "";
        }
    }
}
