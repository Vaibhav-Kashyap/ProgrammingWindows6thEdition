using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Spiral
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            LaunchSpiral();
        }

        /// <summary>
        /// Draw a spiral with expanding distances
        /// </summary>
        private async void LaunchSpiral()
        {
            for (int i = 10; i <= 135; i++)
            {
                Polyline.Points.Clear();
                DrawSpiral(i);
                await Task.Delay(TimeSpan.FromSeconds(0.01));
            }
        }

        /// <summary>
        /// Generate points on Polyline to draw a spiral.
        /// </summary>
        /// <param name="distance"></param>
        private void DrawSpiral(int distance)
        {
            for (int angle = 0; angle < 3600; angle++)
            {
                double radians = Math.PI*angle/distance;
                double radius = angle/10;
                double x = 360 + radius*Math.Sin(radians);
                double y = 360 - radius*Math.Cos(radians);
                Polyline.Points.Add(new Point(x, y));
            }
        }
    }
}