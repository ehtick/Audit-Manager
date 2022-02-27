namespace Autocontrole.core
{
    partial class PointsControleInformationGeolocalisation
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
            this.rbtnNordGeographiqueNordProjet = new System.Windows.Forms.RadioButton();
            this.rbtnCoordonneesPartagees = new System.Windows.Forms.RadioButton();
            this.groupReglesControle = new System.Windows.Forms.GroupBox();
            this.rbtnUnites = new System.Windows.Forms.RadioButton();
            this.rbtnVueDemarrageParametree = new System.Windows.Forms.RadioButton();
            this.rbtnInformationProjet = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnNordGeographiqueNordProjet
            // 
            this.rbtnNordGeographiqueNordProjet.AutoSize = true;
            this.rbtnNordGeographiqueNordProjet.Location = new System.Drawing.Point(3, 95);
            this.rbtnNordGeographiqueNordProjet.Name = "rbtnNordGeographiqueNordProjet";
            this.rbtnNordGeographiqueNordProjet.Size = new System.Drawing.Size(182, 17);
            this.rbtnNordGeographiqueNordProjet.TabIndex = 16;
            this.rbtnNordGeographiqueNordProjet.Text = "Nord Géographique / Nord Projet";
            this.rbtnNordGeographiqueNordProjet.UseVisualStyleBackColor = true;
            // 
            // rbtnCoordonneesPartagees
            // 
            this.rbtnCoordonneesPartagees.AutoSize = true;
            this.rbtnCoordonneesPartagees.Location = new System.Drawing.Point(3, 72);
            this.rbtnCoordonneesPartagees.Name = "rbtnCoordonneesPartagees";
            this.rbtnCoordonneesPartagees.Size = new System.Drawing.Size(138, 17);
            this.rbtnCoordonneesPartagees.TabIndex = 15;
            this.rbtnCoordonneesPartagees.Text = "Coordonnées partagées";
            this.rbtnCoordonneesPartagees.UseVisualStyleBackColor = true;
            // 
            // groupReglesControle
            // 
            this.groupReglesControle.Location = new System.Drawing.Point(295, 3);
            this.groupReglesControle.Name = "groupReglesControle";
            this.groupReglesControle.Size = new System.Drawing.Size(491, 499);
            this.groupReglesControle.TabIndex = 14;
            this.groupReglesControle.TabStop = false;
            this.groupReglesControle.Text = "Règles de contrôle";
            // 
            // rbtnUnites
            // 
            this.rbtnUnites.AutoSize = true;
            this.rbtnUnites.Location = new System.Drawing.Point(3, 49);
            this.rbtnUnites.Name = "rbtnUnites";
            this.rbtnUnites.Size = new System.Drawing.Size(55, 17);
            this.rbtnUnites.TabIndex = 13;
            this.rbtnUnites.Text = "Unités";
            this.rbtnUnites.UseVisualStyleBackColor = true;
            // 
            // rbtnVueDemarrageParametree
            // 
            this.rbtnVueDemarrageParametree.AutoSize = true;
            this.rbtnVueDemarrageParametree.Location = new System.Drawing.Point(3, 26);
            this.rbtnVueDemarrageParametree.Name = "rbtnVueDemarrageParametree";
            this.rbtnVueDemarrageParametree.Size = new System.Drawing.Size(168, 17);
            this.rbtnVueDemarrageParametree.TabIndex = 12;
            this.rbtnVueDemarrageParametree.Text = "Vue de démarrage paramétrée";
            this.rbtnVueDemarrageParametree.UseVisualStyleBackColor = true;
            // 
            // rbtnInformationProjet
            // 
            this.rbtnInformationProjet.AutoSize = true;
            this.rbtnInformationProjet.Checked = true;
            this.rbtnInformationProjet.Location = new System.Drawing.Point(3, 3);
            this.rbtnInformationProjet.Name = "rbtnInformationProjet";
            this.rbtnInformationProjet.Size = new System.Drawing.Size(121, 17);
            this.rbtnInformationProjet.TabIndex = 11;
            this.rbtnInformationProjet.TabStop = true;
            this.rbtnInformationProjet.Text = "Information du projet";
            this.rbtnInformationProjet.UseVisualStyleBackColor = true;
            // 
            // pointsControleInformationGeolocalisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnNordGeographiqueNordProjet);
            this.Controls.Add(this.rbtnCoordonneesPartagees);
            this.Controls.Add(this.groupReglesControle);
            this.Controls.Add(this.rbtnUnites);
            this.Controls.Add(this.rbtnVueDemarrageParametree);
            this.Controls.Add(this.rbtnInformationProjet);
            this.Name = "pointsControleInformationGeolocalisation";
            this.Size = new System.Drawing.Size(789, 505);
            this.Load += new System.EventHandler(this.PointsControleInformationGeolocalisation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnNordGeographiqueNordProjet;
        private System.Windows.Forms.RadioButton rbtnCoordonneesPartagees;
        private System.Windows.Forms.GroupBox groupReglesControle;
        private System.Windows.Forms.RadioButton rbtnUnites;
        private System.Windows.Forms.RadioButton rbtnVueDemarrageParametree;
        private System.Windows.Forms.RadioButton rbtnInformationProjet;
    }
}
