using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSA_Game.Games
{
    public partial class Game03 : Form
    {
        DBConnection dBConnection = new DBConnection();
        //data structure of 8 x 8 chess board
        bool[,] chessBoard = new bool[8, 8];
        int queenPlace = 0;
        const int maxQueen = 8;

        string player;

        public Game03()
        {
            InitializeComponent();
            ResetQueenChessBoard();
            txtPlayer.Text = "";
            btnNew.Enabled = false;
            btnAns.Enabled = false;
            tableLayoutPanel1.Enabled = false;
        }

        private void ResetQueenChessBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    chessBoard[row, col] = false;
                }
            }
            queenPlace = 0;

            // Clear all images
            ClearQueenImage();
        }

        private void ClearQueenImage()
        {
            // Clear images
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Panel chessButton = control as Panel;
                if (chessButton != null)
                {
                    chessButton.BackgroundImage = null; // Remove the queen image
                }
            }
        }

        private Panel CreateChessBoardButton(int row, int col)
        {
            Panel chessButton = new Panel();

            int chessButtonSize = tableLayoutPanel1.Width / 8; 

            chessButton.Size = new Size(chessButtonSize, chessButtonSize);
         
            if ((row + col) % 2 == 0)
            {
                chessButton.BackColor = Color.White;
            }
            else
            {
                chessButton.BackColor = Color.Black;
            }

            chessButton.Name = $"chessButton_{row}_{col}";

            return chessButton;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Panel chessButton = CreateChessBoardButton(row, col);
                    tableLayoutPanel1.Controls.Add(chessButton, col, row);
                    chessButton.Click += ChessBoardButton_Click;
                }
            }
        }

        private bool IsSafe(int CheckRow, int CheckCol)
        {

            for (int col = 0; col < 8; col++)
            {
                if (chessBoard[CheckRow, col] || chessBoard[col, CheckCol])
                {
                    return false; // Another queen is in the same row or column
                }
            }

            // Check for diagonal threats
            for (int row = CheckRow, col = CheckCol; row < 8 && col < 8; row++, col++)
            {
                if (chessBoard[row, col])
                {
                    return false; // Another queen threatens diagonally
                }
            }

            // Check for diagonal threats
            for (int row = CheckRow, col = CheckCol; row < 8 && col >= 0; row++, col--)
            {
                if (chessBoard[row, col])
                {
                    return false; // Another queen threatens diagonally
                }
            }

            // Check for diagonal threats
            for (int row = CheckRow, col = CheckCol; row >= 0 && col < 8; row--, col++)
            {
                if (chessBoard[row, col])
                {
                    return false; // Another queen threatens diagonally
                }
            }

            // Check for diagonal threats
            for (int row = CheckRow, col = CheckCol; row >= 0 && col >= 0; row--, col--)
            {
                if (chessBoard[row, col])
                {
                    return false; // Another queen threatens diagonally
                }
            }

            return true;
        }

        private void ChessBoardButton_Click(object sender, EventArgs e)
        {
            Panel chessButton = (Panel)sender;

            // Get the row and column
            int row = tableLayoutPanel1.GetRow(chessButton);
            int col = tableLayoutPanel1.GetColumn(chessButton);

            // Check if empty
            if (!chessBoard[row, col])
            {

                if (queenPlace >= maxQueen)
                {
                    MessageBox.Show("You have already placed the maximum number of queens.", "Error");
                    return;
                }

                if (!IsSafe(row, col))
                {
                    MessageBox.Show("This placement is wrong. Queens threaten each other.", "Error");
                    return;
                }

                // Place a queen
                chessBoard[row, col] = true;
                queenPlace++;

                
                chessButton.BackgroundImage = Properties.Resources.queenIcon;
                chessButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                // Remove the queen
                chessBoard[row, col] = false;
                queenPlace--;

                chessButton.BackgroundImage = null; // Remove the queen image
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetQueenChessBoard();
        }

        private bool solutionCheck()
        {
            //Verifying that no queens threaten each other
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (chessBoard[row, col] && !IsSafe(row, col))
                    {
                        return false; // Queens threaten each other
                    }
                }
            }

            return true; // No queens threaten each other
        }

        public void addAnsDB(string player, string solution)
        {
            dBConnection.OpenConnection();
            string query = "INSERT INTO player_solution_queen (player, solution) VALUES (@player, @solution)";
            using (MySqlCommand cmd = new MySqlCommand(query, dBConnection.connection))
            {
                cmd.Parameters.AddWithValue("@player", player);
                cmd.Parameters.AddWithValue("@solution", solution);
                cmd.ExecuteNonQuery();
            }
            dBConnection.CloseConnection();
        }

        private string CorrectAnswer()
        {
            string CorrectAnswer = "";

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (chessBoard[row, col])
                    {
                        CorrectAnswer = CorrectAnswer + ";"+ row.ToString()+","+col.ToString();
                    }
                    else
                    {
                        //CorrectAnswer = CorrectAnswer + ";" + row.ToString() + "," + col.ToString();
                    }
                }
            }

            return CorrectAnswer;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {

            if (queenPlace < maxQueen)
            {
                MessageBox.Show("You need to place all 8 queens before submitting.", "Error");
                return;
            }

            // Check if solution is correct
            if (solutionCheck())
            {
                MessageBox.Show("Congratulations! You've found a correct solution.", "Information");


                addAnsDB(player, CorrectAnswer());

                ResetQueenChessBoard();
            }
            else
            {
                MessageBox.Show("This is not a valid solution. Queens threaten each other.", "Error");
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlayer.Text == "")
                {
                    txtPlayer.Text = "";
                    btnNew.Enabled = false;
                    btnAns.Enabled = false;
                    tableLayoutPanel1.Enabled = false;
                    MessageBox.Show("Please enter player name!","Error");
                }
                else
                {
                    player = txtPlayer.Text;
                    btnNew.Enabled = true;
                    btnAns.Enabled = true;
                    tableLayoutPanel1.Enabled = true;
                    ResetQueenChessBoard();
                    MessageBox.Show("Player add successfully!", "Information");
                    txtPlayer.Text = "";
                    lblName.Text = player;

                }
            }
            catch (Exception)
            {
                txtPlayer.Text = "";
                btnNew.Enabled = false;
                btnAns.Enabled = false;
                tableLayoutPanel1.Enabled = false;
                MessageBox.Show("Can't add player name!", "Error");
                ResetQueenChessBoard();
            }
        }
    }
}
