namespace PLWinFormHS
{
    partial class UpdateGameForm
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
            updateGameButton = new Button();
            releaseDateInput = new DateTimePicker();
            notesInput = new TextBox();
            publisherInput = new TextBox();
            titleInput = new TextBox();
            notesLabel = new Label();
            releaseDateLabel = new Label();
            publisherLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // updateGameButton
            // 
            updateGameButton.Location = new Point(71, 190);
            updateGameButton.Name = "updateGameButton";
            updateGameButton.Size = new Size(359, 23);
            updateGameButton.TabIndex = 31;
            updateGameButton.Text = "Update Game";
            updateGameButton.UseVisualStyleBackColor = true;
            updateGameButton.Click += updateGameButton_Click;
            // 
            // releaseDateInput
            // 
            releaseDateInput.Location = new Point(230, 110);
            releaseDateInput.Name = "releaseDateInput";
            releaseDateInput.Size = new Size(200, 23);
            releaseDateInput.TabIndex = 30;
            // 
            // notesInput
            // 
            notesInput.Location = new Point(230, 142);
            notesInput.Name = "notesInput";
            notesInput.Size = new Size(200, 23);
            notesInput.TabIndex = 29;
            // 
            // publisherInput
            // 
            publisherInput.Location = new Point(230, 73);
            publisherInput.Name = "publisherInput";
            publisherInput.Size = new Size(200, 23);
            publisherInput.TabIndex = 28;
            // 
            // titleInput
            // 
            titleInput.Location = new Point(230, 44);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(200, 23);
            titleInput.TabIndex = 27;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(71, 150);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(38, 15);
            notesLabel.TabIndex = 26;
            notesLabel.Text = "Notes";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new Point(71, 116);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(70, 15);
            releaseDateLabel.TabIndex = 25;
            releaseDateLabel.Text = "ReleaseDate";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new Point(71, 76);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(56, 15);
            publisherLabel.TabIndex = 24;
            publisherLabel.Text = "Publisher";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(71, 47);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(29, 15);
            titleLabel.TabIndex = 23;
            titleLabel.Text = "Title";
            // 
            // UpdateGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 283);
            Controls.Add(updateGameButton);
            Controls.Add(releaseDateInput);
            Controls.Add(notesInput);
            Controls.Add(publisherInput);
            Controls.Add(titleInput);
            Controls.Add(notesLabel);
            Controls.Add(releaseDateLabel);
            Controls.Add(publisherLabel);
            Controls.Add(titleLabel);
            Name = "UpdateGameForm";
            Text = "UpdateGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateGameButton;
        private DateTimePicker releaseDateInput;
        private TextBox notesInput;
        private TextBox publisherInput;
        private TextBox titleInput;
        private Label notesLabel;
        private Label releaseDateLabel;
        private Label publisherLabel;
        private Label titleLabel;
    }
}