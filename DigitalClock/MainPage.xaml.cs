#region Information

// ProgrammingWindows6thEdition: DigitalClock
// Created: 2016-03-20
// Modified: 2016-03-20 5:17 PM
// Last modified by: Jason Moore (Jason)
#endregion

#region Using Directives
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

#endregion

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DigitalClock
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Constructors
        public MainPage()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(1)};
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        #endregion

        private void Timer_Tick(object sender, object e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}