namespace GestionEmplyee
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
            panel1 = new Panel();
            button1 = new Button();
            Login = new Label();
            label2 = new Label();
            passe = new TextBox();
            LoginBtn = new Button();
            label3 = new Label();
            AdminBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrchid;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 46);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(238, 6);
            button1.Name = "button1";
            button1.Size = new Size(27, 31);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(20, 84);
            Login.Name = "Login";
            Login.Size = new Size(37, 15);
            Login.TabIndex = 1;
            Login.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 156);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passe
            // 
            passe.Location = new Point(20, 174);
            passe.Name = "passe";
            passe.Size = new Size(194, 23);
            passe.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(19, 222);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(195, 23);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Se Connecter";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 277);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Réinitialiser";
            label3.Click += label3_Click;
            // 
            // AdminBox
            // 
            AdminBox.Location = new Point(19, 108);
            AdminBox.Name = "AdminBox";
            AdminBox.Size = new Size(194, 23);
            AdminBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 450);
            Controls.Add(AdminBox);
            Controls.Add(label3);
            Controls.Add(LoginBtn);
            Controls.Add(passe);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(50, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Login;
        private Label label2;
        private TextBox passe;
        private Button LoginBtn;
        private Label label3;
        private TextBox AdminBox;
        private Button button1;
    }
}
