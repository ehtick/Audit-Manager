namespace Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation
{
    partial class pointsControleVues2dFeuilles
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
            this.groupReglesControle = new System.Windows.Forms.GroupBox();
            this.rbtnCartouche = new System.Windows.Forms.RadioButton();
            this.rbtnRealiseesDepuis3d = new System.Windows.Forms.RadioButton();
            this.rbtnCoherencePresentations = new System.Windows.Forms.RadioButton();
            this.rbtnElementsDetails = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // groupReglesControle
            // 
            this.groupReglesControle.Location = new System.Drawing.Point(295, 3);
            this.groupReglesControle.Name = "groupReglesControle";
            this.groupReglesControle.Size = new System.Drawing.Size(491, 499);
            this.groupReglesControle.TabIndex = 21;
            this.groupReglesControle.TabStop = false;
            this.groupReglesControle.Text = "Règles de contrôle";
            // 
            // rbtnCartouche
            // 
            this.rbtnCartouche.AutoSize = true;
            this.rbtnCartouche.Location = new System.Drawing.Point(3, 49);
            this.rbtnCartouche.Name = "rbtnCartouche";
            this.rbtnCartouche.Size = new System.Drawing.Size(74, 17);
            this.rbtnCartouche.TabIndex = 20;
            this.rbtnCartouche.Text = "Cartouche";
            this.rbtnCartouche.UseVisualStyleBackColor = true;
            // 
            // rbtnRealiseesDepuis3d
            // 
            this.rbtnRealiseesDepuis3d.AutoSize = true;
            this.rbtnRealiseesDepuis3d.Location = new System.Drawing.Point(3, 26);
            this.rbtnRealiseesDepuis3d.Name = "rbtnRealiseesDepuis3d";
            this.rbtnRealiseesDepuis3d.Size = new System.Drawing.Size(133, 17);
            this.rbtnRealiseesDepuis3d.TabIndex = 19;
            this.rbtnRealiseesDepuis3d.Text = "Réalisées depuis la 3D";
            this.rbtnRealiseesDepuis3d.UseVisualStyleBackColor = true;
            // 
            // rbtnCoherencePresentations
            // 
            this.rbtnCoherencePresentations.AutoSize = true;
            this.rbtnCoherencePresentations.Checked = true;
            this.rbtnCoherencePresentations.Location = new System.Drawing.Point(3, 3);
            this.rbtnCoherencePresentations.Name = "rbtnCoherencePresentations";
            this.rbtnCoherencePresentations.Size = new System.Drawing.Size(163, 17);
            this.rbtnCoherencePresentations.TabIndex = 18;
            this.rbtnCoherencePresentations.TabStop = true;
            this.rbtnCoherencePresentations.Text = "Cohérence des présentations";
            this.rbtnCoherencePresentations.UseVisualStyleBackColor = true;
            // 
            // rbtnElementsDetails
            // 
            this.rbtnElementsDetails.AutoSize = true;
            this.rbtnElementsDetails.Location = new System.Drawing.Point(3, 72);
            this.rbtnElementsDetails.Name = "rbtnElementsDetails";
            this.rbtnElementsDetails.Size = new System.Drawing.Size(116, 17);
            this.rbtnElementsDetails.TabIndex = 22;
            this.rbtnElementsDetails.Text = "Eléments de détails";
            this.rbtnElementsDetails.UseVisualStyleBackColor = true;
            // 
            // pointsControleVues2dFeuilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnElementsDetails);
            this.Controls.Add(this.groupReglesControle);
            this.Controls.Add(this.rbtnCartouche);
            this.Controls.Add(this.rbtnRealiseesDepuis3d);
            this.Controls.Add(this.rbtnCoherencePresentations);
            this.Name = "pointsControleVues2dFeuilles";
            this.Size = new System.Drawing.Size(789, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupReglesControle;
        private System.Windows.Forms.RadioButton rbtnCartouche;
        private System.Windows.Forms.RadioButton rbtnRealiseesDepuis3d;
        private System.Windows.Forms.RadioButton rbtnCoherencePresentations;
        private System.Windows.Forms.RadioButton rbtnElementsDetails;
    }
}
