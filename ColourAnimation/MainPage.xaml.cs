#region Information

// ProgrammingWindows6thEdition: ColourAnimation
// Created: 2016-03-20
// Modified: 2016-03-20 5:41 PM
// Last modified by: Jason Moore (Jason)
#endregion

#region Using Directives
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

#endregion

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ColourAnimation
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
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }
        #endregion

        /// <summary>
        ///     Set grid background and textblock foreground to inverse shades of grey.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompositionTarget_Rendering(object sender, object e)
        {
            RenderingEventArgs args = e as RenderingEventArgs;
            double t = (0.25 * args.RenderingTime.TotalSeconds) % 1;
            double scale = t < 0.5 ? 2 * t : 2 - 2 * t;

            // Background colour
            byte grey = (byte) (255 * t);
            GridBrush.Color = Color.FromArgb(255, grey, grey, grey);

            // Foreground
            grey = (byte) (255 - grey);
            TextBlockBrush.Color = Color.FromArgb(255, grey, grey, grey);
        }
    }
}