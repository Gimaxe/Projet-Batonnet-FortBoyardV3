namespace BATONNETS_DE_FORT_BOYARD
{
    partial class PagePartie
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
            labJoueur1 = new Label();
            labNomJoueur1 = new Label();
            labJoueur2 = new Label();
            labNomJoueur2 = new Label();
            labNombreRestantBaton = new Label();
            labNombreBatonRestantTotal = new Label();
            btn1Baton = new Button();
            btn2Baton = new Button();
            btn3Baton = new Button();
            labChoisirNombreBaton = new Label();
            SuspendLayout();
            // 
            // labJoueur1
            // 
            labJoueur1.AutoSize = true;
            labJoueur1.Location = new Point(12, 9);
            labJoueur1.Name = "labJoueur1";
            labJoueur1.Size = new Size(118, 32);
            labJoueur1.TabIndex = 0;
            labJoueur1.Text = "Joueur 1 :";
            // 
            // labNomJoueur1
            // 
            labNomJoueur1.AutoSize = true;
            labNomJoueur1.Location = new Point(12, 54);
            labNomJoueur1.Name = "labNomJoueur1";
            labNomJoueur1.Size = new Size(106, 32);
            labNomJoueur1.TabIndex = 1;
            labNomJoueur1.Text = "Joueur 1";
            // 
            // labJoueur2
            // 
            labJoueur2.AutoSize = true;
            labJoueur2.Location = new Point(670, 9);
            labJoueur2.Name = "labJoueur2";
            labJoueur2.Size = new Size(118, 32);
            labJoueur2.TabIndex = 2;
            labJoueur2.Text = "Joueur 2 :";
            // 
            // labNomJoueur2
            // 
            labNomJoueur2.AutoSize = true;
            labNomJoueur2.Location = new Point(670, 54);
            labNomJoueur2.Name = "labNomJoueur2";
            labNomJoueur2.Size = new Size(118, 32);
            labNomJoueur2.TabIndex = 3;
            labNomJoueur2.Text = "Joueur 2 :";
            // 
            // labNombreRestantBaton
            // 
            labNombreRestantBaton.AutoSize = true;
            labNombreRestantBaton.Location = new Point(176, 104);
            labNombreRestantBaton.Name = "labNombreRestantBaton";
            labNombreRestantBaton.Size = new Size(406, 32);
            labNombreRestantBaton.TabIndex = 4;
            labNombreRestantBaton.Text = "Le nombre de bâtons restant est de :";
            // 
            // labNombreBatonRestantTotal
            // 
            labNombreBatonRestantTotal.AutoSize = true;
            labNombreBatonRestantTotal.Location = new Point(347, 150);
            labNombreBatonRestantTotal.Name = "labNombreBatonRestantTotal";
            labNombreBatonRestantTotal.Size = new Size(40, 32);
            labNombreBatonRestantTotal.TabIndex = 5;
            labNombreBatonRestantTotal.Text = "12";
            // 
            // btn1Baton
            // 
            btn1Baton.Location = new Point(78, 263);
            btn1Baton.Name = "btn1Baton";
            btn1Baton.Size = new Size(150, 46);
            btn1Baton.TabIndex = 6;
            btn1Baton.Text = "1 Bâton";
            btn1Baton.UseVisualStyleBackColor = true;
            // 
            // btn2Baton
            // 
            btn2Baton.Location = new Point(305, 263);
            btn2Baton.Name = "btn2Baton";
            btn2Baton.Size = new Size(150, 46);
            btn2Baton.TabIndex = 7;
            btn2Baton.Text = "2 Bâtons";
            btn2Baton.UseVisualStyleBackColor = true;
            // 
            // btn3Baton
            // 
            btn3Baton.Location = new Point(529, 263);
            btn3Baton.Name = "btn3Baton";
            btn3Baton.Size = new Size(150, 46);
            btn3Baton.TabIndex = 8;
            btn3Baton.Text = "3 Bâtons";
            btn3Baton.UseVisualStyleBackColor = true;
            // 
            // labChoisirNombreBaton
            // 
            labChoisirNombreBaton.AutoSize = true;
            labChoisirNombreBaton.Location = new Point(15, 214);
            labChoisirNombreBaton.Name = "labChoisirNombreBaton";
            labChoisirNombreBaton.Size = new Size(329, 32);
            labChoisirNombreBaton.TabIndex = 9;
            labChoisirNombreBaton.Text = "Choisir le nombre de bâtons :";
            // 
            // PagePartie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 347);
            Controls.Add(labChoisirNombreBaton);
            Controls.Add(btn3Baton);
            Controls.Add(btn2Baton);
            Controls.Add(btn1Baton);
            Controls.Add(labNombreBatonRestantTotal);
            Controls.Add(labNombreRestantBaton);
            Controls.Add(labNomJoueur2);
            Controls.Add(labJoueur2);
            Controls.Add(labNomJoueur1);
            Controls.Add(labJoueur1);
            Name = "PagePartie";
            Text = "PageConnexion";
            Load += this.PagePartie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labJoueur1;
        private Label labNomJoueur1;
        private Label labJoueur2;
        private Label labNomJoueur2;
        private Label labNombreRestantBaton;
        private Label labNombreBatonRestantTotal;
        private Button btn1Baton;
        private Button btn2Baton;
        private Button btn3Baton;
        private Label labChoisirNombreBaton;
    }
}