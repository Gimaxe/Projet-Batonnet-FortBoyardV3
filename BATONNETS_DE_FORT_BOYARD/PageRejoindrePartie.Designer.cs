namespace BATONNETS_DE_FORT_BOYARD
{
    partial class PageRejoindrePartie
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
            labNomPartie = new Label();
            texboxCodePartie = new TextBox();
            labCodePartie = new Label();
            btnRejoidrePartie = new Button();
            SuspendLayout();
            // 
            // labNomPartie
            // 
            labNomPartie.AutoSize = true;
            labNomPartie.Location = new Point(147, 22);
            labNomPartie.Name = "labNomPartie";
            labNomPartie.Size = new Size(223, 32);
            labNomPartie.TabIndex = 0;
            labNomPartie.Text = "Rejoindre la Partie *";
            // 
            // texboxCodePartie
            // 
            texboxCodePartie.Location = new Point(214, 86);
            texboxCodePartie.Name = "texboxCodePartie";
            texboxCodePartie.Size = new Size(291, 39);
            texboxCodePartie.TabIndex = 1;
            // 
            // labCodePartie
            // 
            labCodePartie.AutoSize = true;
            labCodePartie.Location = new Point(24, 89);
            labCodePartie.Name = "labCodePartie";
            labCodePartie.Size = new Size(184, 32);
            labCodePartie.TabIndex = 2;
            labCodePartie.Text = "Code de partie :";
            // 
            // btnRejoidrePartie
            // 
            btnRejoidrePartie.Location = new Point(137, 145);
            btnRejoidrePartie.Name = "btnRejoidrePartie";
            btnRejoidrePartie.Size = new Size(270, 46);
            btnRejoidrePartie.TabIndex = 3;
            btnRejoidrePartie.Text = "Rejoindre la partie";
            btnRejoidrePartie.UseVisualStyleBackColor = true;
            // 
            // PageRejoindrePartie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 237);
            Controls.Add(btnRejoidrePartie);
            Controls.Add(labCodePartie);
            Controls.Add(texboxCodePartie);
            Controls.Add(labNomPartie);
            Name = "PageRejoindrePartie";
            Text = "PageRejoindrePartie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labNomPartie;
        private TextBox texboxCodePartie;
        private Label labCodePartie;
        private Button btnRejoidrePartie;
    }
}