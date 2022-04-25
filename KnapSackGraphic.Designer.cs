namespace Knapsack_problem
{
    partial class KnapSackGraphic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btShowCpuUsage = new System.Windows.Forms.Button();
            this.lbProcessorUsage = new System.Windows.Forms.Label();
            this.timerCpu = new System.Windows.Forms.Timer(this.components);
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.tbRecursion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRamUsage = new System.Windows.Forms.Label();
            this.btMemoization = new System.Windows.Forms.Button();
            this.chartindicatorPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumbersAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRequiredSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCPU
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCPU.Legends.Add(legend2);
            this.chartCPU.Location = new System.Drawing.Point(445, 66);
            this.chartCPU.Name = "chartCPU";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCPU.Series.Add(series2);
            this.chartCPU.Size = new System.Drawing.Size(331, 79);
            this.chartCPU.TabIndex = 0;
            this.chartCPU.Text = "chart1";
            // 
            // btShowCpuUsage
            // 
            this.btShowCpuUsage.Location = new System.Drawing.Point(323, 70);
            this.btShowCpuUsage.Name = "btShowCpuUsage";
            this.btShowCpuUsage.Size = new System.Drawing.Size(107, 23);
            this.btShowCpuUsage.TabIndex = 1;
            this.btShowCpuUsage.Text = "CPU/RAM usage";
            this.btShowCpuUsage.UseVisualStyleBackColor = true;
            this.btShowCpuUsage.Click += new System.EventHandler(this.btShowCpuUsage_Click);
            // 
            // lbProcessorUsage
            // 
            this.lbProcessorUsage.AutoSize = true;
            this.lbProcessorUsage.Location = new System.Drawing.Point(320, 96);
            this.lbProcessorUsage.Name = "lbProcessorUsage";
            this.lbProcessorUsage.Size = new System.Drawing.Size(93, 13);
            this.lbProcessorUsage.TabIndex = 2;
            this.lbProcessorUsage.Text = "lbProcessorUsage";
            // 
            // timerCpu
            // 
            this.timerCpu.Interval = 1000;
            this.timerCpu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbInformation
            // 
            this.rtbInformation.Location = new System.Drawing.Point(26, 151);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.Size = new System.Drawing.Size(750, 257);
            this.rtbInformation.TabIndex = 3;
            this.rtbInformation.Text = "";
            // 
            // tbRecursion
            // 
            this.tbRecursion.Location = new System.Drawing.Point(26, 122);
            this.tbRecursion.Name = "tbRecursion";
            this.tbRecursion.Size = new System.Drawing.Size(107, 23);
            this.tbRecursion.TabIndex = 4;
            this.tbRecursion.Text = "Recursion";
            this.tbRecursion.UseVisualStyleBackColor = true;
            this.tbRecursion.Click += new System.EventHandler(this.tbRecursion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "KnapSack problem";
            // 
            // lbRamUsage
            // 
            this.lbRamUsage.AutoSize = true;
            this.lbRamUsage.Location = new System.Drawing.Point(320, 122);
            this.lbRamUsage.Name = "lbRamUsage";
            this.lbRamUsage.Size = new System.Drawing.Size(68, 13);
            this.lbRamUsage.TabIndex = 6;
            this.lbRamUsage.Text = "lbRamUsage";
            // 
            // btMemoization
            // 
            this.btMemoization.Location = new System.Drawing.Point(149, 122);
            this.btMemoization.Name = "btMemoization";
            this.btMemoization.Size = new System.Drawing.Size(107, 23);
            this.btMemoization.TabIndex = 7;
            this.btMemoization.Text = "Memoization";
            this.btMemoization.UseVisualStyleBackColor = true;
            this.btMemoization.Click += new System.EventHandler(this.btMemoization_Click);
            // 
            // chartindicatorPanel
            // 
            this.chartindicatorPanel.Location = new System.Drawing.Point(445, 53);
            this.chartindicatorPanel.Name = "chartindicatorPanel";
            this.chartindicatorPanel.Size = new System.Drawing.Size(331, 5);
            this.chartindicatorPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numbers amount:";
            // 
            // tbNumbersAmount
            // 
            this.tbNumbersAmount.Location = new System.Drawing.Point(119, 50);
            this.tbNumbersAmount.Name = "tbNumbersAmount";
            this.tbNumbersAmount.Size = new System.Drawing.Size(40, 20);
            this.tbNumbersAmount.TabIndex = 11;
            this.tbNumbersAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumbersAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Required sum:";
            // 
            // tbRequiredSum
            // 
            this.tbRequiredSum.Location = new System.Drawing.Point(119, 77);
            this.tbRequiredSum.Name = "tbRequiredSum";
            this.tbRequiredSum.Size = new System.Drawing.Size(40, 20);
            this.tbRequiredSum.TabIndex = 13;
            this.tbRequiredSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRequiredSum_KeyPress);
            // 
            // KnapSackGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRequiredSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumbersAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartindicatorPanel);
            this.Controls.Add(this.btMemoization);
            this.Controls.Add(this.lbRamUsage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRecursion);
            this.Controls.Add(this.rtbInformation);
            this.Controls.Add(this.lbProcessorUsage);
            this.Controls.Add(this.btShowCpuUsage);
            this.Controls.Add(this.chartCPU);
            this.Name = "KnapSackGraphic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KnapSackGraphic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Button btShowCpuUsage;
        private System.Windows.Forms.Label lbProcessorUsage;
        private System.Windows.Forms.Timer timerCpu;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Button tbRecursion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRamUsage;
        private System.Windows.Forms.Button btMemoization;
        private System.Windows.Forms.Panel chartindicatorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumbersAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRequiredSum;
    }
}

