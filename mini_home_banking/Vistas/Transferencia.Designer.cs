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
            label1 = new Label();
            Cuenta = new TextBox();
            listBoxCuentas = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(239, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar cuenta por medio de alias o cbu";
            // 
            // Cuenta
            // 
            Cuenta.Location = new Point(23, 58);
            Cuenta.Name = "Cuenta";
            Cuenta.Size = new Size(239, 23);
            Cuenta.TabIndex = 1;
            // 
            // listBoxCuentas
            // 
            listBoxCuentas.FormattingEnabled = true;
            listBoxCuentas.ItemHeight = 15;
            listBoxCuentas.Location = new Point(23, 96);
            listBoxCuentas.Name = "listBoxCuentas";
            listBoxCuentas.Size = new Size(239, 64);
            listBoxCuentas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 180);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Monto a transferir:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 38);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 5;
            label3.Text = "Cuenta a transferir con alias o cbu";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 6;
            // 
            // Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 294);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listBoxCuentas);
            Controls.Add(Cuenta);
            Controls.Add(label1);
            Name = "Transferencia";
            Text = "Transferencia";
            Load += Transferencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Cuenta;
        private ListBox listBoxCuentas;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}