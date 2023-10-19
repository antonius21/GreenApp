namespace GreenApp
{
    partial class EnterForm
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
            panel1 = new Panel();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            enterButton = new Button();
            passwordLabel = new Label();
            loginLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(loginTextBox);
            panel1.Controls.Add(enterButton);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(loginLabel);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 451);
            panel1.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Location = new Point(421, 230);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = Color.White;
            loginTextBox.Location = new Point(421, 142);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(100, 23);
            loginTextBox.TabIndex = 3;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(244, 314);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(277, 40);
            enterButton.TabIndex = 2;
            enterButton.Text = "Увійти у систему";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(244, 233);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(148, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Уведіть пароль для входу ";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(244, 145);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(137, 15);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Уведіть логін для входу ";
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EnterForm";
            Text = "Green ERP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button enterButton;
        private Label passwordLabel;
        private Label loginLabel;
    }
}
