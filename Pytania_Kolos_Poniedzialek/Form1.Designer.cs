namespace Pytania_Kolos_Poniedzialek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.Nastepy_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.flowLayoutPanelAnswers);
            this.groupBox1.Controls.Add(this.labelQuestionText);
            this.groupBox1.Controls.Add(this.Nastepy_button);
            this.groupBox1.Location = new System.Drawing.Point(27, 65);
            this.groupBox1.MinimumSize = new System.Drawing.Size(300, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxQuestion";
            // 
            // flowLayoutPanelAnswers
            // 
            this.flowLayoutPanelAnswers.AutoSize = true;
            this.flowLayoutPanelAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAnswers.Location = new System.Drawing.Point(29, 68);
            this.flowLayoutPanelAnswers.MaximumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanelAnswers.MinimumSize = new System.Drawing.Size(150, 150);
            this.flowLayoutPanelAnswers.Name = "flowLayoutPanelAnswers";
            this.flowLayoutPanelAnswers.Size = new System.Drawing.Size(150, 150);
            this.flowLayoutPanelAnswers.TabIndex = 4;
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Location = new System.Drawing.Point(26, 37);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(35, 13);
            this.labelQuestionText.TabIndex = 3;
            this.labelQuestionText.Text = "label1";
            // 
            // Nastepy_button
            // 
            this.Nastepy_button.Location = new System.Drawing.Point(6, 263);
            this.Nastepy_button.Name = "Nastepy_button";
            this.Nastepy_button.Size = new System.Drawing.Size(289, 23);
            this.Nastepy_button.TabIndex = 2;
            this.Nastepy_button.Text = "Następny";
            this.Nastepy_button.UseVisualStyleBackColor = true;
            this.Nastepy_button.Click += new System.EventHandler(this.Nastepy_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nastepy_button;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnswers;
    }
}

