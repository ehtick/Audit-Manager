namespace Autocontrole.core.Commands.AnnotatePanel.Configuration.Organisation
{
    partial class pointsControleStructurationModele
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
            this.rbtnObjetsRattachesSousProjet = new System.Windows.Forms.RadioButton();
            this.groupReglesControle = new System.Windows.Forms.GroupBox();
            this.rbtnZonesDefinition = new System.Windows.Forms.RadioButton();
            this.rbtnNiveaux = new System.Windows.Forms.RadioButton();
            this.rbtnQuadrillages = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnObjetsRattachesSousProjet
            // 
            this.rbtnObjetsRattachesSousProjet.AutoSize = true;
            this.rbtnObjetsRattachesSousProjet.Location = new System.Drawing.Point(3, 72);
            this.rbtnObjetsRattachesSousProjet.Name = "rbtnObjetsRattachesSousProjet";
            this.rbtnObjetsRattachesSousProjet.Size = new System.Drawing.Size(180, 17);
            this.rbtnObjetsRattachesSousProjet.TabIndex = 26;
            this.rbtnObjetsRattachesSousProjet.Text = "Objets rattachés à un sous projet";
            this.rbtnObjetsRattachesSousProjet.UseVisualStyleBackColor = true;
            // 
            // groupReglesControle
            // 
            this.groupReglesControle.Location = new System.Drawing.Point(295, 3);
            this.groupReglesControle.Name = "groupReglesControle";
            this.groupReglesControle.Size = new System.Drawing.Size(491, 499);
            this.groupReglesControle.TabIndex = 25;
            this.groupReglesControle.TabStop = false;
            this.groupReglesControle.Text = "Règles de contrôle";
            // 
            // rbtnZonesDefinition
            // 
            this.rbtnZonesDefinition.AutoSize = true;
            this.rbtnZonesDefinition.Location = new System.Drawing.Point(3, 49);
            this.rbtnZonesDefinition.Name = "rbtnZonesDefinition";
            this.rbtnZonesDefinition.Size = new System.Drawing.Size(115, 17);
            this.rbtnZonesDefinition.TabIndex = 24;
            this.rbtnZonesDefinition.Text = "Zones de définition";
            this.rbtnZonesDefinition.UseVisualStyleBackColor = true;
            // 
            // rbtnNiveaux
            // 
            this.rbtnNiveaux.AutoSize = true;
            this.rbtnNiveaux.Location = new System.Drawing.Point(3, 26);
            this.rbtnNiveaux.Name = "rbtnNiveaux";
            this.rbtnNiveaux.Size = new System.Drawing.Size(64, 17);
            this.rbtnNiveaux.TabIndex = 23;
            this.rbtnNiveaux.Text = "Niveaux";
            this.rbtnNiveaux.UseVisualStyleBackColor = true;
            // 
            // rbtnQuadrillages
            // 
            this.rbtnQuadrillages.AutoSize = true;
            this.rbtnQuadrillages.Checked = true;
            this.rbtnQuadrillages.Location = new System.Drawing.Point(3, 3);
            this.rbtnQuadrillages.Name = "rbtnQuadrillages";
            this.rbtnQuadrillages.Size = new System.Drawing.Size(83, 17);
            this.rbtnQuadrillages.TabIndex = 22;
            this.rbtnQuadrillages.TabStop = true;
            this.rbtnQuadrillages.Text = "Quadrillages";
            this.rbtnQuadrillages.UseVisualStyleBackColor = true;
            // 
            // pointsControleStructurationModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnObjetsRattachesSousProjet);
            this.Controls.Add(this.groupReglesControle);
            this.Controls.Add(this.rbtnZonesDefinition);
            this.Controls.Add(this.rbtnNiveaux);
            this.Controls.Add(this.rbtnQuadrillages);
            this.Name = "pointsControleStructurationModele";
            this.Size = new System.Drawing.Size(789, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnObjetsRattachesSousProjet;
        private System.Windows.Forms.GroupBox groupReglesControle;
        private System.Windows.Forms.RadioButton rbtnZonesDefinition;
        private System.Windows.Forms.RadioButton rbtnNiveaux;
        private System.Windows.Forms.RadioButton rbtnQuadrillages;
    }
}
