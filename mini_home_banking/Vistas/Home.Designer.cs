namespace mini_home_banking.Vistas
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            listBoxCuentas = new ListBox();
            label1 = new Label();
            Tarjetas = new Label();
            button1 = new Button();
            listBoxTarjetas = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBoxCuentas
            // 
            listBoxCuentas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCuentas.FormattingEnabled = true;
            listBoxCuentas.HorizontalScrollbar = true;
            listBoxCuentas.ItemHeight = 15;
            listBoxCuentas.Location = new Point(14, 120);
            listBoxCuentas.Name = "listBoxCuentas";
            listBoxCuentas.Size = new Size(327, 94);
            listBoxCuentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 71);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 2;
            label1.Text = "Cuentas";
            // 
            // Tarjetas
            // 
            Tarjetas.AutoSize = true;
            Tarjetas.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            Tarjetas.ForeColor = SystemColors.ControlLightLight;
            Tarjetas.Location = new Point(347, 71);
            Tarjetas.Name = "Tarjetas";
            Tarjetas.Size = new Size(90, 24);
            Tarjetas.TabIndex = 3;
            Tarjetas.Text = "Tarjetas";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Harrington", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(228, 220);
            button1.Name = "button1";
            button1.Size = new Size(235, 65);
            button1.TabIndex = 1;
            button1.Text = "Hacer transferencia";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBoxTarjetas
            // 
            listBoxTarjetas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTarjetas.FormattingEnabled = true;
            listBoxTarjetas.HorizontalScrollbar = true;
            listBoxTarjetas.ItemHeight = 15;
            listBoxTarjetas.Location = new Point(347, 120);
            listBoxTarjetas.Name = "listBoxTarjetas";
            listBoxTarjetas.Size = new Size(333, 94);
            listBoxTarjetas.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(302, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 6;
            label2.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(443, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(108, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(699, 311);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listBoxTarjetas);
            Controls.Add(button1);
            Controls.Add(Tarjetas);
            Controls.Add(label1);
            Controls.Add(listBoxCuentas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCuentas;
        private Label label1;
        private Label Tarjetas;
        private Button button1;
        private ListBox listBoxTarjetas;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}