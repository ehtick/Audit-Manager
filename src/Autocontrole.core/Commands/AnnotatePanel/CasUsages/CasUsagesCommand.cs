namespace ECBManager.core
{
    using System.Windows.Forms;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;

    /// <summary>
    /// A window form arrives when button is clicked.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class CasUsagesCommand : IExternalCommand
    {
        /// <summary>
        /// Selects cas d'usages specified in the Convention BIM.
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
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
            using (var window = new CasUsagesForm(uidoc))
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
            return typeof(CasUsagesCommand).Namespace + "." + nameof(CasUsagesCommand);
        }

    }
}
