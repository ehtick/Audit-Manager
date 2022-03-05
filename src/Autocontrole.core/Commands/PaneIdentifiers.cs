namespace ECBManager.core
{
    using System;
    
    /// <summary>
    /// Guid container that holds guid references to dockable panes.
    /// </summary>
    public static class PaneIdentifiers
    {
        #region public methods

        /// <summary>
        /// The points de controle manager dockable pane identifier.
        /// </summary>
        /// <returns></returns>
        public static Guid GetManagerPaneIdentidiers()
        {
            return new Guid("3834BED8-6F78-4889-8803-E24A8E71F8C7");
        }

        #endregion
    }
}
