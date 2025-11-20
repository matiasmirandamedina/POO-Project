namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_insertUser
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            Insert_User = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 23);
            comboBox1.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(107, 309);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 23);
            textBox6.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Harrington", 12F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(107, 287);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 37;
            label7.Text = "password:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(107, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 23);
            textBox5.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Harrington", 12F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(107, 240);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 36;
            label6.Text = "email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Harrington", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(107, 191);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 35;
            label5.Text = "fullname:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Harrington", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(107, 143);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 34;
            label4.Text = "username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(107, 95);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 32;
            label1.Text = "rol_id:";
            // 
            // Insert_User
            // 
            Insert_User.BackColor = Color.DarkSlateGray;
            Insert_User.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insert_User.ForeColor = SystemColors.ControlLightLight;
            Insert_User.Location = new Point(107, 338);
            Insert_User.Name = "Insert_User";
            Insert_User.Size = new Size(185, 65);
            Insert_User.TabIndex = 33;
            Insert_User.Text = "Insertar Usuario";
            Insert_User.UseVisualStyleBackColor = false;
            Insert_User.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(116, 59);
            label2.Name = "label2";
            label2.Size = new Size(167, 24);
            label2.TabIndex = 27;
            label2.Text = "Insertar usuario";
            // 
            // UC_insertUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Insert_User);
            Controls.Add(label2);
            Name = "UC_insertUser";
            Size = new Size(400, 491);
            Load += UC_insertUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private Button Insert_User;
        private Label label2;
    }
}
