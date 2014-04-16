using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logitech_LCD.Applets;

namespace G19NumericClock
{
    public partial class Clock : BaseApplet
    {
        public Clock()
        {
            InitializeComponent();
            Size screenSize = new Size((int)Logitech_LCD.ColorBitmap.Width,
                                       (int)Logitech_LCD.ColorBitmap.Height);
            this.Size = screenSize;

        }

        protected override void OnDataUpdate(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
