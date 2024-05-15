namespace PLWinFormHS
{
    partial class AddGameForm
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
            addGameButton = new Button();
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
            // addGameButton
            // 
            addGameButton.Location = new Point(78, 295);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(359, 23);
            addGameButton.TabIndex = 22;
            addGameButton.Text = "Add Game";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += addGameButton_Click;
            // 
            // releaseDateInput
            // 
            releaseDateInput.Location = new Point(237, 215);
            releaseDateInput.Name = "releaseDateInput";
            releaseDateInput.Size = new Size(200, 23);
            releaseDateInput.TabIndex = 21;
            // 
            // notesInput
            // 
            notesInput.Location = new Point(237, 247);
            notesInput.Name = "notesInput";
            notesInput.Size = new Size(200, 23);
            notesInput.TabIndex = 19;
            // 
            // publisherInput
            // 
            publisherInput.Location = new Point(237, 178);
            publisherInput.Name = "publisherInput";
            publisherInput.Size = new Size(200, 23);
            publisherInput.TabIndex = 18;
            // 
            // titleInput
            // 
            titleInput.Location = new Point(237, 149);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(200, 23);
            titleInput.TabIndex = 17;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(78, 255);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(38, 15);
            notesLabel.TabIndex = 15;
            notesLabel.Text = "Notes";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new Point(78, 221);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(70, 15);
            releaseDateLabel.TabIndex = 14;
            releaseDateLabel.Text = "ReleaseDate";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new Point(78, 181);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(56, 15);
            publisherLabel.TabIndex = 13;
            publisherLabel.Text = "Publisher";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(78, 152);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(29, 15);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Title";
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 538);
            Controls.Add(addGameButton);
            Controls.Add(releaseDateInput);
            Controls.Add(notesInput);
            Controls.Add(publisherInput);
            Controls.Add(titleInput);
            Controls.Add(notesLabel);
            Controls.Add(releaseDateLabel);
            Controls.Add(publisherLabel);
            Controls.Add(titleLabel);
            Name = "AddGameForm";
            Text = "AddGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addGameButton;
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