namespace ECBManager.core.Commands.AnnotatePanel.Configuration.Organisation
{
    partial class pointsControleStandardsGraphiques
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
            this.rbtnObjetsMasques = new System.Windows.Forms.RadioButton();
            this.rbtnDocumentation = new System.Windows.Forms.RadioButton();
            this.rbtnApparence = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // groupReglesControle
            // 
            this.groupReglesControle.Location = new System.Drawing.Point(295, 3);
            this.groupReglesControle.Name = "groupReglesControle";
            this.groupReglesControle.Size = new System.Drawing.Size(491, 499);
            this.groupReglesControle.TabIndex = 17;
            this.groupReglesControle.TabStop = false;
            this.groupReglesControle.Text = "Règles de contrôle";
            // 
            // rbtnObjetsMasques
            // 
            this.rbtnObjetsMasques.AutoSize = true;
            this.rbtnObjetsMasques.Location = new System.Drawing.Point(3, 49);
            this.rbtnObjetsMasques.Name = "rbtnObjetsMasques";
            this.rbtnObjetsMasques.Size = new System.Drawing.Size(110, 17);
            this.rbtnObjetsMasques.TabIndex = 16;
            this.rbtnObjetsMasques.Text = "Objets \"masqués\"";
            this.rbtnObjetsMasques.UseVisualStyleBackColor = true;
            // 
            // rbtnDocumentation
            // 
            this.rbtnDocumentation.AutoSize = true;
            this.rbtnDocumentation.Location = new System.Drawing.Point(3, 26);
            this.rbtnDocumentation.Name = "rbtnDocumentation";
            this.rbtnDocumentation.Size = new System.Drawing.Size(97, 17);
            this.rbtnDocumentation.TabIndex = 15;
            this.rbtnDocumentation.Text = "Documentation";
            this.rbtnDocumentation.UseVisualStyleBackColor = true;
            // 
            // rbtnApparence
            // 
            this.rbtnApparence.AutoSize = true;
            this.rbtnApparence.Checked = true;
            this.rbtnApparence.Location = new System.Drawing.Point(3, 3);
            this.rbtnApparence.Name = "rbtnApparence";
            this.rbtnApparence.Size = new System.Drawing.Size(77, 17);
            this.rbtnApparence.TabIndex = 14;
            this.rbtnApparence.TabStop = true;
            this.rbtnApparence.Text = "Apparence";
            this.rbtnApparence.UseVisualStyleBackColor = true;
            // 
            // pointsControleStandardsGraphiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupReglesControle);
            this.Controls.Add(this.rbtnObjetsMasques);
            this.Controls.Add(this.rbtnDocumentation);
            this.Controls.Add(this.rbtnApparence);
            this.Name = "pointsControleStandardsGraphiques";
            this.Size = new System.Drawing.Size(789, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupReglesControle;
        private System.Windows.Forms.RadioButton rbtnObjetsMasques;
        private System.Windows.Forms.RadioButton rbtnDocumentation;
        private System.Windows.Forms.RadioButton rbtnApparence;
    }
}
