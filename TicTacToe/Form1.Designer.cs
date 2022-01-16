
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.lbl_player2 = new System.Windows.Forms.Label();
            this.lbl_player1Score = new System.Windows.Forms.Label();
            this.lbl_player2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(578, 53);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(150, 50);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(578, 165);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 50);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(524, 426);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 23);
            this.textBox2.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(578, 109);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(150, 50);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_player1.Location = new System.Drawing.Point(427, 244);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(151, 37);
            this.lbl_player1.TabIndex = 3;
            this.lbl_player1.Text = "Player 1 :";
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_player2.Location = new System.Drawing.Point(427, 293);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(151, 37);
            this.lbl_player2.TabIndex = 3;
            this.lbl_player2.Text = "Player 2 :";
            // 
            // lbl_player1Score
            // 
            this.lbl_player1Score.AutoSize = true;
            this.lbl_player1Score.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_player1Score.Location = new System.Drawing.Point(578, 244);
            this.lbl_player1Score.Name = "lbl_player1Score";
            this.lbl_player1Score.Size = new System.Drawing.Size(34, 37);
            this.lbl_player1Score.TabIndex = 3;
            this.lbl_player1Score.Text = "0";
            // 
            // lbl_player2Score
            // 
            this.lbl_player2Score.AutoSize = true;
            this.lbl_player2Score.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_player2Score.Location = new System.Drawing.Point(578, 293);
            this.lbl_player2Score.Name = "lbl_player2Score";
            this.lbl_player2Score.Size = new System.Drawing.Size(34, 37);
            this.lbl_player2Score.TabIndex = 3;
            this.lbl_player2Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_player2);
            this.Controls.Add(this.lbl_player2Score);
            this.Controls.Add(this.lbl_player1Score);
            this.Controls.Add(this.lbl_player1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_NewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label lbl_player2;
        private System.Windows.Forms.Label lbl_player1Score;
        private System.Windows.Forms.Label lbl_player2Score;
    }
}

