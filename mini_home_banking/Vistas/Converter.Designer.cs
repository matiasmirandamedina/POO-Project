namespace mini_home_banking.Vistas
{
    partial class Converter
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
            amount = new TextBox();
            currencieA = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            currencieC = new ComboBox();
            Convertion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 15);
            label1.Name = "label1";
            label1.Size = new Size(213, 24);
            label1.TabIndex = 0;
            label1.Text = "Cantidad a convertir:";
            // 
            // amount
            // 
            amount.Location = new Point(39, 41);
            amount.Name = "amount";
            amount.Size = new Size(208, 23);
            amount.TabIndex = 1;
            // 
            // currencieA
            // 
            currencieA.FormattingEnabled = true;
            currencieA.Location = new Point(39, 97);
            currencieA.Name = "currencieA";
            currencieA.Size = new Size(131, 23);
            currencieA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(39, 67);
            label2.Name = "label2";
            label2.Size = new Size(167, 24);
            label2.TabIndex = 3;
            label2.Text = "Tipo de moneda:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(492, 15);
            label3.Name = "label3";
            label3.Size = new Size(202, 24);
            label3.TabIndex = 4;
            label3.Text = "Moneda a convertir:";
            // 
            // currencieC
            // 
            currencieC.FormattingEnabled = true;
            currencieC.Location = new Point(492, 41);
            currencieC.Name = "currencieC";
            currencieC.Size = new Size(131, 23);
            currencieC.TabIndex = 5;
            // 
            // Convertion
            // 
            Convertion.BackColor = Color.DarkSlateGray;
            Convertion.Font = new Font("Harrington", 15F, FontStyle.Bold);
            Convertion.ForeColor = SystemColors.ControlLightLight;
            Convertion.Location = new Point(492, 79);
            Convertion.Name = "Convertion";
            Convertion.Size = new Size(296, 52);
            Convertion.TabIndex = 11;
            Convertion.Text = "Realizar conversion";
            Convertion.UseVisualStyleBackColor = false;
            Convertion.Click += Convertion_Click;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 173);
            Controls.Add(Convertion);
            Controls.Add(currencieC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(currencieA);
            Controls.Add(amount);
            Controls.Add(label1);
            Name = "Converter";
            Text = "Converter";
            Load += Converter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox amount;
        private ComboBox currencieA;
        private Label label2;
        private Label label3;
        private ComboBox currencieC;
        private Button Convertion;
    }
}