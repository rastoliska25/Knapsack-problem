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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btShowCpuUsage = new System.Windows.Forms.Button();
            this.lbProcessorUsage = new System.Windows.Forms.Label();
            this.timerCpu = new System.Windows.Forms.Timer(this.components);
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.tbRecursion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRamUsage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCPU
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCPU.Legends.Add(legend3);
            this.chartCPU.Location = new System.Drawing.Point(544, 66);
            this.chartCPU.Name = "chartCPU";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCPU.Series.Add(series3);
            this.chartCPU.Size = new System.Drawing.Size(232, 79);
            this.chartCPU.TabIndex = 0;
            this.chartCPU.Text = "chart1";
            // 
            // btShowCpuUsage
            // 
            this.btShowCpuUsage.Location = new System.Drawing.Point(411, 70);
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
            this.lbProcessorUsage.Location = new System.Drawing.Point(408, 96);
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
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SackPack problem";
            // 
            // lbRamUsage
            // 
            this.lbRamUsage.AutoSize = true;
            this.lbRamUsage.Location = new System.Drawing.Point(408, 122);
            this.lbRamUsage.Name = "lbRamUsage";
            this.lbRamUsage.Size = new System.Drawing.Size(68, 13);
            this.lbRamUsage.TabIndex = 6;
            this.lbRamUsage.Text = "lbRamUsage";
            // 
            // KnapSackGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

