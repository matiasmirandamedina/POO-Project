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
            pass = new TextBox();
            email = new TextBox();
            Login = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(186, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pass
            // 
            pass.Location = new Point(250, 172);
            pass.Margin = new Padding(4, 3, 4, 3);
            pass.Name = "pass";
            pass.Size = new Size(134, 23);
            pass.TabIndex = 4;
            pass.TextChanged += pass_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(67, 172);
            email.Margin = new Padding(4, 3, 4, 3);
            email.Name = "email";
            email.Size = new Size(134, 23);
            email.TabIndex = 5;
            email.TextChanged += email_TextChanged;
            // 
            // Login
            // 
            Login.BackColor = Color.DarkSlateGray;
            Login.Font = new Font("Harrington", 15.25F, FontStyle.Bold);
            Login.ForeColor = SystemColors.ControlLightLight;
            Login.Location = new Point(144, 201);
            Login.Margin = new Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.Size = new Size(170, 65);
            Login.TabIndex = 6;
            Login.Text = "Iniciar Sesion";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Harrington", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(36, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(259, 32);
            label4.TabIndex = 7;
            label4.Text = "Mini Home Banking";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(67, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 9;
            label2.Text = "Gmail:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(250, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 10;
            label3.Text = "Contraseña:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(444, 286);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Login);
            Controls.Add(email);
            Controls.Add(pass);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox pass;
        private TextBox email;
        private Button Login;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}