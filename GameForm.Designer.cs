namespace JentyTestApp
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.fieldPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameControlPanel = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nextBlockPanel16 = new System.Windows.Forms.Panel();
            this.nextBlockPanel15 = new System.Windows.Forms.Panel();
            this.nextBlockPanel14 = new System.Windows.Forms.Panel();
            this.nextBlockPanel13 = new System.Windows.Forms.Panel();
            this.nextBlockPanel12 = new System.Windows.Forms.Panel();
            this.nextBlockPanel11 = new System.Windows.Forms.Panel();
            this.nextBlockPanel10 = new System.Windows.Forms.Panel();
            this.nextBlockPanel9 = new System.Windows.Forms.Panel();
            this.nextBlockPanel8 = new System.Windows.Forms.Panel();
            this.nextBlockPanel7 = new System.Windows.Forms.Panel();
            this.nextBlockPanel6 = new System.Windows.Forms.Panel();
            this.nextBlockPanel5 = new System.Windows.Forms.Panel();
            this.nextBlockPanel4 = new System.Windows.Forms.Panel();
            this.nextBlockPanel3 = new System.Windows.Forms.Panel();
            this.nextBlockPanel2 = new System.Windows.Forms.Panel();
            this.nextBlockPanel1 = new System.Windows.Forms.Panel();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.addBlockBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.constructorBtn16 = new System.Windows.Forms.Button();
            this.constructorBtn15 = new System.Windows.Forms.Button();
            this.constructorBtn14 = new System.Windows.Forms.Button();
            this.constructorBtn13 = new System.Windows.Forms.Button();
            this.constructorBtn12 = new System.Windows.Forms.Button();
            this.constructorBtn11 = new System.Windows.Forms.Button();
            this.constructorBtn10 = new System.Windows.Forms.Button();
            this.constructorBtn9 = new System.Windows.Forms.Button();
            this.constructorBtn8 = new System.Windows.Forms.Button();
            this.constructorBtn7 = new System.Windows.Forms.Button();
            this.constructorBtn6 = new System.Windows.Forms.Button();
            this.constructorBtn5 = new System.Windows.Forms.Button();
            this.constructorBtn4 = new System.Windows.Forms.Button();
            this.constructorBtn3 = new System.Windows.Forms.Button();
            this.constructorBtn2 = new System.Windows.Forms.Button();
            this.constructorBtn1 = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.fieldPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameControlPanel)).BeginInit();
            this.gameControlPanel.Panel1.SuspendLayout();
            this.gameControlPanel.Panel2.SuspendLayout();
            this.gameControlPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldPictureBox
            // 
            this.fieldPictureBox.Location = new System.Drawing.Point(3, 3);
            this.fieldPictureBox.Name = "fieldPictureBox";
            this.fieldPictureBox.Size = new System.Drawing.Size(424, 523);
            this.fieldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fieldPictureBox.TabIndex = 0;
            this.fieldPictureBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 500;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // gameControlPanel
            // 
            this.gameControlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.gameControlPanel.Location = new System.Drawing.Point(433, 3);
            this.gameControlPanel.Name = "gameControlPanel";
            this.gameControlPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.AutoSize = true;
            // 
            // gameControlPanel.Panel1
            // 
            this.gameControlPanel.Panel1.Controls.Add(this.label1);
            this.gameControlPanel.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.AutoSize = true;
            // 
            // gameControlPanel.Panel2
            // 
            this.gameControlPanel.Panel2.Controls.Add(this.startGameBtn);
            this.gameControlPanel.Panel2.Controls.Add(this.addBlockBtn);
            this.gameControlPanel.Panel2.Controls.Add(this.label2);
            this.gameControlPanel.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.gameControlPanel.Size = new System.Drawing.Size(252, 523);
            this.gameControlPanel.SplitterDistance = 195;
            this.gameControlPanel.TabIndex = 1;
            this.gameControlPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameControlPanel_KeyDown);
            this.AutoSize = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next Block";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextBlockPanel1, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nextBlockPanel16
            // 
            this.nextBlockPanel16.Location = new System.Drawing.Point(155, 107);
            this.nextBlockPanel16.Name = "nextBlockPanel16";
            this.nextBlockPanel16.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel16.TabIndex = 12;
            // 
            // nextBlockPanel15
            // 
            this.nextBlockPanel15.Location = new System.Drawing.Point(105, 107);
            this.nextBlockPanel15.Name = "nextBlockPanel15";
            this.nextBlockPanel15.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel15.TabIndex = 11;
            // 
            // nextBlockPanel14
            // 
            this.nextBlockPanel14.Location = new System.Drawing.Point(55, 107);
            this.nextBlockPanel14.Name = "nextBlockPanel14";
            this.nextBlockPanel14.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel14.TabIndex = 10;
            // 
            // nextBlockPanel13
            // 
            this.nextBlockPanel13.Location = new System.Drawing.Point(5, 107);
            this.nextBlockPanel13.Name = "nextBlockPanel13";
            this.nextBlockPanel13.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel13.TabIndex = 9;
            // 
            // nextBlockPanel12
            // 
            this.nextBlockPanel12.Location = new System.Drawing.Point(155, 73);
            this.nextBlockPanel12.Name = "nextBlockPanel12";
            this.nextBlockPanel12.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel12.TabIndex = 8;
            // 
            // nextBlockPanel11
            // 
            this.nextBlockPanel11.Location = new System.Drawing.Point(105, 73);
            this.nextBlockPanel11.Name = "nextBlockPanel11";
            this.nextBlockPanel11.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel11.TabIndex = 7;
            // 
            // nextBlockPanel10
            // 
            this.nextBlockPanel10.Location = new System.Drawing.Point(55, 73);
            this.nextBlockPanel10.Name = "nextBlockPanel10";
            this.nextBlockPanel10.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel10.TabIndex = 6;
            // 
            // nextBlockPanel9
            // 
            this.nextBlockPanel9.Location = new System.Drawing.Point(5, 73);
            this.nextBlockPanel9.Name = "nextBlockPanel9";
            this.nextBlockPanel9.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel9.TabIndex = 5;
            // 
            // nextBlockPanel8
            // 
            this.nextBlockPanel8.Location = new System.Drawing.Point(155, 39);
            this.nextBlockPanel8.Name = "nextBlockPanel8";
            this.nextBlockPanel8.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel8.TabIndex = 4;
            // 
            // nextBlockPanel7
            // 
            this.nextBlockPanel7.Location = new System.Drawing.Point(105, 39);
            this.nextBlockPanel7.Name = "nextBlockPanel7";
            this.nextBlockPanel7.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel7.TabIndex = 3;
            // 
            // nextBlockPanel6
            // 
            this.nextBlockPanel6.Location = new System.Drawing.Point(55, 39);
            this.nextBlockPanel6.Name = "nextBlockPanel6";
            this.nextBlockPanel6.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel6.TabIndex = 1;
            // 
            // nextBlockPanel5
            // 
            this.nextBlockPanel5.Location = new System.Drawing.Point(5, 39);
            this.nextBlockPanel5.Name = "nextBlockPanel5";
            this.nextBlockPanel5.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel5.TabIndex = 1;
            // 
            // nextBlockPanel4
            // 
            this.nextBlockPanel4.Location = new System.Drawing.Point(155, 5);
            this.nextBlockPanel4.Name = "nextBlockPanel4";
            this.nextBlockPanel4.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel4.TabIndex = 2;
            // 
            // nextBlockPanel3
            // 
            this.nextBlockPanel3.Location = new System.Drawing.Point(105, 5);
            this.nextBlockPanel3.Name = "nextBlockPanel3";
            this.nextBlockPanel3.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel3.TabIndex = 1;
            // 
            // nextBlockPanel2
            // 
            this.nextBlockPanel2.Location = new System.Drawing.Point(55, 5);
            this.nextBlockPanel2.Name = "nextBlockPanel2";
            this.nextBlockPanel2.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel2.TabIndex = 1;
            // 
            // nextBlockPanel1
            // 
            this.nextBlockPanel1.Location = new System.Drawing.Point(5, 5);
            this.nextBlockPanel1.Name = "nextBlockPanel1";
            this.nextBlockPanel1.Size = new System.Drawing.Size(42, 26);
            this.nextBlockPanel1.TabIndex = 0;
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startGameBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startGameBtn.Location = new System.Drawing.Point(47, 261);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(160, 43);
            this.startGameBtn.TabIndex = 4;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // addBlockBtn
            // 
            this.addBlockBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBlockBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addBlockBtn.Location = new System.Drawing.Point(47, 212);
            this.addBlockBtn.Name = "addBlockBtn";
            this.addBlockBtn.Size = new System.Drawing.Size(160, 43);
            this.addBlockBtn.TabIndex = 3;
            this.addBlockBtn.Text = "Add Block to Game";
            this.addBlockBtn.UseVisualStyleBackColor = false;
            this.addBlockBtn.Click += new System.EventHandler(this.AddBlockBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Block Constructor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn16, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn15, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn14, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn12, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn11, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.constructorBtn1, 0, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(202, 154);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // constructorBtn16
            // 
            this.constructorBtn16.BackColor = System.Drawing.Color.Black;
            this.constructorBtn16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn16.Location = new System.Drawing.Point(152, 116);
            this.constructorBtn16.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn16.Name = "constructorBtn16";
            this.constructorBtn16.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn16.TabIndex = 15;
            this.constructorBtn16.UseVisualStyleBackColor = false;
            this.constructorBtn16.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn15
            // 
            this.constructorBtn15.BackColor = System.Drawing.Color.Black;
            this.constructorBtn15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn15.Location = new System.Drawing.Point(102, 116);
            this.constructorBtn15.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn15.Name = "constructorBtn15";
            this.constructorBtn15.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn15.TabIndex = 14;
            this.constructorBtn15.UseVisualStyleBackColor = false;
            this.constructorBtn15.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn14
            // 
            this.constructorBtn14.BackColor = System.Drawing.Color.Black;
            this.constructorBtn14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn14.Location = new System.Drawing.Point(52, 116);
            this.constructorBtn14.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn14.Name = "constructorBtn14";
            this.constructorBtn14.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn14.TabIndex = 13;
            this.constructorBtn14.UseVisualStyleBackColor = false;
            this.constructorBtn14.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn13
            // 
            this.constructorBtn13.BackColor = System.Drawing.Color.Black;
            this.constructorBtn13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn13.Location = new System.Drawing.Point(2, 116);
            this.constructorBtn13.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn13.Name = "constructorBtn13";
            this.constructorBtn13.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn13.TabIndex = 12;
            this.constructorBtn13.UseVisualStyleBackColor = false;
            this.constructorBtn13.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn12
            // 
            this.constructorBtn12.BackColor = System.Drawing.Color.Black;
            this.constructorBtn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn12.Location = new System.Drawing.Point(152, 78);
            this.constructorBtn12.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn12.Name = "constructorBtn12";
            this.constructorBtn12.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn12.TabIndex = 11;
            this.constructorBtn12.UseVisualStyleBackColor = false;
            this.constructorBtn12.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn11
            // 
            this.constructorBtn11.BackColor = System.Drawing.Color.Black;
            this.constructorBtn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn11.Location = new System.Drawing.Point(102, 78);
            this.constructorBtn11.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn11.Name = "constructorBtn11";
            this.constructorBtn11.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn11.TabIndex = 10;
            this.constructorBtn11.UseVisualStyleBackColor = false;
            this.constructorBtn11.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn10
            // 
            this.constructorBtn10.BackColor = System.Drawing.Color.Black;
            this.constructorBtn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn10.Location = new System.Drawing.Point(52, 78);
            this.constructorBtn10.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn10.Name = "constructorBtn10";
            this.constructorBtn10.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn10.TabIndex = 9;
            this.constructorBtn10.UseVisualStyleBackColor = false;
            this.constructorBtn10.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn9
            // 
            this.constructorBtn9.BackColor = System.Drawing.Color.Black;
            this.constructorBtn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn9.Location = new System.Drawing.Point(2, 78);
            this.constructorBtn9.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn9.Name = "constructorBtn9";
            this.constructorBtn9.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn9.TabIndex = 8;
            this.constructorBtn9.UseVisualStyleBackColor = false;
            this.constructorBtn9.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn8
            // 
            this.constructorBtn8.BackColor = System.Drawing.Color.Black;
            this.constructorBtn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn8.Location = new System.Drawing.Point(152, 40);
            this.constructorBtn8.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn8.Name = "constructorBtn8";
            this.constructorBtn8.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn8.TabIndex = 7;
            this.constructorBtn8.UseVisualStyleBackColor = false;
            this.constructorBtn8.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn7
            // 
            this.constructorBtn7.BackColor = System.Drawing.Color.Black;
            this.constructorBtn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn7.Location = new System.Drawing.Point(102, 40);
            this.constructorBtn7.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn7.Name = "constructorBtn7";
            this.constructorBtn7.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn7.TabIndex = 6;
            this.constructorBtn7.UseVisualStyleBackColor = false;
            this.constructorBtn7.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn6
            // 
            this.constructorBtn6.BackColor = System.Drawing.Color.Black;
            this.constructorBtn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn6.Location = new System.Drawing.Point(52, 40);
            this.constructorBtn6.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn6.Name = "constructorBtn6";
            this.constructorBtn6.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn6.TabIndex = 5;
            this.constructorBtn6.UseVisualStyleBackColor = false;
            this.constructorBtn6.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn5
            // 
            this.constructorBtn5.BackColor = System.Drawing.Color.Black;
            this.constructorBtn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn5.Location = new System.Drawing.Point(2, 40);
            this.constructorBtn5.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn5.Name = "constructorBtn5";
            this.constructorBtn5.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn5.TabIndex = 4;
            this.constructorBtn5.UseVisualStyleBackColor = false;
            this.constructorBtn5.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn4
            // 
            this.constructorBtn4.BackColor = System.Drawing.Color.Black;
            this.constructorBtn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn4.Location = new System.Drawing.Point(152, 2);
            this.constructorBtn4.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn4.Name = "constructorBtn4";
            this.constructorBtn4.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn4.TabIndex = 3;
            this.constructorBtn4.UseVisualStyleBackColor = false;
            this.constructorBtn4.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn3
            // 
            this.constructorBtn3.BackColor = System.Drawing.Color.Black;
            this.constructorBtn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn3.Location = new System.Drawing.Point(102, 2);
            this.constructorBtn3.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn3.Name = "constructorBtn3";
            this.constructorBtn3.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn3.TabIndex = 2;
            this.constructorBtn3.UseVisualStyleBackColor = false;
            this.constructorBtn3.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn2
            // 
            this.constructorBtn2.BackColor = System.Drawing.Color.Black;
            this.constructorBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn2.Location = new System.Drawing.Point(52, 2);
            this.constructorBtn2.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn2.Name = "constructorBtn2";
            this.constructorBtn2.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn2.TabIndex = 1;
            this.constructorBtn2.UseVisualStyleBackColor = false;
            this.constructorBtn2.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // constructorBtn1
            // 
            this.constructorBtn1.BackColor = System.Drawing.Color.Black;
            this.constructorBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorBtn1.ForeColor = System.Drawing.Color.Black;
            this.constructorBtn1.Location = new System.Drawing.Point(2, 2);
            this.constructorBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.constructorBtn1.Name = "constructorBtn1";
            this.constructorBtn1.Size = new System.Drawing.Size(48, 36);
            this.constructorBtn1.TabIndex = 0;
            this.constructorBtn1.UseVisualStyleBackColor = false;
            this.constructorBtn1.Click += new System.EventHandler(this.ConstructorBtn_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.AutoSize = true;
            this.gamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamePanel.Controls.Add(this.fieldPictureBox);
            this.gamePanel.Controls.Add(this.gameControlPanel);
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(688, 529);
            this.gamePanel.TabIndex = 2;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(710, 553);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Game Form";
            ((System.ComponentModel.ISupportInitialize)(this.fieldPictureBox)).EndInit();
            this.gameControlPanel.Panel1.ResumeLayout(false);
            this.gameControlPanel.Panel1.PerformLayout();
            this.gameControlPanel.Panel2.ResumeLayout(false);
            this.gameControlPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameControlPanel)).EndInit();
            this.gameControlPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox fieldPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private SplitContainer gameControlPanel;
        private FlowLayoutPanel gamePanel;
        private Label label1;
        private Button addBlockBtn;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button constructorBtn16;
        private Button constructorBtn15;
        private Button constructorBtn14;
        private Button constructorBtn13;
        private Button constructorBtn12;
        private Button constructorBtn11;
        private Button constructorBtn10;
        private Button constructorBtn9;
        private Button constructorBtn8;
        private Button constructorBtn7;
        private Button constructorBtn6;
        private Button constructorBtn5;
        private Button constructorBtn4;
        private Button constructorBtn3;
        private Button constructorBtn2;
        private Button constructorBtn1;
        private Button startGameBtn;
        private Panel nextBlockPanel16;
        private Panel nextBlockPanel15;
        private Panel nextBlockPanel14;
        private Panel nextBlockPanel13;
        private Panel nextBlockPanel12;
        private Panel nextBlockPanel11;
        private Panel nextBlockPanel10;
        private Panel nextBlockPanel9;
        private Panel nextBlockPanel8;
        private Panel nextBlockPanel7;
        private Panel nextBlockPanel6;
        private Panel nextBlockPanel5;
        private Panel nextBlockPanel4;
        private Panel nextBlockPanel3;
        private Panel nextBlockPanel2;
        private Panel nextBlockPanel1;
    }
}