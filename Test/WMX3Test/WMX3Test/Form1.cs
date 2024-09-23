using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMX3ApiCLR;

namespace WMX3Test
{
    public partial class Form1 : Form
    {
        WMX3Api wmxlib = new WMX3Api();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void WMX3Start()
        {
            wmxlib.CreateDevice("C:\\Program Files\\SoftServo\\WMX3", DeviceType.DeviceTypeNormal);
        }
        private void WMX3Close()
        {
            wmxlib.CloseDevice();
            wmxlib.Dispose();
        }
    }
}
