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
            label1 = new Label();
            cuentaOrigen = new TextBox();
            label2 = new Label();
            monto = new TextBox();
            label3 = new Label();
            cuentaDestino = new TextBox();
            transferir = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(319, 19);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar cuenta por medio de alias o cbu:";
            // 
            // cuentaOrigen
            // 
            cuentaOrigen.Location = new Point(12, 40);
            cuentaOrigen.Name = "cuentaOrigen";
            cuentaOrigen.Size = new Size(319, 23);
            cuentaOrigen.TabIndex = 1;
            cuentaOrigen.TextChanged += cuentaOrigen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 3;
            label2.Text = "Monto a transferir:";
            // 
            // monto
            // 
            monto.Location = new Point(12, 194);
            monto.Name = "monto";
            monto.Size = new Size(319, 23);
            monto.TabIndex = 4;
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
            cuentaDestino.TabIndex = 6;
            // 
            // transferir
            // 
            transferir.BackColor = Color.DarkSlateGray;
            transferir.Font = new Font("Harrington", 15F, FontStyle.Bold);
            transferir.ForeColor = SystemColors.ControlLightLight;
            transferir.Location = new Point(370, 152);
            transferir.Name = "transferir";
            transferir.Size = new Size(296, 65);
            transferir.TabIndex = 7;
            transferir.Text = "Transferir";
            transferir.UseVisualStyleBackColor = false;
            transferir.Click += transferir_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 79);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(692, 236);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(transferir);
            Controls.Add(cuentaDestino);
            Controls.Add(label3);
            Controls.Add(monto);
            Controls.Add(label2);
            Controls.Add(cuentaOrigen);
            Controls.Add(label1);
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

        private Label label1;
        private TextBox cuentaOrigen;
        private Label label2;
        private TextBox monto;
        private Label label3;
        private TextBox cuentaDestino;
        private Button transferir;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}