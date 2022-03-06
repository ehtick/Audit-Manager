namespace ECBManager
{
    using Autodesk.Revit.UI;
    using ui;
    using core;
    /// <summary>
    /// Setup whole plugins interface with tabs, panels, buttons,...
    /// </summary>
    public class SetupInterface
    {

        #region constructor

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="SetupInterface"/> class.
        /// </summary>
        public SetupInterface()
        {

        }

        #endregion

        #region public methods

        /// <summary>
        /// Initializes all interface elements on custom created Revit tab.
        /// </summary>
        /// <param name="app"></param>
        public void Initialize(UIControlledApplication app)
        {
            // Create ribbon tab.
            string tabName = "ECB Manager";
            app.CreateRibbonTab(tabName);

            // Create the ribbon panels.
            var annotateCommandsPanel = app.CreateRibbonPanel(tabName, "ECB Audit Manager");
            
            #region Configuration Button

            // Populate button data model.
            var ConfigurationButtonData = new RevitPushButtonDataModel
            {
                Label = "Configuration",
                Panel = annotateCommandsPanel,
                Tooltip = "Mettre en place les règles de contrôle\npour tous les points de contrôle.",
                CommandNamespacePath = ConfigurationCommand.GetPath(),
                IconImageName = "Logo_Configuration_23x23.png",
                TooltipImageName = "Tooltip_Configuration_223x223.png"
            };

            // Create button from provided data.
            var ConfigurationButton = RevitPushButton.Create(ConfigurationButtonData);

            #endregion

            #region Fiche d'audit Button

            // Populate button data model.
            var FicheAuditButtonData = new RevitPushButtonDataModel
            {
                Label = "Fiche d'audit",
                Panel = annotateCommandsPanel,
                Tooltip = "Ouvrir ECB Fiche d'Audit Manager.",
                CommandNamespacePath = FicheAuditManagerCommand.GetPath(),
                IconImageName = "Logo_PointsDeControleManager_23x23.png",
                TooltipImageName = "Tooltip_Configuration_223x223.png"
            };

            // Create button from provided data.
            var FicheAuditButton = RevitPushButton.Create(FicheAuditButtonData);

            #endregion

            #region Cas d'usages

            // Populate button data model.
            var CasUsagesButtonData = new RevitPushButtonDataModel
            {
                Label = "Cas d'usages",
                Panel = annotateCommandsPanel,
                Tooltip = "Choisir règles de contrôle s’adaptant aux cas d'usages du projet.",
                CommandNamespacePath = CasUsagesCommand.GetPath(),
                IconImageName = "Logo_Cas d'usage_23x23.png",
                TooltipImageName = "Tooltip_Configuration_223x223.png"
            };

            // Create button from provided data.
            var CasUsagesButton = RevitPushButton.Create(CasUsagesButtonData);

            #endregion


        }

        #endregion

    }
}
