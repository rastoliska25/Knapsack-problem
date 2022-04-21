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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btShowCpuUsage = new System.Windows.Forms.Button();
            this.lbProcessorUsage = new System.Windows.Forms.Label();
            this.timerCpu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCPU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(399, 182);
            this.chartCPU.Name = "chartCPU";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCPU.Series.Add(series1);
            this.chartCPU.Size = new System.Drawing.Size(371, 106);
            this.chartCPU.TabIndex = 0;
            this.chartCPU.Text = "chart1";
            // 
            // btShowCpuUsage
            // 
            this.btShowCpuUsage.Location = new System.Drawing.Point(544, 89);
            this.btShowCpuUsage.Name = "btShowCpuUsage";
            this.btShowCpuUsage.Size = new System.Drawing.Size(107, 23);
            this.btShowCpuUsage.TabIndex = 1;
            this.btShowCpuUsage.Text = "Výkon procesora";
            this.btShowCpuUsage.UseVisualStyleBackColor = true;
            this.btShowCpuUsage.Click += new System.EventHandler(this.btShowCpuUsage_Click);
            // 
            // lbProcessorUsage
            // 
            this.lbProcessorUsage.AutoSize = true;
            this.lbProcessorUsage.Location = new System.Drawing.Point(541, 125);
            this.lbProcessorUsage.Name = "lbProcessorUsage";
            this.lbProcessorUsage.Size = new System.Drawing.Size(93, 13);
            this.lbProcessorUsage.TabIndex = 2;
            this.lbProcessorUsage.Text = "lbProcessorUsage";
            // 
            // timerCpu
            // 
            this.timerCpu.Interval = 2000;
            this.timerCpu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KnapSackGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProcessorUsage);
            this.Controls.Add(this.btShowCpuUsage);
            this.Controls.Add(this.chartCPU);
            this.Name = "KnapSackGraphic";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Button btShowCpuUsage;
        private System.Windows.Forms.Label lbProcessorUsage;
        private System.Windows.Forms.Timer timerCpu;
    }
}

