namespace PLWinFormHS
{
    partial class UpdateHighScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            updateHighScoreButton = new Button();
            scoreInput = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gameComboBox = new ComboBox();
            gameIndexBindingSource = new BindingSource(components);
            playerComboBox = new ComboBox();
            playerIndexBindingSource = new BindingSource(components);
            playerLabel = new Label();
            gameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)scoreInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).BeginInit();
            SuspendLayout();
            // 
            // updateHighScoreButton
            // 
            updateHighScoreButton.Location = new Point(129, 210);
            updateHighScoreButton.Name = "updateHighScoreButton";
            updateHighScoreButton.Size = new Size(75, 23);
            updateHighScoreButton.TabIndex = 14;
            updateHighScoreButton.Text = "Update";
            updateHighScoreButton.UseVisualStyleBackColor = true;
            updateHighScoreButton.Click += updateHighScoreButton_Click;
            // 
            // scoreInput
            // 
            scoreInput.Location = new Point(164, 151);
            scoreInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            scoreInput.Name = "scoreInput";
            scoreInput.Size = new Size(155, 23);
            scoreInput.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 153);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "Game";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Player";
            // 
            // gameComboBox
            // 
            gameComboBox.DataSource = gameIndexBindingSource;
            gameComboBox.FormattingEnabled = true;
            gameComboBox.Location = new Point(46, 103);
            gameComboBox.Name = "gameComboBox";
            gameComboBox.Size = new Size(274, 23);
            gameComboBox.TabIndex = 9;
            // 
            // gameIndexBindingSource
            // 
            gameIndexBindingSource.DataSource = typeof(DTOsHS.GameIndex);
            // 
            // playerComboBox
            // 
            playerComboBox.DataSource = playerIndexBindingSource;
            playerComboBox.FormattingEnabled = true;
            playerComboBox.Location = new Point(45, 48);
            playerComboBox.Name = "playerComboBox";
            playerComboBox.Size = new Size(274, 23);
            playerComboBox.TabIndex = 8;
            // 
            // playerIndexBindingSource
            // 
            playerIndexBindingSource.DataSource = typeof(DTOsHS.PlayerIndex);
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Location = new Point(46, 51);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(0, 15);
            playerLabel.TabIndex = 15;
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Location = new Point(46, 103);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(0, 15);
            gameLabel.TabIndex = 16;
            // 
            // UpdateHighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 284);
            Controls.Add(gameLabel);
            Controls.Add(playerLabel);
            Controls.Add(updateHighScoreButton);
            Controls.Add(scoreInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gameComboBox);
            Controls.Add(playerComboBox);
            Name = "UpdateHighScoreForm";
            Text = "UpdateHighScoreFormcs";
            ((System.ComponentModel.ISupportInitialize)scoreInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateHighScoreButton;
        private NumericUpDown scoreInput;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox gameComboBox;
        private ComboBox playerComboBox;
        private BindingSource gameIndexBindingSource;
        private BindingSource playerIndexBindingSource;
        private Label playerLabel;
        private Label gameLabel;
    }
}