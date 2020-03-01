namespace TilePicker
{
    partial class frmTilePicker
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblClickedLabel = new System.Windows.Forms.Label();
            this.lblClicked = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(367, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblScoreLabel.Location = new System.Drawing.Point(362, 116);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(88, 26);
            this.lblScoreLabel.TabIndex = 1;
            this.lblScoreLabel.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblScore.Location = new System.Drawing.Point(439, 116);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(26, 26);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // lblClickedLabel
            // 
            this.lblClickedLabel.AutoSize = true;
            this.lblClickedLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblClickedLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClickedLabel.Location = new System.Drawing.Point(362, 142);
            this.lblClickedLabel.Name = "lblClickedLabel";
            this.lblClickedLabel.Size = new System.Drawing.Size(168, 26);
            this.lblClickedLabel.TabIndex = 3;
            this.lblClickedLabel.Text = "Tiles Clicked:";
            // 
            // lblClicked
            // 
            this.lblClicked.AutoSize = true;
            this.lblClicked.BackColor = System.Drawing.Color.Transparent;
            this.lblClicked.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClicked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClicked.Location = new System.Drawing.Point(524, 142);
            this.lblClicked.Name = "lblClicked";
            this.lblClicked.Size = new System.Drawing.Size(26, 26);
            this.lblClicked.TabIndex = 4;
            this.lblClicked.Text = "0";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResults.Location = new System.Drawing.Point(361, 168);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(120, 34);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Results";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResults.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(367, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.AutoSize = true;
            this.lblTitleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitleLabel.Location = new System.Drawing.Point(37, 12);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(291, 34);
            this.lblTitleLabel.TabIndex = 8;
            this.lblTitleLabel.Text = "TILE PICKER GAME";
            // 
            // frmTilePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(586, 410);
            this.Controls.Add(this.lblTitleLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblClicked);
            this.Controls.Add(this.lblClickedLabel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreLabel);
            this.Controls.Add(this.btnStart);
            this.Name = "frmTilePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Picker";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmTilePicker_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblClickedLabel;
        private System.Windows.Forms.Label lblClicked;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitleLabel;
    }
}

