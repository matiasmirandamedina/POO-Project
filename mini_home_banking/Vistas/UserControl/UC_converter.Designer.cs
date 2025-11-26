namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_converter
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
            Convertion = new Button();
            currencieC = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            currencieA = new ComboBox();
            amount = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Convertion
            // 
            Convertion.BackColor = Color.DarkSlateGray;
            Convertion.Font = new Font("Harrington", 15F, FontStyle.Bold);
            Convertion.ForeColor = SystemColors.ControlLightLight;
            Convertion.Location = new Point(52, 332);
            Convertion.Name = "Convertion";
            Convertion.Size = new Size(296, 65);
            Convertion.TabIndex = 18;
            Convertion.Text = "Realizar conversion";
            Convertion.UseVisualStyleBackColor = false;
            Convertion.Click += Convertion_Click;
            // 
            // currencieC
            // 
            currencieC.FormattingEnabled = true;
            currencieC.Location = new Point(41, 270);
            currencieC.Name = "currencieC";
            currencieC.Size = new Size(319, 23);
            currencieC.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(41, 248);
            label3.Name = "label3";
            label3.Size = new Size(147, 19);
            label3.TabIndex = 16;
            label3.Text = "Moneda a convertir:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(40, 167);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 15;
            label2.Text = "Tipo de moneda:";
            // 
            // currencieA
            // 
            currencieA.FormattingEnabled = true;
            currencieA.Location = new Point(41, 189);
            currencieA.Name = "currencieA";
            currencieA.Size = new Size(319, 23);
            currencieA.TabIndex = 14;
            // 
            // amount
            // 
            amount.Location = new Point(41, 120);
            amount.Name = "amount";
            amount.Size = new Size(319, 23);
            amount.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(40, 98);
            label1.Name = "label1";
            label1.Size = new Size(154, 19);
            label1.TabIndex = 12;
            label1.Text = "Cantidad a convertir:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Harrington", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(104, 18);
            label4.Name = "label4";
            label4.Size = new Size(188, 32);
            label4.TabIndex = 22;
            label4.Text = "Transferencia";
            // 
            // UC_converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(label4);
            Controls.Add(Convertion);
            Controls.Add(currencieC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(currencieA);
            Controls.Add(amount);
            Controls.Add(label1);
            Name = "UC_converter";
            Size = new Size(400, 450);
            Load += UC_converter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Convertion;
        private ComboBox currencieC;
        private Label label3;
        private Label label2;
        private ComboBox currencieA;
        private TextBox amount;
        private Label label1;
        private Label label4;
    }
}
