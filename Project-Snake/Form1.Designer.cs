namespace Project_Snake
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGame = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Button();

            GameView MainView = new GameView();

            this.panel1 = new System.Windows.Forms.Panel();


            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(20, 20);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(112, 35);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(214, 18);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(112, 35);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            this.Score.UseVisualStyleBackColor = true;
            // 

         

    // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(14, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 178);
            this.panel1.TabIndex = 2;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(502, 402);
           
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.panel1);

            this.Controls.Add(this.Score);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(MainView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Panel panel1;
    }
}

