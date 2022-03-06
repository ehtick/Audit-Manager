namespace ECBManager.core
{
    using Autodesk.Revit.DB;

    /// <summary>
    /// Information and data model for command <see cref="CasUsagesCommand"/> to execute.
    /// </summary>
    public class CasUsagesCommandData
    {
        #region public properties

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Nom du fichier conforme".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool NomFichier { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Taille du fichier".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool TailleFichier { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Maquette purgée".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool MaquettePurgee { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Maquette détachée".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool MaquetteDetachee { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Modèles et documents liés déchargés".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ModeleDecharge { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Modèle IFC diffusé".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool IfcDiffuse { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Export du modèle IFC".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ExportIfc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Infos du Projet".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool InfosProjet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Vue de démarrage paramétrée".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool VueDemarrage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Unités".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Unites { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Coordonnées partagées".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool CoordonneesPartagees { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Nord Géo. / Nord Projet".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool NordGeoNordProjet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Organisation Arborescence des vues".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ArborescenceVues { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Organisation Arborescence des feuilles".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ArborescenceFeuilles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Distinction des vues de travail / vues de livrables".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool DistinctionTravailLivrables { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Organisation en Sous-Projets".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool SousProjets { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Quadrillages (positionnement, nommage, …)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Quadrillages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Niveaux (altimétrie, nom)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Niveaux { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Zones de définition".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ZonesDefinition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Objets rattachés aux bons sous projet".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ObjetsBonsSousProjet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Paramètres Projet et Partagés".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ParametresProjetPartages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Nomenclatures (Catégories, Orga., …)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Nomenclatures { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Codification des Nomenclatures".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool CodificationNomenclatures { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Matériaux (Texture, Caractéristiques, Codification)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Materiaux { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Codification des objets (famille et type)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool CodificationObjets { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Classification des objets".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ClassificationObjets { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Apparence (Styles d'objets, de lignes; Motifs de lignes, de remplissages)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Apparence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Documentation (Textes, Etq, Cotations, Annot.)".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Documentation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Objets masqués".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ObjetsMasques { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Cohérence des présentations".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool CoherencePresentations { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Réalisées depuis la 3D".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool RealiseesDepuis3d { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Cartouche".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Cartouche { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CasUsagesCommandData"/> should display layer function "Eléments de détails".
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool ElementDetails { get; set; }

        #endregion

        #region constructor

        public CasUsagesCommandData()
        {

        }

        #endregion
    }
}
