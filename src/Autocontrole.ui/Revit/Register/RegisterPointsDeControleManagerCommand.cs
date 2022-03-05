namespace Autocontrole.ui
{
    using System.Windows;
    
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;

    using core;

    /// <summary>
    /// Register "points de contrôle manager" in zero state document.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class RegisterFicheAuditManagerCommand : IExternalCommand
    {
        #region public methods

        /// <summary>
        /// Executes the specified command data.
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            return Execute(commandData.Application);
        }

        /// <summary>
        /// Register dockable pane.
        /// </summary>
        /// <param name="uIApplication"></param>
        /// <returns></returns>
        public Result Execute(UIApplication uIApplication)
        {
            // Todo implement register...

            var data = new DockablePaneProviderData();
            var managerPage = new FicheAuditManagerMainPage();

            // Setup initial state.
            data.FrameworkElement = managerPage as FrameworkElement;
            var state = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };

            // Use unique guid identifier for this dockable pane.
            var dpid = new DockablePaneId(PaneIdentifiers.GetManagerPaneIdentidiers());
            uIApplication.RegisterDockablePane(dpid, "ECB Fiche d'Audit Manager", managerPage as IDockablePaneProvider);


            return Result.Succeeded;
        }

        #endregion
    }
}
