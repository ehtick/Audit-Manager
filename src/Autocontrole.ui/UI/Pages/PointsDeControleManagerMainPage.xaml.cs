namespace Autocontrole.ui
{
    using Autodesk.Revit.UI;
    using System;
    using System.Windows;
    using System.Windows.Controls;
    /// <summary>
    /// Interaction logic for PointsDeControleManagerMainPage.xaml
    /// </summary>
    public partial class PointsDeControleManagerMainPage : Page, IDisposable, IDockablePaneProvider
    {
        #region constructor

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="PointsDeControleManagerMainPage"/>.
        /// </summary>
        public PointsDeControleManagerMainPage()
        {
            InitializeComponent();
        }

        #endregion

        #region public methods

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Dispose()
        {
            this.Dispose();
        }

        /// <summary>
        /// Setups the dockable pane.
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this as FrameworkElement;

            // Define initial pane position in Revit UI.
            data.InitialState = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };
        }

        #endregion
    }
}
