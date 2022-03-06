namespace ECBManager.core
{
    using System;
    using System.Windows.Forms;
    using Autodesk.Revit.UI;

    /// <summary>
    /// Cas d'usage data aquisition form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"/>.
    public partial class CasUsagesForm : System.Windows.Forms.Form
    {
        #region private members

        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>.
        /// </summary>
        private UIDocument uidoc = null;

        #endregion

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="CasUsagesForm"/> class.
        /// </summary>
        /// <param name="uIDocment"></param>
        public CasUsagesForm(UIDocument uIDocment)
        {
            InitializeComponent();
            uidoc = uIDocment;
        }
    }
}
