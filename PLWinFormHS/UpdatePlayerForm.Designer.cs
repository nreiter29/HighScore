namespace PLWinFormHS
{
    partial class UpdatePlayerForm
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
            addPlayerButton = new Button();
            birthDayInput = new DateTimePicker();
            notesInput = new TextBox();
            lastNameInput = new TextBox();
            firstNameInput = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // addPlayerButton
            // 
            addPlayerButton.Location = new Point(82, 201);
            addPlayerButton.Name = "addPlayerButton";
            addPlayerButton.Size = new Size(359, 23);
            addPlayerButton.TabIndex = 22;
            addPlayerButton.Text = "Update Player";
            addPlayerButton.UseVisualStyleBackColor = true;
            addPlayerButton.Click += addPlayerButton_Click;
            // 
            // birthDayInput
            // 
            birthDayInput.Location = new Point(241, 121);
            birthDayInput.Name = "birthDayInput";
            birthDayInput.Size = new Size(200, 23);
            birthDayInput.TabIndex = 21;
            // 
            // notesInput
            // 
            notesInput.Location = new Point(241, 153);
            notesInput.Name = "notesInput";
            notesInput.Size = new Size(200, 23);
            notesInput.TabIndex = 19;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(241, 84);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(200, 23);
            lastNameInput.TabIndex = 18;
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(241, 55);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(200, 23);
            firstNameInput.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 161);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 127);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 14;
            label3.Text = "BirthDay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 13;
            label2.Text = "LastName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 58);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "FirstName";
            // 
            // UpdatePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 270);
            Controls.Add(addPlayerButton);
            Controls.Add(birthDayInput);
            Controls.Add(notesInput);
            Controls.Add(lastNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdatePlayerForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addPlayerButton;
        private DateTimePicker birthDayInput;
        private TextBox notesInput;
        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}