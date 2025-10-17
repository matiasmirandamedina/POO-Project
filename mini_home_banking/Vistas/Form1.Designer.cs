namespace mini_home_banking.Vistas
{
    partial class Form1
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
            pass = new TextBox();
            email = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 52);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 52);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // pass
            // 
            pass.Location = new Point(161, 70);
            pass.Name = "pass";
            pass.Size = new Size(100, 23);
            pass.TabIndex = 4;
            pass.TextChanged += pass_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(32, 70);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 5;
            email.TextChanged += email_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(96, 99);
            Login.Name = "Login";
            Login.Size = new Size(88, 39);
            Login.TabIndex = 6;
            Login.Text = "Iniciar Sesion";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 179);
            Controls.Add(Login);
            Controls.Add(email);
            Controls.Add(pass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox pass;
        private TextBox email;
        private Button Login;
    }
}