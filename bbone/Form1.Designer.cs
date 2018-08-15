namespace bbone
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
            this.die1 = new System.Windows.Forms.Button();
            this.die2 = new System.Windows.Forms.Button();
            this.die3 = new System.Windows.Forms.Button();
            this.die4 = new System.Windows.Forms.Button();
            this.die5 = new System.Windows.Forms.Button();
            this.die6 = new System.Windows.Forms.Button();
            this.roll_button = new System.Windows.Forms.Button();
            this.reroll_all = new System.Windows.Forms.Button();
            this.endTurn_butt = new System.Windows.Forms.Button();
            this.howMany = new System.Windows.Forms.Label();
            this.numPlayers = new System.Windows.Forms.NumericUpDown();
            this.startButt = new System.Windows.Forms.Button();
            this.p1_score = new System.Windows.Forms.Label();
            this.p2_score = new System.Windows.Forms.Label();
            this.p3_score = new System.Windows.Forms.Label();
            this.p4_score = new System.Windows.Forms.Label();
            this.p5_score = new System.Windows.Forms.Label();
            this.p6_score = new System.Windows.Forms.Label();
            this.p7_score = new System.Windows.Forms.Label();
            this.p8_score = new System.Windows.Forms.Label();
            this.p9_score = new System.Windows.Forms.Label();
            this.p10_score = new System.Windows.Forms.Label();
            this.p11_score = new System.Windows.Forms.Label();
            this.p12_score = new System.Windows.Forms.Label();
            this.p12_num = new System.Windows.Forms.Label();
            this.p11_num = new System.Windows.Forms.Label();
            this.p10_num = new System.Windows.Forms.Label();
            this.p9_num = new System.Windows.Forms.Label();
            this.p8_num = new System.Windows.Forms.Label();
            this.p7_num = new System.Windows.Forms.Label();
            this.p6_num = new System.Windows.Forms.Label();
            this.p5_num = new System.Windows.Forms.Label();
            this.p4_num = new System.Windows.Forms.Label();
            this.p3_num = new System.Windows.Forms.Label();
            this.p2_num = new System.Windows.Forms.Label();
            this.p1_num = new System.Windows.Forms.Label();
            this.error_msg = new System.Windows.Forms.Label();
            this.currScore = new System.Windows.Forms.Label();
            this.straightLabel = new System.Windows.Forms.Label();
            this.roll_straight = new System.Windows.Forms.Button();
            this.allSelectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // die1
            // 
            this.die1.Location = new System.Drawing.Point(12, 12);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(194, 170);
            this.die1.TabIndex = 0;
            this.die1.Text = "die1";
            this.die1.UseVisualStyleBackColor = true;
            this.die1.Click += new System.EventHandler(this.die1_Click);
            // 
            // die2
            // 
            this.die2.Location = new System.Drawing.Point(212, 12);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(194, 170);
            this.die2.TabIndex = 1;
            this.die2.Text = "die2";
            this.die2.UseVisualStyleBackColor = true;
            this.die2.Click += new System.EventHandler(this.die2_Click);
            // 
            // die3
            // 
            this.die3.Location = new System.Drawing.Point(412, 12);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(194, 170);
            this.die3.TabIndex = 2;
            this.die3.Text = "die3";
            this.die3.UseVisualStyleBackColor = true;
            this.die3.Click += new System.EventHandler(this.die3_Click);
            // 
            // die4
            // 
            this.die4.Location = new System.Drawing.Point(12, 188);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(194, 170);
            this.die4.TabIndex = 3;
            this.die4.Text = "die4";
            this.die4.UseVisualStyleBackColor = true;
            this.die4.Click += new System.EventHandler(this.die4_Click);
            // 
            // die5
            // 
            this.die5.Location = new System.Drawing.Point(212, 188);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(194, 170);
            this.die5.TabIndex = 4;
            this.die5.Text = "die5";
            this.die5.UseVisualStyleBackColor = true;
            this.die5.Click += new System.EventHandler(this.die5_Click);
            // 
            // die6
            // 
            this.die6.Location = new System.Drawing.Point(412, 188);
            this.die6.Name = "die6";
            this.die6.Size = new System.Drawing.Size(194, 170);
            this.die6.TabIndex = 5;
            this.die6.Text = "die6";
            this.die6.UseVisualStyleBackColor = true;
            this.die6.Click += new System.EventHandler(this.die6_Click);
            // 
            // roll_button
            // 
            this.roll_button.Location = new System.Drawing.Point(637, 65);
            this.roll_button.Name = "roll_button";
            this.roll_button.Size = new System.Drawing.Size(75, 23);
            this.roll_button.TabIndex = 6;
            this.roll_button.Text = "Roll";
            this.roll_button.UseVisualStyleBackColor = true;
            this.roll_button.Click += new System.EventHandler(this.roll_button_Click);
            // 
            // reroll_all
            // 
            this.reroll_all.Location = new System.Drawing.Point(735, 304);
            this.reroll_all.Name = "reroll_all";
            this.reroll_all.Size = new System.Drawing.Size(75, 23);
            this.reroll_all.TabIndex = 7;
            this.reroll_all.Text = "Roll All";
            this.reroll_all.UseVisualStyleBackColor = true;
            this.reroll_all.Visible = false;
            this.reroll_all.Click += new System.EventHandler(this.reroll_all_Click);
            // 
            // endTurn_butt
            // 
            this.endTurn_butt.Location = new System.Drawing.Point(718, 65);
            this.endTurn_butt.Name = "endTurn_butt";
            this.endTurn_butt.Size = new System.Drawing.Size(75, 23);
            this.endTurn_butt.TabIndex = 8;
            this.endTurn_butt.Text = "End Turn";
            this.endTurn_butt.UseVisualStyleBackColor = true;
            this.endTurn_butt.Click += new System.EventHandler(this.endTurn_butt_Click);
            // 
            // howMany
            // 
            this.howMany.AutoSize = true;
            this.howMany.Location = new System.Drawing.Point(634, 12);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(96, 13);
            this.howMany.TabIndex = 9;
            this.howMany.Text = "Number of Players:";
            // 
            // numPlayers
            // 
            this.numPlayers.Location = new System.Drawing.Point(762, 10);
            this.numPlayers.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(31, 20);
            this.numPlayers.TabIndex = 10;
            this.numPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startButt
            // 
            this.startButt.Location = new System.Drawing.Point(637, 36);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(156, 23);
            this.startButt.TabIndex = 11;
            this.startButt.Text = "Start Game";
            this.startButt.UseVisualStyleBackColor = true;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // p1_score
            // 
            this.p1_score.AutoSize = true;
            this.p1_score.Location = new System.Drawing.Point(634, 101);
            this.p1_score.Name = "p1_score";
            this.p1_score.Size = new System.Drawing.Size(57, 13);
            this.p1_score.TabIndex = 12;
            this.p1_score.Text = "Player 1: b";
            // 
            // p2_score
            // 
            this.p2_score.AutoSize = true;
            this.p2_score.Location = new System.Drawing.Point(634, 119);
            this.p2_score.Name = "p2_score";
            this.p2_score.Size = new System.Drawing.Size(57, 13);
            this.p2_score.TabIndex = 13;
            this.p2_score.Text = "Player 2: b";
            // 
            // p3_score
            // 
            this.p3_score.AutoSize = true;
            this.p3_score.Location = new System.Drawing.Point(634, 137);
            this.p3_score.Name = "p3_score";
            this.p3_score.Size = new System.Drawing.Size(57, 13);
            this.p3_score.TabIndex = 14;
            this.p3_score.Text = "Player 3: b";
            // 
            // p4_score
            // 
            this.p4_score.AutoSize = true;
            this.p4_score.Location = new System.Drawing.Point(634, 155);
            this.p4_score.Name = "p4_score";
            this.p4_score.Size = new System.Drawing.Size(57, 13);
            this.p4_score.TabIndex = 15;
            this.p4_score.Text = "Player 4: b";
            // 
            // p5_score
            // 
            this.p5_score.AutoSize = true;
            this.p5_score.Location = new System.Drawing.Point(634, 173);
            this.p5_score.Name = "p5_score";
            this.p5_score.Size = new System.Drawing.Size(57, 13);
            this.p5_score.TabIndex = 16;
            this.p5_score.Text = "Player 5: b";
            // 
            // p6_score
            // 
            this.p6_score.AutoSize = true;
            this.p6_score.Location = new System.Drawing.Point(634, 191);
            this.p6_score.Name = "p6_score";
            this.p6_score.Size = new System.Drawing.Size(57, 13);
            this.p6_score.TabIndex = 17;
            this.p6_score.Text = "Player 6: b";
            // 
            // p7_score
            // 
            this.p7_score.AutoSize = true;
            this.p7_score.Location = new System.Drawing.Point(634, 209);
            this.p7_score.Name = "p7_score";
            this.p7_score.Size = new System.Drawing.Size(57, 13);
            this.p7_score.TabIndex = 18;
            this.p7_score.Text = "Player 7: b";
            // 
            // p8_score
            // 
            this.p8_score.AutoSize = true;
            this.p8_score.Location = new System.Drawing.Point(634, 227);
            this.p8_score.Name = "p8_score";
            this.p8_score.Size = new System.Drawing.Size(57, 13);
            this.p8_score.TabIndex = 19;
            this.p8_score.Text = "Player 8: b";
            // 
            // p9_score
            // 
            this.p9_score.AutoSize = true;
            this.p9_score.Location = new System.Drawing.Point(634, 245);
            this.p9_score.Name = "p9_score";
            this.p9_score.Size = new System.Drawing.Size(57, 13);
            this.p9_score.TabIndex = 20;
            this.p9_score.Text = "Player 9: b";
            // 
            // p10_score
            // 
            this.p10_score.AutoSize = true;
            this.p10_score.Location = new System.Drawing.Point(634, 263);
            this.p10_score.Name = "p10_score";
            this.p10_score.Size = new System.Drawing.Size(63, 13);
            this.p10_score.TabIndex = 21;
            this.p10_score.Text = "Player 10: b";
            // 
            // p11_score
            // 
            this.p11_score.AutoSize = true;
            this.p11_score.Location = new System.Drawing.Point(634, 281);
            this.p11_score.Name = "p11_score";
            this.p11_score.Size = new System.Drawing.Size(63, 13);
            this.p11_score.TabIndex = 22;
            this.p11_score.Text = "Player 11: b";
            // 
            // p12_score
            // 
            this.p12_score.AutoSize = true;
            this.p12_score.Location = new System.Drawing.Point(634, 299);
            this.p12_score.Name = "p12_score";
            this.p12_score.Size = new System.Drawing.Size(63, 13);
            this.p12_score.TabIndex = 23;
            this.p12_score.Text = "Player 12: b";
            // 
            // p12_num
            // 
            this.p12_num.AutoSize = true;
            this.p12_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p12_num.Location = new System.Drawing.Point(742, 299);
            this.p12_num.Name = "p12_num";
            this.p12_num.Size = new System.Drawing.Size(51, 13);
            this.p12_num.TabIndex = 35;
            this.p12_num.Text = "p12_num";
            // 
            // p11_num
            // 
            this.p11_num.AutoSize = true;
            this.p11_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p11_num.Location = new System.Drawing.Point(742, 281);
            this.p11_num.Name = "p11_num";
            this.p11_num.Size = new System.Drawing.Size(51, 13);
            this.p11_num.TabIndex = 34;
            this.p11_num.Text = "p11_num";
            // 
            // p10_num
            // 
            this.p10_num.AutoSize = true;
            this.p10_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p10_num.Location = new System.Drawing.Point(742, 263);
            this.p10_num.Name = "p10_num";
            this.p10_num.Size = new System.Drawing.Size(51, 13);
            this.p10_num.TabIndex = 33;
            this.p10_num.Text = "p10_num";
            // 
            // p9_num
            // 
            this.p9_num.AutoSize = true;
            this.p9_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p9_num.Location = new System.Drawing.Point(742, 245);
            this.p9_num.Name = "p9_num";
            this.p9_num.Size = new System.Drawing.Size(45, 13);
            this.p9_num.TabIndex = 32;
            this.p9_num.Text = "p9_num";
            // 
            // p8_num
            // 
            this.p8_num.AutoSize = true;
            this.p8_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p8_num.Location = new System.Drawing.Point(742, 227);
            this.p8_num.Name = "p8_num";
            this.p8_num.Size = new System.Drawing.Size(45, 13);
            this.p8_num.TabIndex = 31;
            this.p8_num.Text = "p8_num";
            // 
            // p7_num
            // 
            this.p7_num.AutoSize = true;
            this.p7_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p7_num.Location = new System.Drawing.Point(742, 209);
            this.p7_num.Name = "p7_num";
            this.p7_num.Size = new System.Drawing.Size(45, 13);
            this.p7_num.TabIndex = 30;
            this.p7_num.Text = "p7_num";
            // 
            // p6_num
            // 
            this.p6_num.AutoSize = true;
            this.p6_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p6_num.Location = new System.Drawing.Point(742, 191);
            this.p6_num.Name = "p6_num";
            this.p6_num.Size = new System.Drawing.Size(45, 13);
            this.p6_num.TabIndex = 29;
            this.p6_num.Text = "p6_num";
            // 
            // p5_num
            // 
            this.p5_num.AutoSize = true;
            this.p5_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p5_num.Location = new System.Drawing.Point(742, 173);
            this.p5_num.Name = "p5_num";
            this.p5_num.Size = new System.Drawing.Size(45, 13);
            this.p5_num.TabIndex = 28;
            this.p5_num.Text = "p5_num";
            // 
            // p4_num
            // 
            this.p4_num.AutoSize = true;
            this.p4_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p4_num.Location = new System.Drawing.Point(742, 155);
            this.p4_num.Name = "p4_num";
            this.p4_num.Size = new System.Drawing.Size(45, 13);
            this.p4_num.TabIndex = 27;
            this.p4_num.Text = "p4_num";
            // 
            // p3_num
            // 
            this.p3_num.AutoSize = true;
            this.p3_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p3_num.Location = new System.Drawing.Point(742, 137);
            this.p3_num.Name = "p3_num";
            this.p3_num.Size = new System.Drawing.Size(45, 13);
            this.p3_num.TabIndex = 26;
            this.p3_num.Text = "p3_num";
            // 
            // p2_num
            // 
            this.p2_num.AutoSize = true;
            this.p2_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p2_num.Location = new System.Drawing.Point(742, 119);
            this.p2_num.Name = "p2_num";
            this.p2_num.Size = new System.Drawing.Size(45, 13);
            this.p2_num.TabIndex = 25;
            this.p2_num.Text = "p2_num";
            // 
            // p1_num
            // 
            this.p1_num.AutoSize = true;
            this.p1_num.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p1_num.Location = new System.Drawing.Point(742, 101);
            this.p1_num.Name = "p1_num";
            this.p1_num.Size = new System.Drawing.Size(45, 13);
            this.p1_num.TabIndex = 24;
            this.p1_num.Text = "p1_num";
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Location = new System.Drawing.Point(669, 330);
            this.error_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(103, 13);
            this.error_msg.TabIndex = 36;
            this.error_msg.Text = "Invalid die selection!";
            this.error_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currScore
            // 
            this.currScore.Location = new System.Drawing.Point(654, 350);
            this.currScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currScore.Name = "currScore";
            this.currScore.Size = new System.Drawing.Size(132, 13);
            this.currScore.TabIndex = 37;
            this.currScore.Text = "Current Roll Score: 0";
            this.currScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // straightLabel
            // 
            this.straightLabel.Location = new System.Drawing.Point(611, 330);
            this.straightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.straightLabel.Name = "straightLabel";
            this.straightLabel.Size = new System.Drawing.Size(212, 13);
            this.straightLabel.TabIndex = 38;
            this.straightLabel.Text = "Rolled a straight! You must end your turn.";
            this.straightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roll_straight
            // 
            this.roll_straight.Location = new System.Drawing.Point(616, 304);
            this.roll_straight.Name = "roll_straight";
            this.roll_straight.Size = new System.Drawing.Size(75, 23);
            this.roll_straight.TabIndex = 39;
            this.roll_straight.Text = "Roll Straight";
            this.roll_straight.UseVisualStyleBackColor = true;
            this.roll_straight.Click += new System.EventHandler(this.roll_straight_Click);
            // 
            // allSelectLabel
            // 
            this.allSelectLabel.Location = new System.Drawing.Point(611, 330);
            this.allSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allSelectLabel.Name = "allSelectLabel";
            this.allSelectLabel.Size = new System.Drawing.Size(212, 13);
            this.allSelectLabel.TabIndex = 40;
            this.allSelectLabel.Text = "You must roll again!";
            this.allSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 372);
            this.Controls.Add(this.allSelectLabel);
            this.Controls.Add(this.reroll_all);
            this.Controls.Add(this.roll_straight);
            this.Controls.Add(this.straightLabel);
            this.Controls.Add(this.currScore);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.p12_num);
            this.Controls.Add(this.p11_num);
            this.Controls.Add(this.p10_num);
            this.Controls.Add(this.p9_num);
            this.Controls.Add(this.p8_num);
            this.Controls.Add(this.p7_num);
            this.Controls.Add(this.p6_num);
            this.Controls.Add(this.p5_num);
            this.Controls.Add(this.p4_num);
            this.Controls.Add(this.p3_num);
            this.Controls.Add(this.p2_num);
            this.Controls.Add(this.p1_num);
            this.Controls.Add(this.p12_score);
            this.Controls.Add(this.p11_score);
            this.Controls.Add(this.p10_score);
            this.Controls.Add(this.p9_score);
            this.Controls.Add(this.p8_score);
            this.Controls.Add(this.p7_score);
            this.Controls.Add(this.p6_score);
            this.Controls.Add(this.p5_score);
            this.Controls.Add(this.p4_score);
            this.Controls.Add(this.p3_score);
            this.Controls.Add(this.p2_score);
            this.Controls.Add(this.p1_score);
            this.Controls.Add(this.startButt);
            this.Controls.Add(this.numPlayers);
            this.Controls.Add(this.howMany);
            this.Controls.Add(this.endTurn_butt);
            this.Controls.Add(this.roll_button);
            this.Controls.Add(this.die6);
            this.Controls.Add(this.die5);
            this.Controls.Add(this.die4);
            this.Controls.Add(this.die3);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "bBones";
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button die1;
        private System.Windows.Forms.Button die2;
        private System.Windows.Forms.Button die3;
        private System.Windows.Forms.Button die4;
        private System.Windows.Forms.Button die5;
        private System.Windows.Forms.Button die6;
        private System.Windows.Forms.Button roll_button;
        private System.Windows.Forms.Button reroll_all;
        private System.Windows.Forms.Button endTurn_butt;
        private System.Windows.Forms.Label howMany;
        private System.Windows.Forms.NumericUpDown numPlayers;
        private System.Windows.Forms.Button startButt;
        private System.Windows.Forms.Label p1_score;
        private System.Windows.Forms.Label p2_score;
        private System.Windows.Forms.Label p3_score;
        private System.Windows.Forms.Label p4_score;
        private System.Windows.Forms.Label p5_score;
        private System.Windows.Forms.Label p6_score;
        private System.Windows.Forms.Label p7_score;
        private System.Windows.Forms.Label p8_score;
        private System.Windows.Forms.Label p9_score;
        private System.Windows.Forms.Label p10_score;
        private System.Windows.Forms.Label p11_score;
        private System.Windows.Forms.Label p12_score;
        private System.Windows.Forms.Label p12_num;
        private System.Windows.Forms.Label p11_num;
        private System.Windows.Forms.Label p10_num;
        private System.Windows.Forms.Label p9_num;
        private System.Windows.Forms.Label p8_num;
        private System.Windows.Forms.Label p7_num;
        private System.Windows.Forms.Label p6_num;
        private System.Windows.Forms.Label p5_num;
        private System.Windows.Forms.Label p4_num;
        private System.Windows.Forms.Label p3_num;
        private System.Windows.Forms.Label p2_num;
        private System.Windows.Forms.Label p1_num;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.Label currScore;
        private System.Windows.Forms.Label straightLabel;
        private System.Windows.Forms.Button roll_straight;
        private System.Windows.Forms.Label allSelectLabel;
    }
}

