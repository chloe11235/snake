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
            this.components = new System.ComponentModel.Container();
            this.NewGame = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Button();
            this.MainView = new Project_Snake.GameView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(13, 13);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.OnclickNewGame);
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(154, 12);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(75, 23);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            this.Score.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Black;
            this.MainView.GameOn = false;
            this.MainView.GameStop = false;
            this.MainView.Location = new System.Drawing.Point(13, 60);
            this.MainView.Name = "MainView";
            this.MainView.Score = 0;
            this.MainView.Size = new System.Drawing.Size(300, 100);
            this.MainView.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.MainView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Score;
        
        private GameView MainView;
        private System.Windows.Forms.Timer timer1;
    }
}

