namespace PrincipalForm
{
    partial class LoginForm
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
            tbSenha = new TextBox();
            tbLogin = new TextBox();
            btnLogin = new Button();
            lbSenha = new Label();
            lbLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbSenha);
            panel1.Controls.Add(tbLogin);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lbSenha);
            panel1.Controls.Add(lbLogin);
            panel1.Location = new Point(169, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 217);
            panel1.TabIndex = 0;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(224, 101);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PlaceholderText = "Digite Sua Senha";
            tbSenha.Size = new Size(100, 23);
            tbSenha.TabIndex = 9;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(224, 46);
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "Digite Seu Login";
            tbLogin.Size = new Size(100, 23);
            tbLogin.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(194, 148);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(139, 104);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(42, 15);
            lbSenha.TabIndex = 6;
            lbSenha.Text = "Senha:";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(139, 49);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(40, 15);
            lbLogin.TabIndex = 5;
            lbLogin.Text = "Login:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbSenha;
        private TextBox tbLogin;
        private Button btnLogin;
        private Label lbSenha;
        private Label lbLogin;
    }
}
