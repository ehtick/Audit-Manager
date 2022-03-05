namespace ECBManager.core
{
    partial class PointsControleFormatDocumentDiffusion
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
            this.rbtnMaquettePurgee = new System.Windows.Forms.RadioButton();
            this.rbtnTailleFichier = new System.Windows.Forms.RadioButton();
            this.rbtnNomFichier = new System.Windows.Forms.RadioButton();
            this.groupReglesControle = new System.Windows.Forms.GroupBox();
            this.rbtnModeleIfcDiffuse = new System.Windows.Forms.RadioButton();
            this.rbtnModelesDocumentsDecharges = new System.Windows.Forms.RadioButton();
            this.rbtnMaquetteDetachee = new System.Windows.Forms.RadioButton();
            this.rbtnExportModeleIfc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnMaquettePurgee
            // 
            this.rbtnMaquettePurgee.AutoSize = true;
            this.rbtnMaquettePurgee.Location = new System.Drawing.Point(3, 49);
            this.rbtnMaquettePurgee.Name = "rbtnMaquettePurgee";
            this.rbtnMaquettePurgee.Size = new System.Drawing.Size(106, 17);
            this.rbtnMaquettePurgee.TabIndex = 5;
            this.rbtnMaquettePurgee.Text = "Maquette purgée";
            this.rbtnMaquettePurgee.UseVisualStyleBackColor = true;
            // 
            // rbtnTailleFichier
            // 
            this.rbtnTailleFichier.AutoSize = true;
            this.rbtnTailleFichier.Location = new System.Drawing.Point(3, 26);
            this.rbtnTailleFichier.Name = "rbtnTailleFichier";
            this.rbtnTailleFichier.Size = new System.Drawing.Size(96, 17);
            this.rbtnTailleFichier.TabIndex = 4;
            this.rbtnTailleFichier.Text = "Taille du fichier";
            this.rbtnTailleFichier.UseVisualStyleBackColor = true;
            // 
            // rbtnNomFichier
            // 
            this.rbtnNomFichier.AutoSize = true;
            this.rbtnNomFichier.Checked = true;
            this.rbtnNomFichier.Location = new System.Drawing.Point(3, 3);
            this.rbtnNomFichier.Name = "rbtnNomFichier";
            this.rbtnNomFichier.Size = new System.Drawing.Size(140, 17);
            this.rbtnNomFichier.TabIndex = 3;
            this.rbtnNomFichier.TabStop = true;
            this.rbtnNomFichier.Text = "Nom du fichier conforme";
            this.rbtnNomFichier.UseVisualStyleBackColor = true;
            // 
            // groupReglesControle
            // 
            this.groupReglesControle.Location = new System.Drawing.Point(295, 3);
            this.groupReglesControle.Name = "groupReglesControle";
            this.groupReglesControle.Size = new System.Drawing.Size(491, 499);
            this.groupReglesControle.TabIndex = 6;
            this.groupReglesControle.TabStop = false;
            this.groupReglesControle.Text = "Règles de contrôle";
            // 
            // rbtnModeleIfcDiffuse
            // 
            this.rbtnModeleIfcDiffuse.AutoSize = true;
            this.rbtnModeleIfcDiffuse.Location = new System.Drawing.Point(3, 118);
            this.rbtnModeleIfcDiffuse.Name = "rbtnModeleIfcDiffuse";
            this.rbtnModeleIfcDiffuse.Size = new System.Drawing.Size(113, 17);
            this.rbtnModeleIfcDiffuse.TabIndex = 9;
            this.rbtnModeleIfcDiffuse.Text = "Modèle IFC diffusé";
            this.rbtnModeleIfcDiffuse.UseVisualStyleBackColor = true;
            // 
            // rbtnModelesDocumentsDecharges
            // 
            this.rbtnModelesDocumentsDecharges.AutoSize = true;
            this.rbtnModelesDocumentsDecharges.Location = new System.Drawing.Point(3, 95);
            this.rbtnModelesDocumentsDecharges.Name = "rbtnModelesDocumentsDecharges";
            this.rbtnModelesDocumentsDecharges.Size = new System.Drawing.Size(203, 17);
            this.rbtnModelesDocumentsDecharges.TabIndex = 8;
            this.rbtnModelesDocumentsDecharges.Text = "Modèles et documents liés déchargés";
            this.rbtnModelesDocumentsDecharges.UseVisualStyleBackColor = true;
            // 
            // rbtnMaquetteDetachee
            // 
            this.rbtnMaquetteDetachee.AutoSize = true;
            this.rbtnMaquetteDetachee.Location = new System.Drawing.Point(3, 72);
            this.rbtnMaquetteDetachee.Name = "rbtnMaquetteDetachee";
            this.rbtnMaquetteDetachee.Size = new System.Drawing.Size(118, 17);
            this.rbtnMaquetteDetachee.TabIndex = 7;
            this.rbtnMaquetteDetachee.Text = "Maquette détachée";
            this.rbtnMaquetteDetachee.UseVisualStyleBackColor = true;
            // 
            // rbtnExportModeleIfc
            // 
            this.rbtnExportModeleIfc.AutoSize = true;
            this.rbtnExportModeleIfc.Location = new System.Drawing.Point(3, 141);
            this.rbtnExportModeleIfc.Name = "rbtnExportModeleIfc";
            this.rbtnExportModeleIfc.Size = new System.Drawing.Size(126, 17);
            this.rbtnExportModeleIfc.TabIndex = 10;
            this.rbtnExportModeleIfc.Text = "Export du modèle IFC";
            this.rbtnExportModeleIfc.UseVisualStyleBackColor = true;
            // 
            // PointsControleFormatDocumentDiffusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnExportModeleIfc);
            this.Controls.Add(this.rbtnModeleIfcDiffuse);
            this.Controls.Add(this.rbtnModelesDocumentsDecharges);
            this.Controls.Add(this.rbtnMaquetteDetachee);
            this.Controls.Add(this.groupReglesControle);
            this.Controls.Add(this.rbtnMaquettePurgee);
            this.Controls.Add(this.rbtnTailleFichier);
            this.Controls.Add(this.rbtnNomFichier);
            this.Name = "PointsControleFormatDocumentDiffusion";
            this.Size = new System.Drawing.Size(789, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMaquettePurgee;
        private System.Windows.Forms.RadioButton rbtnTailleFichier;
        private System.Windows.Forms.RadioButton rbtnNomFichier;
        private System.Windows.Forms.GroupBox groupReglesControle;
        private System.Windows.Forms.RadioButton rbtnModeleIfcDiffuse;
        private System.Windows.Forms.RadioButton rbtnModelesDocumentsDecharges;
        private System.Windows.Forms.RadioButton rbtnMaquetteDetachee;
        private System.Windows.Forms.RadioButton rbtnExportModeleIfc;
    }
}
