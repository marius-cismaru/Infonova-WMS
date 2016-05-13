using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO.Ports;

namespace Sirius.EntityModels
{
    public partial class ConfigurationStation
    {
        public Parity OptionSerialPortParity
        {
            get { return (Parity)SerialPortParity; }
            set { SerialPortParity = (int)value; }
        }

        public StopBits OptionSerialPortStopBits
        {
            get { return (StopBits)SerialPortStopBits; }
            set { SerialPortStopBits = (int)value; }
        }

        public Handshake OptionSerialPortFlowControl
        {
            get { return (Handshake)SerialPortFlowControl; }
            set { SerialPortFlowControl = (int)value; }
        }

        public ConfigurationStation()
        {
            Id = 0;
            LabelPrinterName = string.Empty;
            SerialPortName = string.Empty;
            SerialPortBaudRate = 9600;
            SerialPortDataBits = 8;
            OptionSerialPortParity = Parity.Odd;
            OptionSerialPortStopBits = StopBits.One;
            OptionSerialPortFlowControl = Handshake.None;
        }

        public override string ToString()
        {
            return LabelPrinterName + ", " + SerialPortName + " (" + SerialPortBaudRate.ToString() + "-" + SerialPortDataBits.ToString() + "-" + OptionSerialPortParity.ToString() + "-" + OptionSerialPortStopBits.ToString() + "-" + OptionSerialPortFlowControl.ToString() + ")";
        }
    }
}
