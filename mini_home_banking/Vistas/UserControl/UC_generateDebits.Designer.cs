namespace mini_home_banking.Vistas.UserControl
{
    partial class UC_generateDebits
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
            Debitos = new TextBox();
            label17 = new Label();
            Generate_Debits = new Button();
            Number_card = new TextBox();
            label13 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // Debitos
            // 
            Debitos.Location = new Point(51, 255);
            Debitos.Name = "Debitos";
            Debitos.Size = new Size(296, 23);
            Debitos.TabIndex = 37;
            Debitos.KeyUp += Debitos_KeyUp;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Harrington", 12F);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(51, 233);
            label17.Name = "label17";
            label17.Size = new Size(67, 19);
            label17.TabIndex = 41;
            label17.Text = "Débitos:";
            // 
            // Generate_Debits
            // 
            Generate_Debits.BackColor = Color.DarkSlateGray;
            Generate_Debits.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Generate_Debits.ForeColor = SystemColors.ControlLightLight;
            Generate_Debits.Location = new Point(51, 286);
            Generate_Debits.Name = "Generate_Debits";
            Generate_Debits.Size = new Size(296, 65);
            Generate_Debits.TabIndex = 38;
            Generate_Debits.Text = "Generar debitos";
            Generate_Debits.UseVisualStyleBackColor = false;
            Generate_Debits.Click += button1_Click;
            // 
            // Number_card
            // 
            Number_card.Location = new Point(51, 207);
            Number_card.Name = "Number_card";
            Number_card.Size = new Size(296, 23);
            Number_card.TabIndex = 36;
            Number_card.KeyUp += Number_card_KeyUp;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Harrington", 12F);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(51, 185);
            label13.Name = "label13";
            label13.Size = new Size(137, 19);
            label13.TabIndex = 40;
            label13.Text = "Número de tarjeta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(51, 149);
            label12.Name = "label12";
            label12.Size = new Size(296, 24);
            label12.TabIndex = 39;
            label12.Text = "Generar débitos a una tarjeta";
            // 
            // UC_generateDebits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(Debitos);
            Controls.Add(label17);
            Controls.Add(Generate_Debits);
            Controls.Add(Number_card);
            Controls.Add(label13);
            Controls.Add(label12);
            Name = "UC_generateDebits";
            Size = new Size(400, 491);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Debitos;
        private Label label17;
        private Button Generate_Debits;
        private TextBox Number_card;
        private Label label13;
        private Label label12;
    }
}
