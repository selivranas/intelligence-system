namespace SystemExpert
{
    partial class RockForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockForm));
            this.retry_button = new System.Windows.Forms.Button();
            this.question1_groupBox = new System.Windows.Forms.GroupBox();
            this.question1_NO = new System.Windows.Forms.Button();
            this.question1_YES = new System.Windows.Forms.Button();
            this.question2_groupBox = new System.Windows.Forms.GroupBox();
            this.question2_NO = new System.Windows.Forms.Button();
            this.question2_YES = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.question1_groupBox.SuspendLayout();
            this.question2_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // retry_button
            // 
            this.retry_button.Location = new System.Drawing.Point(611, 25);
            this.retry_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retry_button.Name = "retry_button";
            this.retry_button.Size = new System.Drawing.Size(139, 22);
            this.retry_button.TabIndex = 4;
            this.retry_button.Text = "начать сначала";
            this.retry_button.UseVisualStyleBackColor = true;
            this.retry_button.Click += new System.EventHandler(this.retry_button_Click);
            // 
            // question1_groupBox
            // 
            this.question1_groupBox.BackColor = System.Drawing.Color.Black;
            this.question1_groupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("question1_groupBox.BackgroundImage")));
            this.question1_groupBox.Controls.Add(this.label1);
            this.question1_groupBox.Controls.Add(this.question1_NO);
            this.question1_groupBox.Controls.Add(this.question1_YES);
            this.question1_groupBox.Location = new System.Drawing.Point(-5, -8);
            this.question1_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question1_groupBox.Name = "question1_groupBox";
            this.question1_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question1_groupBox.Size = new System.Drawing.Size(782, 415);
            this.question1_groupBox.TabIndex = 5;
            this.question1_groupBox.TabStop = false;
            // 
            // question1_NO
            // 
            this.question1_NO.BackColor = System.Drawing.Color.Indigo;
            this.question1_NO.FlatAppearance.BorderSize = 0;
            this.question1_NO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.question1_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question1_NO.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question1_NO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.question1_NO.Location = new System.Drawing.Point(483, 203);
            this.question1_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question1_NO.Name = "question1_NO";
            this.question1_NO.Size = new System.Drawing.Size(95, 39);
            this.question1_NO.TabIndex = 3;
            this.question1_NO.Text = "Нет";
            this.question1_NO.UseVisualStyleBackColor = false;
            this.question1_NO.Click += new System.EventHandler(this.question1_NO_Click);
            // 
            // question1_YES
            // 
            this.question1_YES.BackColor = System.Drawing.Color.Indigo;
            this.question1_YES.FlatAppearance.BorderSize = 0;
            this.question1_YES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.question1_YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question1_YES.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question1_YES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.question1_YES.Location = new System.Drawing.Point(197, 203);
            this.question1_YES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question1_YES.Name = "question1_YES";
            this.question1_YES.Size = new System.Drawing.Size(95, 39);
            this.question1_YES.TabIndex = 2;
            this.question1_YES.Text = "Да";
            this.question1_YES.UseVisualStyleBackColor = false;
            this.question1_YES.Click += new System.EventHandler(this.question1_YES_Click);
            // 
            // question2_groupBox
            // 
            this.question2_groupBox.BackColor = System.Drawing.Color.Black;
            this.question2_groupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("question2_groupBox.BackgroundImage")));
            this.question2_groupBox.Controls.Add(this.label2);
            this.question2_groupBox.Controls.Add(this.question2_NO);
            this.question2_groupBox.Controls.Add(this.question2_YES);
            this.question2_groupBox.Location = new System.Drawing.Point(-5, -8);
            this.question2_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question2_groupBox.Name = "question2_groupBox";
            this.question2_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question2_groupBox.Size = new System.Drawing.Size(782, 415);
            this.question2_groupBox.TabIndex = 6;
            this.question2_groupBox.TabStop = false;
            // 
            // question2_NO
            // 
            this.question2_NO.BackColor = System.Drawing.Color.Indigo;
            this.question2_NO.FlatAppearance.BorderSize = 0;
            this.question2_NO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.question2_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question2_NO.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question2_NO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.question2_NO.Location = new System.Drawing.Point(483, 203);
            this.question2_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question2_NO.Name = "question2_NO";
            this.question2_NO.Size = new System.Drawing.Size(95, 39);
            this.question2_NO.TabIndex = 3;
            this.question2_NO.Text = "Нет";
            this.question2_NO.UseVisualStyleBackColor = false;
            this.question2_NO.Click += new System.EventHandler(this.question2_NO_Click);
            // 
            // question2_YES
            // 
            this.question2_YES.BackColor = System.Drawing.Color.Indigo;
            this.question2_YES.FlatAppearance.BorderSize = 0;
            this.question2_YES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.question2_YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question2_YES.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question2_YES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.question2_YES.Location = new System.Drawing.Point(197, 203);
            this.question2_YES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question2_YES.Name = "question2_YES";
            this.question2_YES.Size = new System.Drawing.Size(95, 39);
            this.question2_YES.TabIndex = 2;
            this.question2_YES.Text = "Да";
            this.question2_YES.UseVisualStyleBackColor = false;
            this.question2_YES.Click += new System.EventHandler(this.question2_YES_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(770, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Любите андерграунд?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Вы обожаете адские гитарные запилы?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 376);
            this.Controls.Add(this.retry_button);
            this.Controls.Add(this.question2_groupBox);
            this.Controls.Add(this.question1_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подбор музыки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RockForm_FormClosed);
            this.question1_groupBox.ResumeLayout(false);
            this.question2_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button retry_button;
        private System.Windows.Forms.GroupBox question1_groupBox;
        private System.Windows.Forms.Button question1_NO;
        private System.Windows.Forms.Button question1_YES;
        private System.Windows.Forms.GroupBox question2_groupBox;
        private System.Windows.Forms.Button question2_NO;
        private System.Windows.Forms.Button question2_YES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}