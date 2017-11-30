namespace SearchDojo
{
    partial class Form1
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.MatchBox = new System.Windows.Forms.TextBox();
            this.RegexBox = new System.Windows.Forms.TextBox();
            this.FartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(44, 46);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(392, 228);
            this.TextBox.TabIndex = 0;
            // 
            // MatchBox
            // 
            this.MatchBox.Location = new System.Drawing.Point(492, 46);
            this.MatchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchBox.Multiline = true;
            this.MatchBox.Name = "MatchBox";
            this.MatchBox.Size = new System.Drawing.Size(297, 228);
            this.MatchBox.TabIndex = 1;
            // 
            // RegexBox
            // 
            this.RegexBox.Location = new System.Drawing.Point(152, 320);
            this.RegexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegexBox.Name = "RegexBox";
            this.RegexBox.Size = new System.Drawing.Size(284, 22);
            this.RegexBox.TabIndex = 2;
            this.RegexBox.TextChanged += new System.EventHandler(this.RegexBox_TextChanged);
            // 
            // FartButton
            // 
            this.FartButton.Location = new System.Drawing.Point(492, 319);
            this.FartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FartButton.Name = "FartButton";
            this.FartButton.Size = new System.Drawing.Size(184, 23);
            this.FartButton.TabIndex = 3;
            this.FartButton.Text = "Fart";
            this.FartButton.UseVisualStyleBackColor = true;
            this.FartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matched:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pattern:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FartButton);
            this.Controls.Add(this.RegexBox);
            this.Controls.Add(this.MatchBox);
            this.Controls.Add(this.TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox MatchBox;
        private System.Windows.Forms.TextBox RegexBox;
        private System.Windows.Forms.Button FartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

