namespace CS161_Translator
{
    partial class CS161_Translator
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.translateItalianButton = new System.Windows.Forms.Button();
            this.translateSpanishButton = new System.Windows.Forms.Button();
            this.translateGermanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(76, 24);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(392, 21);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select A Language And I Will Say Good Morning.";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(112, 68);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(312, 30);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateItalianButton
            // 
            this.translateItalianButton.Location = new System.Drawing.Point(116, 140);
            this.translateItalianButton.Name = "translateItalianButton";
            this.translateItalianButton.Size = new System.Drawing.Size(75, 23);
            this.translateItalianButton.TabIndex = 2;
            this.translateItalianButton.Text = "Italian";
            this.translateItalianButton.UseVisualStyleBackColor = true;
            this.translateItalianButton.Click += new System.EventHandler(this.translateItalianButton_Click);
            // 
            // translateSpanishButton
            // 
            this.translateSpanishButton.Location = new System.Drawing.Point(229, 140);
            this.translateSpanishButton.Name = "translateSpanishButton";
            this.translateSpanishButton.Size = new System.Drawing.Size(75, 23);
            this.translateSpanishButton.TabIndex = 3;
            this.translateSpanishButton.Text = "Spanish";
            this.translateSpanishButton.UseVisualStyleBackColor = true;
            this.translateSpanishButton.Click += new System.EventHandler(this.translateSpanishButton_Click);
            // 
            // translateGermanButton
            // 
            this.translateGermanButton.Location = new System.Drawing.Point(342, 140);
            this.translateGermanButton.Name = "translateGermanButton";
            this.translateGermanButton.Size = new System.Drawing.Size(75, 23);
            this.translateGermanButton.TabIndex = 4;
            this.translateGermanButton.Text = "German";
            this.translateGermanButton.UseVisualStyleBackColor = true;
            this.translateGermanButton.Click += new System.EventHandler(this.translateGermanButton_Click);
            // 
            // CS161_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 194);
            this.Controls.Add(this.translateGermanButton);
            this.Controls.Add(this.translateSpanishButton);
            this.Controls.Add(this.translateItalianButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "CS161_Translator";
            this.Text = "CS161 Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button translateItalianButton;
        private System.Windows.Forms.Button translateSpanishButton;
        private System.Windows.Forms.Button translateGermanButton;
    }
}

