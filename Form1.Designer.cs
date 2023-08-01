namespace Gandi
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
            score = new System.Windows.Forms.Label();
            labelProgressBar1 = new Moble.LabelProgressBar();
            SuspendLayout();
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            score.ForeColor = System.Drawing.Color.White;
            score.Location = new System.Drawing.Point(156, 53);
            score.Name = "score";
            score.Size = new System.Drawing.Size(146, 74);
            score.TabIndex = 35;
            score.Text = "100";
            // 
            // labelProgressBar1
            // 
            labelProgressBar1.BackColor = System.Drawing.Color.White;
            labelProgressBar1.CustomText = "";
            labelProgressBar1.Location = new System.Drawing.Point(23, 12);
            labelProgressBar1.Name = "labelProgressBar1";
            labelProgressBar1.ProgressColor = System.Drawing.Color.LightGreen;
            labelProgressBar1.Size = new System.Drawing.Size(428, 38);
            labelProgressBar1.TabIndex = 34;
            labelProgressBar1.TextColor = System.Drawing.Color.Black;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProgressBar1.VisualMode = Moble.ProgressBarDisplayMode.CurrProgress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(score);
            Controls.Add(labelProgressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label score;
        private Moble.LabelProgressBar labelProgressBar1;
    }
}