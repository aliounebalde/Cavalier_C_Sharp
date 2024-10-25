using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier
{

    public partial class Simulation : Form
    {
        //Cheese variables
        private const int GridSize = 8; // Taille de la grille 8x8 pour un échiquier standard
        private Button[,] board = new Button[GridSize, GridSize]; // Tableau de boutons
        private static int[] rowMovement = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        private static int[] colMovement = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        private bool[,] visited = new bool[8, 8];

        // game variables
        private static Random rand = new Random();
        private static int currentRow = 0;
        private static int currentCol = 0;
        private static int deplacementNumber = 1;
        private static bool canMove = true;
        // animation variables
        private Timer moveTimer;
        private static double simulationSpeed;

        Image cavalierImage;
        public Simulation()
        {
            InitializeComponent();
            InitializeChessBoard();

        }




        private void InitializeChessBoard()
        {
            int tileSize = 60; // Taille de chaque case (en pixels)

            // Boucle pour créer chaque case de l’échiquier
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    // Créer un bouton pour chaque case
                    Button tile = new Button
                    {
                        Width = tileSize,
                        Height = tileSize,
                        Location = new Point(j * tileSize, i * tileSize),
                        Text = string.Empty,
                        Tag = (i, j)
                    };

                    // Appliquer une couleur alternée pour l'effet échiquier
                    tile.BackColor = (i + j) % 2 == 0 ? Color.White : Color.Black;

                    // Ajouter la case à la forme et au tableau
                    Controls.Add(tile);
                    board[i, j] = tile;
                }
            }
        }
        private void SimulateMove()
        {
            int bestMoveIndex = -1;
            int minFutureMoves = int.MaxValue;
            int nextRow = -1;
            int nextCol = -1;
            for (int i = 0; i < 8; i++)
            {
                nextRow = currentRow + rowMovement[i];
                nextCol = currentCol + colMovement[i];
                if (IsValidMove(nextRow, nextCol))
                {
                    int futureMoves = CountFutureMove(nextRow, nextCol);
                    if (futureMoves < minFutureMoves)
                    {
                        minFutureMoves = futureMoves;
                        bestMoveIndex = i;
                    }
                }
            }
            if (bestMoveIndex != -1)
            {
                currentRow += rowMovement[bestMoveIndex];
                currentCol += colMovement[bestMoveIndex];
                board[currentRow, currentCol].Image = cavalierImage;
                //board[currentRow, currentCol].BackColor = Color.DodgerBlue;
                visited[currentRow, currentCol] = true;
                deplacementNumber++;
            }
            else
            {
                canMove = false;
                // Console.WriteLine("pas de move");

            }


        }
        private int CountFutureMove(int row, int col)
        {
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                int nextRow = row + rowMovement[i];
                int nextCol = col + colMovement[i];
                if (IsValidMove(nextRow, nextCol))
                {
                    count++;
                }
            }
            return count;
        }
        private bool IsValidMove(int row, int col)
        {
            if (row >= 0 && row <= 7 && col >= 0 && col <= 7)
            {

                //return (board[row, col].BackColor == Color.White || board[row, col].BackColor == Color.Black);
                //return (board[row, col].Image == null);
                return !visited[row, col];
            }

            return false;
        }
        private void StartAnimation()
        {
            moveTimer = new Timer();
            moveTimer.Interval = (int)(simulationSpeed * 1000); // 500 ms entre chaque mouvement
            moveTimer.Tick += move_cavalier;
            moveTimer.Start();
        }
        private void MoveWithoutAnimation()
        {
            while (true)
            {
                SimulateMove();
                if (deplacementNumber == 64 || canMove == false)
                    break;
            }
            MessageBox.Show($"Fin de Parcours du Cavalier ", "Fin Simulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            breakBtn.Text = "Rejouer";
        }

        private void move_cavalier(object sender, EventArgs e)
        {

            SimulateMove();

            if (deplacementNumber == 64 || canMove == false)
            {
                moveTimer.Stop();
                MessageBox.Show($"Fin de Parcours du Cavalier ", "Fin Simulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                breakBtn.Text = "Rejouer";
            }
        }



        private void Simulation_Load(object sender, EventArgs e)
        {
            cavalierImage = Image.FromFile(@".\Images\cavalier.png"); // Charger une seule fois
            foreach (Button button in board)
            {
                button.Click += new System.EventHandler(this.tile_Click);
            }
        }
        private void tile_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = cavalierImage;
            (currentRow, currentCol) = ((int, int))btn.Tag;
            visited[currentRow, currentCol] = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool choseTile = false;
            if (double.TryParse(textBox1.Text, out simulationSpeed) && simulationSpeed >= 0)
            {
                if (randomRadioBtn.Checked)
                {
                    currentRow = rand.Next(0, 8);
                    currentCol = rand.Next(0, 8);
                    board[currentRow, currentCol].Image = cavalierImage;
                    visited[currentRow, currentCol] = true;
                    choseTile = true;
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (visited[i, j])
                            {
                                choseTile = true;
                                break;
                            }
                        }
                    }
                }
                if (choseTile)
                {
                    if (simulationSpeed != 0)
                        StartAnimation();
                    else
                        MoveWithoutAnimation();
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Veuillez choisir une case de l'echequier\n Ou cochez Random pour un choix aleatoir", "Case de départ manuel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else { MessageBox.Show($"Veuillez taper une valeur numérique (utilisez ',' pour les nombres décimaux )", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (breakBtn.Text.Equals("Pause"))
            {
                moveTimer.Stop();
                breakBtn.Text = "Relancer";
                breakBtn.BackColor = Color.Green;
            }
            else if (breakBtn.Text.Equals("Relancer"))
            {
                moveTimer.Start();
                breakBtn.Text = "Pause";
            }
            else
            {
                deplacementNumber = 1;
                for (int i = 0; i < GridSize; i++)
                {
                    for (int j = 0; j < GridSize; j++)
                    {
                        board[i, j].Image = null;
                        visited[i, j] = false;
                    }
                }
                breakBtn.Text = "Pause";
                button1.Enabled = true;
            }
            // button1.Enabled = false;
        }
    }
}
