namespace ConnectFour_Group2
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
            this.btn_1player = new System.Windows.Forms.Button();
            this.btn_2player = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_1player
            // 
            this.btn_1player.BackColor = System.Drawing.Color.Tomato;
            this.btn_1player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1player.Location = new System.Drawing.Point(55, 197);
            this.btn_1player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_1player.Name = "btn_1player";
            this.btn_1player.Size = new System.Drawing.Size(283, 80);
            this.btn_1player.TabIndex = 0;
            this.btn_1player.Text = "PLAYING ALONE?";
            this.btn_1player.UseVisualStyleBackColor = false;
            this.btn_1player.Click += new System.EventHandler(this.btn_1player_Click);
            // 
            // btn_2player
            // 
            this.btn_2player.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_2player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2player.Location = new System.Drawing.Point(421, 197);
            this.btn_2player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_2player.Name = "btn_2player";
            this.btn_2player.Size = new System.Drawing.Size(283, 80);
            this.btn_2player.TabIndex = 1;
            this.btn_2player.Text = "GOT A FRIEND?";
            this.btn_2player.UseVisualStyleBackColor = false;
            this.btn_2player.Click += new System.EventHandler(this.btn_2player_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Location = new System.Drawing.Point(55, 373);
            this.btn_stats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(283, 80);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "PREVIOUS LOSERS";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Gold;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(421, 373);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(283, 80);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "EXIT (COWARD)";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO CONNECT SOULS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConnectFour_Group2.Properties.Resources.stone_wall;
            this.ClientSize = new System.Drawing.Size(776, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_2player);
            this.Controls.Add(this.btn_1player);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Welcome to Connect Four";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1player;
        private System.Windows.Forms.Button btn_2player;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
    }
}

