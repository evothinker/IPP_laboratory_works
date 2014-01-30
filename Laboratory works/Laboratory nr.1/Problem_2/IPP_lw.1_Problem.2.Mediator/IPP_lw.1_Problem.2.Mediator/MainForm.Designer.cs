namespace IPP_lw._1_Problem._2.Mediator
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.btnPressPlayer1 = new System.Windows.Forms.Button();
            this.groupBoxScoreboardPlayer1 = new System.Windows.Forms.GroupBox();
            this.textBoxScoarboardPlayer1 = new System.Windows.Forms.TextBox();
            this.groupBoxScoreboardPlayer2 = new System.Windows.Forms.GroupBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.btnPressPlayer2 = new System.Windows.Forms.Button();
            this.groupBoxScoreboardPlayer1.SuspendLayout();
            this.groupBoxScoreboardPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.Red;
            this.buttonStartGame.Location = new System.Drawing.Point(10, 160);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(260, 51);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // btnPressPlayer1
            // 
            this.btnPressPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPressPlayer1.Location = new System.Drawing.Point(21, 81);
            this.btnPressPlayer1.Name = "btnPressPlayer1";
            this.btnPressPlayer1.Size = new System.Drawing.Size(75, 43);
            this.btnPressPlayer1.TabIndex = 1;
            this.btnPressPlayer1.Text = "Click me!";
            this.btnPressPlayer1.UseVisualStyleBackColor = false;
            this.btnPressPlayer1.Click += new System.EventHandler(this.btnPressPlayer1_Click);
            // 
            // groupBoxScoreboardPlayer1
            // 
            this.groupBoxScoreboardPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxScoreboardPlayer1.Controls.Add(this.textBoxScoarboardPlayer1);
            this.groupBoxScoreboardPlayer1.Controls.Add(this.btnPressPlayer1);
            this.groupBoxScoreboardPlayer1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScoreboardPlayer1.Name = "groupBoxScoreboardPlayer1";
            this.groupBoxScoreboardPlayer1.Size = new System.Drawing.Size(117, 130);
            this.groupBoxScoreboardPlayer1.TabIndex = 2;
            this.groupBoxScoreboardPlayer1.TabStop = false;
            this.groupBoxScoreboardPlayer1.Text = "Player 1";
            // 
            // textBoxScoarboardPlayer1
            // 
            this.textBoxScoarboardPlayer1.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxScoarboardPlayer1.Font = new System.Drawing.Font("LCDMono2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScoarboardPlayer1.Location = new System.Drawing.Point(23, 18);
            this.textBoxScoarboardPlayer1.MaxLength = 99;
            this.textBoxScoarboardPlayer1.Name = "textBoxScoarboardPlayer1";
            this.textBoxScoarboardPlayer1.ReadOnly = true;
            this.textBoxScoarboardPlayer1.Size = new System.Drawing.Size(71, 35);
            this.textBoxScoarboardPlayer1.TabIndex = 2;
            this.textBoxScoarboardPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxScoarboardPlayer1.TextChanged += new System.EventHandler(this.textBoxScoarboardPlayer1_TextChanged);
            // 
            // groupBoxScoreboardPlayer2
            // 
            this.groupBoxScoreboardPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxScoreboardPlayer2.Controls.Add(this.textBoxPlayer2);
            this.groupBoxScoreboardPlayer2.Controls.Add(this.btnPressPlayer2);
            this.groupBoxScoreboardPlayer2.Location = new System.Drawing.Point(155, 12);
            this.groupBoxScoreboardPlayer2.Name = "groupBoxScoreboardPlayer2";
            this.groupBoxScoreboardPlayer2.Size = new System.Drawing.Size(117, 130);
            this.groupBoxScoreboardPlayer2.TabIndex = 3;
            this.groupBoxScoreboardPlayer2.TabStop = false;
            this.groupBoxScoreboardPlayer2.Text = "Player 2";
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPlayer2.Font = new System.Drawing.Font("LCDMono2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2.Location = new System.Drawing.Point(23, 18);
            this.textBoxPlayer2.MaxLength = 99;
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.ReadOnly = true;
            this.textBoxPlayer2.Size = new System.Drawing.Size(71, 35);
            this.textBoxPlayer2.TabIndex = 2;
            this.textBoxPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPlayer2.TextChanged += new System.EventHandler(this.textBoxPlayer2_TextChanged);
            // 
            // btnPressPlayer2
            // 
            this.btnPressPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPressPlayer2.Location = new System.Drawing.Point(21, 81);
            this.btnPressPlayer2.Name = "btnPressPlayer2";
            this.btnPressPlayer2.Size = new System.Drawing.Size(75, 43);
            this.btnPressPlayer2.TabIndex = 1;
            this.btnPressPlayer2.Text = "Click me!";
            this.btnPressPlayer2.UseVisualStyleBackColor = false;
            this.btnPressPlayer2.Click += new System.EventHandler(this.btnPressPlayer2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 223);
            this.Controls.Add(this.groupBoxScoreboardPlayer2);
            this.Controls.Add(this.groupBoxScoreboardPlayer1);
            this.Controls.Add(this.buttonStartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "IPP.lw.1.Problem2.Mediator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxScoreboardPlayer1.ResumeLayout(false);
            this.groupBoxScoreboardPlayer1.PerformLayout();
            this.groupBoxScoreboardPlayer2.ResumeLayout(false);
            this.groupBoxScoreboardPlayer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button btnPressPlayer1;
        private System.Windows.Forms.GroupBox groupBoxScoreboardPlayer1;
        private System.Windows.Forms.TextBox textBoxScoarboardPlayer1;
        private System.Windows.Forms.GroupBox groupBoxScoreboardPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Button btnPressPlayer2;
    }
}

