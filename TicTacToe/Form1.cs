using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int player1 = 0;
        int player2 = 0;
        bool turn = true;
        List<Button> buttons = new List<Button>();
        
        public void Button(int x)
        {
            

            int btnFontSize = 30;
            int top = -50;
            int left = 50;
            int btn = 1;
            string btnName = "btn_";
            

            for (int i = 0; i < x; i++)
            {
                
                left = 50;
                top += 105;
                
                for (int j = 0; j < x; j++)
                {
                    Button newbutton = new Button();
                    newbutton.Name = btnName + btn;
                    newbutton.Font = new Font(newbutton.Font.FontFamily, btnFontSize);
                    newbutton.Text = "";
                    newbutton.Top = top;
                    newbutton.Left = left;
                    newbutton.Size = new Size(100, 100);
                    this.Controls.Add(newbutton);
                    newbutton.Click += new EventHandler(newbutton_Click);
                    left += newbutton.Width + 5;
                    btn++;
                    buttons.Add(newbutton);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false; // Ki kommentelve ezt a sort, nyomon követhetjük a textbox alakulását.
            textBox2.Visible = false; // -""-
            btn_Reset.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            Reset();
            lbl_player1Score.Text = "0";
            lbl_player2Score.Text = "0";
            btn_Reset.Enabled = true;
            Button(3);
            
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (turn)
            {
                button.Text = "X";
                turn = false;
                button.Enabled = false;
            }
            else
            {
                button.Text = "O";
                turn = true;
                button.Enabled = false;
            }
            if(button.Text == "X")
            {
                textBox1.Text += button.Name.ToString();
            }
            else
            {
                textBox2.Text += button.Name.ToString();
            }
            checkTheWinnerx();
            
        }
        private void Reset()
        {
            foreach (var clearButtons in buttons)
            {
                clearButtons.Text = "";
                clearButtons.Enabled = true;
            }
            textBox1.Text = "";
            textBox2.Text = "";
           
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void checkTheWinnerx()
        {
            
            if (textBox1.Text.Contains("btn_1") && textBox1.Text.Contains("btn_2") && textBox1.Text.Contains("btn_3"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
                
            }
            else if (textBox2.Text.Contains("btn_1") && textBox2.Text.Contains("btn_2") && textBox2.Text.Contains("btn_3"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_1") && textBox1.Text.Contains("btn_5") && textBox1.Text.Contains("btn_9"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if (textBox2.Text.Contains("btn_1") && textBox2.Text.Contains("btn_5") && textBox2.Text.Contains("btn_9"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_1") && textBox1.Text.Contains("btn_4") && textBox1.Text.Contains("btn_7"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if(textBox2.Text.Contains("btn_1") && textBox2.Text.Contains("btn_4") && textBox2.Text.Contains("btn_7"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_2") && textBox1.Text.Contains("btn_5") && textBox1.Text.Contains("btn_8"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if (textBox2.Text.Contains("btn_2") && textBox2.Text.Contains("btn_5") && textBox2.Text.Contains("btn_8"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_3") && textBox1.Text.Contains("btn_6") && textBox1.Text.Contains("btn_9"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if (textBox2.Text.Contains("btn_3") && textBox2.Text.Contains("btn_6") && textBox2.Text.Contains("btn_9"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_3") && textBox1.Text.Contains("btn_5") && textBox1.Text.Contains("btn_7"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if(textBox2.Text.Contains("btn_3") && textBox2.Text.Contains("btn_5") && textBox2.Text.Contains("btn_7"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_4") && textBox1.Text.Contains("btn_5") && textBox1.Text.Contains("btn_6"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if(textBox2.Text.Contains("btn_4") && textBox2.Text.Contains("btn_5") && textBox2.Text.Contains("btn_6"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
            else if (textBox1.Text.Contains("btn_7") && textBox1.Text.Contains("btn_8") && textBox1.Text.Contains("btn_9"))
            {
                MessageBox.Show("X nyert!");
                player1++;
                lbl_player1Score.Text = player1.ToString();
            }
            else if(textBox2.Text.Contains("btn_7") && textBox2.Text.Contains("btn_8") && textBox2.Text.Contains("btn_9"))
            {
                MessageBox.Show("O nyert!");
                player2++;
                lbl_player2Score.Text = player2.ToString();
            }
        }

        
    }
}
