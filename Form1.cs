using ChessBoardModel;

namespace ChessBoardGUIApp
{
    public partial class frmChessBoard : Form
    {

        public Board myBoard = new Board(8);
        public Button[,] myButtons = new Button[8, 8];

        public Color[] colourSet1 =
        {
            Color.FromArgb(240, 240, 250), Color.FromArgb(220, 220, 220), Color.FromArgb(180, 233, 180), Color.LightBlue
        };

        public Color[] colourSet2 =
        {
            Color.FromArgb(220, 200, 200), Color.FromArgb(180, 160, 160), Color.LightCoral, Color.MistyRose
        };

        public Color[] colourSet3 =
        {
            Color.FromArgb(180, 180, 180), Color.FromArgb(160, 160, 160), Color.Aqua, Color.MediumAquamarine
        };

        public frmChessBoard()
        {
            InitializeComponent();
            SetupButtons();
        }

        //Sets up all buttons on the board
        private void SetupButtons()
        {
            int buttonSize = pnlChessBoard.Width / myBoard.Size;
            pnlChessBoard.Height = pnlChessBoard.Width;

            for (int row = 0; row < myBoard.Size; row++)
            {
                for(int col = 0; col < myBoard.Size; col++)
                {
                    myButtons[row, col] = new Button();
                    myButtons[row, col].Width = buttonSize;
                    myButtons[row, col].Height = buttonSize;

                    myButtons[row, col].Left = buttonSize * row;
                    myButtons[row, col].Top = buttonSize * col;

                    myButtons[row, col].Click += GridButtons_Click;
                    myButtons[row, col].Tag = new Point(row, col);

                    myButtons[row, col].Text = row + "|" + col;

                    pnlChessBoard.Controls.Add(myButtons[row, col]);
                }
            }

        }

        //when cell is clicked on
        private void GridButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Point p = (Point)b.Tag;

            int row = p.X;
            int col = p.Y;

            MessageBox.Show("You clicked on Button " + row + "|" + col);

            String piece = comboPieceNames.Text;
            myBoard.MarkNextLegalMove(myBoard.theGrid[row,col], piece);
            updateButtonFaces(myBoard);
        }

        //Changes the text properties to the letters
        private void updateButtonFaces(Board myBoard)
        {
            //map for later reference to switch initials for words
           var pieceMap = new Dictionary<string, string>
           {
               {"N", "Knight" },
               {"P", "Pawn" },
               {"B", "Bishop" },
               {"R", "Rook" },
               {"K", "King" },
               {"Q", "Queen" }
           };

            for (int i = 0; i < myBoard.Size; i++)
            {
                for(int j = 0; j < myBoard.Size; j++)
                {
                    //clears all
                    myButtons[i, j].Text = " ";
                    
                    //changes text in place of legal next moves
                    if (myBoard.theGrid[i, j].isLegalNextMove)
                    {
                        myButtons[i, j].Text = "Legal Next Move";
                    }

                    if (myBoard.theGrid[i, j].isCurrentlyOccupied != "")
                    {
                        //Looks at map and switches initial for full text
                        myButtons[i, j].Text = pieceMap[myBoard.theGrid[i, j].isCurrentlyOccupied];
                    }

                    Color colour1 = colourSet1[0];
                    Color colour2 = colourSet1[1];
                    Color colour3 = colourSet1[2];
                    Color colour4 = colourSet1[3];

                    if (radioButton2.Checked)
                    {
                        colour1 = colourSet2[0];
                        colour2 = colourSet2[1];
                        colour3 = colourSet2[2];
                        colour4 = colourSet2[3];
                    }
                    if (radioButton3.Checked)
                    {
                        colour1 = colourSet3[0];
                        colour2 = colourSet3[1];
                        colour3 = colourSet3[2];
                        colour4 = colourSet3[3];
                    }


                    if (((i + j) % 2) == 1)
                    {
                        myButtons[i,j].BackColor = colour1;
                    }
                    else
                    {
                        myButtons[i, j].BackColor = colour2;
                    }

                    if (myBoard.theGrid[i, j].isCurrentlyOccupied != "")
                    {
                        myButtons[i, j].BackColor = colour3;
                    }
                    if (myBoard.theGrid[i, j].isLegalNextMove)
                    {
                        myButtons[i, j].BackColor = colour4;
                    }

                }
            }
        }
    }
}
