using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDSA_Game.Games
{
    public partial class Game01 : Form
    {
        private const int BoardSize = 8;
        private Button currentlyClickedButton;
        private bool[,] visitedCells;
        private int totalMovableCells;
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pdsagame;";
        private int[][] moves = new int[][] { new int[] { 2, 1 }, new int[] { 1, 2 }, new int[] { -1, 2 }, new int[] { -2, 1 }, new int[] { -2, -1 }, new int[] { -1, -2 }, new int[] { 1, -2 }, new int[] { 2, -1 } };
        private int[,] visited;
        private int totalMoves;
        private int currentRow;
        private int currentCol;
        private Button lastValidButton;
        private string playerName;
        public Game01()
        {
            InitializeComponent();
            InitializeChessboard();
            CreateChessboardButtons();
            
        }

        private void InitializeChessboard()


        {
            visitedCells = new bool[BoardSize, BoardSize];

            visited = new int[BoardSize, BoardSize];
            
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    visited[i, j] = 0;
                    visitedCells[i, j] = false; // Initialize visitedCells array
                }
            }
        }

        private bool IsSafe(int row, int col)
        {
            return (row >= 0 && col >= 0 && row < BoardSize && col < BoardSize && visited[row, col] == 0);
        }

        private bool KnightTour(int row, int col)
        {
            if (totalMoves == BoardSize * BoardSize)
                return true;

            // An array to store the number of accessible neighbors for each move
            int[] accessibleNeighbors = new int[8];

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + moves[i][0];
                int newCol = col + moves[i][1];

                if (IsSafe(newRow, newCol))
                {
                    // Count the number of accessible neighbors for this move
                    int neighborCount = CountAccessibleNeighbors(newRow, newCol);
                    accessibleNeighbors[i] = neighborCount;
                }
                else
                {
                    // Mark invalid moves with a high number to avoid them
                    accessibleNeighbors[i] = int.MaxValue;
                }
            }

            // Check if there are any valid moves left
            if (accessibleNeighbors.All(x => x == int.MaxValue))
            {
                MessageBox.Show("No more valid moves! The game is over.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartNewGame();
                return false;
            }

            // Find the move with the minimum number of accessible neighbors
            int minNeighborCount = accessibleNeighbors.Min();
            int bestMove = Array.IndexOf(accessibleNeighbors, minNeighborCount);

            // Make the best move
            int nextRow = row + moves[bestMove][0];
            int nextCol = col + moves[bestMove][1];
            visited[nextRow, nextCol] = totalMoves + 1;
            if (KnightTour(nextRow, nextCol))
                return true;
            else
                visited[nextRow, nextCol] = 0; // Backtrack

            return false;
        }



        private void CreateChessboardButtons()
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    Panel cell = new Panel();
                    cell.BackColor = (row + col) % 2 == 0 ? Color.White : Color.Black;
                    cell.Dock = DockStyle.Fill;

                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Text = "";
                    btn.UseVisualStyleBackColor = false; // Set the UseVisualStyleBackColor property to true
                    btn.Click += ChessboardButton_Click;
                    btn.Tag = row * BoardSize + col; // Use a unique tag for each button to identify its position
                    cell.Controls.Add(btn); // Add the button to the cell

                    if ((row + col) % 2 == 0)
                    {
                        // White cells
                        cell.BackColor = Color.White;
                    }
                    else
                    {
                        // Black cells
                        cell.BackColor = Color.Black;
                    }

                    if (IsKnightMove(row, col))
                    {
                        totalMovableCells++; // Increment totalMovableCells for each movable cell
                    }

                    ChessBoardLayoutPanel.Controls.Add(cell, col, row);
                }
            }
        }


        private void CheckGameOutcome()
        {
            int movableCellsVisited = 0;
            bool noValidMovesLeft = true;

            foreach (int[] move in moves)
            {
                int newRow = currentRow + move[0];
                int newCol = currentCol + move[1];

                if (IsSafe(newRow, newCol) && !visitedCells[newRow, newCol])
                {
                    // If there's at least one valid move left, set noValidMovesLeft to false
                    noValidMovesLeft = false;
                }
                else if (IsSafe(newRow, newCol) && visitedCells[newRow, newCol])
                {
                    movableCellsVisited++;
                }
            }

            // Check if all movable cells have been visited
            if (movableCellsVisited == totalMovableCells)
            {
                MessageBox.Show("You Lose! All movable cells have been visited.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartNewGame();
            }
            // Check if all cells on the board have been visited
            else if (totalMoves == BoardSize * BoardSize)
            {
                MessageBox.Show("Congratulations! You've completed the Knight's Tour!", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartNewGame();
            }
            // Check if there are no valid moves left
            else if (noValidMovesLeft)
            {
                MessageBox.Show("No more valid moves! The game is over.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartNewGame();
            }
        }



        private void ChessboardButton_Click(object sender, EventArgs e)
        {
            if (currentlyClickedButton != null)
            {
                currentlyClickedButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            Button button = (Button)sender;
            int buttonIndex = (int)button.Tag;
            int row = buttonIndex / BoardSize;
            int col = buttonIndex % BoardSize;
            Console.WriteLine("row - " + row + " | col - " + col);
            // Check if the selected cell is a valid knight move from the current position
            bool isValidMove = IsKnightMove(row, col);

            if (isValidMove && !visitedCells[row, col])
            {
                // Move the knight
                MoveKnight(row, col);
            
                button.BackColor = Color.LightGreen;
                lastValidButton = button;
                currentlyClickedButton = button;
                Console.WriteLine("row - "+row + " | col - "+ col );
            }
            else if (!isValidMove)
            {
                MessageBox.Show("Invalid move! Knights can only move in an L-shape.", "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (lastValidButton != null)
                {
                    lastValidButton.BackColor = Color.LightGreen;
                    currentlyClickedButton = lastValidButton;
                }

            }
            else if (visitedCells[row, col])
            {
                MessageBox.Show("Cell already visited!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private bool IsKnightMove(int targetRow, int targetCol)
        {
            int rowDiff = Math.Abs(targetRow - currentRow);
            int colDiff = Math.Abs(targetCol - currentCol);

            Console.WriteLine(rowDiff);
            Console.WriteLine(colDiff);
            Console.WriteLine((rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2));
            // Check if the target cell is a valid knight move and has not been visited
             return (rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2);
        }

        private void MoveKnight(int row, int col)
        {
            if (IsSafe(row, col))
            {
                totalMoves++;
                visitedCells[row, col] = true; // Mark the cell as visited
                visited[row, col] = totalMoves;
                currentRow = row;
                currentCol = col;
                UpdateChessboard();
                CheckWinCondition();
                CheckGameOutcome(); // Call CheckGameOutcome after each move
            }
        }

        private void UpdateChessboard()
        {
            foreach (Control cell in ChessBoardLayoutPanel.Controls)
            {
                if (cell is Panel panel)
                {
                    foreach (Control button in panel.Controls)
                    {
                        if (button is Button btn)
                        {
                            int buttonIndex = (int)btn.Tag;
                            int buttonRow = buttonIndex / BoardSize;
                            int buttonCol = buttonIndex % BoardSize;
                            //btn.Text = visited[buttonRow, buttonCol].ToString();

                            if (visitedCells[buttonRow, buttonCol])
                            {
                                // Set the background color to a permanent color (e.g., blue)
                                btn.BackColor = Color.LightBlue;
                            }

                        }
                    }
                }
            }
        }

        private void CheckWinCondition()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            if (totalMoves == BoardSize * BoardSize)
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO KnightTour (PlayerName, CorrectResponse) VALUES (@name, @totalMoves)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@totalMoves", totalMoves);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }

                MessageBox.Show("Congratulations! You've completed the Knight's Tour!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartNewGame();
            }
        }

        private void StartNewGame()
        {
            InitializeChessboard();
            ResetChessboardButtons();


            playerName = name.Text;

            bool isEmpty=playerName.Length == 0;

            if (isEmpty)
            {
                MessageBox.Show(" Please Enter Your Name " , "Error !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            totalMoves = 0;
            
            Random rand = new Random();
            currentRow = rand.Next(0, BoardSize);
            currentCol = rand.Next(0, BoardSize);
            visited[currentRow, currentCol] = 1;
            visitedCells[currentRow, currentCol] = true; // Mark the starting cell as visited

            UpdateChessboard();

            
        }


        private void ChessBoardLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private int CountAccessibleNeighbors(int row, int col)
        {
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + moves[i][0];
                int newCol = col + moves[i][1];

                if (IsSafe(newRow, newCol) && !visitedCells[newRow, newCol])
                {
                    count++;
                }
            }

            return count;
        }

        private void restart_click_Click(object sender, EventArgs e)
        {                
            StartNewGame();
        }

        private void ResetChessboardButtons()
        {
            foreach (Control cell in ChessBoardLayoutPanel.Controls)
            {
                if (cell is Panel panel)
                {
                    foreach (Control button in panel.Controls)
                    {
                        if (button is Button btn)
                        {
                            // Reset the button's background color to its initial color
                            btn.BackColor = (panel.BackColor == Color.White) ? Color.White : Color.Black;
                        }
                    }
                }
            }
        }


        private void back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit the game?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                this.Close(); 
                              
            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
