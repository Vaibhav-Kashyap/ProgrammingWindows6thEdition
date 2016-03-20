#region Information

// ProgrammingWindows6thEdition: ExpandingText
// Created: 2016-03-20
// Modified: 2016-03-20 5:32 PM
// Last modified by: Jason Moore (Jason)
#endregion

#region Using Directives
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

#endregion

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExpandingText
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
        ///     Expand text size between 1 and 144 and back again every 4 seconds.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompositionTarget_Rendering(object sender, object e)
        {
            RenderingEventArgs args = e as RenderingEventArgs;
            double t = (0.25 * args.RenderingTime.TotalSeconds) % 1;
            double scale = t < 0.5 ? 2 * t : 2 - 2 * t;
            Block.FontSize = 1 + scale * 143;
        }
    }
}