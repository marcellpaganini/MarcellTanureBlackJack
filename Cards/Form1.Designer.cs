namespace Cards
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.tboScorePlayer = new System.Windows.Forms.TextBox();
            this.tboScoreDealer = new System.Windows.Forms.TextBox();
            this.btnStand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Location = new System.Drawing.Point(171, 349);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(279, 96);
            this.Panel2.TabIndex = 10;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Location = new System.Drawing.Point(171, 13);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(279, 96);
            this.Panel1.TabIndex = 8;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(13, 13);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(41, 349);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 46);
            this.btnHit.TabIndex = 15;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // tboScorePlayer
            // 
            this.tboScorePlayer.Location = new System.Drawing.Point(194, 324);
            this.tboScorePlayer.Name = "tboScorePlayer";
            this.tboScorePlayer.Size = new System.Drawing.Size(22, 20);
            this.tboScorePlayer.TabIndex = 16;
            this.tboScorePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboScoreDealer
            // 
            this.tboScoreDealer.Location = new System.Drawing.Point(194, 114);
            this.tboScoreDealer.Name = "tboScoreDealer";
            this.tboScoreDealer.Size = new System.Drawing.Size(22, 20);
            this.tboScoreDealer.TabIndex = 17;
            this.tboScoreDealer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(41, 401);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(100, 46);
            this.btnStand.TabIndex = 18;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.tboScoreDealer);
            this.Controls.Add(this.tboScorePlayer);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.TextBox tboScorePlayer;
        private System.Windows.Forms.TextBox tboScoreDealer;
        private System.Windows.Forms.Button btnStand;
    }
}