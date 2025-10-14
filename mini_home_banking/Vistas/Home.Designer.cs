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
            listBoxCuentas = new ListBox();
            label1 = new Label();
            Tarjetas = new Label();
            button1 = new Button();
            listBoxTarjetas = new ListBox();
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 343);
            Controls.Add(listBoxTarjetas);
            Controls.Add(button1);
            Controls.Add(Tarjetas);
            Controls.Add(label1);
            Controls.Add(listBoxCuentas);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCuentas;
        private Label label1;
        private Label Tarjetas;
        private Button button1;
        private ListBox listBoxTarjetas;
    }
}