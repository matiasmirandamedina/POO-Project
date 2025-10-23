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
            listBoxCuentas.FormattingEnabled = true;
            listBoxCuentas.ItemHeight = 15;
            listBoxCuentas.Location = new Point(12, 167);
            listBoxCuentas.Name = "listBoxCuentas";
            listBoxCuentas.Size = new Size(195, 79);
            listBoxCuentas.TabIndex = 0;
            listBoxCuentas.SelectedIndexChanged += listBoxCuentas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Cuentas";
            // 
            // Tarjetas
            // 
            Tarjetas.AutoSize = true;
            Tarjetas.Location = new Point(213, 140);
            Tarjetas.Name = "Tarjetas";
            Tarjetas.Size = new Size(46, 15);
            Tarjetas.TabIndex = 3;
            Tarjetas.Text = "Tarjetas";
            // 
            // button1
            // 
            button1.Location = new Point(566, 167);
            button1.Name = "button1";
            button1.Size = new Size(121, 78);
            button1.TabIndex = 4;
            button1.Text = "Hacer transferencia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxTarjetas
            // 
            listBoxTarjetas.FormattingEnabled = true;
            listBoxTarjetas.ItemHeight = 15;
            listBoxTarjetas.Location = new Point(213, 167);
            listBoxTarjetas.Name = "listBoxTarjetas";
            listBoxTarjetas.Size = new Size(333, 79);
            listBoxTarjetas.TabIndex = 5;
            listBoxTarjetas.SelectedIndexChanged += listBoxTarjetas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 6;
            label2.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 111);
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
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(699, 343);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listBoxTarjetas);
            Controls.Add(button1);
            Controls.Add(Tarjetas);
            Controls.Add(label1);
            Controls.Add(listBoxCuentas);
            Name = "Home";
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