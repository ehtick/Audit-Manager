namespace ECBManager.core
{
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;

    /// <summary>
    /// Show "ECB Fiche d'Audit Manager" dockable pane.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class FicheAuditManagerCommand : IExternalCommand
    {
        #region public methods

        /// <summary>
        /// Executes the specified command data.
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var dpid = new DockablePaneId(PaneIdentifiers.GetManagerPaneIdentidiers());
            var dp = commandData.Application.GetDockablePane(dpid);
            dp.Show();

            return Result.Succeeded;
        }


        /// <summary>
        /// Gets the full namespace path to this command.
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            // Return constructed namespace path.
            return typeof(FicheAuditManagerCommand).Namespace + "." + nameof(FicheAuditManagerCommand);
        }

        #endregion
    }
}
