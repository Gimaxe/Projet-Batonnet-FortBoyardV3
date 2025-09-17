namespace BATONNETS_DE_FORT_BOYARD
{
    partial class Dashboard
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
            listboxPartieTrouve = new ListBox();
            labPartieTrouve = new Label();
            btnRejoindrePartie = new Button();
            btnCreerPartie = new Button();
            btnActualiser = new Button();
            SuspendLayout();
            // 
            // listboxPartieTrouve
            // 
            listboxPartieTrouve.FormattingEnabled = true;
            listboxPartieTrouve.Location = new Point(55, 66);
            listboxPartieTrouve.Name = "listboxPartieTrouve";
            listboxPartieTrouve.Size = new Size(707, 292);
            listboxPartieTrouve.TabIndex = 0;
            // 
            // labPartieTrouve
            // 
            labPartieTrouve.AutoSize = true;
            labPartieTrouve.Location = new Point(55, 31);
            labPartieTrouve.Name = "labPartieTrouve";
            labPartieTrouve.Size = new Size(161, 32);
            labPartieTrouve.TabIndex = 2;
            labPartieTrouve.Text = "Partie trouvé :";
            // 
            // btnRejoindrePartie
            // 
            btnRejoindrePartie.Location = new Point(497, 364);
            btnRejoindrePartie.Name = "btnRejoindrePartie";
            btnRejoindrePartie.Size = new Size(265, 46);
            btnRejoindrePartie.TabIndex = 3;
            btnRejoindrePartie.Text = "Rejoindre une partie";
            btnRejoindrePartie.UseVisualStyleBackColor = true;
            // 
            // btnCreerPartie
            // 
            btnCreerPartie.Location = new Point(55, 364);
            btnCreerPartie.Name = "btnCreerPartie";
            btnCreerPartie.Size = new Size(265, 46);
            btnCreerPartie.TabIndex = 4;
            btnCreerPartie.Text = "Créer une partie";
            btnCreerPartie.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(620, 14);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(142, 46);
            btnActualiser.TabIndex = 5;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualiser);
            Controls.Add(btnCreerPartie);
            Controls.Add(btnRejoindrePartie);
            Controls.Add(labPartieTrouve);
            Controls.Add(listboxPartieTrouve);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listboxPartieTrouve;
        private Label label1;
        private Label labPartieTrouve;
        private Button btnRejoindrePartie;
        private Button btnCreerPartie;
        private Button btnActualiser;
    }
}