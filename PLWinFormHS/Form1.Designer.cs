namespace PLWinFormHS
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            playerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            playerIndexBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            gameIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releaseDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameIndexBindingSource = new BindingSource(components);
            dataGridView4 = new DataGridView();
            gameIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            publisherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            highScoreGameIndexBindingSource = new BindingSource(components);
            highScoreIndexBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            scoreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            addPlayerButton = new Button();
            deletePlayerButton = new Button();
            addGameButton = new Button();
            deleteGameButton = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            saveButton = new Button();
            rollbackButton = new Button();
            playerDetailButton = new Button();
            gameDetailButton = new Button();
            highScoreDetailButton = new Button();
            highScoreGameDetailButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highScoreGameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highScoreIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { playerIdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, birthDayDataGridViewTextBoxColumn });
            dataGridView1.DataSource = playerIndexBindingSource;
            dataGridView1.Location = new Point(42, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(341, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            birthDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerIndexBindingSource
            // 
            playerIndexBindingSource.DataSource = typeof(DTOsHS.PlayerIndex);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, releaseDateDataGridViewTextBoxColumn });
            dataGridView2.DataSource = gameIndexBindingSource;
            dataGridView2.Location = new Point(652, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(341, 150);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            gameIdDataGridViewTextBoxColumn.DataPropertyName = "GameId";
            gameIdDataGridViewTextBoxColumn.HeaderText = "GameId";
            gameIdDataGridViewTextBoxColumn.Name = "gameIdDataGridViewTextBoxColumn";
            gameIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameIndexBindingSource
            // 
            gameIndexBindingSource.DataSource = typeof(DTOsHS.GameIndex);
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn1, publisherDataGridViewTextBoxColumn, scoreDataGridViewTextBoxColumn, createdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn1 });
            dataGridView4.DataSource = highScoreGameIndexBindingSource;
            dataGridView4.Location = new Point(652, 357);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.Size = new Size(341, 150);
            dataGridView4.TabIndex = 3;
            dataGridView4.CellDoubleClick += dataGridView4_CellDoubleClick;
            // 
            // gameIdDataGridViewTextBoxColumn1
            // 
            gameIdDataGridViewTextBoxColumn1.DataPropertyName = "GameId";
            gameIdDataGridViewTextBoxColumn1.HeaderText = "GameId";
            gameIdDataGridViewTextBoxColumn1.Name = "gameIdDataGridViewTextBoxColumn1";
            gameIdDataGridViewTextBoxColumn1.ReadOnly = true;
            gameIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            publisherDataGridViewTextBoxColumn.ReadOnly = true;
            publisherDataGridViewTextBoxColumn.Visible = false;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            createdDataGridViewTextBoxColumn.HeaderText = "Created";
            createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // highScoreGameIndexBindingSource
            // 
            highScoreGameIndexBindingSource.DataSource = typeof(DTOsHS.HighScoreGameIndex);
            // 
            // highScoreIndexBindingSource
            // 
            highScoreIndexBindingSource.DataSource = typeof(DTOsHS.HighScoreIndex);
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { scoreDataGridViewTextBoxColumn1, createdDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = highScoreIndexBindingSource;
            dataGridView3.Location = new Point(42, 357);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(341, 150);
            dataGridView3.TabIndex = 4;
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
            // 
            // scoreDataGridViewTextBoxColumn1
            // 
            scoreDataGridViewTextBoxColumn1.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn1.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn1.Name = "scoreDataGridViewTextBoxColumn1";
            scoreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn1
            // 
            createdDataGridViewTextBoxColumn1.DataPropertyName = "Created";
            createdDataGridViewTextBoxColumn1.HeaderText = "Created";
            createdDataGridViewTextBoxColumn1.Name = "createdDataGridViewTextBoxColumn1";
            createdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addPlayerButton
            // 
            addPlayerButton.Location = new Point(42, 195);
            addPlayerButton.Name = "addPlayerButton";
            addPlayerButton.Size = new Size(75, 23);
            addPlayerButton.TabIndex = 5;
            addPlayerButton.Text = "Add";
            addPlayerButton.UseVisualStyleBackColor = true;
            addPlayerButton.Click += addPlayerButton_Click;
            // 
            // deletePlayerButton
            // 
            deletePlayerButton.Location = new Point(123, 195);
            deletePlayerButton.Name = "deletePlayerButton";
            deletePlayerButton.Size = new Size(75, 23);
            deletePlayerButton.TabIndex = 6;
            deletePlayerButton.Text = "Remove";
            deletePlayerButton.UseVisualStyleBackColor = true;
            deletePlayerButton.Click += deletePlayerButton_Click;
            // 
            // addGameButton
            // 
            addGameButton.Location = new Point(652, 195);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(75, 23);
            addGameButton.TabIndex = 7;
            addGameButton.Text = "Add";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += addGameButton_Click;
            // 
            // deleteGameButton
            // 
            deleteGameButton.Location = new Point(733, 195);
            deleteGameButton.Name = "deleteGameButton";
            deleteGameButton.Size = new Size(75, 23);
            deleteGameButton.TabIndex = 8;
            deleteGameButton.Text = "Remove";
            deleteGameButton.UseVisualStyleBackColor = true;
            deleteGameButton.Click += deleteGameButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 513);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(123, 513);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(733, 513);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Remove";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(652, 513);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(473, 238);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(95, 36);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // rollbackButton
            // 
            rollbackButton.Location = new Point(473, 280);
            rollbackButton.Name = "rollbackButton";
            rollbackButton.Size = new Size(95, 31);
            rollbackButton.TabIndex = 14;
            rollbackButton.Text = "Rollback";
            rollbackButton.UseVisualStyleBackColor = true;
            rollbackButton.Click += rollbackButton_Click;
            // 
            // playerDetailButton
            // 
            playerDetailButton.Location = new Point(308, 195);
            playerDetailButton.Name = "playerDetailButton";
            playerDetailButton.Size = new Size(75, 23);
            playerDetailButton.TabIndex = 15;
            playerDetailButton.Text = "Details";
            playerDetailButton.UseVisualStyleBackColor = true;
            playerDetailButton.Click += playerDetailButton_Click;
            // 
            // gameDetailButton
            // 
            gameDetailButton.Location = new Point(918, 195);
            gameDetailButton.Name = "gameDetailButton";
            gameDetailButton.Size = new Size(75, 23);
            gameDetailButton.TabIndex = 16;
            gameDetailButton.Text = "Details";
            gameDetailButton.UseVisualStyleBackColor = true;
            gameDetailButton.Click += gameDetailButton_Click;
            // 
            // highScoreDetailButton
            // 
            highScoreDetailButton.Location = new Point(308, 513);
            highScoreDetailButton.Name = "highScoreDetailButton";
            highScoreDetailButton.Size = new Size(75, 23);
            highScoreDetailButton.TabIndex = 17;
            highScoreDetailButton.Text = "Details";
            highScoreDetailButton.UseVisualStyleBackColor = true;
            highScoreDetailButton.Click += highScoreDetailButton_Click;
            // 
            // highScoreGameDetailButton
            // 
            highScoreGameDetailButton.Location = new Point(918, 513);
            highScoreGameDetailButton.Name = "highScoreGameDetailButton";
            highScoreGameDetailButton.Size = new Size(75, 23);
            highScoreGameDetailButton.TabIndex = 18;
            highScoreGameDetailButton.Text = "Details";
            highScoreGameDetailButton.UseVisualStyleBackColor = true;
            highScoreGameDetailButton.Click += highScoreGameDetailButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 561);
            Controls.Add(highScoreGameDetailButton);
            Controls.Add(highScoreDetailButton);
            Controls.Add(gameDetailButton);
            Controls.Add(playerDetailButton);
            Controls.Add(rollbackButton);
            Controls.Add(saveButton);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(deleteGameButton);
            Controls.Add(addGameButton);
            Controls.Add(deletePlayerButton);
            Controls.Add(addPlayerButton);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)highScoreGameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)highScoreIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private BindingSource playerIndexBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private BindingSource gameIndexBindingSource;
        private DataGridView dataGridView4;
        private BindingSource highScoreIndexBindingSource;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn1;
        private Button addPlayerButton;
        private Button deletePlayerButton;
        private Button addGameButton;
        private Button deleteGameButton;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button saveButton;
        private Button rollbackButton;
        private BindingSource highScoreGameIndexBindingSource;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private Button playerDetailButton;
        private Button gameDetailButton;
        private Button highScoreDetailButton;
        private Button highScoreGameDetailButton;
    }
}
