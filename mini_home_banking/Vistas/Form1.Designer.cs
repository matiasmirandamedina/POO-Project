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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pass = new TextBox();
            email = new TextBox();
            Login = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 118);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 158);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 158);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // pass
            // 
            pass.Location = new Point(256, 191);
            pass.Name = "pass";
            pass.Size = new Size(100, 23);
            pass.TabIndex = 4;
            pass.TextChanged += pass_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(71, 191);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 5;
            email.TextChanged += email_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(171, 230);
            Login.Name = "Login";
            Login.Size = new Size(88, 39);
            Login.TabIndex = 6;
            Login.Text = "Iniciar Sesion";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 42);
            label4.Name = "label4";
            label4.Size = new Size(227, 32);
            label4.TabIndex = 7;
            label4.Text = "Mini Home Banking";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(447, 294);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Login);
            Controls.Add(email);
            Controls.Add(pass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label4;
        private PictureBox pictureBox1;
    }
}