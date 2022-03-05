namespace ECBManager.core.Commands.AnnotatePanel.Configuration.Organisation
{
    partial class PointsControleOrganisationFichier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnOrganisationSousProjets = new System.Windows.Forms.RadioButton();
            this.groupReglesControle = new System.Windows.Forms.GroupBox();
            this.rbtnDistinctionVuesTravailVuesLivrables = new System.Windows.Forms.RadioButton();
            this.rbtnOrganisationArborescenceFeuilles = new System.Windows.Forms.RadioButton();
            this.rbtnOrganisationArborescenceVues = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnOrganisationSousProjets
            // 
            this.rbtnOrganisationSousProjets.AutoSize = true;
            this.rbtnOrganisationSousProjets.Location = new System.Drawing.Point(3, 72);
            this.rbtnOrganisationSousProjets.Name = "rbtnOrganisationSousProjets";
            this.rbtnOrganisationSousProjets.Size = new System.Drawing.Size(161, 17);
            this.rbtnOrganisationSousProjets.TabIndex = 21;
            this.rbtnOrganisationSousProjets.Text = "Organisation en Sous-Projets";
            this.rbtnOrganisationSousProjets.UseVisualStyleBackColor = true;
            // 
            // groupReglesControle
            // 
            this.groupReglesControle.Location = new System.Drawing.Point(295, 3);
            this.groupReglesControle.Name = "groupReglesControle";
            this.groupReglesControle.Size = new System.Drawing.Size(491, 499);
            this.groupReglesControle.TabIndex = 20;
            this.groupReglesControle.TabStop = false;
            this.groupReglesControle.Text = "Règles de contrôle";
            // 
            // rbtnDistinctionVuesTravailVuesLivrables
            // 
            this.rbtnDistinctionVuesTravailVuesLivrables.AutoSize = true;
            this.rbtnDistinctionVuesTravailVuesLivrables.Location = new System.Drawing.Point(3, 49);
            this.rbtnDistinctionVuesTravailVuesLivrables.Name = "rbtnDistinctionVuesTravailVuesLivrables";
            this.rbtnDistinctionVuesTravailVuesLivrables.Size = new System.Drawing.Size(256, 17);
            this.rbtnDistinctionVuesTravailVuesLivrables.TabIndex = 19;
            this.rbtnDistinctionVuesTravailVuesLivrables.Text = "Distinction des vues de travail / vues de livrables";
            this.rbtnDistinctionVuesTravailVuesLivrables.UseVisualStyleBackColor = true;
            // 
            // rbtnOrganisationArborescenceFeuilles
            // 
            this.rbtnOrganisationArborescenceFeuilles.AutoSize = true;
            this.rbtnOrganisationArborescenceFeuilles.Location = new System.Drawing.Point(3, 26);
            this.rbtnOrganisationArborescenceFeuilles.Name = "rbtnOrganisationArborescenceFeuilles";
            this.rbtnOrganisationArborescenceFeuilles.Size = new System.Drawing.Size(208, 17);
            this.rbtnOrganisationArborescenceFeuilles.TabIndex = 18;
            this.rbtnOrganisationArborescenceFeuilles.Text = "Organisation Arborescence des feuilles";
            this.rbtnOrganisationArborescenceFeuilles.UseVisualStyleBackColor = true;
            // 
            // rbtnOrganisationArborescenceVues
            // 
            this.rbtnOrganisationArborescenceVues.AutoSize = true;
            this.rbtnOrganisationArborescenceVues.Checked = true;
            this.rbtnOrganisationArborescenceVues.Location = new System.Drawing.Point(3, 3);
            this.rbtnOrganisationArborescenceVues.Name = "rbtnOrganisationArborescenceVues";
            this.rbtnOrganisationArborescenceVues.Size = new System.Drawing.Size(199, 17);
            this.rbtnOrganisationArborescenceVues.TabIndex = 17;
            this.rbtnOrganisationArborescenceVues.TabStop = true;
            this.rbtnOrganisationArborescenceVues.Text = "Organisation Arborescence des vues";
            this.rbtnOrganisationArborescenceVues.UseVisualStyleBackColor = true;
            // 
            // pointsControleOrganisationFichier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnOrganisationSousProjets);
            this.Controls.Add(this.groupReglesControle);
            this.Controls.Add(this.rbtnDistinctionVuesTravailVuesLivrables);
            this.Controls.Add(this.rbtnOrganisationArborescenceFeuilles);
            this.Controls.Add(this.rbtnOrganisationArborescenceVues);
            this.Name = "pointsControleOrganisationFichier";
            this.Size = new System.Drawing.Size(789, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnOrganisationSousProjets;
        private System.Windows.Forms.GroupBox groupReglesControle;
        private System.Windows.Forms.RadioButton rbtnDistinctionVuesTravailVuesLivrables;
        private System.Windows.Forms.RadioButton rbtnOrganisationArborescenceFeuilles;
        private System.Windows.Forms.RadioButton rbtnOrganisationArborescenceVues;
    }
}
