﻿namespace DemoUserControl
{
    partial class UserEntryForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.ucPseudo = new DemoUserControl.UC_Input();
            this.label1 = new System.Windows.Forms.Label();
            this.UcScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(197, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucPseudo
            // 
            this.ucPseudo.EmptyText = "Saisissez votre Pseudo";
            this.ucPseudo.Location = new System.Drawing.Point(21, 26);
            this.ucPseudo.MaximumSize = new System.Drawing.Size(2048, 40);
            this.ucPseudo.MinimumSize = new System.Drawing.Size(0, 40);
            this.ucPseudo.Name = "ucPseudo";
            this.ucPseudo.PropertyLabel = "Pseudo";
            this.ucPseudo.PropertyValue = "";
            this.ucPseudo.Size = new System.Drawing.Size(213, 40);
            this.ucPseudo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // UcScore
            // 
            this.UcScore.AccessibleName = "Score";
            this.UcScore.AutoSize = true;
            this.UcScore.Location = new System.Drawing.Point(152, 105);
            this.UcScore.Name = "UcScore";
            this.UcScore.Size = new System.Drawing.Size(35, 13);
            this.UcScore.TabIndex = 5;
            this.UcScore.Text = "label2";
            // 
            // UserEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UcScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucPseudo);
            this.Controls.Add(this.btnOK);
            this.Name = "UserEntryForm";
            this.Text = "Demo User Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private UC_Input ucPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UcScore;
    }
}

