namespace PLWinFormHS
{
    partial class AddHighScoreForm
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
            comboBox1 = new ComboBox();
            playerIndexBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            gameIndexBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            scoreInput = new NumericUpDown();
            addHighScoreButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scoreInput).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DataSource = playerIndexBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(274, 23);
            comboBox1.TabIndex = 0;
            // 
            // playerIndexBindingSource
            // 
            playerIndexBindingSource.DataSource = typeof(DTOsHS.PlayerIndex);
            // 
            // comboBox2
            // 
            comboBox2.DataSource = gameIndexBindingSource;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(30, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(274, 23);
            comboBox2.TabIndex = 1;
            // 
            // gameIndexBindingSource
            // 
            gameIndexBindingSource.DataSource = typeof(DTOsHS.GameIndex);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 168);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Score";
            // 
            // scoreInput
            // 
            scoreInput.Location = new Point(149, 166);
            scoreInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            scoreInput.Name = "scoreInput";
            scoreInput.Size = new Size(155, 23);
            scoreInput.TabIndex = 6;
            // 
            // addHighScoreButton
            // 
            addHighScoreButton.Location = new Point(114, 225);
            addHighScoreButton.Name = "addHighScoreButton";
            addHighScoreButton.Size = new Size(75, 23);
            addHighScoreButton.TabIndex = 7;
            addHighScoreButton.Text = "Add";
            addHighScoreButton.UseVisualStyleBackColor = true;
            addHighScoreButton.Click += addHighScoreButton_Click;
            // 
            // AddHighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 355);
            Controls.Add(addHighScoreButton);
            Controls.Add(scoreInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "AddHighScoreForm";
            Text = "AddHighScoreForm";
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)scoreInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private BindingSource playerIndexBindingSource;
        private ComboBox comboBox2;
        private BindingSource gameIndexBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown scoreInput;
        private Button addHighScoreButton;
    }
}