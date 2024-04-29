namespace PDSA_Game.Games
{
    partial class Game05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game05));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txttemp = new System.Windows.Forms.TextBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtsource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelmatrix = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Shortest Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txttemp);
            this.groupBox1.Controls.Add(this.btnhome);
            this.groupBox1.Controls.Add(this.txtanswer);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnplay);
            this.groupBox1.Controls.Add(this.btnrestart);
            this.groupBox1.Controls.Add(this.btnstart);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.txtsource);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(777, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 619);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::PDSA_Game.Properties.Resources.icons8_add;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(425, 540);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(183, 52);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // txttemp
            // 
            this.txttemp.Location = new System.Drawing.Point(517, 257);
            this.txttemp.Multiline = true;
            this.txttemp.Name = "txttemp";
            this.txttemp.Size = new System.Drawing.Size(103, 88);
            this.txttemp.TabIndex = 12;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Image = global::PDSA_Game.Properties.Resources.icons8_home_16;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(203, 540);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(183, 52);
            this.btnhome.TabIndex = 8;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // txtanswer
            // 
            this.txtanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.Location = new System.Drawing.Point(51, 209);
            this.txtanswer.Multiline = true;
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(452, 230);
            this.txtanswer.TabIndex = 11;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::PDSA_Game.Properties.Resources.save_icon;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(614, 456);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(154, 52);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Image = global::PDSA_Game.Properties.Resources.icons8_play_64;
            this.btnplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplay.Location = new System.Drawing.Point(425, 456);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(176, 52);
            this.btnplay.TabIndex = 9;
            this.btnplay.Text = "Play Now";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.Image = global::PDSA_Game.Properties.Resources.icons8_refresh;
            this.btnrestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestart.Location = new System.Drawing.Point(210, 456);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(176, 52);
            this.btnrestart.TabIndex = 8;
            this.btnrestart.Text = "Resrart";
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Image = global::PDSA_Game.Properties.Resources.icons8_start_48;
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstart.Location = new System.Drawing.Point(17, 456);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(183, 52);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = " Start Game";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "A  B  C  D  E  F  G  H  I  J"});
            this.listBox1.Location = new System.Drawing.Point(51, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(424, 44);
            this.listBox1.TabIndex = 5;
            // 
            // txtsource
            // 
            this.txtsource.Location = new System.Drawing.Point(203, 98);
            this.txtsource.Multiline = true;
            this.txtsource.Name = "txtsource";
            this.txtsource.Size = new System.Drawing.Size(300, 28);
            this.txtsource.TabIndex = 4;
            this.txtsource.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source Vertex";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(203, 42);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(300, 25);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Player Name";
            // 
            // panelmatrix
            // 
            this.panelmatrix.Location = new System.Drawing.Point(12, 88);
            this.panelmatrix.Name = "panelmatrix";
            this.panelmatrix.Size = new System.Drawing.Size(743, 448);
            this.panelmatrix.TabIndex = 2;
            this.panelmatrix.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmatrix_Paint);
            // 
            // Game05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1576, 725);
            this.Controls.Add(this.panelmatrix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Game05";
            this.Text = "ShortestPath";
            this.Load += new System.EventHandler(this.Game05_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Panel panelmatrix;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.Button btnadd;
    }
}