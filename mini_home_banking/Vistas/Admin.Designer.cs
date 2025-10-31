namespace mini_home_banking.Vistas
{
    partial class Admin
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
            Insert_Account = new Button();
            label2 = new Label();
            label3 = new Label();
            Insert_User = new Button();
            rol = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            textBox13 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label16 = new Label();
            textBox12 = new TextBox();
            Number_card = new TextBox();
            Generate_Debits = new Button();
            label17 = new Label();
            Debitos = new TextBox();
            label18 = new Label();
            label19 = new Label();
            Id_card = new TextBox();
            label20 = new Label();
            Month = new TextBox();
            Resumen = new Button();
            SuspendLayout();
            // 
            // Insert_Account
            // 
            Insert_Account.BackColor = Color.DarkSlateGray;
            Insert_Account.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insert_Account.ForeColor = SystemColors.ControlLightLight;
            Insert_Account.Location = new Point(234, 352);
            Insert_Account.Name = "Insert_Account";
            Insert_Account.Size = new Size(225, 65);
            Insert_Account.TabIndex = 13;
            Insert_Account.Text = "Insertar Cuenta";
            Insert_Account.UseVisualStyleBackColor = false;
            Insert_Account.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(21, 25);
            label2.Name = "label2";
            label2.Size = new Size(167, 24);
            label2.TabIndex = 1;
            label2.Text = "Insertar usuario";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(269, 25);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 2;
            label3.Text = "Insertar cuenta";
            // 
            // Insert_User
            // 
            Insert_User.BackColor = Color.DarkSlateGray;
            Insert_User.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insert_User.ForeColor = SystemColors.ControlLightLight;
            Insert_User.Location = new Point(12, 304);
            Insert_User.Name = "Insert_User";
            Insert_User.Size = new Size(185, 65);
            Insert_User.TabIndex = 6;
            Insert_User.Text = "Insertar Usuario";
            Insert_User.UseVisualStyleBackColor = false;
            Insert_User.Click += button4_Click;
            // 
            // rol
            // 
            rol.Location = new Point(12, 83);
            rol.Name = "rol";
            rol.Size = new Size(185, 23);
            rol.TabIndex = 1;
            rol.TextChanged += textBox3_TextChanged;
            rol.KeyUp += rol_KeyUp;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(234, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyUp += textBox4_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 6;
            label1.Text = "rol_id:";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Harrington", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 7;
            label4.Text = "username:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Harrington", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 157);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 9;
            label5.Text = "fullname:";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Harrington", 12F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 206);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 11;
            label6.Text = "email:";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 23);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyUp += textBox5_KeyUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Harrington", 12F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 253);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 13;
            label7.Text = "password:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 275);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 23);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox6.KeyUp += textBox6_KeyUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Harrington", 12F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(234, 61);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 15;
            label8.Text = "user_id:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Harrington", 12F);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(234, 109);
            label9.Name = "label9";
            label9.Size = new Size(129, 19);
            label9.TabIndex = 16;
            label9.Text = "account_type_id:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(234, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(225, 23);
            textBox7.TabIndex = 8;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox7.KeyUp += textBox7_KeyUp;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Harrington", 12F);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(234, 157);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
            label10.TabIndex = 18;
            label10.Text = "currency_id:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(234, 179);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(225, 23);
            textBox8.TabIndex = 9;
            textBox8.TextChanged += textBox8_TextChanged;
            textBox8.KeyUp += textBox8_KeyUp;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Harrington", 12F);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(234, 205);
            label11.Name = "label11";
            label11.Size = new Size(44, 19);
            label11.TabIndex = 20;
            label11.Text = "CBU:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(234, 227);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(225, 23);
            textBox9.TabIndex = 10;
            textBox9.TextChanged += textBox9_TextChanged;
            textBox9.KeyUp += textBox9_KeyUp;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Harrington", 12F);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(234, 253);
            label14.Name = "label14";
            label14.Size = new Size(126, 19);
            label14.TabIndex = 26;
            label14.Text = "current_balance:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Harrington", 12F);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(234, 301);
            label15.Name = "label15";
            label15.Size = new Size(45, 19);
            label15.TabIndex = 28;
            label15.Text = "alias:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(234, 323);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(225, 23);
            textBox13.TabIndex = 12;
            textBox13.TextChanged += textBox13_TextChanged;
            textBox13.KeyUp += textBox13_KeyUp;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(492, 25);
            label12.Name = "label12";
            label12.Size = new Size(296, 24);
            label12.TabIndex = 30;
            label12.Text = "Generar débitos a una tarjeta";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Harrington", 12F);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(492, 61);
            label13.Name = "label13";
            label13.Size = new Size(137, 19);
            label13.TabIndex = 31;
            label13.Text = "Número de tarjeta:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Harrington", 12F);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(385, 278);
            label16.Name = "label16";
            label16.Size = new Size(0, 19);
            label16.TabIndex = 32;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(234, 275);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(225, 23);
            textBox12.TabIndex = 11;
            textBox12.TextChanged += textBox12_TextChanged;
            textBox12.KeyUp += textBox12_KeyUp;
            // 
            // Number_card
            // 
            Number_card.Location = new Point(492, 83);
            Number_card.Name = "Number_card";
            Number_card.Size = new Size(296, 23);
            Number_card.TabIndex = 14;
            Number_card.TextChanged += Number_card_TextChanged;
            Number_card.KeyUp += Number_card_KeyUp;
            // 
            // Generate_Debits
            // 
            Generate_Debits.BackColor = Color.DarkSlateGray;
            Generate_Debits.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Generate_Debits.ForeColor = SystemColors.ControlLightLight;
            Generate_Debits.Location = new Point(492, 162);
            Generate_Debits.Name = "Generate_Debits";
            Generate_Debits.Size = new Size(296, 65);
            Generate_Debits.TabIndex = 16;
            Generate_Debits.Text = "Generar debitos";
            Generate_Debits.UseVisualStyleBackColor = false;
            Generate_Debits.Click += button1_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Harrington", 12F);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(492, 109);
            label17.Name = "label17";
            label17.Size = new Size(67, 19);
            label17.TabIndex = 35;
            label17.Text = "Débitos:";
            label17.Click += label17_Click;
            // 
            // Debitos
            // 
            Debitos.Location = new Point(492, 131);
            Debitos.Name = "Debitos";
            Debitos.Size = new Size(296, 23);
            Debitos.TabIndex = 15;
            Debitos.KeyUp += Debitos_KeyUp;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(492, 248);
            label18.Name = "label18";
            label18.Size = new Size(279, 24);
            label18.TabIndex = 37;
            label18.Text = "Ver resumen de  una tarjeta";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Harrington", 12F);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(492, 278);
            label19.Name = "label19";
            label19.Size = new Size(113, 19);
            label19.TabIndex = 38;
            label19.Text = "ID de la tarjeta:";
            // 
            // Id_card
            // 
            Id_card.Location = new Point(492, 300);
            Id_card.Name = "Id_card";
            Id_card.Size = new Size(296, 23);
            Id_card.TabIndex = 17;
            Id_card.KeyUp += Id_card_KeyUp;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Harrington", 12F);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(492, 329);
            label20.Name = "label20";
            label20.Size = new Size(41, 19);
            label20.TabIndex = 40;
            label20.Text = "Mes:";
            // 
            // Month
            // 
            Month.Location = new Point(492, 352);
            Month.Name = "Month";
            Month.Size = new Size(296, 23);
            Month.TabIndex = 18;
            Month.TextChanged += Month_TextChanged;
            Month.KeyUp += Month_KeyUp;
            // 
            // Resumen
            // 
            Resumen.BackColor = Color.DarkSlateGray;
            Resumen.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resumen.ForeColor = SystemColors.ControlLightLight;
            Resumen.Location = new Point(492, 381);
            Resumen.Name = "Resumen";
            Resumen.Size = new Size(296, 65);
            Resumen.TabIndex = 19;
            Resumen.Text = "Ver resumen";
            Resumen.UseVisualStyleBackColor = false;
            Resumen.Click += Resumen_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 491);
            Controls.Add(Resumen);
            Controls.Add(Month);
            Controls.Add(label20);
            Controls.Add(Id_card);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(Debitos);
            Controls.Add(label17);
            Controls.Add(Generate_Debits);
            Controls.Add(Number_card);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox13);
            Controls.Add(label15);
            Controls.Add(textBox12);
            Controls.Add(label14);
            Controls.Add(textBox9);
            Controls.Add(label11);
            Controls.Add(textBox8);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(rol);
            Controls.Add(Insert_User);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Insert_Account);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana de administrador";
            Load += Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button Resumen;
        private Button Insert_Account;
        private Label label2;
        private Label label3;
        private Button Insert_User;
        private TextBox rol;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox8;
        private Label label11;
        private TextBox textBox9;
        private Label label14;
        private Label label15;
        private TextBox textBox13;
        private Label label12;
        private Label label13;
        private Label label16;
        private TextBox textBox12;
        private TextBox Number_card;
        private Button Generate_Debits;
        private Label label17;
        private TextBox Debitos;
        private Label label18;
        private Label label19;
        private TextBox Id_card;
        private Label label20;
        private TextBox Month;
    }
}