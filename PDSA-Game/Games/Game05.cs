using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace PDSA_Game.Games
{
    public partial class Game05 : Form
    {
        DBConnection connection = new DBConnection();

        
        public Game05()               //form name
        {
            InitializeComponent();


        }


        private void Game05_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)     //start 
        {
            try
            {

                Random random = new Random();
                int randomValue;
                randomValue = random.Next(0, 9);
                int x = randomValue;
                txtsource.Text = (x.ToString());

                int y = Convert.ToInt32(randomValue);

                genarateMatix(y);      // call matrix method

                txttemp.Text = gamedata.CDistance.ToString();

                //textbox databind

                //txttemp.Text = Values.CDistance.ToString();

                btnstart.Enabled = false;
            }
            catch (Exception ex)
            {
                // Handle the exception here (e.g., display an error message)
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }


        private void genarateMatix(int x)
        {

            //create random number object
            Random rand = new Random();

            //genarateMatix();
            var matrix = new Matrix();

            var a = matrix.CreateRoot("A");
            var b = matrix.Creatematrixnode("B");
            var c = matrix.Creatematrixnode("C");
            var d = matrix.Creatematrixnode("D");
            var e = matrix.Creatematrixnode("E");  
            var f = matrix.Creatematrixnode("F");
            var g = matrix.Creatematrixnode("G");
            var h = matrix.Creatematrixnode("H");
            var i = matrix.Creatematrixnode("I");
            var j = matrix.Creatematrixnode("J");


            a.AddEdge(b, rand.Next(5, 50))
                .AddEdge(c, rand.Next(5, 50))
                .AddEdge(d, rand.Next(5, 50))
                .AddEdge(e, rand.Next(5, 50))
                .AddEdge(f, rand.Next(5, 50))
                .AddEdge(g, rand.Next(5, 50))
                .AddEdge(h, rand.Next(5, 50))
                .AddEdge(i, rand.Next(5, 50))
                .AddEdge(j, rand.Next(5, 50));

            c.AddEdge(b, rand.Next(5, 50))
               .AddEdge(c, rand.Next(5, 50))
               .AddEdge(d, rand.Next(5, 50))
               .AddEdge(e, rand.Next(5, 50))
               .AddEdge(f, rand.Next(5, 50))
               .AddEdge(g, rand.Next(5, 50))
               .AddEdge(h, rand.Next(5, 50))
               .AddEdge(i, rand.Next(5, 50))
               .AddEdge(j, rand.Next(5, 50));

            d.AddEdge(b, rand.Next(5, 50))
               .AddEdge(c, rand.Next(5, 50))
               .AddEdge(d, rand.Next(5, 50))
               .AddEdge(e, rand.Next(5, 50))
               .AddEdge(f, rand.Next(5, 50))
               .AddEdge(g, rand.Next(5, 50))
               .AddEdge(h, rand.Next(5, 50))
               .AddEdge(i, rand.Next(5, 50))
               .AddEdge(j, rand.Next(5, 50));

            e.AddEdge(b, rand.Next(5, 50))
               .AddEdge(c, rand.Next(5, 50))
               .AddEdge(d, rand.Next(5, 50))
               .AddEdge(e, rand.Next(5, 50))
               .AddEdge(f, rand.Next(5, 50))
               .AddEdge(g, rand.Next(5, 50))
               .AddEdge(h, rand.Next(5, 50))
               .AddEdge(i, rand.Next(5, 50))
               .AddEdge(j, rand.Next(5, 50));

            f.AddEdge(b, rand.Next(5, 50))
               .AddEdge(c, rand.Next(5, 50))
               .AddEdge(d, rand.Next(5, 50))
               .AddEdge(e, rand.Next(5, 50))
               .AddEdge(f, rand.Next(5, 50))
               .AddEdge(g, rand.Next(5, 50))
               .AddEdge(h, rand.Next(5, 50))
               .AddEdge(i, rand.Next(5, 50))
               .AddEdge(j, rand.Next(5, 50));

            g.AddEdge(b, rand.Next(5, 50))
               .AddEdge(c, rand.Next(5, 50))
               .AddEdge(d, rand.Next(5, 50))
               .AddEdge(e, rand.Next(5, 50))
               .AddEdge(f, rand.Next(5, 50))
               .AddEdge(g, rand.Next(5, 50))
               .AddEdge(h, rand.Next(5, 50))
               .AddEdge(i, rand.Next(5, 50))
               .AddEdge(j, rand.Next(5, 50));

            h.AddEdge(b, rand.Next(5, 50))
              .AddEdge(c, rand.Next(5, 50))
              .AddEdge(d, rand.Next(5, 50))
              .AddEdge(e, rand.Next(5, 50))
              .AddEdge(f, rand.Next(5, 50))
              .AddEdge(g, rand.Next(5, 50))
              .AddEdge(h, rand.Next(5, 50))
              .AddEdge(i, rand.Next(5, 50))
              .AddEdge(j, rand.Next(5, 50));

            i.AddEdge(b, rand.Next(5, 50))
              .AddEdge(c, rand.Next(5, 50))
              .AddEdge(d, rand.Next(5, 50))
              .AddEdge(e, rand.Next(5, 50))
              .AddEdge(f, rand.Next(5, 50))
              .AddEdge(g, rand.Next(5, 50))
              .AddEdge(h, rand.Next(5, 50))
              .AddEdge(i, rand.Next(5, 50))
              .AddEdge(j, rand.Next(5, 50));

            j.AddEdge(b, rand.Next(5, 50))
              .AddEdge(c, rand.Next(5, 50))
              .AddEdge(d, rand.Next(5, 50))
              .AddEdge(e, rand.Next(5, 50))
              .AddEdge(f, rand.Next(5, 50))
              .AddEdge(g, rand.Next(5, 50))
              .AddEdge(h, rand.Next(5, 50))
              .AddEdge(i, rand.Next(5, 50))
              .AddEdge(j, rand.Next(5, 50));


            int[,] adj = matrix.CreatedjkMatrix();

            PrintMatrix(ref adj, matrix.AllNodes.Count);

            Dijkstra(adj, x);



        }


        private void PrintMatrix(ref int[,] matrix, int Count)
        {

            System.Windows.Forms.ListView listView = new System.Windows.Forms.ListView();
            listView.Location = new System.Drawing.Point(12, 12);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(245, 200);
            listView.ForeColor = System.Drawing.Color.Black;
            listView.Dock = DockStyle.Fill;

            Console.Write("       ");
            listView.Items.Add("       ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ", (char)('A' + i));
                listView.Items.Add(((char)('A' + i)).ToString());
            }
            Console.WriteLine();
            listView.Items.Add("\n");

            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0} | [ ", (char)('A' + i));
                listView.Items.Add(((char)('A' + i)).ToString());
                for (int j = 0; j < Count; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" 0");
                        listView.Items.Add(" 0");
                    }
                    else if (matrix[i, j] == null)
                    {
                        Console.Write(" .,");
                        listView.Items.Add(" .,");
                    }
                    else
                    {
                        Console.Write(" {0},", matrix[i, j]);
                        listView.Items.Add(matrix[i, j].ToString());
                    }

                }
                Console.Write(" ]\r\n");
                listView.Items.Add("\r\n");
            }

            Console.Write("\r\n");
            listView.Items.Add("\r\n");


            panelmatrix.Controls.Add(listView);

         }


        static int V = 10;
        int minDistance(int[] dist,
                        bool[] sptSet)
        {
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        void printSolution(int[] dist, int n)
        {
            System.Diagnostics.Debug.WriteLine("Vertex     Distance "
                          + "from Source\n");
            for (int i = 0; i < V; i++)
            {
                System.Diagnostics.Debug.WriteLine(i + " \t\t " + dist[i] + "\n");
                gamedata.CDistance.Add(dist[i]);
            }
        }

        public void Dijkstra(int[,] graph, int src)
        {
            int[] dist = new int[V];
            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = minDistance(dist, sptSet);

                sptSet[u] = true;

                for (int v = 0; v < V; v++)

                    if (!sptSet[v] && graph[u, v] != 0 &&
                         dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }

            printSolution(dist, V);
        }



        private void btnadd_Click(object sender, EventArgs e)  //play button

        {
            if (string.IsNullOrEmpty(txtanswer.Text))
            {
                MessageBox.Show("Please provide your answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                Play();
            }



        }


        public void Play()
        {
            bool isEqualWeight = gamedata.CDistance.OrderBy(x => x).SequenceEqual(gamedata.PlayerDistance.OrderBy(x => x));

            if (isEqualWeight == true)
            {
                MessageBox.Show("Correct Answer", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnsave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wrong Answer", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveDataToDAtabase(string userID, DateTime playedDate, Dictionary<char, int> correctAnswers)
        {



        }

       


        private void saveDataInDatabase()
        {
            try
            {

                string  query = "INSERT INTO  `shortestpath` (`player_name`, `answer`) VALUES ('" + gamedata.playerName + "','" + gamedata.CDistance + "')";
                if (connection.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.CloseConnection();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Database saving process failed" + ex.StackTrace, "Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        
        }

      
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Please enter player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gamedata.playerName = txtname.Text;
                saveDataInDatabase();


            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelmatrix_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)    //ADD Button
        {
            if (string.IsNullOrEmpty(txtanswer.Text))
            {
                MessageBox.Show("Please provide your answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    string[] txtNumbers = txtanswer.Text.Split('\n');
                    foreach (string index in txtNumbers)
                    {
                        //int number = int.Parse(index);
                        //gamedata.PlayerDistance.Add(number);
                        gamedata.PlayerDistance.Add(int.Parse(index));

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }


            }

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home nextform = new Home();
            nextform.Show();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            btnplay.Enabled = true;
            Random random = new Random();
            int randomValue;
            randomValue = random.Next(0, 9);
            int x = randomValue;
            txtsource.Text = (x.ToString());

            int y = Convert.ToInt32(randomValue);

            genarateMatix(y);
            btnstart.Enabled = false;
        }
    }
    }






