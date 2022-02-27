namespace Autocontrole
{
    using Autodesk.Revit.DB.Events;
    using Autodesk.Revit.ApplicationServices;
    using Autodesk.Revit.UI;
    using ui;


    /// <summary>
    /// Plugin's main entry point.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalApplication" />
    public class Main : IExternalApplication
    {
        #region external application public methods

        /// <summary>
        /// Callled when Revit starts up.
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnStartup(UIControlledApplication application)
        {
            // Initialize whole plugin's user interface.
            var ui = new SetupInterface();
            ui.Initialize(application);

            application.ControlledApplication.ApplicationInitialized += DockablePaneRegisters;

            return Result.Succeeded;
        }

        /// <summary>
        /// Callled when Revit shutdown.
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
        #endregion

        #region private methods

        /// <summary>
        /// Register dockable panes in zero state document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void DockablePaneRegisters(object sender, ApplicationInitializedEventArgs e)
        {
            // Register dockable pane.
            var pointsDeControleManagerRegisterCommand = new RegisterPointsDeControleManagerCommand();
            pointsDeControleManagerRegisterCommand.Execute(new UIApplication(sender as Application));
        }

        #endregion
    }
}
