namespace ECBManager.core
{
    partial class CasUsagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxCasUsage = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxCasUsage
            // 
            this.checkedListBoxCasUsage.FormattingEnabled = true;
            this.checkedListBoxCasUsage.Items.AddRange(new object[] {
            "Nom du fichier conforme",
            "Taille du fichier",
            "Maquette purgée",
            "Maquette détachée (Ss-projets libérés)",
            "Modèles et documents liés déchargés",
            "Modèle IFC diffusé",
            "Export du modèle IFC",
            "Infos du Projet",
            "Vue de démarrage paramétrée",
            "Unités",
            "Coordonnées partagées",
            "Nord Géo. / Nord Projet",
            "Organisation Arborescence des vues",
            "Organisation Arborescence des feuilles",
            "Distinction des vues de travail / vues de livrables",
            "Organisation en Sous-Projets",
            "Quadrillages (positionnement, nommage, …)",
            "Niveaux (altimétrie, nom)",
            "Zones de définition",
            "Objets rattachés aux bons sous projet",
            "Paramètres Projet et Partagés",
            "Nomenclatures (Catégories, Orga., …)",
            "Codification des Nomenclatures",
            "Matériaux (Texture, Caractéristiques, Codification)",
            "Codification des objets (famille et type)",
            "Classification des objets",
            "Apparence (Styles d\'objets, de lignes; Motifs de lignes, de remplissages)",
            "Documentation (Textes, Etq, Cotations, Annot.)",
            "Objets \"masqués\"",
            "Cohérence des présentations",
            "Réalisées depuis la 3D",
            "Cartouche",
            "Eléments de détails"});
            this.checkedListBoxCasUsage.Location = new System.Drawing.Point(198, 12);
            this.checkedListBoxCasUsage.Name = "checkedListBoxCasUsage";
            this.checkedListBoxCasUsage.Size = new System.Drawing.Size(422, 469);
            this.checkedListBoxCasUsage.TabIndex = 0;
            // 
            // CasUsagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 542);
            this.Controls.Add(this.checkedListBoxCasUsage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CasUsagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cas d\'usages";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox checkedListBoxCasUsage;
    }
}