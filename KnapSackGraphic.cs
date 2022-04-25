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
        int tickNumber = 0;

        ProcessorUsage processorUsage;
        public KnapSackGraphic()
        {
            InitializeComponent();
        }

        private void btShowCpuUsage_Click(object sender, EventArgs e)
        {
            ProcessorUsage processorUsage = new ProcessorUsage();
            this.processorUsage = processorUsage;

            if (timerCpu.Enabled == false)
            {
                timerCpu.Enabled = true;
                chartindicatorPanel.BackColor = Color.Green;
            }
            else
            {
                chartindicatorPanel.BackColor = Color.Gray;
                tickNumber = 0;
                chartCPU.Series[0].Points.Clear();
                timerCpu.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float CpuUsage;
            CpuUsage = processorUsage.getCurrentCpuUsage();
            lbProcessorUsage.Text = CpuUsage.ToString("0.0000") + "%";

            if (tickNumber < 7)
            {
                chartCPU.Series[0].Points.Add(CpuUsage, tickNumber);
                tickNumber++;
            }
            else
            {
                tickNumber = 0;
                chartCPU.Series[0].Points.Clear();
                chartCPU.Series[0].Points.Add(CpuUsage, tickNumber);
            }
            lbRamUsage.Text = processorUsage.getAvailableRAM();
        }

        private void tbRecursion_Click(object sender, EventArgs e)
        {
            Calculation(sender, e);
        }

        private void KnapSackGraphic_Load(object sender, EventArgs e)
        {
            lbProcessorUsage.Text = "";
            lbRamUsage.Text = "";
            chartindicatorPanel.BackColor = Color.Gray;
            tickNumber = 0;
            chartCPU.Series[0].Points.Clear();
            chartCPU.Series[0].Name = "CPU Load";
        }

        private void Calculation(object sender, EventArgs e)
        {
            if (tbNumbersAmount.Text == "")
            {
                MessageBox.Show("please insert Numbers amount");
                return;
            }

            int[] inputNumbers;
            string inputNumbersS = "";
            string result = "";
            int numbersCount = Convert.ToInt32(tbNumbersAmount.Text);

            if (numbersCount > 100)
            {
                MessageBox.Show("numbers amount is too big! please insert numbert from 1 to 100");
                return;
            }

            Random random = new Random();
            inputNumbers = new int[numbersCount];

            //input
            for (int j = 0; j < inputNumbers.Length; j++)
            {
                inputNumbers[j] = random.Next(100, 800);
                inputNumbersS = inputNumbersS + "   " + inputNumbers[j].ToString();
            }

            if (sender == tbRecursion)
            {
                Recursion recursion = new Recursion();
                result = (recursion.itemsUsed(inputNumbers, 7555, inputNumbers.Length));
            }
            else
            {
                Memoization memoization = new Memoization();
                result = (memoization.itemsUsed(inputNumbers, 7555, inputNumbers.Length));
            }

            rtbInformation.Text = "Inserted numbers: " + inputNumbersS + "\n\n" + result;
        }

        private void btMemoization_Click(object sender, EventArgs e)
        {
            Calculation(sender, e);
        }

        private void tbNumbersAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (!(e.KeyChar == (char)8)) && (!(e.KeyChar == (char)13)))
            {
                e.Handled = true;
                MessageBox.Show("please insert number from 1 to 100");
                tbNumbersAmount.Text = "";
            }
        }
    }
}
