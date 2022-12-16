namespace JentyTestApp
{
    public partial class GameForm : Form
    {
        private const int minimalWidth = 15, minimalHeight = 20,constructorMaxCellsCount = 8;
        private readonly Bitmap bitmapField;
        private readonly Graphics graphics;
        private readonly IList<int[,]> blockTypes;
        private readonly Random random;
        private readonly int cellSize;
        private int[,]? currentBlock, nextBlock, constructorBlock;
        private int[,] field = new int[minimalWidth,minimalHeight];
        private int blockTopLeftCornerX, blockTopLeftCornerY;
        private int constructorBlockCellsCount = 0;

        private int fieldWidth = minimalWidth;
        public int FieldWidth 
        {
            get { return fieldWidth; }
            set 
            { 
                if(value > minimalWidth)
                    fieldWidth = value;
                else
                    fieldWidth = minimalWidth;
            } 
        }

        private int fieldHeight = minimalHeight;
        public int FieldHeight
        {
            get { return fieldHeight; }
            set
            {
                if (value > minimalHeight)
                    fieldHeight = value;
                else
                    fieldHeight = minimalHeight;
            }
        }
        public GameForm()
        {
            FieldSizeForm fieldSizeForm = new()
            {
                Owner = this
            };
            fieldSizeForm.ShowDialog(this);

            blockTypes = new List<int[,]>()
            {
                new int[4, 4] { { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } },
                new int[4, 4] { { 0, 0, 0, 1 }, { 0, 0, 1, 1 }, { 0, 0, 0, 1 }, { 0, 0, 0, 0 } },
                new int[4, 4] { { 0, 1, 1, 1 }, { 0, 0, 0, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } },
                new int[4, 4] { { 0, 0, 1, 0 }, { 0, 0, 1, 1 }, { 0, 0, 0, 1 }, { 0, 0, 0, 0 } },
                new int[4, 4] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } }
            };
           
            if(FieldWidth > fieldHeight)
               cellSize = (int)(Screen.AllScreens[0].Bounds.Width / (1.25*FieldWidth));
            else
               cellSize =(int) (Screen.AllScreens[0].Bounds.Height / (1.25* FieldHeight));
            bitmapField = new Bitmap(cellSize * (FieldWidth)+1, cellSize * (FieldHeight)+1);
            graphics = Graphics.FromImage(bitmapField);
            random = new();
            
            InitializeComponent();
            this.Focus();
        }
        private void InitializeField()
        {
            field = new int[FieldWidth, FieldHeight];

            for (int i = 0; i < FieldWidth; i++)
                field[i, FieldHeight - 1] = 1;
            for (int i = 0; i < FieldHeight; i++)
            {
                field[0, i] = 1;
                field[FieldWidth - 1, i] = 1;
            }
        }
        private void DrawField()
        {
            if (currentBlock == null)
                return;

            ClearFullLines();

            graphics.Clear(Color.Black);
            for (int i = 0; i < FieldWidth; i++)
                for (int j = 0; j < FieldHeight; j++)
                    if (field[i, j] == 1)
                    {
                        graphics.FillRectangle(Brushes.Red, i * cellSize, j * cellSize, cellSize, cellSize);
                        graphics.DrawRectangle(Pens.Black, i * cellSize, j * cellSize, cellSize, cellSize);
                    }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (currentBlock[i, j] == 1)
                    {
                        graphics.FillRectangle(Brushes.Yellow, (blockTopLeftCornerX + i) * cellSize, (blockTopLeftCornerY + j) * cellSize, cellSize, cellSize);
                    }
                    graphics.DrawRectangle(Pens.Green, (blockTopLeftCornerX + i) * cellSize, (blockTopLeftCornerY + j) * cellSize, cellSize, cellSize);
                }
            }
            blockTopLeftCornerY++;
            fieldPictureBox.Image = bitmapField;
        }

        private void ClearFullLines()
        {
            for (int j = 0; j < FieldHeight - 1; j++)
            {
                bool lineIsFull = true;
                for (int i = 0; i < FieldWidth; i++)
                {
                    if (field[i, j] != 1)
                        lineIsFull = false;
                }
                if (lineIsFull)
                {
                    for (int i = 1; i < FieldWidth-1; i++)
                    {
                        field[i, j] = 0;
                        for (int j1 = j; j1 >0; j1--)
                        {
                            if (field[i, j1] == 1)
                            {
                                field[i, j1] = 0;
                                field[i, j1 + 1] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void GetCurrentBlock()
        {
            blockTopLeftCornerX = FieldWidth / 2 -4;
            blockTopLeftCornerY = 0;

            if(nextBlock==null)
                nextBlock = blockTypes[random.Next(blockTypes.Count)];

            currentBlock = nextBlock;
            UpdateNextBlock();
        }

        private void UpdateNextBlock()
        {
            nextBlock = blockTypes[random.Next(blockTypes.Count)];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var panel =  tableLayoutPanel1.GetControlFromPosition(i, j);
                    if (nextBlock[i, j] == 1)
                        panel.BackColor = Color.Yellow;
                    else
                        panel.BackColor = Color.Black;
                }
            }
        }

        private bool CheckBlockCrossing()
        {
            if (currentBlock == null)
                return false;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (currentBlock[i, j] == 1 
                            && (blockTopLeftCornerX + i >= FieldWidth  ||
                                blockTopLeftCornerY + j >= fieldHeight ||
                                blockTopLeftCornerX +i < 0 ||
                                blockTopLeftCornerY +j < 0 ||
                                field[blockTopLeftCornerX + i, blockTopLeftCornerY + j] == 1))
                        return true;
                }
            }
            return false;
        }
        private void AddBlockBtn_Click(object sender, EventArgs e)
        {
            if (constructorBlock!= null && CheckIfConstructorBlockIsConsistent())
            {
                blockTypes.Add(constructorBlock);
                constructorBlock = null;
                foreach (Button btn in tableLayoutPanel2.Controls)
                {
                    btn.BackColor = Color.Black;
                }
                constructorBlockCellsCount = 0;
            }
            else
            {
                MessageBox.Show("Inconsistent block type");
            }
        }

        private bool CheckIfConstructorBlockIsConsistent()
        {
            if (constructorBlock == null)
                return false;

            bool isConsistent = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (constructorBlock[i, j] == 1)
                    {
                        if(!HasNeighbourAtPoint(i+1,j) && !HasNeighbourAtPoint(i-1, j) && 
                           !HasNeighbourAtPoint(i, j+1) && !HasNeighbourAtPoint(i, j-1))
                            isConsistent = false;
                    }
                }
            }
            return isConsistent;
        }

        private bool HasNeighbourAtPoint(int i, int j)
        {
            if (constructorBlock!= null && i >= 0 && j >= 0 && i < 4 && j < 4)
            {
                if (constructorBlock[i, j] == 1)
                    return true;
            }
            return false;
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            currentBlock = null;

            InitializeField();
            gameTimer.Start();
            addBlockBtn.Enabled = false;
            gamePanel.Focus();
            gameControlPanel.Focus();
        }

        private void ConstructorBtn_Click(object sender, EventArgs e)
        {
            if(constructorBlock==null)
                constructorBlock = new int[4, 4];
            Button button = (Button)sender;
            TableLayoutPanelCellPosition position = tableLayoutPanel2.GetPositionFromControl(button);
          
            if (button.BackColor == Color.Black)
            {
                if (constructorBlockCellsCount < constructorMaxCellsCount)
                {
                    button.BackColor = Color.Yellow;
                    constructorBlockCellsCount++;
                    constructorBlock[position.Row, position.Column] = 1;
                }
            }
            else
            {
                button.BackColor = Color.Black;
                constructorBlockCellsCount--;
                constructorBlock[position.Row, position.Column] = 0;
            }
        }

        private void GameControlPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentBlock == null)
                return;
            switch (e.KeyCode)
            {
                case Keys.A:
                    blockTopLeftCornerX--;
                    if (CheckBlockCrossing())
                        blockTopLeftCornerX++;
                    break;
                case Keys.D:
                    blockTopLeftCornerX++;
                    if (CheckBlockCrossing())
                        blockTopLeftCornerX--;
                    break;
                case Keys.S:
                    blockTopLeftCornerY++;
                    if (CheckBlockCrossing())
                        blockTopLeftCornerY--;
                    break;
                case Keys.W:
                    if (CheckIfRotationIsPossible())
                    {
                        var blockTransponation = new int[4, 4];
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                blockTransponation[j, i] = currentBlock[i, j];
                            }
                        }
                        Array.Copy(blockTransponation, currentBlock, currentBlock.Length);
                        if (CheckBlockCrossing())
                            blockTopLeftCornerY++;
                    }
                    break;
            }
        }

        private bool CheckIfRotationIsPossible()
        {
            bool isCrossingField = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (blockTopLeftCornerX + j < FieldWidth &&
                        blockTopLeftCornerY + i < FieldHeight &&
                        blockTopLeftCornerX + j > 0 &&
                        blockTopLeftCornerY + i > 0)
                    {
                        if (field[blockTopLeftCornerX + j, blockTopLeftCornerY + i] == 1)
                        {
                            isCrossingField = true;
                            break;
                        }
                    }
                    else
                    {
                        isCrossingField = true;
                    }
                }
            }
            return !isCrossingField;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (currentBlock == null)
                GetCurrentBlock();
            DrawField();
            if (CheckBlockCrossing())
            {
                if (blockTopLeftCornerY <= 1)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over");
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (currentBlock[i, j] == 1)
                            field[blockTopLeftCornerX + i, blockTopLeftCornerY + j-1] = 1;
                    }
                }
                currentBlock = null;
            }
            
        }
    }
}