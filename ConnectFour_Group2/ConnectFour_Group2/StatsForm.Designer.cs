namespace ConnectFour_Group2
{
    partial class StatsForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.lbl_playerHeader = new System.Windows.Forms.Label();
            this.lbl_computerHeader = new System.Windows.Forms.Label();
            this.lbl_player1Static = new System.Windows.Forms.Label();
            this.lbl_computerStatic = new System.Windows.Forms.Label();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.lbl_computer = new System.Windows.Forms.Label();
            this.lbl_totalStatic = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.lbl_2playerWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(144, 52);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(278, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Winner\\Loser Ratio";
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(353, 463);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(181, 80);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "Return to \r\nMain Menu";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lbl_playerHeader
            // 
            this.lbl_playerHeader.AutoSize = true;
            this.lbl_playerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerHeader.Location = new System.Drawing.Point(90, 134);
            this.lbl_playerHeader.Name = "lbl_playerHeader";
            this.lbl_playerHeader.Size = new System.Drawing.Size(67, 25);
            this.lbl_playerHeader.TabIndex = 2;
            this.lbl_playerHeader.Text = "Player";
            // 
            // lbl_computerHeader
            // 
            this.lbl_computerHeader.AutoSize = true;
            this.lbl_computerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computerHeader.Location = new System.Drawing.Point(348, 134);
            this.lbl_computerHeader.Name = "lbl_computerHeader";
            this.lbl_computerHeader.Size = new System.Drawing.Size(139, 25);
            this.lbl_computerHeader.TabIndex = 3;
            this.lbl_computerHeader.Text = "Lesser Demon";
            // 
            // lbl_player1Static
            // 
            this.lbl_player1Static.AutoSize = true;
            this.lbl_player1Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1Static.Location = new System.Drawing.Point(63, 202);
            this.lbl_player1Static.Name = "lbl_player1Static";
            this.lbl_player1Static.Size = new System.Drawing.Size(48, 80);
            this.lbl_player1Static.TabIndex = 4;
            this.lbl_player1Static.Text = "Wins:\r\n\r\nWin \r\nRate:";
            // 
            // lbl_computerStatic
            // 
            this.lbl_computerStatic.AutoSize = true;
            this.lbl_computerStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computerStatic.Location = new System.Drawing.Point(334, 202);
            this.lbl_computerStatic.Name = "lbl_computerStatic";
            this.lbl_computerStatic.Size = new System.Drawing.Size(53, 80);
            this.lbl_computerStatic.TabIndex = 5;
            this.lbl_computerStatic.Text = "Souls:\r\n\r\nSteal \r\nRate:";
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1.Location = new System.Drawing.Point(146, 202);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(44, 80);
            this.lbl_player1.TabIndex = 6;
            this.lbl_player1.Text = "Wins\r\n\r\nWin \r\nRate";
            // 
            // lbl_computer
            // 
            this.lbl_computer.AutoSize = true;
            this.lbl_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computer.Location = new System.Drawing.Point(427, 202);
            this.lbl_computer.Name = "lbl_computer";
            this.lbl_computer.Size = new System.Drawing.Size(44, 80);
            this.lbl_computer.TabIndex = 7;
            this.lbl_computer.Text = "Wins\r\n\r\nWin \r\nRate";
            // 
            // lbl_totalStatic
            // 
            this.lbl_totalStatic.AutoSize = true;
            this.lbl_totalStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalStatic.Location = new System.Drawing.Point(52, 367);
            this.lbl_totalStatic.Name = "lbl_totalStatic";
            this.lbl_totalStatic.Size = new System.Drawing.Size(155, 60);
            this.lbl_totalStatic.TabIndex = 8;
            this.lbl_totalStatic.Text = "                           Ties:\r\n\r\nTotal Games Played:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(265, 367);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(151, 60);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "Ties\r\n\r\nTotal Games Played";
            // 
            // btn_review
            // 
            this.btn_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review.Location = new System.Drawing.Point(195, 463);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(152, 80);
            this.btn_review.TabIndex = 10;
            this.btn_review.Text = "Review Game Board";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Visible = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(8, 463);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(181, 80);
            this.btn_playAgain.TabIndex = 11;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Visible = false;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // lbl_2playerWarning
            // 
            this.lbl_2playerWarning.AutoSize = true;
            this.lbl_2playerWarning.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2playerWarning.Location = new System.Drawing.Point(36, 294);
            this.lbl_2playerWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_2playerWarning.Name = "lbl_2playerWarning";
            this.lbl_2playerWarning.Size = new System.Drawing.Size(161, 40);
            this.lbl_2playerWarning.TabIndex = 12;
            this.lbl_2playerWarning.Text = "!2playerError";
            this.lbl_2playerWarning.Visible = false;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 565);
            this.Controls.Add(this.lbl_2playerWarning);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_totalStatic);
            this.Controls.Add(this.lbl_computer);
            this.Controls.Add(this.lbl_player1);
            this.Controls.Add(this.lbl_computerStatic);
            this.Controls.Add(this.lbl_player1Static);
            this.Controls.Add(this.lbl_computerHeader);
            this.Controls.Add(this.lbl_playerHeader);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_title);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lbl_playerHeader;
        private System.Windows.Forms.Label lbl_computerHeader;
        private System.Windows.Forms.Label lbl_player1Static;
        private System.Windows.Forms.Label lbl_computerStatic;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label lbl_computer;
        private System.Windows.Forms.Label lbl_totalStatic;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Label lbl_2playerWarning;
    }
}