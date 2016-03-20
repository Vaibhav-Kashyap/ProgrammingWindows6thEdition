#region Information

// ProgrammingWindows6thEdition: RoutedEvents3
// Created: 2016-03-20
// Modified: 2016-03-20 4:51 PM
// Last modified by: Jason Moore (Jason)
#endregion

#region Using Directives
using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

#endregion

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RoutedEvents3
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region  Fields
        readonly Random _random = new Random();

        readonly byte[] _rgb = new byte[3];
        #endregion

        #region Constructors
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnTapped(TappedRoutedEventArgs e)
        {
            _random.NextBytes(_rgb);
            Color colour = Color.FromArgb(255, _rgb[0], _rgb[1], _rgb[2]);
            var brush = new SolidColorBrush(colour);
            var source = e.OriginalSource;

            if (source is TextBlock)
            {
                ((TextBlock) source).Foreground = brush;
            }
            else if (source is Grid)
            {
                ((Grid) source).Background = brush;
            }
            base.OnTapped(e);
        }
    }
}