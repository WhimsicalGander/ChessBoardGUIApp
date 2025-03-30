namespace ChessBoardGUIApp
{
    partial class frmChessBoard
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
            lblPieceName = new Label();
            comboPieceNames = new ComboBox();
            pnlChessBoard = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPieceName
            // 
            lblPieceName.AutoSize = true;
            lblPieceName.Location = new Point(702, 23);
            lblPieceName.Name = "lblPieceName";
            lblPieceName.Size = new Size(128, 25);
            lblPieceName.TabIndex = 0;
            lblPieceName.Text = "Pick Your Piece";
            // 
            // comboPieceNames
            // 
            comboPieceNames.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPieceNames.FormattingEnabled = true;
            comboPieceNames.Items.AddRange(new object[] { "Pawn", "Bishop", "Rook", "Knight", "Queen", "King" });
            comboPieceNames.Location = new Point(836, 23);
            comboPieceNames.Name = "comboPieceNames";
            comboPieceNames.Size = new Size(182, 33);
            comboPieceNames.TabIndex = 1;
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(129, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(500, 500);
            pnlChessBoard.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(820, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cool";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(820, 201);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Warm";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(820, 257);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 29);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Wild";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(836, 101);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 6;
            label1.Text = "Color Scheme";
            // 
            // frmChessBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pnlChessBoard);
            Controls.Add(comboPieceNames);
            Controls.Add(lblPieceName);
            Name = "frmChessBoard";
            Text = "Chess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPieceName;
        private ComboBox comboPieceNames;
        private Panel pnlChessBoard;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
    }
}
