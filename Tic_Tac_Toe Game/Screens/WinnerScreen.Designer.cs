namespace Tic_Tac_Toe_Game.Screens
{
    partial class WinnerScreen
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
            this.pbWinner = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWinner
            // 
            this.pbWinner.Image = global::Tic_Tac_Toe_Game.Properties.Resources.thinking;
            this.pbWinner.Location = new System.Drawing.Point(307, 34);
            this.pbWinner.Name = "pbWinner";
            this.pbWinner.Size = new System.Drawing.Size(215, 194);
            this.pbWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWinner.TabIndex = 0;
            this.pbWinner.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(68)))));
            this.lblResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResult.Location = new System.Drawing.Point(265, 276);
            this.lblResult.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblResult.MinimumSize = new System.Drawing.Size(225, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(298, 50);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Winner Player 1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.UseWaitCursor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(98, 386);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(230, 50);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(68)))));
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(501, 386);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(230, 50);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // WinnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(839, 509);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pbWinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(265, 276);
            this.MaximumSize = new System.Drawing.Size(839, 509);
            this.MinimumSize = new System.Drawing.Size(839, 509);
            this.Name = "WinnerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XOGAME";
            this.Load += new System.EventHandler(this.WinnerScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWinner;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}