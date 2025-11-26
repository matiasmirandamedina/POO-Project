namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_transfer));
            radioCbu = new RadioButton();
            radioAlias = new RadioButton();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            transferir = new Button();
            cuentaDestino = new TextBox();
            label3 = new Label();
            monto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioCbu
            // 
            radioCbu.AutoSize = true;
            radioCbu.Font = new Font("Harrington", 12F);
            radioCbu.ForeColor = SystemColors.ControlLightLight;
            radioCbu.Location = new Point(40, 136);
            radioCbu.Name = "radioCbu";
            radioCbu.Size = new Size(288, 23);
            radioCbu.TabIndex = 13;
            radioCbu.TabStop = true;
            radioCbu.Text = "Seleccionar cuenta por medio de cbu:";
            radioCbu.UseVisualStyleBackColor = true;
            radioCbu.KeyUp += radioCbu_KeyUp;
            // 
            // radioAlias
            // 
            radioAlias.AutoSize = true;
            radioAlias.Checked = true;
            radioAlias.Font = new Font("Harrington", 12F);
            radioAlias.ForeColor = SystemColors.ControlLightLight;
            radioAlias.Location = new Point(40, 78);
            radioAlias.Name = "radioAlias";
            radioAlias.Size = new Size(294, 23);
            radioAlias.TabIndex = 11;
            radioAlias.TabStop = true;
            radioAlias.Text = "Seleccionar cuenta por medio de alias:";
            radioAlias.UseVisualStyleBackColor = true;
            radioAlias.KeyUp += radioAlias_KeyUp;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(40, 165);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(319, 23);
            comboBox2.TabIndex = 15;
            comboBox2.KeyUp += comboBox2_KeyUp;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 23);
            comboBox1.TabIndex = 12;
            comboBox1.KeyUp += comboBox1_KeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(175, 278);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // transferir
            // 
            transferir.BackColor = Color.DarkSlateGray;
            transferir.Font = new Font("Harrington", 15F, FontStyle.Bold);
            transferir.ForeColor = SystemColors.ControlLightLight;
            transferir.Location = new Point(51, 350);
            transferir.Name = "transferir";
            transferir.Size = new Size(296, 65);
            transferir.TabIndex = 19;
            transferir.Text = "Transferir";
            transferir.UseVisualStyleBackColor = false;
            transferir.Click += transferir_Click;
            // 
            // cuentaDestino
            // 
            cuentaDestino.Location = new Point(40, 232);
            cuentaDestino.Name = "cuentaDestino";
            cuentaDestino.Size = new Size(319, 23);
            cuentaDestino.TabIndex = 16;
            cuentaDestino.KeyUp += cuentaDestino_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(40, 210);
            label3.Name = "label3";
            label3.Size = new Size(252, 19);
            label3.TabIndex = 17;
            label3.Text = "Cuenta a transferir con alias o cbu:";
            // 
            // monto
            // 
            monto.Location = new Point(40, 321);
            monto.Name = "monto";
            monto.Size = new Size(319, 23);
            monto.TabIndex = 18;
            monto.KeyUp += monto_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(40, 285);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 14;
            label2.Text = "Monto a transferir:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(104, 18);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 21;
            label1.Text = "Transferencia";
            // 
            // UC_transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(label1);
            Controls.Add(radioCbu);
            Controls.Add(radioAlias);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(transferir);
            Controls.Add(cuentaDestino);
            Controls.Add(label3);
            Controls.Add(monto);
            Controls.Add(label2);
            Name = "UC_transfer";
            Size = new Size(400, 450);
            Load += UC_transfer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioCbu;
        private RadioButton radioAlias;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button transferir;
        private TextBox cuentaDestino;
        private Label label3;
        private TextBox monto;
        private Label label2;
        private Label label1;
    }
}
