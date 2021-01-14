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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.Panel2.Location = new System.Drawing.Point(228, 430);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(372, 118);
            this.Panel2.TabIndex = 10;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Location = new System.Drawing.Point(228, 16);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(372, 118);
            this.Panel1.TabIndex = 8;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Gold;
            this.btnNewGame.Location = new System.Drawing.Point(55, 16);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 57);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHit.FlatAppearance.BorderSize = 0;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHit.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.Gold;
            this.btnHit.Location = new System.Drawing.Point(55, 430);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(120, 57);
            this.btnHit.TabIndex = 15;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // tboScorePlayer
            // 
            this.tboScorePlayer.Location = new System.Drawing.Point(259, 399);
            this.tboScorePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboScorePlayer.Name = "tboScorePlayer";
            this.tboScorePlayer.Size = new System.Drawing.Size(28, 22);
            this.tboScorePlayer.TabIndex = 16;
            this.tboScorePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboScoreDealer
            // 
            this.tboScoreDealer.Location = new System.Drawing.Point(259, 140);
            this.tboScoreDealer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboScoreDealer.Name = "tboScoreDealer";
            this.tboScoreDealer.Size = new System.Drawing.Size(28, 22);
            this.tboScoreDealer.TabIndex = 17;
            this.tboScoreDealer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStand.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.Gold;
            this.btnStand.Location = new System.Drawing.Point(55, 494);
            this.btnStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(120, 57);
            this.btnStand.TabIndex = 18;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 561);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.tboScoreDealer);
            this.Controls.Add(this.tboScorePlayer);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
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