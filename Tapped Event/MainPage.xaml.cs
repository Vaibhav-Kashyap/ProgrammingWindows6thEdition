#region Information

// ProgrammingWindows6thEdition: Tapped Event
// Created: 2016-03-20
// Modified: 2016-03-20 3:52 PM
// Last modified by: Jason Moore (Jason)
#endregion

 // The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tapped_Event
{
    #region Using Directives
    using System;

    using Windows.UI;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;

    #endregion

    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region  Fields
        readonly Random random = new Random();

        readonly byte[] rgb = new byte[3];
        #endregion

        #region Constructors
        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion

        private void TextBlock_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            this.random.NextBytes(this.rgb);
            Color colour = Color.FromArgb(255, this.rgb[0], this.rgb[1], this.rgb[2]);
            this.TextBlock.Foreground = new SolidColorBrush(colour);
        }
    }
}