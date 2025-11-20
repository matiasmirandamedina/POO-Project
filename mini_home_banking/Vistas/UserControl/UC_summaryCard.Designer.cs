namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_summaryCard
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
            Resumen = new Button();
            Month = new TextBox();
            label20 = new Label();
            Card_number = new TextBox();
            label19 = new Label();
            label18 = new Label();
            SuspendLayout();
            // 
            // Resumen
            // 
            Resumen.BackColor = Color.DarkSlateGray;
            Resumen.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resumen.ForeColor = SystemColors.ControlLightLight;
            Resumen.Location = new Point(52, 279);
            Resumen.Name = "Resumen";
            Resumen.Size = new Size(296, 65);
            Resumen.TabIndex = 43;
            Resumen.Text = "Ver resumen";
            Resumen.UseVisualStyleBackColor = false;
            Resumen.Click += Resumen_Click;
            // 
            // Month
            // 
            Month.Location = new Point(52, 250);
            Month.Name = "Month";
            Month.Size = new Size(296, 23);
            Month.TabIndex = 42;
            Month.KeyUp += Month_KeyUp;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Harrington", 12F);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(52, 227);
            label20.Name = "label20";
            label20.Size = new Size(41, 19);
            label20.TabIndex = 46;
            label20.Text = "Mes:";
            // 
            // Card_number
            // 
            Card_number.Location = new Point(52, 198);
            Card_number.Name = "Card_number";
            Card_number.Size = new Size(296, 23);
            Card_number.TabIndex = 41;
            Card_number.KeyUp += Id_card_KeyUp;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Harrington", 12F);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(52, 176);
            label19.Name = "label19";
            label19.Size = new Size(153, 19);
            label19.TabIndex = 45;
            label19.Text = "Numero de la tarjeta:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(52, 146);
            label18.Name = "label18";
            label18.Size = new Size(279, 24);
            label18.TabIndex = 44;
            label18.Text = "Ver resumen de  una tarjeta";
            // 
            // UC_summaryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(Resumen);
            Controls.Add(Month);
            Controls.Add(label20);
            Controls.Add(Card_number);
            Controls.Add(label19);
            Controls.Add(label18);
            Name = "UC_summaryCard";
            Size = new Size(400, 491);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Resumen;
        private TextBox Month;
        private Label label20;
        private TextBox Card_number;
        private Label label19;
        private Label label18;
    }
}
