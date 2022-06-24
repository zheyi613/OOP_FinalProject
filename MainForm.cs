using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using ChannelImformationProject;

namespace OOP_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SamplingRate = InitialParameter.SAMPLING_RATE;
            RandomGenerator = new Random();
            Channels = new List<ChannelImformation>();
            Channels.Add(new ChannelImformation());    // Add a channel to channel list when form load
            listBox_ChannelList.Items.Add("Channel " + (listBox_ChannelList.Items.Count + 1).ToString());
            listBox_ChannelList.SelectedIndex = listBox_ChannelList.Items.Count - 1;

            // Initial value of user contol
            button_DeleteChannel.Enabled = false;
            numericUpDown_SamplingRate.Value = (decimal)InitialParameter.SAMPLING_RATE;
            comboBox_Magnitude.Text = InitialParameter.MAGNITUDE.ToString();
            comboBox_Period.Text = InitialParameter.PERIOD.ToString();

            DirectoryInfo ProjectDir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            openFileDialog.InitialDirectory = ProjectDir.Parent.Parent.FullName;
            saveFileDialog.InitialDirectory = ProjectDir.Parent.Parent.FullName;
        }
        private void numericUpDown_SamplingRate_ValueChanged(object sender, EventArgs e)
        {
            SamplingRate = (int)numericUpDown_SamplingRate.Value;
        }

        private void button_Source_Click(object sender, EventArgs e)
        {
            SamplingCheckedForm CurSamplingCheckedForm = new SamplingCheckedForm(Channels[listBox_ChannelList.SelectedIndex].SamplingType,
                Channels[listBox_ChannelList.SelectedIndex].TypeParameter);

            CurSamplingCheckedForm.Show();

            CurSamplingCheckedForm.FormClosed += new FormClosedEventHandler(SamplingCheckedForm_FormClosedInMainForm);         
        }

        private void SamplingCheckedForm_FormClosedInMainForm(object sender, FormClosedEventArgs e)
        {
            SamplingCheckedForm SamplingCheckedFormSender = (SamplingCheckedForm)sender;

            Channels[listBox_ChannelList.SelectedIndex].SamplingType = SamplingCheckedFormSender.SamplingTypeInCheckedForm;
            Channels[listBox_ChannelList.SelectedIndex].TypeParameter = SamplingCheckedFormSender.TypeParameterInCheckedForm;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            double Value1 = 0.0;

            if (double.TryParse(comboBox_Magnitude.Text, out Value1) && Value1 > 0)
                Channels[listBox_ChannelList.SelectedIndex].Magnitude = Value1;
            else
                comboBox_Magnitude.Text = Channels[listBox_ChannelList.SelectedIndex].Magnitude.ToString();

            if (double.TryParse(comboBox_Period.Text, out Value1) && Value1 > 0)
                Channels[listBox_ChannelList.SelectedIndex].Period = Value1;
            else
                comboBox_Period.Text = Channels[listBox_ChannelList.SelectedIndex].Period.ToString();

            VariableUpdateFlag = true;
        }

        private void button_TimerSwitch_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (timer1.Enabled)
            {
                button_TimerSwitch_EnableControl(true);
                timer1.Stop();
                button_TimerSwitch.Text = "Start";
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
            else
            {
                button_TimerSwitch.Text = "Stop";
                button_TimerSwitch_EnableControl(false);
                VariableUpdateFlag = true;
                TimerCount = 0;

                for (int i = 0; i < chart_Channel.Series.Count; i++)
                {
                    chart_Channel.Series[i].ChartType = SeriesChartType.Line;
                    chart_Channel.Series[i].ChartArea = "ChartArea" + (i + 1).ToString();
                    chart_Channel.Series[i].Points.Clear();
                }

                for (int i = 0; i < chart_Channel.ChartAreas.Count; i++)
                {
                    chart_Channel.ChartAreas[i].AxisX.ScaleView.Position = 0;
                    chart_Channel.ChartAreas[i].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                    chart_Channel.ChartAreas[i].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
                    chart_Channel.ChartAreas[i].AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                    chart_Channel.ChartAreas[i].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;

                    chart_Channel.ChartAreas[i].AxisX.ScaleView.Size =
                        (double)InitialParameter.X_AXIS_SIZE * Channels[listBox_ChannelList.SelectedIndex].Period;
                    chart_Channel.ChartAreas[i].AxisX.Interval = Channels[listBox_ChannelList.SelectedIndex].Period;
                    chart_Channel.ChartAreas[i].AxisY.Interval = Channels[listBox_ChannelList.SelectedIndex].Magnitude;
                }

                int SerialInChannelIndex = -1;
                for (int i = 0; i < Channels.Count; i++)
                    if (Channels[i].SamplingType.Equals(SamplingTypes.EXTERNAL))
                        SerialInChannelIndex = i;
                if (SerialInChannelIndex != -1)
                {
                    SerialParameter CurTypeParameter = (SerialParameter)Channels[SerialInChannelIndex].TypeParameter;
                    serialPort1.PortName = CurTypeParameter.PortName;
                    serialPort1.BaudRate = (Int32)CurTypeParameter.BaudRate;
                    serialPort1.DataBits = (Int32)CurTypeParameter.DataBits;
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CurTypeParameter.StopBits);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CurTypeParameter.ParityBits);
                    serialPort1.Open();
                }

                timer1.Interval = (int)(1000 / SamplingRate);
                timer1.Start();
            }
            progressBar1.Value = 100;
        }

        private void RefreshChart(Object sender, EventArgs e)
        {
            TimerCount++;

            if (VariableUpdateFlag)
            {              
                chart_Channel.ChartAreas[listBox_ChannelList.SelectedIndex].AxisX.ScaleView.Size =
                    (double)InitialParameter.X_AXIS_SIZE * Channels[listBox_ChannelList.SelectedIndex].Period;
                chart_Channel.ChartAreas[listBox_ChannelList.SelectedIndex].AxisX.Interval = Channels[listBox_ChannelList.SelectedIndex].Period;        
                chart_Channel.ChartAreas[listBox_ChannelList.SelectedIndex].AxisY.Interval = Channels[listBox_ChannelList.SelectedIndex].Magnitude;
 
                VariableUpdateFlag = false;
            }
            // external
            int ExternalChannelCount = 0;
            String GetString;
            GetString = serialPort1.ReadLine();
            String[] Piecewise = GetString.Split(' ');
            //
            for (int i = 0; i < Channels.Count; i++)
            {
                switch (Channels[i].SamplingType)
                {
                    case SamplingTypes.SIMULATE_SINE_WAVE:
                        double Value = Math.Sin((double)TimerCount / SamplingRate / (double)Channels[i].TypeParameter * 2 * Math.PI);

                        if (Math.Abs(Value) < 0.000001) Value = 0;    // if value approximate to zero, modifying value to zero 

                        chart_Channel.Series[i].Points.AddXY((double)TimerCount / SamplingRate, Value);
                        break;
                    case SamplingTypes.SIMULATE_RANDOM_NUM:
                        chart_Channel.Series[i].Points.AddXY((double)TimerCount / SamplingRate, RandomGenerator.NextDouble());            
                        break;
                    case SamplingTypes.EXTERNAL:
                        // external source code
                        chart_Channel.Series[i].Points.AddXY((double)TimerCount / SamplingRate, double.Parse(Piecewise[ExternalChannelCount]));
                        ExternalChannelCount++;
                        break;
                }
                if (chart_Channel.ChartAreas[i].AxisX.ScrollBar.IsVisible)
                    chart_Channel.ChartAreas[i].AxisX.ScaleView.Position =
                        TimerCount / SamplingRate - chart_Channel.ChartAreas[i].AxisX.ScaleView.Size;
            }       
        }

        private void button_TimerSwitch_EnableControl(bool Control)
        {
            button_Source.Enabled = Control;
            button_AddChannel.Enabled = Control;
            button_DeleteChannel.Enabled = Control;
            button_LoadData.Enabled = Control;
            numericUpDown_SamplingRate.Enabled = Control;
        }

        private void listBox_ChannelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Channels.Count != listBox_ChannelList.Items.Count) return;
            
            comboBox_Magnitude.Text = Channels[listBox_ChannelList.SelectedIndex].Magnitude.ToString();
            comboBox_Period.Text = Channels[listBox_ChannelList.SelectedIndex].Period.ToString();
        }

        private void button_AddChannel_Click(object sender, EventArgs e)
        { 
            Channels.Add(new ChannelImformation());
            listBox_ChannelList.Items.Add("Channel " + (listBox_ChannelList.Items.Count + 1).ToString());
            listBox_ChannelList.SelectedIndex = listBox_ChannelList.Items.Count - 1;

            chart_Channel.ChartAreas.Add("ChartArea" + (chart_Channel.ChartAreas.Count + 1).ToString());
            chart_Channel.Series.Add("Series" + (chart_Channel.Series.Count + 1).ToString());
            // Channel number <= 4
            button_AddDelete_EnableControl(Channels.Count);
        }

        private void button_DeleteChannel_Click(object sender, EventArgs e)
        {
            Channels.RemoveAt(Channels.Count - 1);
            listBox_ChannelList.SelectedIndex = listBox_ChannelList.Items.Count - 2;
            listBox_ChannelList.Items.RemoveAt(listBox_ChannelList.Items.Count - 1);

            chart_Channel.ChartAreas.RemoveAt(chart_Channel.ChartAreas.Count - 1);
            chart_Channel.Series.RemoveAt(chart_Channel.Series.Count - 1);
            // Channel number > 0
            button_AddDelete_EnableControl(Channels.Count);
        }

        private void button_AddDelete_EnableControl(int ChannelsCount)
        {
            button_AddChannel.Enabled = (ChannelsCount < InitialParameter.MAX_CHANNEL) ? true : false;
            button_DeleteChannel.Enabled = (ChannelsCount > 1) ? true : false;
        }

        private void button_SaveChart_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPEG (*.jpg)|*.jpg|All Files (*.*)|*.*";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Value = 0;
                chart_Channel.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                progressBar1.Value = 100;
            }                     
        }

        private void button_SaveData_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|Office Files|*.xls|*All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Value = 0;
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")   // save as txt file
                {
                    StreamWriter TextFile = new StreamWriter(saveFileDialog.FileName);

                    for (int i = 0; i < chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points.Count; i++)
                    {
                        TextFile.WriteLine(chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points[i].XValue.ToString() + "\t"
                            + chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points[i].YValues[0].ToString());
                    }

                    TextFile.Close();
                }
                else if (Path.GetExtension(saveFileDialog.FileName) == ".xls")  // save as xls file
                {
                    Excel.Application CurExcelApplication = new Excel.Application();

                    if (CurExcelApplication != null)
                    {
                        Excel.Workbook CurWorkbook = CurExcelApplication.Workbooks.Add();
                        Excel.Worksheet CurWorksheet = (Excel.Worksheet)CurWorkbook.Sheets.Add();
                        for (int i = 0; i < chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points.Count; i++)
                        {
                            CurWorksheet.Cells[i + 1, 1] = chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points[i].XValue.ToString();
                            CurWorksheet.Cells[i + 1, 2] = chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points[i].YValues[0].ToString();
                        }

                        CurExcelApplication.ActiveWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookNormal);

                        CurWorkbook.Close();
                        CurExcelApplication.Quit();
                    }
                }
                progressBar1.Value = 100;
            }
        }

        private void button_LoadData_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Value = 0;
                ErrorCodes CurErrCode = LoadDataFile(openFileDialog.FileName);
                switch (CurErrCode)
                {
                    case ErrorCodes.WRONG_FORMAT:
                        MessageBox.Show("Wrong Format!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ErrorCodes.NONE:
                        progressBar1.Value = 100;
                        break;
                }
            }
        }

        public ErrorCodes LoadDataFile(String FileName)
        {
            chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points.Clear(); // clear chart before load file
            double XValue, YValue;

            if (Path.GetExtension(openFileDialog.FileName) == ".txt")
            {
                StreamReader TextFile = new StreamReader(FileName);
                String CurText;
                String[] Piecewise;               

                while (TextFile.Peek() >= 0)
                {
                    CurText = TextFile.ReadLine();
                    Piecewise = CurText.Split('\t');
                    if (!(Piecewise.Length == 2 && double.TryParse(Piecewise[0], out XValue) && double.TryParse(Piecewise[0], out YValue)))
                    {
                        TextFile.Close();
                        return ErrorCodes.WRONG_FORMAT;
                    }                     
                    chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points.AddXY(XValue, YValue);
                }
                TextFile.Close();
            }
            else if (Path.GetExtension(openFileDialog.FileName) == ".xls")
            {
                Excel.Application CurExcelApplication = new Excel.Application();
                Object Missing = System.Reflection.Missing.Value;

                if (CurExcelApplication != null)
                {
                    Excel.Workbook CurWorkbook = CurExcelApplication.Workbooks.Open(FileName, Missing, Missing);
                    Excel.Sheets CurSheet = CurWorkbook.Worksheets;
                    Excel.Worksheet CurWorksheet = (Excel.Worksheet)CurSheet[1];
                    Excel.Range CurRange;

                    object miss = System.Reflection.Missing.Value;
                    if ( CurWorksheet.UsedRange.Columns.Count != 2)
                    {
                        CurWorkbook.Close();
                        CurExcelApplication.Quit();
                        return ErrorCodes.WRONG_FORMAT;
                    }
                    for (int i = 0; i < CurWorksheet.UsedRange.Rows.Count; i++)
                    {
                        CurRange = CurWorksheet.UsedRange.Cells.get_Range("A" + (i + 1).ToString(), miss);
                        if (!double.TryParse(CurRange.Value.ToString(), out XValue))
                        {            
                            CurWorkbook.Close();
                            CurExcelApplication.Quit();
                            return ErrorCodes.WRONG_FORMAT;
                        }
                        CurRange = CurWorksheet.UsedRange.Cells.get_Range("B" + (i + 1).ToString(), miss);
                        if (!double.TryParse(CurRange.Value.ToString(), out YValue))
                        {
                            CurWorkbook.Close();
                            CurExcelApplication.Quit();
                            return ErrorCodes.WRONG_FORMAT;
                        }
                        chart_Channel.Series[listBox_ChannelList.SelectedIndex].Points.AddXY(XValue, YValue);
                    }
                    CurWorkbook.Close();
                    CurExcelApplication.Quit();
                }
            }
            return ErrorCodes.NONE;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}
