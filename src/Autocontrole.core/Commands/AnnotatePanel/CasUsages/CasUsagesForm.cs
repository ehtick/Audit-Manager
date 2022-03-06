namespace ECBManager.core
{
    using System;
    using System.Linq;
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

        #region public methods

        /// <summary>
        /// Gets information from user.
        /// </summary>
        /// <returns></returns>
        public CasUsagesCommandData GetInformation()
        {
            var information = new CasUsagesCommandData()
            {
                NomFichier = checkedListBoxCasUsage.GetItemChecked(0),
                TailleFichier = checkedListBoxCasUsage.GetItemChecked(1),
                MaquettePurgee = checkedListBoxCasUsage.GetItemChecked(2),
                MaquetteDetachee = checkedListBoxCasUsage.GetItemChecked(3),
                ModeleDecharge = checkedListBoxCasUsage.GetItemChecked(4),
                IfcDiffuse = checkedListBoxCasUsage.GetItemChecked(5),
                ExportIfc = checkedListBoxCasUsage.GetItemChecked(6),
                InfosProjet = checkedListBoxCasUsage.GetItemChecked(7),
                VueDemarrage = checkedListBoxCasUsage.GetItemChecked(8),
                Unites = checkedListBoxCasUsage.GetItemChecked(9),
                CoordonneesPartagees = checkedListBoxCasUsage.GetItemChecked(10),
                NordGeoNordProjet = checkedListBoxCasUsage.GetItemChecked(11),
                ArborescenceVues = checkedListBoxCasUsage.GetItemChecked(12),
                ArborescenceFeuilles = checkedListBoxCasUsage.GetItemChecked(13),
                DistinctionTravailLivrables = checkedListBoxCasUsage.GetItemChecked(14),
                SousProjets = checkedListBoxCasUsage.GetItemChecked(15),
                Quadrillages = checkedListBoxCasUsage.GetItemChecked(16),
                Niveaux = checkedListBoxCasUsage.GetItemChecked(17),
                ZonesDefinition = checkedListBoxCasUsage.GetItemChecked(18),
                ObjetsBonsSousProjet = checkedListBoxCasUsage.GetItemChecked(19),
                ParametresProjetPartages = checkedListBoxCasUsage.GetItemChecked(20),
                Nomenclatures = checkedListBoxCasUsage.GetItemChecked(21),
                CodificationNomenclatures = checkedListBoxCasUsage.GetItemChecked(22),
                Materiaux = checkedListBoxCasUsage.GetItemChecked(23),
                CodificationObjets = checkedListBoxCasUsage.GetItemChecked(24),
                ClassificationObjets = checkedListBoxCasUsage.GetItemChecked(25),
                Apparence = checkedListBoxCasUsage.GetItemChecked(26),
                Documentation = checkedListBoxCasUsage.GetItemChecked(27),
                ObjetsMasques = checkedListBoxCasUsage.GetItemChecked(28),
                CoherencePresentations = checkedListBoxCasUsage.GetItemChecked(29),
                RealiseesDepuis3d = checkedListBoxCasUsage.GetItemChecked(30),
                Cartouche = checkedListBoxCasUsage.GetItemChecked(31),
                ElementDetails = checkedListBoxCasUsage.GetItemChecked(32),
            };

            return information;
        }

        #endregion
    }
}
