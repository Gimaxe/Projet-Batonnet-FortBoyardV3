namespace BATONNETS_DE_FORT_BOYARD
{
    partial class PageCreerPartie
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
            btnCreerPartie = new Button();
            checkboxPartiePrivé = new CheckBox();
            texboxCodePartie = new TextBox();
            labCodePartie = new Label();
            labNomPartie = new Label();
            texboxNomPartie = new TextBox();
            SuspendLayout();
            // 
            // btnCreerPartie
            // 
            btnCreerPartie.Location = new Point(131, 150);
            btnCreerPartie.Name = "btnCreerPartie";
            btnCreerPartie.Size = new Size(283, 46);
            btnCreerPartie.TabIndex = 1;
            btnCreerPartie.Text = "Créer une partie";
            btnCreerPartie.UseVisualStyleBackColor = true;
            // 
            // checkboxPartiePrivé
            // 
            checkboxPartiePrivé.AutoSize = true;
            checkboxPartiePrivé.Location = new Point(501, 45);
            checkboxPartiePrivé.Name = "checkboxPartiePrivé";
            checkboxPartiePrivé.Size = new Size(164, 36);
            checkboxPartiePrivé.TabIndex = 2;
            checkboxPartiePrivé.Text = "Partie Privé";
            checkboxPartiePrivé.UseVisualStyleBackColor = true;
            // 
            // texboxCodePartie
            // 
            texboxCodePartie.Location = new Point(238, 87);
            texboxCodePartie.Name = "texboxCodePartie";
            texboxCodePartie.Size = new Size(124, 39);
            texboxCodePartie.TabIndex = 3;
            // 
            // labCodePartie
            // 
            labCodePartie.AutoSize = true;
            labCodePartie.Location = new Point(50, 90);
            labCodePartie.Name = "labCodePartie";
            labCodePartie.Size = new Size(182, 32);
            labCodePartie.TabIndex = 4;
            labCodePartie.Text = "Code de Partie :";
            // 
            // labNomPartie
            // 
            labNomPartie.AutoSize = true;
            labNomPartie.Location = new Point(26, 45);
            labNomPartie.Name = "labNomPartie";
            labNomPartie.Size = new Size(206, 32);
            labNomPartie.TabIndex = 5;
            labNomPartie.Text = "Nom de la partie :";
            // 
            // texboxNomPartie
            // 
            texboxNomPartie.Location = new Point(238, 42);
            texboxNomPartie.Name = "texboxNomPartie";
            texboxNomPartie.Size = new Size(257, 39);
            texboxNomPartie.TabIndex = 6;
            // 
            // PageCreerPartie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 232);
            Controls.Add(texboxNomPartie);
            Controls.Add(labNomPartie);
            Controls.Add(labCodePartie);
            Controls.Add(texboxCodePartie);
            Controls.Add(checkboxPartiePrivé);
            Controls.Add(btnCreerPartie);
            Name = "PageCreerPartie";
            Text = "PageCreerPartie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreerPartie;
        private CheckBox checkboxPartiePrivé;
        private TextBox texboxCodePartie;
        private Label labCodePartie;
        private Label labNomPartie;
        private TextBox texboxNomPartie;
    }
}