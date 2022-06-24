using System;
using ChannelImformationProject;

namespace OOP_FinalProject
{
    partial class SamplingCheckedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public SamplingTypes SamplingTypeInCheckedForm;
        public Object TypeParameterInCheckedForm;

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
            this.radioButton_SimulateSignal = new System.Windows.Forms.RadioButton();
            this.radioButton_External = new System.Windows.Forms.RadioButton();
            this.button_Close = new System.Windows.Forms.Button();
            this.comboBox_SimulateSignal = new System.Windows.Forms.ComboBox();
            this.label_Period = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.groupBox_Simulate = new System.Windows.Forms.GroupBox();
            this.comboBox_SimulatePeriod = new System.Windows.Forms.ComboBox();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label_PortName = new System.Windows.Forms.Label();
            this.groupBox_SerialPort = new System.Windows.Forms.GroupBox();
            this.label_ParityBits = new System.Windows.Forms.Label();
            this.comboBox_ParityBits = new System.Windows.Forms.ComboBox();
            this.label_StopBits = new System.Windows.Forms.Label();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.label_DataBits = new System.Windows.Forms.Label();
            this.comboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox_Simulate.SuspendLayout();
            this.groupBox_SerialPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_SimulateSignal
            // 
            this.radioButton_SimulateSignal.AutoSize = true;
            this.radioButton_SimulateSignal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_SimulateSignal.Location = new System.Drawing.Point(38, 38);
            this.radioButton_SimulateSignal.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_SimulateSignal.Name = "radioButton_SimulateSignal";
            this.radioButton_SimulateSignal.Size = new System.Drawing.Size(93, 24);
            this.radioButton_SimulateSignal.TabIndex = 0;
            this.radioButton_SimulateSignal.TabStop = true;
            this.radioButton_SimulateSignal.Text = "Simulate";
            this.radioButton_SimulateSignal.UseVisualStyleBackColor = true;
            this.radioButton_SimulateSignal.CheckedChanged += new System.EventHandler(this.radioButton_SamplingType_CheckedChanged);
            // 
            // radioButton_External
            // 
            this.radioButton_External.AutoSize = true;
            this.radioButton_External.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_External.Location = new System.Drawing.Point(38, 204);
            this.radioButton_External.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_External.Name = "radioButton_External";
            this.radioButton_External.Size = new System.Drawing.Size(88, 24);
            this.radioButton_External.TabIndex = 1;
            this.radioButton_External.TabStop = true;
            this.radioButton_External.Text = "External";
            this.radioButton_External.UseVisualStyleBackColor = true;
            this.radioButton_External.CheckedChanged += new System.EventHandler(this.radioButton_SamplingType_CheckedChanged);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Close.Location = new System.Drawing.Point(170, 461);
            this.button_Close.Margin = new System.Windows.Forms.Padding(2);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(90, 37);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // comboBox_SimulateSignal
            // 
            this.comboBox_SimulateSignal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SimulateSignal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_SimulateSignal.FormattingEnabled = true;
            this.comboBox_SimulateSignal.Items.AddRange(new object[] {
            "Sine Wave",
            "Random Number"});
            this.comboBox_SimulateSignal.Location = new System.Drawing.Point(16, 19);
            this.comboBox_SimulateSignal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_SimulateSignal.Name = "comboBox_SimulateSignal";
            this.comboBox_SimulateSignal.Size = new System.Drawing.Size(159, 28);
            this.comboBox_SimulateSignal.TabIndex = 6;
            this.comboBox_SimulateSignal.SelectedIndexChanged += new System.EventHandler(this.comboBox_SimulateSignal_SelectedIndexChanged);
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Period.Location = new System.Drawing.Point(12, 55);
            this.label_Period.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(66, 20);
            this.label_Period.TabIndex = 8;
            this.label_Period.Text = "Period :";
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_s.Location = new System.Drawing.Point(228, 55);
            this.label_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(16, 20);
            this.label_s.TabIndex = 9;
            this.label_s.Text = "s";
            // 
            // groupBox_Simulate
            // 
            this.groupBox_Simulate.Controls.Add(this.comboBox_SimulatePeriod);
            this.groupBox_Simulate.Controls.Add(this.label_Period);
            this.groupBox_Simulate.Controls.Add(this.label_s);
            this.groupBox_Simulate.Controls.Add(this.comboBox_SimulateSignal);
            this.groupBox_Simulate.Location = new System.Drawing.Point(72, 66);
            this.groupBox_Simulate.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Simulate.Name = "groupBox_Simulate";
            this.groupBox_Simulate.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Simulate.Size = new System.Drawing.Size(301, 102);
            this.groupBox_Simulate.TabIndex = 10;
            this.groupBox_Simulate.TabStop = false;
            // 
            // comboBox_SimulatePeriod
            // 
            this.comboBox_SimulatePeriod.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_SimulatePeriod.FormattingEnabled = true;
            this.comboBox_SimulatePeriod.Items.AddRange(new object[] {
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
            this.comboBox_SimulatePeriod.Location = new System.Drawing.Point(109, 52);
            this.comboBox_SimulatePeriod.Name = "comboBox_SimulatePeriod";
            this.comboBox_SimulatePeriod.Size = new System.Drawing.Size(101, 28);
            this.comboBox_SimulatePeriod.TabIndex = 11;
            this.comboBox_SimulatePeriod.TextChanged += new System.EventHandler(this.comboBox_SimulatePeriod_TextChanged);
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PortName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(145, 21);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 28);
            this.comboBox_PortName.TabIndex = 11;
            // 
            // label_PortName
            // 
            this.label_PortName.AutoSize = true;
            this.label_PortName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_PortName.Location = new System.Drawing.Point(24, 24);
            this.label_PortName.Name = "label_PortName";
            this.label_PortName.Size = new System.Drawing.Size(49, 20);
            this.label_PortName.TabIndex = 12;
            this.label_PortName.Text = "Port :";
            // 
            // groupBox_SerialPort
            // 
            this.groupBox_SerialPort.Controls.Add(this.label_ParityBits);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_ParityBits);
            this.groupBox_SerialPort.Controls.Add(this.label_StopBits);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_StopBits);
            this.groupBox_SerialPort.Controls.Add(this.label_DataBits);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_DataBits);
            this.groupBox_SerialPort.Controls.Add(this.label_BaudRate);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_BaudRate);
            this.groupBox_SerialPort.Controls.Add(this.label_PortName);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_PortName);
            this.groupBox_SerialPort.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_SerialPort.Location = new System.Drawing.Point(72, 247);
            this.groupBox_SerialPort.Name = "groupBox_SerialPort";
            this.groupBox_SerialPort.Size = new System.Drawing.Size(301, 202);
            this.groupBox_SerialPort.TabIndex = 13;
            this.groupBox_SerialPort.TabStop = false;
            this.groupBox_SerialPort.Text = "Serial Port";
            // 
            // label_ParityBits
            // 
            this.label_ParityBits.AutoSize = true;
            this.label_ParityBits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ParityBits.Location = new System.Drawing.Point(24, 160);
            this.label_ParityBits.Name = "label_ParityBits";
            this.label_ParityBits.Size = new System.Drawing.Size(91, 20);
            this.label_ParityBits.TabIndex = 20;
            this.label_ParityBits.Text = "Parity Bits :";
            // 
            // comboBox_ParityBits
            // 
            this.comboBox_ParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ParityBits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_ParityBits.FormattingEnabled = true;
            this.comboBox_ParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox_ParityBits.Location = new System.Drawing.Point(145, 157);
            this.comboBox_ParityBits.Name = "comboBox_ParityBits";
            this.comboBox_ParityBits.Size = new System.Drawing.Size(121, 28);
            this.comboBox_ParityBits.TabIndex = 19;
            // 
            // label_StopBits
            // 
            this.label_StopBits.AutoSize = true;
            this.label_StopBits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_StopBits.Location = new System.Drawing.Point(24, 126);
            this.label_StopBits.Name = "label_StopBits";
            this.label_StopBits.Size = new System.Drawing.Size(83, 20);
            this.label_StopBits.TabIndex = 18;
            this.label_StopBits.Text = "Stop Bits :";
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StopBits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBox_StopBits.Location = new System.Drawing.Point(145, 123);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(121, 28);
            this.comboBox_StopBits.TabIndex = 17;
            // 
            // label_DataBits
            // 
            this.label_DataBits.AutoSize = true;
            this.label_DataBits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_DataBits.Location = new System.Drawing.Point(24, 92);
            this.label_DataBits.Name = "label_DataBits";
            this.label_DataBits.Size = new System.Drawing.Size(84, 20);
            this.label_DataBits.TabIndex = 16;
            this.label_DataBits.Text = "Data Bits :";
            // 
            // comboBox_DataBits
            // 
            this.comboBox_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DataBits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_DataBits.FormattingEnabled = true;
            this.comboBox_DataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.comboBox_DataBits.Location = new System.Drawing.Point(145, 89);
            this.comboBox_DataBits.Name = "comboBox_DataBits";
            this.comboBox_DataBits.Size = new System.Drawing.Size(121, 28);
            this.comboBox_DataBits.TabIndex = 15;
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_BaudRate.Location = new System.Drawing.Point(24, 58);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(94, 20);
            this.label_BaudRate.TabIndex = 14;
            this.label_BaudRate.Text = "Baud Rate :";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BaudRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(145, 55);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 28);
            this.comboBox_BaudRate.TabIndex = 13;
            // 
            // SamplingCheckedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 509);
            this.Controls.Add(this.groupBox_SerialPort);
            this.Controls.Add(this.groupBox_Simulate);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.radioButton_External);
            this.Controls.Add(this.radioButton_SimulateSignal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SamplingCheckedForm";
            this.Text = "SamplingCheckedForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SamplingCheckedForm_FormClosing);
            this.groupBox_Simulate.ResumeLayout(false);
            this.groupBox_Simulate.PerformLayout();
            this.groupBox_SerialPort.ResumeLayout(false);
            this.groupBox_SerialPort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_SimulateSignal;
        private System.Windows.Forms.RadioButton radioButton_External;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.ComboBox comboBox_SimulateSignal;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.GroupBox groupBox_Simulate;
        private System.Windows.Forms.ComboBox comboBox_SimulatePeriod;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label_PortName;
        private System.Windows.Forms.GroupBox groupBox_SerialPort;
        private System.Windows.Forms.Label label_ParityBits;
        private System.Windows.Forms.ComboBox comboBox_ParityBits;
        private System.Windows.Forms.Label label_StopBits;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.Label label_DataBits;
        private System.Windows.Forms.ComboBox comboBox_DataBits;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
    }
}