namespace Duel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.attackButton = new System.Windows.Forms.Button();
            this.blockButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.outputRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerStatsRTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compStatRTB = new System.Windows.Forms.RichTextBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.compAttack = new System.Windows.Forms.Button();
            this.compBlock = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.compHeal = new System.Windows.Forms.Button();
            this.cWinsRTB = new System.Windows.Forms.RichTextBox();
            this.pWinsRTB = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attackButton.Location = new System.Drawing.Point(894, 399);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(154, 79);
            this.attackButton.TabIndex = 0;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // blockButton
            // 
            this.blockButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blockButton.Location = new System.Drawing.Point(978, 493);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(154, 79);
            this.blockButton.TabIndex = 1;
            this.blockButton.Text = "Spiked Shield";
            this.blockButton.UseVisualStyleBackColor = false;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // healButton
            // 
            this.healButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.healButton.Location = new System.Drawing.Point(1080, 399);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(154, 79);
            this.healButton.TabIndex = 2;
            this.healButton.Text = "Reckless Attack";
            this.healButton.UseVisualStyleBackColor = false;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // outputRTB
            // 
            this.outputRTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.outputRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.outputRTB.Location = new System.Drawing.Point(397, 96);
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.Size = new System.Drawing.Size(477, 441);
            this.outputRTB.TabIndex = 3;
            this.outputRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(1127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Stats";
            // 
            // playerStatsRTB
            // 
            this.playerStatsRTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playerStatsRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.playerStatsRTB.Location = new System.Drawing.Point(999, 96);
            this.playerStatsRTB.Name = "playerStatsRTB";
            this.playerStatsRTB.Size = new System.Drawing.Size(235, 101);
            this.playerStatsRTB.TabIndex = 7;
            this.playerStatsRTB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(596, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(32, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Computer Stats";
            // 
            // compStatRTB
            // 
            this.compStatRTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.compStatRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.compStatRTB.Location = new System.Drawing.Point(26, 96);
            this.compStatRTB.Name = "compStatRTB";
            this.compStatRTB.Size = new System.Drawing.Size(239, 101);
            this.compStatRTB.TabIndex = 10;
            this.compStatRTB.Text = "";
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fightButton.Location = new System.Drawing.Point(397, 543);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(239, 101);
            this.fightButton.TabIndex = 11;
            this.fightButton.Text = "FIGHT";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // compAttack
            // 
            this.compAttack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compAttack.Location = new System.Drawing.Point(12, 399);
            this.compAttack.Name = "compAttack";
            this.compAttack.Size = new System.Drawing.Size(154, 79);
            this.compAttack.TabIndex = 12;
            this.compAttack.Text = "Attack";
            this.compAttack.UseVisualStyleBackColor = false;
            this.compAttack.Click += new System.EventHandler(this.compAttack_Click);
            // 
            // compBlock
            // 
            this.compBlock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compBlock.Location = new System.Drawing.Point(111, 493);
            this.compBlock.Name = "compBlock";
            this.compBlock.Size = new System.Drawing.Size(154, 79);
            this.compBlock.TabIndex = 13;
            this.compBlock.Text = "Spiked Shield";
            this.compBlock.UseVisualStyleBackColor = false;
            this.compBlock.Click += new System.EventHandler(this.compBlock_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainBtn.Location = new System.Drawing.Point(661, 543);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(213, 101);
            this.trainBtn.TabIndex = 16;
            this.trainBtn.Text = "Train";
            this.trainBtn.UseVisualStyleBackColor = false;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // compHeal
            // 
            this.compHeal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compHeal.Location = new System.Drawing.Point(195, 399);
            this.compHeal.Name = "compHeal";
            this.compHeal.Size = new System.Drawing.Size(154, 79);
            this.compHeal.TabIndex = 14;
            this.compHeal.Text = "Reckless Attack";
            this.compHeal.UseVisualStyleBackColor = false;
            this.compHeal.Click += new System.EventHandler(this.compHeal_Click);
            // 
            // cWinsRTB
            // 
            this.cWinsRTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cWinsRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.cWinsRTB.Location = new System.Drawing.Point(119, 578);
            this.cWinsRTB.Name = "cWinsRTB";
            this.cWinsRTB.Size = new System.Drawing.Size(123, 66);
            this.cWinsRTB.TabIndex = 17;
            this.cWinsRTB.Text = "";
            // 
            // pWinsRTB
            // 
            this.pWinsRTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pWinsRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.pWinsRTB.Location = new System.Drawing.Point(995, 578);
            this.pWinsRTB.Name = "pWinsRTB";
            this.pWinsRTB.Size = new System.Drawing.Size(127, 66);
            this.pWinsRTB.TabIndex = 18;
            this.pWinsRTB.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(908, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1256, 656);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pWinsRTB);
            this.Controls.Add(this.cWinsRTB);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.compHeal);
            this.Controls.Add(this.compBlock);
            this.Controls.Add(this.compAttack);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.compStatRTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerStatsRTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputRTB);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.attackButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button blockButton;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.RichTextBox outputRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox playerStatsRTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox compStatRTB;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button compAttack;
        private System.Windows.Forms.Button compBlock;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.Button compHeal;
        private System.Windows.Forms.RichTextBox cWinsRTB;
        private System.Windows.Forms.RichTextBox pWinsRTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

