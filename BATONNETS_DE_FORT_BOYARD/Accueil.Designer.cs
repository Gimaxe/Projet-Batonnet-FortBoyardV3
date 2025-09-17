namespace BATONNETS_DE_FORT_BOYARD
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labJeuFortBoyard = new Label();
            btConnexion = new Button();
            btnInscription = new Button();
            SuspendLayout();
            // 
            // labJeuFortBoyard
            // 
            labJeuFortBoyard.AutoSize = true;
            labJeuFortBoyard.Location = new Point(23, 18);
            labJeuFortBoyard.Margin = new Padding(2, 0, 2, 0);
            labJeuFortBoyard.Name = "labJeuFortBoyard";
            labJeuFortBoyard.Size = new Size(210, 17);
            labJeuFortBoyard.TabIndex = 0;
            labJeuFortBoyard.Text = "Le jeu des bâtonnet de FortBoyard";
            // 
            // btConnexion
            // 
            btConnexion.Location = new Point(30, 65);
            btConnexion.Margin = new Padding(2);
            btConnexion.Name = "btConnexion";
            btConnexion.Size = new Size(81, 24);
            btConnexion.TabIndex = 1;
            btConnexion.Text = "Connexion";
            btConnexion.UseVisualStyleBackColor = true;
            btConnexion.Click += btConnexion_Click;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(122, 65);
            btnInscription.Margin = new Padding(2);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(81, 24);
            btnInscription.TabIndex = 2;
            btnInscription.Text = "Inscription";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 106);
            Controls.Add(btnInscription);
            Controls.Add(btConnexion);
            Controls.Add(labJeuFortBoyard);
            Margin = new Padding(2);
            Name = "Accueil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labJeuFortBoyard;
        private Button btConnexion;
        private Button btnInscription;
    }
}
