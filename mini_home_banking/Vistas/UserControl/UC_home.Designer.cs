namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_home));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            listBoxTarjetas = new ListBox();
            Tarjetas = new Label();
            label1 = new Label();
            listBoxCuentas = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(225, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(160, 18);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 14;
            label2.Text = "Home";
            // 
            // listBoxTarjetas
            // 
            listBoxTarjetas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTarjetas.FormattingEnabled = true;
            listBoxTarjetas.HorizontalScrollbar = true;
            listBoxTarjetas.ItemHeight = 15;
            listBoxTarjetas.Location = new Point(35, 299);
            listBoxTarjetas.Name = "listBoxTarjetas";
            listBoxTarjetas.Size = new Size(333, 94);
            listBoxTarjetas.TabIndex = 13;
            // 
            // Tarjetas
            // 
            Tarjetas.AutoSize = true;
            Tarjetas.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            Tarjetas.ForeColor = SystemColors.ControlLightLight;
            Tarjetas.Location = new Point(129, 255);
            Tarjetas.Name = "Tarjetas";
            Tarjetas.Size = new Size(90, 24);
            Tarjetas.TabIndex = 12;
            Tarjetas.Text = "Tarjetas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(131, 90);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 11;
            label1.Text = "Cuentas";
            // 
            // listBoxCuentas
            // 
            listBoxCuentas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCuentas.FormattingEnabled = true;
            listBoxCuentas.HorizontalScrollbar = true;
            listBoxCuentas.ItemHeight = 15;
            listBoxCuentas.Location = new Point(35, 134);
            listBoxCuentas.Name = "listBoxCuentas";
            listBoxCuentas.Size = new Size(327, 94);
            listBoxCuentas.TabIndex = 9;
            // 
            // UC_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listBoxTarjetas);
            Controls.Add(Tarjetas);
            Controls.Add(label1);
            Controls.Add(listBoxCuentas);
            Name = "UC_home";
            Size = new Size(400, 450);
            Load += UC_home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private ListBox listBoxTarjetas;
        private Label Tarjetas;
        private Label label1;
        private ListBox listBoxCuentas;
    }
}
