namespace Autocontrole.core
{
    partial class ConfigurationForm
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
            this.tabConfiguration = new System.Windows.Forms.TabControl();
            this.tabOrganisation = new System.Windows.Forms.TabPage();
            this.btnVues2dFeuilles = new System.Windows.Forms.Button();
            this.btnStandardsGraphiques = new System.Windows.Forms.Button();
            this.btnOrganisationDonnee = new System.Windows.Forms.Button();
            this.btnStructurationModele = new System.Windows.Forms.Button();
            this.btnOrganisationFichier = new System.Windows.Forms.Button();
            this.btnInformationGeolocalisation = new System.Windows.Forms.Button();
            this.groupPointsControle = new System.Windows.Forms.GroupBox();
            this.btnFormatDocumentDiffusion = new System.Windows.Forms.Button();
            this.tabModelisation = new System.Windows.Forms.TabPage();
            this.btnReglesModelisationStructurale = new System.Windows.Forms.Button();
            this.btnReglesModelisationArchitecturale = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCoherenceGenerale = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.pointsControleVues2dFeuilles = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation.pointsControleVues2dFeuilles();
            this.pointsControleStandardsGraphiques = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation.pointsControleStandardsGraphiques();
            this.pointsControleOrganisationDonnee = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation.pointsControleOrganisationDonnee();
            this.pointsControleStructurationModele = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation.pointsControleStructurationModele();
            this.pointsControleOrganisationFichier = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation.pointsControleOrganisationFichier();
            this.pointsControleInformationGeolocalisation = new Autocontrole.core.PointsControleInformationGeolocalisation();
            this.pointsControleFormatDocumentDiffusion = new Autocontrole.core.pointsControleFormatDocumentDiffusion();
            this.pointsControleReglesModelisationStructurale = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Modelisation.PointsControleReglesModelisationStructurale();
            this.pointsControleReglesModelisationArchitecturale = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Modelisation.pointsControleReglesModelisationArchitecturale();
            this.pointsControleCoherenceGenerale = new Autocontrole.core.Commands.AnnotatePanel.Configuration.Modelisation.pointsControleCoherenceGenerale();
            this.tabConfiguration.SuspendLayout();
            this.tabOrganisation.SuspendLayout();
            this.groupPointsControle.SuspendLayout();
            this.tabModelisation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.tabOrganisation);
            this.tabConfiguration.Controls.Add(this.tabModelisation);
            this.tabConfiguration.Location = new System.Drawing.Point(12, 12);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.SelectedIndex = 0;
            this.tabConfiguration.Size = new System.Drawing.Size(1088, 580);
            this.tabConfiguration.TabIndex = 2;
            // 
            // tabOrganisation
            // 
            this.tabOrganisation.Controls.Add(this.btnVues2dFeuilles);
            this.tabOrganisation.Controls.Add(this.btnStandardsGraphiques);
            this.tabOrganisation.Controls.Add(this.btnOrganisationDonnee);
            this.tabOrganisation.Controls.Add(this.btnStructurationModele);
            this.tabOrganisation.Controls.Add(this.btnOrganisationFichier);
            this.tabOrganisation.Controls.Add(this.btnInformationGeolocalisation);
            this.tabOrganisation.Controls.Add(this.groupPointsControle);
            this.tabOrganisation.Controls.Add(this.btnFormatDocumentDiffusion);
            this.tabOrganisation.Location = new System.Drawing.Point(4, 22);
            this.tabOrganisation.Name = "tabOrganisation";
            this.tabOrganisation.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrganisation.Size = new System.Drawing.Size(1080, 554);
            this.tabOrganisation.TabIndex = 0;
            this.tabOrganisation.Text = "Organisation";
            this.tabOrganisation.UseVisualStyleBackColor = true;
            // 
            // btnVues2dFeuilles
            // 
            this.btnVues2dFeuilles.Location = new System.Drawing.Point(7, 186);
            this.btnVues2dFeuilles.Name = "btnVues2dFeuilles";
            this.btnVues2dFeuilles.Size = new System.Drawing.Size(247, 23);
            this.btnVues2dFeuilles.TabIndex = 10;
            this.btnVues2dFeuilles.Text = "Vues 2D / Feuilles";
            this.btnVues2dFeuilles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVues2dFeuilles.UseVisualStyleBackColor = true;
            this.btnVues2dFeuilles.Click += new System.EventHandler(this.BtnVues2dFeuilles_Click);
            // 
            // btnStandardsGraphiques
            // 
            this.btnStandardsGraphiques.Location = new System.Drawing.Point(7, 157);
            this.btnStandardsGraphiques.Name = "btnStandardsGraphiques";
            this.btnStandardsGraphiques.Size = new System.Drawing.Size(247, 23);
            this.btnStandardsGraphiques.TabIndex = 9;
            this.btnStandardsGraphiques.Text = "Standards graphiques";
            this.btnStandardsGraphiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandardsGraphiques.UseVisualStyleBackColor = true;
            this.btnStandardsGraphiques.Click += new System.EventHandler(this.BtnStandardsGraphiques_Click);
            // 
            // btnOrganisationDonnee
            // 
            this.btnOrganisationDonnee.Location = new System.Drawing.Point(7, 128);
            this.btnOrganisationDonnee.Name = "btnOrganisationDonnee";
            this.btnOrganisationDonnee.Size = new System.Drawing.Size(247, 23);
            this.btnOrganisationDonnee.TabIndex = 8;
            this.btnOrganisationDonnee.Text = "Organisation de la donnée";
            this.btnOrganisationDonnee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganisationDonnee.UseVisualStyleBackColor = true;
            this.btnOrganisationDonnee.Click += new System.EventHandler(this.BtnOrganisationDonnee_Click);
            // 
            // btnStructurationModele
            // 
            this.btnStructurationModele.Location = new System.Drawing.Point(7, 99);
            this.btnStructurationModele.Name = "btnStructurationModele";
            this.btnStructurationModele.Size = new System.Drawing.Size(247, 23);
            this.btnStructurationModele.TabIndex = 7;
            this.btnStructurationModele.Text = "Structuration du modèle";
            this.btnStructurationModele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStructurationModele.UseVisualStyleBackColor = true;
            this.btnStructurationModele.Click += new System.EventHandler(this.BtnStructurationModele_Click);
            // 
            // btnOrganisationFichier
            // 
            this.btnOrganisationFichier.Location = new System.Drawing.Point(7, 70);
            this.btnOrganisationFichier.Name = "btnOrganisationFichier";
            this.btnOrganisationFichier.Size = new System.Drawing.Size(247, 23);
            this.btnOrganisationFichier.TabIndex = 6;
            this.btnOrganisationFichier.Text = "Organisation du fichier";
            this.btnOrganisationFichier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganisationFichier.UseVisualStyleBackColor = true;
            this.btnOrganisationFichier.Click += new System.EventHandler(this.BtnOrganisationFichier_Click);
            // 
            // btnInformationGeolocalisation
            // 
            this.btnInformationGeolocalisation.Location = new System.Drawing.Point(7, 41);
            this.btnInformationGeolocalisation.Name = "btnInformationGeolocalisation";
            this.btnInformationGeolocalisation.Size = new System.Drawing.Size(247, 23);
            this.btnInformationGeolocalisation.TabIndex = 5;
            this.btnInformationGeolocalisation.Text = "Information du projet, géolocalisation";
            this.btnInformationGeolocalisation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformationGeolocalisation.UseVisualStyleBackColor = true;
            this.btnInformationGeolocalisation.Click += new System.EventHandler(this.BtnInformationGeolocalisation_Click);
            // 
            // groupPointsControle
            // 
            this.groupPointsControle.Controls.Add(this.pointsControleVues2dFeuilles);
            this.groupPointsControle.Controls.Add(this.pointsControleStandardsGraphiques);
            this.groupPointsControle.Controls.Add(this.pointsControleOrganisationDonnee);
            this.groupPointsControle.Controls.Add(this.pointsControleStructurationModele);
            this.groupPointsControle.Controls.Add(this.pointsControleOrganisationFichier);
            this.groupPointsControle.Controls.Add(this.pointsControleInformationGeolocalisation);
            this.groupPointsControle.Controls.Add(this.pointsControleFormatDocumentDiffusion);
            this.groupPointsControle.Location = new System.Drawing.Point(280, 6);
            this.groupPointsControle.Name = "groupPointsControle";
            this.groupPointsControle.Size = new System.Drawing.Size(799, 548);
            this.groupPointsControle.TabIndex = 4;
            this.groupPointsControle.TabStop = false;
            this.groupPointsControle.Text = "Points de contrôle";
            // 
            // btnFormatDocumentDiffusion
            // 
            this.btnFormatDocumentDiffusion.Location = new System.Drawing.Point(7, 11);
            this.btnFormatDocumentDiffusion.Name = "btnFormatDocumentDiffusion";
            this.btnFormatDocumentDiffusion.Size = new System.Drawing.Size(247, 23);
            this.btnFormatDocumentDiffusion.TabIndex = 3;
            this.btnFormatDocumentDiffusion.Text = "Format du fichier, documents liés, diffusion";
            this.btnFormatDocumentDiffusion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormatDocumentDiffusion.UseVisualStyleBackColor = true;
            this.btnFormatDocumentDiffusion.Click += new System.EventHandler(this.BtnFormatDocumentDiffusion_Click);
            // 
            // tabModelisation
            // 
            this.tabModelisation.Controls.Add(this.btnReglesModelisationStructurale);
            this.tabModelisation.Controls.Add(this.btnReglesModelisationArchitecturale);
            this.tabModelisation.Controls.Add(this.groupBox1);
            this.tabModelisation.Controls.Add(this.btnCoherenceGenerale);
            this.tabModelisation.Location = new System.Drawing.Point(4, 22);
            this.tabModelisation.Name = "tabModelisation";
            this.tabModelisation.Padding = new System.Windows.Forms.Padding(3);
            this.tabModelisation.Size = new System.Drawing.Size(1080, 554);
            this.tabModelisation.TabIndex = 1;
            this.tabModelisation.Text = "Modélisation";
            this.tabModelisation.UseVisualStyleBackColor = true;
            // 
            // btnReglesModelisationStructurale
            // 
            this.btnReglesModelisationStructurale.Location = new System.Drawing.Point(6, 68);
            this.btnReglesModelisationStructurale.Name = "btnReglesModelisationStructurale";
            this.btnReglesModelisationStructurale.Size = new System.Drawing.Size(247, 23);
            this.btnReglesModelisationStructurale.TabIndex = 8;
            this.btnReglesModelisationStructurale.Text = "Règles de modélisation structurale";
            this.btnReglesModelisationStructurale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglesModelisationStructurale.UseVisualStyleBackColor = true;
            this.btnReglesModelisationStructurale.Click += new System.EventHandler(this.BtnReglesModelisationStructurale_Click);
            // 
            // btnReglesModelisationArchitecturale
            // 
            this.btnReglesModelisationArchitecturale.Location = new System.Drawing.Point(6, 39);
            this.btnReglesModelisationArchitecturale.Name = "btnReglesModelisationArchitecturale";
            this.btnReglesModelisationArchitecturale.Size = new System.Drawing.Size(247, 23);
            this.btnReglesModelisationArchitecturale.TabIndex = 7;
            this.btnReglesModelisationArchitecturale.Text = "Règles de modélisation architecturale";
            this.btnReglesModelisationArchitecturale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglesModelisationArchitecturale.UseVisualStyleBackColor = true;
            this.btnReglesModelisationArchitecturale.Click += new System.EventHandler(this.BtnReglesModelisationArchitecturale_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointsControleReglesModelisationStructurale);
            this.groupBox1.Controls.Add(this.pointsControleReglesModelisationArchitecturale);
            this.groupBox1.Controls.Add(this.pointsControleCoherenceGenerale);
            this.groupBox1.Location = new System.Drawing.Point(277, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 552);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Points de contrôle";
            // 
            // btnCoherenceGenerale
            // 
            this.btnCoherenceGenerale.Location = new System.Drawing.Point(6, 10);
            this.btnCoherenceGenerale.Name = "btnCoherenceGenerale";
            this.btnCoherenceGenerale.Size = new System.Drawing.Size(247, 23);
            this.btnCoherenceGenerale.TabIndex = 5;
            this.btnCoherenceGenerale.Text = "Cohérence générale de la modélisation";
            this.btnCoherenceGenerale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoherenceGenerale.UseVisualStyleBackColor = true;
            this.btnCoherenceGenerale.Click += new System.EventHandler(this.BtnCoherenceGenerale_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(863, 598);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(944, 598);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(1025, 598);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 5;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.BtnAide_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(599, 598);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(75, 23);
            this.btnReinitialiser.TabIndex = 6;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.BtnReinitialiser_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(16, 598);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(97, 598);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(75, 23);
            this.btnOuvrir.TabIndex = 8;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.BtnOuvrir_Click);
            // 
            // pointsControleVues2dFeuilles
            // 
            this.pointsControleVues2dFeuilles.Location = new System.Drawing.Point(6, 19);
            this.pointsControleVues2dFeuilles.Name = "pointsControleVues2dFeuilles";
            this.pointsControleVues2dFeuilles.Size = new System.Drawing.Size(789, 505);
            this.pointsControleVues2dFeuilles.TabIndex = 6;
            this.pointsControleVues2dFeuilles.Visible = false;
            // 
            // pointsControleStandardsGraphiques
            // 
            this.pointsControleStandardsGraphiques.Location = new System.Drawing.Point(6, 19);
            this.pointsControleStandardsGraphiques.Name = "pointsControleStandardsGraphiques";
            this.pointsControleStandardsGraphiques.Size = new System.Drawing.Size(789, 505);
            this.pointsControleStandardsGraphiques.TabIndex = 5;
            this.pointsControleStandardsGraphiques.Visible = false;
            // 
            // pointsControleOrganisationDonnee
            // 
            this.pointsControleOrganisationDonnee.Location = new System.Drawing.Point(6, 19);
            this.pointsControleOrganisationDonnee.Name = "pointsControleOrganisationDonnee";
            this.pointsControleOrganisationDonnee.Size = new System.Drawing.Size(789, 505);
            this.pointsControleOrganisationDonnee.TabIndex = 4;
            this.pointsControleOrganisationDonnee.Visible = false;
            // 
            // pointsControleStructurationModele
            // 
            this.pointsControleStructurationModele.Location = new System.Drawing.Point(6, 19);
            this.pointsControleStructurationModele.Name = "pointsControleStructurationModele";
            this.pointsControleStructurationModele.Size = new System.Drawing.Size(789, 505);
            this.pointsControleStructurationModele.TabIndex = 3;
            this.pointsControleStructurationModele.Visible = false;
            // 
            // pointsControleOrganisationFichier
            // 
            this.pointsControleOrganisationFichier.Location = new System.Drawing.Point(6, 19);
            this.pointsControleOrganisationFichier.Name = "pointsControleOrganisationFichier";
            this.pointsControleOrganisationFichier.Size = new System.Drawing.Size(789, 505);
            this.pointsControleOrganisationFichier.TabIndex = 2;
            this.pointsControleOrganisationFichier.Visible = false;
            // 
            // pointsControleInformationGeolocalisation
            // 
            this.pointsControleInformationGeolocalisation.Location = new System.Drawing.Point(6, 19);
            this.pointsControleInformationGeolocalisation.Name = "pointsControleInformationGeolocalisation";
            this.pointsControleInformationGeolocalisation.Size = new System.Drawing.Size(789, 505);
            this.pointsControleInformationGeolocalisation.TabIndex = 1;
            this.pointsControleInformationGeolocalisation.Visible = false;
            // 
            // pointsControleFormatDocumentDiffusion
            // 
            this.pointsControleFormatDocumentDiffusion.Location = new System.Drawing.Point(6, 19);
            this.pointsControleFormatDocumentDiffusion.Name = "pointsControleFormatDocumentDiffusion";
            this.pointsControleFormatDocumentDiffusion.Size = new System.Drawing.Size(787, 518);
            this.pointsControleFormatDocumentDiffusion.TabIndex = 0;
            this.pointsControleFormatDocumentDiffusion.Visible = false;
            // 
            // pointsControleReglesModelisationStructurale
            // 
            this.pointsControleReglesModelisationStructurale.Location = new System.Drawing.Point(6, 17);
            this.pointsControleReglesModelisationStructurale.Name = "pointsControleReglesModelisationStructurale";
            this.pointsControleReglesModelisationStructurale.Size = new System.Drawing.Size(789, 533);
            this.pointsControleReglesModelisationStructurale.TabIndex = 2;
            this.pointsControleReglesModelisationStructurale.Visible = false;
            // 
            // pointsControleReglesModelisationArchitecturale
            // 
            this.pointsControleReglesModelisationArchitecturale.Location = new System.Drawing.Point(6, 17);
            this.pointsControleReglesModelisationArchitecturale.Name = "pointsControleReglesModelisationArchitecturale";
            this.pointsControleReglesModelisationArchitecturale.Size = new System.Drawing.Size(789, 505);
            this.pointsControleReglesModelisationArchitecturale.TabIndex = 1;
            this.pointsControleReglesModelisationArchitecturale.Visible = false;
            // 
            // pointsControleCoherenceGenerale
            // 
            this.pointsControleCoherenceGenerale.Location = new System.Drawing.Point(6, 17);
            this.pointsControleCoherenceGenerale.Name = "pointsControleCoherenceGenerale";
            this.pointsControleCoherenceGenerale.Size = new System.Drawing.Size(789, 505);
            this.pointsControleCoherenceGenerale.TabIndex = 0;
            this.pointsControleCoherenceGenerale.Visible = false;
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(1112, 633);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tabConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.tabConfiguration.ResumeLayout(false);
            this.tabOrganisation.ResumeLayout(false);
            this.groupPointsControle.ResumeLayout(false);
            this.tabModelisation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabConfiguration;
        private System.Windows.Forms.TabPage tabOrganisation;
        private System.Windows.Forms.TabPage tabModelisation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.GroupBox groupPointsControle;
        private System.Windows.Forms.Button btnFormatDocumentDiffusion;
        private pointsControleFormatDocumentDiffusion pointsControleFormatDocumentDiffusion;
        private System.Windows.Forms.Button btnInformationGeolocalisation;
        private PointsControleInformationGeolocalisation pointsControleInformationGeolocalisation;
        private System.Windows.Forms.Button btnOrganisationFichier;
        private Commands.AnnotatePanel.Configuration.Organisation.pointsControleOrganisationFichier pointsControleOrganisationFichier;
        private System.Windows.Forms.Button btnStructurationModele;
        private Commands.AnnotatePanel.Configuration.Organisation.pointsControleStructurationModele pointsControleStructurationModele;
        private System.Windows.Forms.Button btnOrganisationDonnee;
        private Commands.AnnotatePanel.Configuration.Organisation.pointsControleOrganisationDonnee pointsControleOrganisationDonnee;
        private System.Windows.Forms.Button btnStandardsGraphiques;
        private Commands.AnnotatePanel.Configuration.Organisation.pointsControleStandardsGraphiques pointsControleStandardsGraphiques;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnVues2dFeuilles;
        private Commands.AnnotatePanel.Configuration.Organisation.pointsControleVues2dFeuilles pointsControleVues2dFeuilles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReglesModelisationArchitecturale;
        private System.Windows.Forms.Button btnReglesModelisationStructurale;
        private Commands.AnnotatePanel.Configuration.Modelisation.pointsControleCoherenceGenerale pointsControleCoherenceGenerale;
        private Commands.AnnotatePanel.Configuration.Modelisation.pointsControleReglesModelisationArchitecturale pointsControleReglesModelisationArchitecturale;
        private Commands.AnnotatePanel.Configuration.Modelisation.PointsControleReglesModelisationStructurale pointsControleReglesModelisationStructurale;
        private System.Windows.Forms.Button btnCoherenceGenerale;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnOuvrir;
    }
}