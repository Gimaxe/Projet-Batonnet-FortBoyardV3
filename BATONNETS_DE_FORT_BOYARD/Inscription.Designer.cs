namespace BATONNETS_DE_FORT_BOYARD
{
    partial class Inscription
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
            Lbl_Inscription = new Label();
            Lbl_Password = new Label();
            Lbl_Prenom = new Label();
            Lbl_Nom = new Label();
            Lbl_UserName = new Label();
            Txt_Name = new TextBox();
            Txt_Prenom = new TextBox();
            Txt_UserName = new TextBox();
            Txt_Password = new TextBox();
            Btn_Inscription = new Button();
            SuspendLayout();
            // 
            // Lbl_Inscription
            // 
            Lbl_Inscription.AutoSize = true;
            Lbl_Inscription.Location = new Point(64, 9);
            Lbl_Inscription.Name = "Lbl_Inscription";
            Lbl_Inscription.Size = new Size(68, 17);
            Lbl_Inscription.TabIndex = 0;
            Lbl_Inscription.Text = "Inscription";
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Location = new Point(12, 196);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(88, 17);
            Lbl_Password.TabIndex = 1;
            Lbl_Password.Text = "Mot de Passe";
            // 
            // Lbl_Prenom
            // 
            Lbl_Prenom.AutoSize = true;
            Lbl_Prenom.Location = new Point(12, 105);
            Lbl_Prenom.Name = "Lbl_Prenom";
            Lbl_Prenom.Size = new Size(53, 17);
            Lbl_Prenom.TabIndex = 2;
            Lbl_Prenom.Text = "Prenom";
            // 
            // Lbl_Nom
            // 
            Lbl_Nom.AutoSize = true;
            Lbl_Nom.Location = new Point(12, 59);
            Lbl_Nom.Name = "Lbl_Nom";
            Lbl_Nom.Size = new Size(37, 17);
            Lbl_Nom.TabIndex = 3;
            Lbl_Nom.Text = "Nom";
            // 
            // Lbl_UserName
            // 
            Lbl_UserName.AutoSize = true;
            Lbl_UserName.Location = new Point(12, 147);
            Lbl_UserName.Name = "Lbl_UserName";
            Lbl_UserName.Size = new Size(108, 17);
            Lbl_UserName.TabIndex = 4;
            Lbl_UserName.Text = "Nom d'utilisateur";
            // 
            // Txt_Name
            // 
            Txt_Name.Location = new Point(64, 56);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(110, 25);
            Txt_Name.TabIndex = 5;
            // 
            // Txt_Prenom
            // 
            Txt_Prenom.Location = new Point(81, 102);
            Txt_Prenom.Name = "Txt_Prenom";
            Txt_Prenom.Size = new Size(110, 25);
            Txt_Prenom.TabIndex = 6;
            // 
            // Txt_UserName
            // 
            Txt_UserName.Location = new Point(136, 144);
            Txt_UserName.Name = "Txt_UserName";
            Txt_UserName.Size = new Size(110, 25);
            Txt_UserName.TabIndex = 7;
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(119, 193);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '.';
            Txt_Password.Size = new Size(110, 25);
            Txt_Password.TabIndex = 8;
            // 
            // Btn_Inscription
            // 
            Btn_Inscription.Location = new Point(91, 250);
            Btn_Inscription.Name = "Btn_Inscription";
            Btn_Inscription.Size = new Size(83, 25);
            Btn_Inscription.TabIndex = 9;
            Btn_Inscription.Text = "Inscription";
            Btn_Inscription.UseVisualStyleBackColor = true;
            Btn_Inscription.Click += button1_Click;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 287);
            Controls.Add(Btn_Inscription);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_UserName);
            Controls.Add(Txt_Prenom);
            Controls.Add(Txt_Name);
            Controls.Add(Lbl_UserName);
            Controls.Add(Lbl_Nom);
            Controls.Add(Lbl_Prenom);
            Controls.Add(Lbl_Password);
            Controls.Add(Lbl_Inscription);
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Inscription;
        private Label Lbl_Password;
        private Label Lbl_Prenom;
        private Label Lbl_Nom;
        private Label Lbl_UserName;
        private TextBox Txt_Name;
        private TextBox Txt_Prenom;
        private TextBox Txt_UserName;
        private TextBox Txt_Password;
        private Button Btn_Inscription;
    }
}