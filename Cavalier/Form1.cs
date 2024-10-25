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
    public partial class Form1 : Form
    {
        //Cheese variables
        private const int GridSize = 8; // Taille de la grille 8x8
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

        // Simulation windows
        Simulation simulation;

        // Cancel moves variables
        private Stack<(int row, int col)> lastMoves;
        private static int authorizeUndo = 5;
        private static int undo = authorizeUndo;

        // Image variables
        Image cavalierImage;

        public Form1()
        {
            InitializeComponent();
            //InitializeChessBoard();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            simulation = new Simulation();
            this.BackgroundImage = Image.FromFile(@".\Images\CheseBackground2.png");
            linkLabel1.Location = new Point(this.ClientSize.Width - linkLabel1.Width, this.ClientSize.Height - linkLabel1.Height);
            label1.Text = String.Empty;
            label1.ForeColor = Color.Green;

            Redo.Visible = false;
            btnRejouer.Visible = false;
            btnLeave2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simulation.ShowDialog();
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
                        TextAlign = ContentAlignment.BottomLeft,
                        ForeColor = Color.Red,
                        //je stocke la ligne et la colonne dans le tag
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
        //bouton jouer
        private void button2_Click(object sender, EventArgs e)
        {
            InitializeChessBoard();
            this.BackgroundImage = null;
            btnLeave.Visible = false;
            btnSimulation.Visible = false;
            btnJouer.Visible = false;
            menuStrip1.Visible = false;
            cavalierImage = Image.FromFile(@".\Images\cavalier.png");
            foreach (Button button in board)
            {
                button.Click += new System.EventHandler(this.tile_Click);
            }
            lastMoves = new Stack<(int row, int col)>();
            Redo.Visible = true;
            btnRejouer.Visible = true;
            btnLeave2.Visible = true;
            label1.Text = $"il vous reste {undo} annulations possible !";

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tile_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = cavalierImage;
            (currentRow, currentCol) = ((int, int))btn.Tag;
            visited[currentRow, currentCol] = true;

            // Add the currentRow and currentCol to lastMove Stack
            Save_Click(currentRow, currentCol);

            // Ajouter un label pour afficher le numéro
            Label lbl = new Label();
            lbl.Text = deplacementNumber.ToString(); // Remplacez par le numéro que vous souhaitez afficher
            lbl.Location = new Point(btn.Left, btn.Bottom - lbl.Height);
            lbl.ForeColor = Color.Green; // Couleur du texte
            lbl.BackColor = Color.Transparent; // Fond transparent
            btn.Parent.Controls.Add(lbl);
            lbl.BringToFront();
            lbl.AutoSize = true;
            //
            AvailableMove();
            if (!canMove)
            {
                MessageBox.Show($"Le Cavalier ne peut plus bouger", "Bloqué", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if ((++deplacementNumber) == 64)
                MessageBox.Show($"Félicitations vous avez gagné", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AvailableMove()
        {
            int availableMove = 0;
            foreach (Button btn in board)
            {
                var (targetRow, targetCol) = ((int, int))btn.Tag;
                bool isValidMove = IsKnightMoveValid(currentRow, currentCol, targetRow, targetCol);
                if (!visited[targetRow, targetCol] && isValidMove)
                {
                    btn.Enabled = true;
                    availableMove++;
                    btn.FlatStyle = FlatStyle.Flat; // Définit le style du bouton à 'Flat'
                    btn.FlatAppearance.BorderSize = 2; // Ajoute une bordure épaisse
                    btn.FlatAppearance.BorderColor = Color.LightBlue; // Change la couleur de la bordure

                }
                else
                {
                    btn.Enabled = false;
                    btn.FlatAppearance.BorderSize = 0;
                }

            }
            if (availableMove <= 0) canMove = false;
        }
        private bool IsKnightMoveValid(int currentRow, int currentCol, int targetRow, int targetCol)
        {
            // Calculer le déplacement du cavalier (ex : 2 cases en L)
            int rowMove = Math.Abs(targetRow - currentRow);
            int colMove = Math.Abs(targetCol - currentCol);
            return (rowMove == 2 && colMove == 1) || (rowMove == 1 && colMove == 2);
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if (lastMoves.Count > 0)
            {
                visited[currentRow, currentCol] = false;
                board[currentRow, currentCol].Image = null;
                lastMoves.Pop(); //enlever le dernier coup de la liste

                // il se peut que la pile soit vide aprés le retrait
                if (lastMoves.Count > 0)
                {
                    (currentRow, currentCol) = lastMoves.Peek(); //recuperer maintenant l'avant dernier comme coup actuel 
                }
                AvailableMove();
                deplacementNumber--;
                // Enlever le label associé au dernier mouvement
                foreach (Control control in board[currentRow, currentCol].Parent.Controls)
                {
                    if (control is Label lbl && lbl.Text == deplacementNumber.ToString())
                    {
                        board[currentRow, currentCol].Parent.Controls.Remove(lbl);
                        lbl.Dispose();
                        break;
                    }
                }
                //label1.Text = $"il vous reste {undo} annulations possible !";
                if (--undo <= 0)
                {
                    label1.Text = "nombre maximum d'annulations atteints";
                    label1.ForeColor = Color.Red;
                    Redo.Enabled = false;
                }
                label1.Text = $"il vous reste {undo} annulations possible !";

            }
        }
        private void Save_Click(int row, int col)
        {

            if (lastMoves.Count == authorizeUndo)
            {
                //reverse la pile et retirr l'element le plus ancien
                List<(int, int)> tempList = lastMoves.Reverse().ToList();
                tempList.RemoveAt(0);
                lastMoves = new Stack<(int row, int col)>(tempList.AsEnumerable().Reverse());
            }
            lastMoves.Push((row, col));
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Règles du Jeu :\n\nLe but du jeu est de déplacer le cavalier sur un échiquier de façon à ce qu'il visite chaque case une seule fois.\n\nRègles :\n- Le cavalier se déplace en 'L' : deux cases dans une direction (horizontalement ou verticalement) et ensuite une case perpendiculaire, ou une case dans une direction puis deux cases perpendiculaires.\n- Le joueur doit éviter de repasser sur une case déjà visitée.\n\nBonne chance !", "Règles du Jeu");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auteur :\n Alioune BALDE.\nVersion :\n1.0.0\nDate:\n 10 Octobre 2024", "A Propos");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/aliounebalde");

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La fonctionnalité Settings sera ajouté dans la prochaine version\n Veuillez nous excuser du désagrément", "Info Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            foreach (Button btn in board)
            {
                btn.Image = null; // Retirer toutes les images du cavalier
                btn.Enabled = true; // Rendre toutes les cases cliquables
            }
            // Réinitialiser toutes les variables du jeu
            Array.Clear(visited, 0, visited.Length); // Réinitialiser le tableau des cases visitées
            lastMoves.Clear();
            currentRow = 0;
            currentCol = 0;
            deplacementNumber = 1;
            canMove = true;

            // Réinitialiser l'interface
            undo = authorizeUndo;
            Redo.Enabled = true;

            foreach (Button btn in board)
            {
                foreach (Control control in btn.Parent.Controls)
                {
                    if (control is Label lbl)
                    {
                        btn.Parent.Controls.Remove(lbl);
                        lbl.Dispose();
                        break;
                    }
                }

            }
            

            MessageBox.Show("La partie a été réinitialisée. Bonne chance !", "Recommencer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
