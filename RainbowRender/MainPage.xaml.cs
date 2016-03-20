#region Information

// ProgrammingWindows6thEdition: RainbowRender
// Created: 2016-03-20
// Modified: 2016-03-20 5:52 PM
// Last modified by: Jason Moore (Jason)
#endregion

#region Using Directives
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

#endregion

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RainbowRender
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region  Fields

        // Get base size of text block
        private double _textBlockBaseSize;
        #endregion

        #region Constructors
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }
        #endregion

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            _textBlockBaseSize = Block.ActualHeight;
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(object sender, object e)
        {
            // Set FontSize as large as possible.
            Block.FontSize = ActualHeight / _textBlockBaseSize;

            // Calculate t from 0 to 1 repetitively
            RenderingEventArgs renderingArgs = e as RenderingEventArgs;
            double t = (0.25 * renderingArgs.RenderingTime.TotalSeconds) % 1;

            // Loop through GradientStop objects
            for (int i = 0; i < GradientBrush.GradientStops.Count; i++)
            {
                GradientBrush.GradientStops[i].Offset = i / 7.0 - t;
            }
        }
    }
}