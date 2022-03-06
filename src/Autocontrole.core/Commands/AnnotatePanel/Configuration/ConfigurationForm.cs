namespace ECBManager.core
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Autodesk.Revit.UI;

    /// <summary>
    /// Configuration data acquisition form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"/>.
    public partial class ConfigurationForm : System.Windows.Forms.Form
    {
        #region private members

        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>.
        /// </summary>
        private UIDocument uidoc = null;

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="ConfigurationForm"/> class.
        /// </summary>
        /// <param name="uIDocment"></param>
        public ConfigurationForm(UIDocument uIDocment)
        {
            InitializeComponent();
            uidoc = uIDocment;
        }

        #endregion

        #region events

        /// <summary>
        /// Handles the Click event of the btnValider control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the btnAnnuler control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the btnAide control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAide_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the btnReinitialiser control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReinitialiser_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the btnEnregistrer control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the btnOuvrir control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOuvrir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Catégorie Organisation

        /// <summary>
        /// Handles the Click event of the btnFormatDocumentDiffusion control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFormatDocumentDiffusion_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = true;
            pointsControleInformationGeolocalisation.Visible = false;
            pointsControleOrganisationFichier.Visible = false;
            pointsControleStructurationModele.Visible = false;
            pointsControleOrganisationDonnee.Visible = false;
            pointsControleStandardsGraphiques.Visible = false;
            pointsControleVues2dFeuilles.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnInformationGeolocalisation control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInformationGeolocalisation_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = false;
            pointsControleInformationGeolocalisation.Visible = true;
            pointsControleOrganisationFichier.Visible = false;
            pointsControleStructurationModele.Visible = false;
            pointsControleOrganisationDonnee.Visible = false;
            pointsControleStandardsGraphiques.Visible = false;
            pointsControleVues2dFeuilles.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnOrganisationFichier control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrganisationFichier_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = false;
            pointsControleInformationGeolocalisation.Visible = false;
            pointsControleOrganisationFichier.Visible = true;
            pointsControleStructurationModele.Visible = false;
            pointsControleOrganisationDonnee.Visible = false;
            pointsControleStandardsGraphiques.Visible = false;
            pointsControleVues2dFeuilles.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnStructurationModele control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStructurationModele_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = false;
            pointsControleInformationGeolocalisation.Visible = false;
            pointsControleOrganisationFichier.Visible = false;
            pointsControleStructurationModele.Visible = true;
            pointsControleOrganisationDonnee.Visible = false;
            pointsControleStandardsGraphiques.Visible = false;
            pointsControleVues2dFeuilles.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnOrganisationDonnee control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrganisationDonnee_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = false;
            pointsControleInformationGeolocalisation.Visible = false;
            pointsControleOrganisationFichier.Visible = false;
            pointsControleStructurationModele.Visible = false;
            pointsControleOrganisationDonnee.Visible = true;
            pointsControleStandardsGraphiques.Visible = false;
            pointsControleVues2dFeuilles.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnStandardsGraphiques control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStandardsGraphiques_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = false;
            pointsControleInformationGeolocalisation.Visible = false;
            pointsControleOrganisationFichier.Visible = false;
            pointsControleStructurationModele.Visible = false;
            pointsControleOrganisationDonnee.Visible = false;
            pointsControleStandardsGraphiques.Visible = true;
            pointsControleVues2dFeuilles.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnVues2dFeuilles control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVues2dFeuilles_Click(object sender, EventArgs e)
        {
            pointsControleFormatDocumentDiffusion.Visible = false;
            pointsControleInformationGeolocalisation.Visible = false;
            pointsControleOrganisationFichier.Visible = false;
            pointsControleStructurationModele.Visible = false;
            pointsControleOrganisationDonnee.Visible = false;
            pointsControleStandardsGraphiques.Visible = false;
            pointsControleVues2dFeuilles.Visible = true;
        }

        #endregion

        #region Catégorie Modélisation

        /// <summary>
        /// Handles the Click event of the btnCoherenceGenerale control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCoherenceGenerale_Click(object sender, EventArgs e)
        {
            pointsControleCoherenceGenerale.Visible = true;
            pointsControleReglesModelisationArchitecturale.Visible = false;
            pointsControleReglesModelisationStructurale.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnReglesModelisationArchitecturale control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReglesModelisationArchitecturale_Click(object sender, EventArgs e)
        {
            pointsControleCoherenceGenerale.Visible = false;
            pointsControleReglesModelisationArchitecturale.Visible = true;
            pointsControleReglesModelisationStructurale.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnReglesModelisationStructurale control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReglesModelisationStructurale_Click(object sender, EventArgs e)
        {
            pointsControleCoherenceGenerale.Visible = false;
            pointsControleReglesModelisationArchitecturale.Visible = false;
            pointsControleReglesModelisationStructurale.Visible = true;
        }


        #endregion

        #region public methods

        #endregion

        
    }
}
