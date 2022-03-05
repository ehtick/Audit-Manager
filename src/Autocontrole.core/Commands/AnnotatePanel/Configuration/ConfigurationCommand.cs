namespace Autocontrole.core
{
    using System.Windows.Forms;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;

    /// <summary>
    /// Command code to be executed when button is clicked.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class ConfigurationCommand : IExternalCommand
    {
        #region public methods

        /// <summary>
        /// Establish basic parameters for audit rules.
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Application context.
            var uidoc = commandData.Application.ActiveUIDocument;
            var doc = uidoc.Document;

            // Check if we are in the Revit project, not a family one.
            if (doc.IsFamilyDocument)
            {
                Message.Display("Can't use command in family document.", WindowType.Warning);
                return Result.Cancelled;
            }

            // Get user provided information from window and show dialog.
            using (var window = new ConfigurationForm(uidoc))
            {
                window.ShowDialog();

                if (window.DialogResult == DialogResult.OK)
                    return Result.Cancelled;
            }

            return Result.Succeeded;
        }

        /// <summary>
        /// Gets the full namespace path to this command.
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            // Return constructed namespace path.
            return typeof(ConfigurationCommand).Namespace + "." + nameof(ConfigurationCommand);
        }

        #endregion
    }
}
