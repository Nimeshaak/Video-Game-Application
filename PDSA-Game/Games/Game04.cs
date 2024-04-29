using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySqlConnector;

namespace PDSA_Game.Games
{
    public partial class Game04 : Form
    {
        string connectionString = "server =localhost; user = root ; database =pdsagame ;passwprd = ";
        string playerName = "";

        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int PlayerWins = 0;
        int CPUWins = 0;
        int Draws = 0;
        int totalMoves = 0;
        List<Button> buttons;


        public Game04()
        {
            InitializeComponent();
            Restart();
        }


        private void CPUMove(object sender, EventArgs e)
        {
            if(buttons.Count > 0)
            {
                int Index = BestMove();
                //int Index = random.Next(buttons.Count);
                buttons[Index].Enabled = false;
                currentPlayer = Player.O;
                buttons[Index].Text = currentPlayer.ToString();
                buttons.RemoveAt(Index);
                CheckGame();   //Check the Game
                totalMoves++;
                CPUTimer.Stop();

            }
        }

        private void ClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.AliceBlue;
            buttons.Remove(button);
            totalMoves++;
            CheckGame();  //Check the Game
            CPUTimer.Start();
        }


        private int BestMove()
        {

            int bestScore = int.MinValue;
            int bestMove = -1;

            for (int i = 0; i < buttons.Count; i++)
            {
                Button currentButton = buttons[i];
                currentButton.Text = Player.O.ToString();
                buttons.RemoveAt(i);

                // MiniMax Algorithm: Calculating the score using Minimax algorithm
                int score = Minimax(0, false);

                //Reverse the move
                currentButton.Text = "";
                buttons.Insert(i, currentButton);

                // Update the best move and score
                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = i;
                }
            }

            return bestMove;


        }


        private int Minimax(int depth, bool isMaximizing)
        {
            
            int score = Analyze(); //Analyze the current state of the board

            if (score == 10)       // CPU wins
                return score - depth;
            if (score == -10)      // Player wins
                return score + depth;
            if (buttons.Count == 0) // A Draw
                return 0;

            int bestScore = isMaximizing ? int.MinValue: int.MaxValue;

            for (int i = 0; i < buttons.Count; i++)
            {
                Button currentButton = buttons[i];
                currentButton.Text = isMaximizing ? Player.O.ToString() : Player.X.ToString();
                buttons.RemoveAt(i);

                int currentScore = Minimax(depth + 1, !isMaximizing);

                currentButton.Text = "";
                buttons.Insert(i, currentButton);

                if (isMaximizing)
                {
                    bestScore = Math.Max(bestScore, currentScore);
                }
                else
                {
                    bestScore = Math.Min(bestScore, currentScore);
                }
              
            }
            return bestScore;
        }


        private int Analyze()
        {
            // Analyze the board and check for winning combinations
           
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")

            {
                return -10;    // A negative value means the Player is winning
            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "0"
                 || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                 || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                 || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                 || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")

            {
                return 10;   // A positive value means the CPU is winning
            }
            return 0;     // Game Draw
        }


        private void Restart(object sender, EventArgs e)
        {
            Restart();
        }
        
        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")

            {
                  CPUTimer.Stop();
                  MessageBox.Show("Player Won the Game !!");

                  playerName = Interaction.InputBox("Congratulations! You won the Game !! \n\n\n Enter Player name:", "Player Name");
                  SavePlayerName(playerName);

                  PlayerWins++;
                  label4.Text = PlayerWins.ToString();
                  Restart();

            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "0"
                 || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                 || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                 || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                 || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")

            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Won the Game !!");

                CPUWins++;
                label5.Text = CPUWins.ToString();
                Restart();
            }
            else if (totalMoves == 9)

            {
                CPUTimer.Stop();
                MessageBox.Show("It's A Draw");

                Draws++;
                label6.Text = Draws.ToString();
                Restart();
            }
        }
        

        private void SavePlayerName(string playerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tictactoe (PlayerName, date) VALUES (@playerName, @date)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@playerName", playerName);
                        command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle MySQL exceptions
                    MessageBox.Show("MySQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Restart()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }

            totalMoves = 0;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game04_Load(object sender, EventArgs e)
        {

        }
    }
}