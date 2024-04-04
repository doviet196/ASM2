namespace ASM2
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 53);
            label1.Name = "label1";
            label1.Size = new Size(330, 65);
            label1.TabIndex = 0;
            label1.Text = "Login System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 201);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(275, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(566, 39);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 334);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(564, 39);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(393, 411);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 93);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(775, 646);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 57);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 715);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
    }
}
