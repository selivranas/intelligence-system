
namespace SystemExpert.MainForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pop_button = new System.Windows.Forms.Button();
            this.rap_button = new System.Windows.Forms.Button();
            this.rock_button = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pop_button
            // 
            this.pop_button.BackColor = System.Drawing.Color.Indigo;
            this.pop_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.pop_button.FlatAppearance.BorderSize = 0;
            this.pop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pop_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pop_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pop_button.Location = new System.Drawing.Point(317, 298);
            this.pop_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pop_button.Name = "pop_button";
            this.pop_button.Size = new System.Drawing.Size(113, 48);
            this.pop_button.TabIndex = 8;
            this.pop_button.Text = "Поп";
            this.pop_button.UseVisualStyleBackColor = false;
            this.pop_button.Click += new System.EventHandler(this.pop_button_Click);
            // 
            // rap_button
            // 
            this.rap_button.BackColor = System.Drawing.Color.Indigo;
            this.rap_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rap_button.FlatAppearance.BorderSize = 0;
            this.rap_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rap_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rap_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rap_button.Location = new System.Drawing.Point(317, 210);
            this.rap_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rap_button.Name = "rap_button";
            this.rap_button.Size = new System.Drawing.Size(113, 48);
            this.rap_button.TabIndex = 7;
            this.rap_button.Text = "Рэп";
            this.rap_button.UseVisualStyleBackColor = false;
            this.rap_button.Click += new System.EventHandler(this.rap_button_Click);
            // 
            // rock_button
            // 
            this.rock_button.BackColor = System.Drawing.Color.Indigo;
            this.rock_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rock_button.FlatAppearance.BorderSize = 0;
            this.rock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rock_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rock_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rock_button.Location = new System.Drawing.Point(317, 123);
            this.rock_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(113, 48);
            this.rock_button.TabIndex = 6;
            this.rock_button.Text = "Рок";
            this.rock_button.UseVisualStyleBackColor = false;
            this.rock_button.Click += new System.EventHandler(this.rock_button_Click);
            // 
            // Question
            // 
            this.Question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Question.Location = new System.Drawing.Point(0, 47);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(766, 45);
            this.Question.TabIndex = 5;
            this.Question.Text = "Какой жанр музыки тебе интересен?";
            this.Question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 376);
            this.Controls.Add(this.pop_button);
            this.Controls.Add(this.rap_button);
            this.Controls.Add(this.rock_button);
            this.Controls.Add(this.Question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подбор музыки";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pop_button;
        private System.Windows.Forms.Button rap_button;
        private System.Windows.Forms.Button rock_button;
        private System.Windows.Forms.Label Question;
    }
}