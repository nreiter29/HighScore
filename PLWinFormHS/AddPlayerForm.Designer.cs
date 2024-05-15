namespace PLWinFormHS
{
    partial class AddPlayerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            notesInput = new TextBox();
            passwordInput = new TextBox();
            birthDayInput = new DateTimePicker();
            addPlayerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 116);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 145);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 185);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "BirthDay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 219);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 253);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(230, 113);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(200, 23);
            firstNameInput.TabIndex = 5;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(230, 142);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(200, 23);
            lastNameInput.TabIndex = 6;
            // 
            // notesInput
            // 
            notesInput.Location = new Point(230, 211);
            notesInput.Name = "notesInput";
            notesInput.Size = new Size(200, 23);
            notesInput.TabIndex = 8;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(230, 245);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(200, 23);
            passwordInput.TabIndex = 9;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // birthDayInput
            // 
            birthDayInput.Location = new Point(230, 179);
            birthDayInput.Name = "birthDayInput";
            birthDayInput.Size = new Size(200, 23);
            birthDayInput.TabIndex = 10;
            // 
            // addPlayerButton
            // 
            addPlayerButton.Location = new Point(71, 296);
            addPlayerButton.Name = "addPlayerButton";
            addPlayerButton.Size = new Size(359, 23);
            addPlayerButton.TabIndex = 11;
            addPlayerButton.Text = "Add Player";
            addPlayerButton.UseVisualStyleBackColor = true;
            addPlayerButton.Click += addPlayerButton_Click;
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 600);
            Controls.Add(addPlayerButton);
            Controls.Add(birthDayInput);
            Controls.Add(passwordInput);
            Controls.Add(notesInput);
            Controls.Add(lastNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPlayerForm";
            Text = "AddPlayerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private TextBox notesInput;
        private TextBox passwordInput;
        private DateTimePicker birthDayInput;
        private Button addPlayerButton;
    }
}