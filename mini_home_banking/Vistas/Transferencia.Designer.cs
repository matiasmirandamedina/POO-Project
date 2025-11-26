namespace mini_home_banking.Vistas
{
    partial class Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferencia));
            label2 = new Label();
            monto = new TextBox();
            label3 = new Label();
            cuentaDestino = new TextBox();
            transferir = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioAlias = new RadioButton();
            radioCbu = new RadioButton();
            Conv = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 3;
            label2.Text = "Monto a transferir:";
            // 
            // monto
            // 
            monto.Location = new Point(12, 160);
            monto.Name = "monto";
            monto.Size = new Size(319, 23);
            monto.TabIndex = 6;
            monto.KeyUp += monto_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(392, 18);
            label3.Name = "label3";
            label3.Size = new Size(252, 19);
            label3.TabIndex = 5;
            label3.Text = "Cuenta a transferir con alias o cbu:";
            // 
            // cuentaDestino
            // 
            cuentaDestino.Location = new Point(370, 40);
            cuentaDestino.Name = "cuentaDestino";
            cuentaDestino.Size = new Size(296, 23);
            cuentaDestino.TabIndex = 5;
            cuentaDestino.KeyUp += cuentaDestino_KeyUp;
            // 
            // transferir
            // 
            transferir.BackColor = Color.DarkSlateGray;
            transferir.Font = new Font("Harrington", 15F, FontStyle.Bold);
            transferir.ForeColor = SystemColors.ControlLightLight;
            transferir.Location = new Point(370, 76);
            transferir.Name = "transferir";
            transferir.Size = new Size(296, 65);
            transferir.TabIndex = 7;
            transferir.Text = "Transferir";
            transferir.UseVisualStyleBackColor = false;
            transferir.Click += transferir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 23);
            comboBox1.TabIndex = 2;
            comboBox1.KeyUp += comboBox1_KeyUp;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 88);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(319, 23);
            comboBox2.TabIndex = 4;
            comboBox2.KeyUp += comboBox2_KeyUp;
            // 
            // radioAlias
            // 
            radioAlias.AutoSize = true;
            radioAlias.Checked = true;
            radioAlias.Font = new Font("Harrington", 12F);
            radioAlias.ForeColor = SystemColors.ControlLightLight;
            radioAlias.Location = new Point(12, 16);
            radioAlias.Name = "radioAlias";
            radioAlias.Size = new Size(294, 23);
            radioAlias.TabIndex = 1;
            radioAlias.TabStop = true;
            radioAlias.Text = "Seleccionar cuenta por medio de alias:";
            radioAlias.UseVisualStyleBackColor = true;
            radioAlias.KeyUp += radioAlias_KeyUp;
            // 
            // radioCbu
            // 
            radioCbu.AutoSize = true;
            radioCbu.Font = new Font("Harrington", 12F);
            radioCbu.ForeColor = SystemColors.ControlLightLight;
            radioCbu.Location = new Point(12, 64);
            radioCbu.Name = "radioCbu";
            radioCbu.Size = new Size(288, 23);
            radioCbu.TabIndex = 3;
            radioCbu.TabStop = true;
            radioCbu.Text = "Seleccionar cuenta por medio de cbu:";
            radioCbu.UseVisualStyleBackColor = true;
            radioCbu.KeyUp += radioCbu_KeyUp;
            // 
            // Conv
            // 
            Conv.BackColor = Color.DarkSlateGray;
            Conv.Font = new Font("Harrington", 15F, FontStyle.Bold);
            Conv.ForeColor = SystemColors.ControlLightLight;
            Conv.Location = new Point(370, 147);
            Conv.Name = "Conv";
            Conv.Size = new Size(296, 52);
            Conv.TabIndex = 10;
            Conv.Text = "Conversion de unidades";
            Conv.UseVisualStyleBackColor = false;
            Conv.Click += Convert_Click;
            // 
            // Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(692, 211);
            Controls.Add(Conv);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Transferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transferencia";
            Load += Transferencia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox monto;
        private Label label3;
        private TextBox cuentaDestino;
        private Button transferir;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioAlias;
        private RadioButton radioCbu;
        private Button Conv;
    }
}