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
            this.compHeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(998, 311);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(154, 79);
            this.attackButton.TabIndex = 0;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(998, 396);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(154, 79);
            this.blockButton.TabIndex = 1;
            this.blockButton.Text = "Block";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(998, 481);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(154, 79);
            this.healButton.TabIndex = 2;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // outputRTB
            // 
            this.outputRTB.Location = new System.Drawing.Point(375, 96);
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.Size = new System.Drawing.Size(509, 441);
            this.outputRTB.TabIndex = 3;
            this.outputRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1018, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Stats";
            // 
            // playerStatsRTB
            // 
            this.playerStatsRTB.Location = new System.Drawing.Point(957, 96);
            this.playerStatsRTB.Name = "playerStatsRTB";
            this.playerStatsRTB.Size = new System.Drawing.Size(235, 167);
            this.playerStatsRTB.TabIndex = 7;
            this.playerStatsRTB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Computer Stats";
            // 
            // compStatRTB
            // 
            this.compStatRTB.Location = new System.Drawing.Point(61, 96);
            this.compStatRTB.Name = "compStatRTB";
            this.compStatRTB.Size = new System.Drawing.Size(239, 160);
            this.compStatRTB.TabIndex = 10;
            this.compStatRTB.Text = "";
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(511, 543);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(239, 101);
            this.fightButton.TabIndex = 11;
            this.fightButton.Text = "FIGHT";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // compAttack
            // 
            this.compAttack.Location = new System.Drawing.Point(99, 329);
            this.compAttack.Name = "compAttack";
            this.compAttack.Size = new System.Drawing.Size(154, 79);
            this.compAttack.TabIndex = 12;
            this.compAttack.Text = "Attack";
            this.compAttack.UseVisualStyleBackColor = true;
            this.compAttack.Click += new System.EventHandler(this.compAttack_Click);
            // 
            // compBlock
            // 
            this.compBlock.Location = new System.Drawing.Point(99, 414);
            this.compBlock.Name = "compBlock";
            this.compBlock.Size = new System.Drawing.Size(154, 79);
            this.compBlock.TabIndex = 13;
            this.compBlock.Text = "Block";
            this.compBlock.UseVisualStyleBackColor = true;
            this.compBlock.Click += new System.EventHandler(this.compBlock_Click);
            // 
            // compHeal
            // 
            this.compHeal.Location = new System.Drawing.Point(99, 499);
            this.compHeal.Name = "compHeal";
            this.compHeal.Size = new System.Drawing.Size(154, 79);
            this.compHeal.TabIndex = 14;
            this.compHeal.Text = "Heal";
            this.compHeal.UseVisualStyleBackColor = true;
            this.compHeal.Click += new System.EventHandler(this.compHeal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 656);
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
        private System.Windows.Forms.Button compHeal;
    }
}

