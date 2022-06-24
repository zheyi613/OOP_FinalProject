using System.Collections.Generic;
using System.Windows.Forms;
using System;
using ChannelImformationProject;

namespace OOP_FinalProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        private int SamplingRate;
        private List<ChannelImformation> Channels;
        private bool VariableUpdateFlag;    // remember updete button has be clicked, waiting time tick to update variable
        private int TimerCount;
        private Random RandomGenerator;
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Source = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listBox_ChannelList = new System.Windows.Forms.ListBox();
            this.label_ChannelList = new System.Windows.Forms.Label();
            this.button_TimerSwitch = new System.Windows.Forms.Button();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.button_LoadData = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_s = new System.Windows.Forms.Label();
            this.button_SaveData = new System.Windows.Forms.Button();
            this.button_SaveChart = new System.Windows.Forms.Button();
            this.label_Period = new System.Windows.Forms.Label();
            this.comboBox_Period = new System.Windows.Forms.ComboBox();
            this.label_Magnitude = new System.Windows.Forms.Label();
            this.comboBox_Magnitude = new System.Windows.Forms.ComboBox();
            this.label_SamplingRate = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chart_Channel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_Hz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_SamplingRate = new System.Windows.Forms.NumericUpDown();
            this.button_AddChannel = new System.Windows.Forms.Button();
            this.button_DeleteChannel = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox_Function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Channel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SamplingRate)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Source
            // 
            this.button_Source.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.button_Source.Location = new System.Drawing.Point(924, 185);
            this.button_Source.Margin = new System.Windows.Forms.Padding(2);
            this.button_Source.Name = "button_Source";
            this.button_Source.Size = new System.Drawing.Size(133, 39);
            this.button_Source.TabIndex = 0;
            this.button_Source.Text = "Source";
            this.button_Source.UseVisualStyleBackColor = true;
            this.button_Source.Click += new System.EventHandler(this.button_Source_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"txt files (*.txt)|*.txt|Office Files|*.xls|*All files (*.*)|*.*\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"JPEG (*.jpg)|*.jpg|All Files (*.*)|*.*\"";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // listBox_ChannelList
            // 
            this.listBox_ChannelList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.listBox_ChannelList.FormattingEnabled = true;
            this.listBox_ChannelList.ItemHeight = 20;
            this.listBox_ChannelList.Location = new System.Drawing.Point(765, 140);
            this.listBox_ChannelList.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_ChannelList.Name = "listBox_ChannelList";
            this.listBox_ChannelList.Size = new System.Drawing.Size(133, 84);
            this.listBox_ChannelList.TabIndex = 3;
            this.listBox_ChannelList.SelectedIndexChanged += new System.EventHandler(this.listBox_ChannelList_SelectedIndexChanged);
            // 
            // label_ChannelList
            // 
            this.label_ChannelList.AutoSize = true;
            this.label_ChannelList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label_ChannelList.Location = new System.Drawing.Point(761, 111);
            this.label_ChannelList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ChannelList.Name = "label_ChannelList";
            this.label_ChannelList.Size = new System.Drawing.Size(105, 20);
            this.label_ChannelList.TabIndex = 4;
            this.label_ChannelList.Text = "Channel List:";
            // 
            // button_TimerSwitch
            // 
            this.button_TimerSwitch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.button_TimerSwitch.Location = new System.Drawing.Point(875, 18);
            this.button_TimerSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.button_TimerSwitch.Name = "button_TimerSwitch";
            this.button_TimerSwitch.Size = new System.Drawing.Size(85, 37);
            this.button_TimerSwitch.TabIndex = 6;
            this.button_TimerSwitch.Text = "Start";
            this.button_TimerSwitch.UseVisualStyleBackColor = true;
            this.button_TimerSwitch.Click += new System.EventHandler(this.button_TimerSwitch_Click);
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_LoadData);
            this.groupBox_Function.Controls.Add(this.button_Update);
            this.groupBox_Function.Controls.Add(this.label_s);
            this.groupBox_Function.Controls.Add(this.button_SaveData);
            this.groupBox_Function.Controls.Add(this.button_SaveChart);
            this.groupBox_Function.Controls.Add(this.label_Period);
            this.groupBox_Function.Controls.Add(this.comboBox_Period);
            this.groupBox_Function.Controls.Add(this.label_Magnitude);
            this.groupBox_Function.Controls.Add(this.comboBox_Magnitude);
            this.groupBox_Function.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.groupBox_Function.Location = new System.Drawing.Point(765, 237);
            this.groupBox_Function.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Function.Size = new System.Drawing.Size(310, 253);
            this.groupBox_Function.TabIndex = 7;
            this.groupBox_Function.TabStop = false;
            // 
            // button_LoadData
            // 
            this.button_LoadData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_LoadData.Location = new System.Drawing.Point(165, 35);
            this.button_LoadData.Name = "button_LoadData";
            this.button_LoadData.Size = new System.Drawing.Size(109, 37);
            this.button_LoadData.TabIndex = 16;
            this.button_LoadData.Text = "Load Data";
            this.button_LoadData.UseVisualStyleBackColor = true;
            this.button_LoadData.Click += new System.EventHandler(this.button_LoadData_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Update.Location = new System.Drawing.Point(25, 35);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(109, 37);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_s.Location = new System.Drawing.Point(280, 211);
            this.label_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(16, 20);
            this.label_s.TabIndex = 11;
            this.label_s.Text = "s";
            // 
            // button_SaveData
            // 
            this.button_SaveData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.button_SaveData.Location = new System.Drawing.Point(165, 100);
            this.button_SaveData.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveData.Name = "button_SaveData";
            this.button_SaveData.Size = new System.Drawing.Size(109, 36);
            this.button_SaveData.TabIndex = 21;
            this.button_SaveData.Text = "Save Data";
            this.button_SaveData.UseVisualStyleBackColor = true;
            this.button_SaveData.Click += new System.EventHandler(this.button_SaveData_Click);
            // 
            // button_SaveChart
            // 
            this.button_SaveChart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.button_SaveChart.Location = new System.Drawing.Point(25, 100);
            this.button_SaveChart.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveChart.Name = "button_SaveChart";
            this.button_SaveChart.Size = new System.Drawing.Size(109, 36);
            this.button_SaveChart.TabIndex = 8;
            this.button_SaveChart.Text = "Save Chart";
            this.button_SaveChart.UseVisualStyleBackColor = true;
            this.button_SaveChart.Click += new System.EventHandler(this.button_SaveChart_Click);
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Location = new System.Drawing.Point(31, 211);
            this.label_Period.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(66, 20);
            this.label_Period.TabIndex = 13;
            this.label_Period.Text = "Period :";
            // 
            // comboBox_Period
            // 
            this.comboBox_Period.FormattingEnabled = true;
            this.comboBox_Period.Items.AddRange(new object[] {
            "0.001",
            "0.01",
            "0.1",
            "0.25",
            "0.5",
            "1",
            "2",
            "2.5",
            "5",
            "10"});
            this.comboBox_Period.Location = new System.Drawing.Point(151, 209);
            this.comboBox_Period.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Period.Name = "comboBox_Period";
            this.comboBox_Period.Size = new System.Drawing.Size(123, 28);
            this.comboBox_Period.TabIndex = 12;
            // 
            // label_Magnitude
            // 
            this.label_Magnitude.AutoSize = true;
            this.label_Magnitude.Location = new System.Drawing.Point(31, 161);
            this.label_Magnitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Magnitude.Name = "label_Magnitude";
            this.label_Magnitude.Size = new System.Drawing.Size(100, 20);
            this.label_Magnitude.TabIndex = 11;
            this.label_Magnitude.Text = "Magnitude :";
            // 
            // comboBox_Magnitude
            // 
            this.comboBox_Magnitude.FormattingEnabled = true;
            this.comboBox_Magnitude.Items.AddRange(new object[] {
            "0.1",
            "0.25",
            "0.5",
            "1",
            "2",
            "2.5",
            "4",
            "5",
            "10"});
            this.comboBox_Magnitude.Location = new System.Drawing.Point(151, 158);
            this.comboBox_Magnitude.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Magnitude.Name = "comboBox_Magnitude";
            this.comboBox_Magnitude.Size = new System.Drawing.Size(123, 28);
            this.comboBox_Magnitude.TabIndex = 9;
            // 
            // label_SamplingRate
            // 
            this.label_SamplingRate.AutoSize = true;
            this.label_SamplingRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SamplingRate.Location = new System.Drawing.Point(773, 67);
            this.label_SamplingRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SamplingRate.Name = "label_SamplingRate";
            this.label_SamplingRate.Size = new System.Drawing.Size(126, 20);
            this.label_SamplingRate.TabIndex = 10;
            this.label_SamplingRate.Text = "Sampling Rate :";
            // 
            // chart_Channel
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX2.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart_Channel.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_Channel.Legends.Add(legend3);
            this.chart_Channel.Location = new System.Drawing.Point(18, 18);
            this.chart_Channel.Margin = new System.Windows.Forms.Padding(2);
            this.chart_Channel.Name = "chart_Channel";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart_Channel.Series.Add(series3);
            this.chart_Channel.Size = new System.Drawing.Size(708, 524);
            this.chart_Channel.TabIndex = 8;
            this.chart_Channel.Text = "chart1";
            // 
            // label_Hz
            // 
            this.label_Hz.AutoSize = true;
            this.label_Hz.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hz.Location = new System.Drawing.Point(1028, 67);
            this.label_Hz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Hz.Name = "label_Hz";
            this.label_Hz.Size = new System.Drawing.Size(29, 20);
            this.label_Hz.TabIndex = 13;
            this.label_Hz.Text = "Hz";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.RefreshChart);
            // 
            // numericUpDown_SamplingRate
            // 
            this.numericUpDown_SamplingRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown_SamplingRate.Location = new System.Drawing.Point(916, 65);
            this.numericUpDown_SamplingRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_SamplingRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SamplingRate.Name = "numericUpDown_SamplingRate";
            this.numericUpDown_SamplingRate.Size = new System.Drawing.Size(104, 28);
            this.numericUpDown_SamplingRate.TabIndex = 15;
            this.numericUpDown_SamplingRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SamplingRate.ValueChanged += new System.EventHandler(this.numericUpDown_SamplingRate_ValueChanged);
            // 
            // button_AddChannel
            // 
            this.button_AddChannel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.button_AddChannel.Location = new System.Drawing.Point(939, 140);
            this.button_AddChannel.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddChannel.Name = "button_AddChannel";
            this.button_AddChannel.Size = new System.Drawing.Size(39, 39);
            this.button_AddChannel.TabIndex = 16;
            this.button_AddChannel.Text = "+";
            this.button_AddChannel.UseVisualStyleBackColor = true;
            this.button_AddChannel.Click += new System.EventHandler(this.button_AddChannel_Click);
            // 
            // button_DeleteChannel
            // 
            this.button_DeleteChannel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.button_DeleteChannel.Location = new System.Drawing.Point(1000, 140);
            this.button_DeleteChannel.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteChannel.Name = "button_DeleteChannel";
            this.button_DeleteChannel.Size = new System.Drawing.Size(39, 39);
            this.button_DeleteChannel.TabIndex = 17;
            this.button_DeleteChannel.Text = "-";
            this.button_DeleteChannel.UseVisualStyleBackColor = true;
            this.button_DeleteChannel.Click += new System.EventHandler(this.button_DeleteChannel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(765, 513);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 28);
            this.progressBar1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 553);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_DeleteChannel);
            this.Controls.Add(this.button_AddChannel);
            this.Controls.Add(this.numericUpDown_SamplingRate);
            this.Controls.Add(this.label_Hz);
            this.Controls.Add(this.chart_Channel);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.button_TimerSwitch);
            this.Controls.Add(this.label_ChannelList);
            this.Controls.Add(this.listBox_ChannelList);
            this.Controls.Add(this.button_Source);
            this.Controls.Add(this.label_SamplingRate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Data Logger Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_Function.ResumeLayout(false);
            this.groupBox_Function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Channel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SamplingRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Source;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox listBox_ChannelList;
        private System.Windows.Forms.Label label_ChannelList;
        private System.Windows.Forms.Button button_TimerSwitch;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button_SaveChart;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.ComboBox comboBox_Period;
        private System.Windows.Forms.Label label_Magnitude;
        private System.Windows.Forms.Label label_SamplingRate;
        private System.Windows.Forms.ComboBox comboBox_Magnitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Channel;
        private System.Windows.Forms.Button button_SaveData;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label_Hz;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numericUpDown_SamplingRate;
        private Button button_LoadData;
        private Button button_AddChannel;
        private Button button_DeleteChannel;
        private System.IO.Ports.SerialPort serialPort1;
        private ProgressBar progressBar1;
    }
}
