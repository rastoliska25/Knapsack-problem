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
            timerCpu.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float CpuUsage;
            CpuUsage = processorUsage.getCurrentCpuUsage();
            lbProcessorUsage.Text = CpuUsage.ToString("0.0000") + "%";
            chartCPU.Series[0].Points.AddY(CpuUsage);

            lbRamUsage.Text = processorUsage.getAvailableRAM();
        }

        private void tbRecursion_Click(object sender, EventArgs e)
        {
            Calculation(sender,e);
        }

        private void KnapSackGraphic_Load(object sender, EventArgs e)
        {
            lbProcessorUsage.Text = "";
            lbRamUsage.Text = "";
        }

        private void Calculation(object sender, EventArgs e)
        {
            int[] inputNumbers;
            string inputNumbersS = "";
            string result = "";
            int i = 10;

            Random random = new Random();
            inputNumbers = new int[i];

            //input
            for (int j = 0; j < inputNumbers.Length; j++)
            {
                inputNumbers[j] = random.Next(100, 800);
                inputNumbersS = inputNumbersS + "   " + inputNumbers[j].ToString();
            }

            if (sender == tbRecursion)
            {
                Recursion recursion = new Recursion();
                result = (recursion.itemsUsed(inputNumbers, 3500, inputNumbers.Length));
            } 
            else
            {
                Memoization memoization = new Memoization();
                result = (memoization.itemsUsed(inputNumbers, 3500, inputNumbers.Length));
            }

            rtbInformation.Text = "Inserted numbers: " + inputNumbersS + "\n\n" + result;
        }

        private void btMemoization_Click(object sender, EventArgs e)
        {
            Calculation(sender, e);
        }
    }
}
