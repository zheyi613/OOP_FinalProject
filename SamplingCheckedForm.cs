using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ChannelImformationProject;

namespace OOP_FinalProject
{
    public partial class SamplingCheckedForm : Form
    {
        public SamplingCheckedForm(SamplingTypes SamplingTypeIn, Object TypeParameterIn)
        {
            InitializeComponent();
            SamplingTypeInCheckedForm = SamplingTypeIn;
            TypeParameterInCheckedForm = TypeParameterIn;

            String[] Ports = SerialPort.GetPortNames();
            comboBox_PortName.Items.AddRange(Ports);

            if (SamplingTypeIn != SamplingTypes.EXTERNAL)
            {
                radioButton_SimulateSignal.Checked = true;
                comboBox_SimulateSignal.Text = comboBox_SimulateSignal.Items[(int)SamplingTypeIn].ToString();
                comboBox_SimulatePeriod.Text = ((double)TypeParameterIn).ToString();

                comboBox_PortName.Text = comboBox_PortName.Items[0].ToString();
                comboBox_BaudRate.Text = comboBox_BaudRate.Items[5].ToString();
                comboBox_DataBits.Text = comboBox_DataBits.Items[0].ToString();
                comboBox_StopBits.Text = comboBox_StopBits.Items[0].ToString();
                comboBox_ParityBits.Text = comboBox_ParityBits.Items[0].ToString();
            }
            else
            {
                radioButton_SimulateSignal.Checked = false;
                comboBox_SimulateSignal.Text = comboBox_SimulateSignal.Items[0].ToString();
                comboBox_SimulatePeriod.Text = (4 / InitialParameter.SAMPLING_RATE).ToString();

                SerialParameter CurTypeParamter = (SerialParameter)TypeParameterIn;
                comboBox_PortName.Text = CurTypeParamter.PortName;
                comboBox_BaudRate.Text = CurTypeParamter.BaudRate.ToString();
                comboBox_DataBits.Text = CurTypeParamter.DataBits.ToString();
                comboBox_StopBits.Text = CurTypeParamter.StopBits;
                comboBox_ParityBits.Text = CurTypeParamter.ParityBits;
            } 
            radioButton_External.Checked = (SamplingTypeIn == SamplingTypes.EXTERNAL) ? true : false;           
        }

        private void comboBox_SimulateSignal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SamplingTypeInCheckedForm = (SamplingTypes)comboBox_SimulateSignal.SelectedIndex;
        }

        private void radioButton_SamplingType_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Simulate.Enabled = radioButton_SimulateSignal.Checked;
            groupBox_SerialPort.Enabled = radioButton_External.Checked;
            SamplingTypeInCheckedForm = (radioButton_External.Checked) ? SamplingTypes.EXTERNAL : (SamplingTypes)comboBox_SimulateSignal.SelectedIndex;
        }

        private void comboBox_SimulatePeriod_TextChanged(object sender, EventArgs e)
        {
            double CurTypeParameter;
            bool canConvert = double.TryParse(comboBox_SimulatePeriod.Text, out CurTypeParameter);

            if (!canConvert)
                comboBox_SimulatePeriod.Text = CurTypeParameter.ToString();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SamplingCheckedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TypeParameterInCheckedForm = new Object();

            if (radioButton_SimulateSignal.Checked)
                TypeParameterInCheckedForm = double.Parse(comboBox_SimulatePeriod.Text);
            else
            {
                SerialParameter CurTypeParameter;
                CurTypeParameter.PortName = comboBox_PortName.Text;
                CurTypeParameter.BaudRate = int.Parse(comboBox_BaudRate.Text);
                CurTypeParameter.DataBits = int.Parse(comboBox_DataBits.Text);
                CurTypeParameter.StopBits = comboBox_StopBits.Text;
                CurTypeParameter.ParityBits = comboBox_ParityBits.Text;
                TypeParameterInCheckedForm = CurTypeParameter;
            }
        }  
    }
}
