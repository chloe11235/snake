namespace DemoUserControl
{
    partial class UC_Input
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProperty = new System.Windows.Forms.Label();
            this.tbProperty = new DemoUserControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // lblProperty
            // 
            this.lblProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(14, 13);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(46, 13);
            this.lblProperty.TabIndex = 0;
            this.lblProperty.Text = "Property";
            // 
            // tbProperty
            // 
            this.tbProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProperty.EmptyText = null;
            this.tbProperty.Location = new System.Drawing.Point(100, 10);
            this.tbProperty.Name = "tbProperty";
            this.tbProperty.Size = new System.Drawing.Size(100, 20);
            this.tbProperty.TabIndex = 1;
            // 
            // UC_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbProperty);
            this.Controls.Add(this.lblProperty);
            this.MaximumSize = new System.Drawing.Size(2048, 40);
            this.MinimumSize = new System.Drawing.Size(0, 40);
            this.Name = "UC_Input";
            this.Size = new System.Drawing.Size(213, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProperty;
        private CustomTextBox tbProperty;
    }
}
