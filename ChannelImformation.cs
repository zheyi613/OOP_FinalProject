using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelImformationProject
{
    public enum SamplingTypes
    {
        SIMULATE_SINE_WAVE,
        SIMULATE_RANDOM_NUM,
        EXTERNAL
    }

    public enum ErrorCodes
    {
        NONE,
        WRONG_FORMAT
    }

    public struct InitialParameter
    {
        public const int SAMPLING_RATE = 1;
        public const SamplingTypes SAMPLING_TYPE = SamplingTypes.SIMULATE_SINE_WAVE;
        public const double MAGNITUDE = 0.5;
        public const double PERIOD = 1;
        public const int X_AXIS_SIZE = 10;
        public const int MAX_CHANNEL = 6;
    }
   
    public struct SerialParameter
    {
        public String PortName;
        public int BaudRate;
        public int DataBits;
        public String StopBits;
        public String ParityBits;
    }

    public class ChannelImformation
    {
        public SamplingTypes SamplingType;
        public Object _TypeParameter;
        public double Magnitude;
        public double Period;

        public ChannelImformation()
        {
            SamplingType = InitialParameter.SAMPLING_TYPE;
            _TypeParameter = (double)(4 / InitialParameter.SAMPLING_RATE);   // fullfill period of simulated wave = (2 * Nyquist frequency) / min sampling rate
            Magnitude = InitialParameter.MAGNITUDE;
            Period = InitialParameter.PERIOD;
        }

        public Object TypeParameter
        {
            get { return _TypeParameter; }
            set
            {
                if (value.GetType() == typeof(double) && (double)value == 0)
                    MessageBox.Show("Value Can't Be Zero!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    this._TypeParameter = value;
            }
        }
    }
}
