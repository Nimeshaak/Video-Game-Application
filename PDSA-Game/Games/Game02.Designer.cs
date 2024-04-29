namespace PDSA_Game.Games
{
    partial class Game02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game02));
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AccessibleName = "text1";
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(48, 162);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(211, 39);
            this.text1.TabIndex = 0;
            this.text1.Text = "Sequence One";
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // text2
            // 
            this.text2.AccessibleName = "text2";
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(403, 162);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(215, 39);
            this.text2.TabIndex = 1;
            this.text2.Text = "Sequence Two";
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // userInput
            // 
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(235, 298);
            this.userInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(261, 26);
            this.userInput.TabIndex = 3;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // button1
            // 
            this.button1.AccessibleName = "submit";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(280, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(639, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "Find Longest Common Sequence";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(25, 457);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 28);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Cyan;
            this.restart.Location = new System.Drawing.Point(585, 457);
            this.restart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(100, 28);
            this.restart.TabIndex = 8;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Location = new System.Drawing.Point(520, 358);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(75, 16);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "Win Streak:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(555, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "demo text to check";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.start.Location = new System.Drawing.Point(341, 108);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 28);
            this.start.TabIndex = 11;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Your Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(200, 111);
            this.inputName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(132, 22);
            this.inputName.TabIndex = 14;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // Game02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game02";
            this.Text = "Game02";
            this.Load += new System.EventHandler(this.Game02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputName;
    }
}