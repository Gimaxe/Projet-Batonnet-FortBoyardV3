namespace BATONNETS_DE_FORT_BOYARD
{
    partial class Connexion
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
            label1 = new Label();
            label2 = new Label();
            Txt_UserName = new TextBox();
            Txt_Password = new TextBox();
            label3 = new Label();
            Btn_Connexion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 0;
            label1.Text = "Connexion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 1;
            label2.Text = "Nom d'utilisateur";
            // 
            // Txt_UserName
            // 
            Txt_UserName.Location = new Point(126, 60);
            Txt_UserName.Name = "Txt_UserName";
            Txt_UserName.Size = new Size(110, 25);
            Txt_UserName.TabIndex = 2;
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(126, 91);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(110, 25);
            Txt_Password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 3;
            label3.Text = "Mot de passe";
            // 
            // Btn_Connexion
            // 
            Btn_Connexion.Location = new Point(68, 134);
            Btn_Connexion.Name = "Btn_Connexion";
            Btn_Connexion.Size = new Size(103, 25);
            Btn_Connexion.TabIndex = 5;
            Btn_Connexion.Text = "Se connecter";
            Btn_Connexion.UseVisualStyleBackColor = true;
            Btn_Connexion.Click += button1_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 167);
            Controls.Add(Btn_Connexion);
            Controls.Add(Txt_Password);
            Controls.Add(label3);
            Controls.Add(Txt_UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Txt_UserName;
        private TextBox Txt_Password;
        private Label label3;
        private Button Btn_Connexion;
    }
}