using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Logitech_LCD;

namespace G19NumericClock
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LogitechLcd.Instance.init("Numeric Clock", LcdType.Color | LcdType.Mono);
        }
    }
}
