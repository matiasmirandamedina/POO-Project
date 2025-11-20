namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_insertAccounts
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
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox13 = new TextBox();
            label15 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            Insert_Account = new Button();
            SuspendLayout();
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(96, 198);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(225, 23);
            comboBox4.TabIndex = 32;
            comboBox4.KeyUp += comboBox4_KeyUp;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.ItemHeight = 15;
            comboBox3.Location = new Point(96, 150);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(225, 23);
            comboBox3.TabIndex = 31;
            comboBox3.KeyUp += comboBox3_KeyUp;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(96, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 23);
            comboBox2.TabIndex = 30;
            comboBox2.KeyUp += comboBox2_KeyUp;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(96, 342);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(225, 23);
            textBox13.TabIndex = 35;
            textBox13.KeyUp += textBox13_KeyUp;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Harrington", 12F);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(96, 320);
            label15.Name = "label15";
            label15.Size = new Size(45, 19);
            label15.TabIndex = 42;
            label15.Text = "alias:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(96, 294);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(225, 23);
            textBox12.TabIndex = 34;
            textBox12.KeyUp += textBox12_KeyUp;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Harrington", 12F);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(96, 272);
            label14.Name = "label14";
            label14.Size = new Size(126, 19);
            label14.TabIndex = 41;
            label14.Text = "current_balance:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(96, 246);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(225, 23);
            textBox9.TabIndex = 33;
            textBox9.KeyUp += textBox9_KeyUp;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Harrington", 12F);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(96, 224);
            label11.Name = "label11";
            label11.Size = new Size(44, 19);
            label11.TabIndex = 40;
            label11.Text = "CBU:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Harrington", 12F);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(96, 176);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
            label10.TabIndex = 39;
            label10.Text = "currency_id:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Harrington", 12F);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(96, 128);
            label9.Name = "label9";
            label9.Size = new Size(129, 19);
            label9.TabIndex = 38;
            label9.Text = "account_type_id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Harrington", 12F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(96, 80);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 37;
            label8.Text = "user_id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(131, 44);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 29;
            label3.Text = "Insertar cuenta";
            // 
            // Insert_Account
            // 
            Insert_Account.BackColor = Color.DarkSlateGray;
            Insert_Account.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insert_Account.ForeColor = SystemColors.ControlLightLight;
            Insert_Account.Location = new Point(96, 371);
            Insert_Account.Name = "Insert_Account";
            Insert_Account.Size = new Size(225, 65);
            Insert_Account.TabIndex = 36;
            Insert_Account.Text = "Insertar Cuenta";
            Insert_Account.UseVisualStyleBackColor = false;
            Insert_Account.Click += button3_Click;
            // 
            // UC_insertAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox13);
            Controls.Add(label15);
            Controls.Add(textBox12);
            Controls.Add(label14);
            Controls.Add(textBox9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(Insert_Account);
            Name = "UC_insertAccounts";
            Size = new Size(400, 491);
            Load += UC_insertAccounts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox13;
        private Label label15;
        private TextBox textBox12;
        private Label label14;
        private TextBox textBox9;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label3;
        private Button Insert_Account;
    }
}
