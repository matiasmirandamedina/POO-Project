namespace mini_home_banking.Vistas
{
    partial class Client
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
            panelVar = new Panel();
            label21 = new Label();
            convertCurrencyVar = new Button();
            transferenceVar = new Button();
            homeUserVar = new Button();
            panel1 = new Panel();
            panelVar.SuspendLayout();
            SuspendLayout();
            // 
            // panelVar
            // 
            panelVar.BackColor = Color.Teal;
            panelVar.Controls.Add(label21);
            panelVar.Controls.Add(convertCurrencyVar);
            panelVar.Controls.Add(transferenceVar);
            panelVar.Controls.Add(homeUserVar);
            panelVar.Dock = DockStyle.Left;
            panelVar.Location = new Point(0, 0);
            panelVar.Name = "panelVar";
            panelVar.Size = new Size(200, 450);
            panelVar.TabIndex = 43;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Harrington", 15F, FontStyle.Bold | FontStyle.Italic);
            label21.ForeColor = SystemColors.ControlLightLight;
            label21.Location = new Point(67, 25);
            label21.Name = "label21";
            label21.Size = new Size(61, 24);
            label21.TabIndex = 43;
            label21.Text = "Menú";
            // 
            // convertCurrencyVar
            // 
            convertCurrencyVar.BackColor = Color.DarkSlateGray;
            convertCurrencyVar.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertCurrencyVar.ForeColor = SystemColors.ControlLightLight;
            convertCurrencyVar.Location = new Point(12, 157);
            convertCurrencyVar.Name = "convertCurrencyVar";
            convertCurrencyVar.Size = new Size(171, 35);
            convertCurrencyVar.TabIndex = 44;
            convertCurrencyVar.Text = "Convertir Moneda";
            convertCurrencyVar.UseVisualStyleBackColor = false;
            convertCurrencyVar.Click += convertCurrencyVar_Click;
            // 
            // transferenceVar
            // 
            transferenceVar.BackColor = Color.DarkSlateGray;
            transferenceVar.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transferenceVar.ForeColor = SystemColors.ControlLightLight;
            transferenceVar.Location = new Point(12, 109);
            transferenceVar.Name = "transferenceVar";
            transferenceVar.Size = new Size(171, 35);
            transferenceVar.TabIndex = 43;
            transferenceVar.Text = "Transferencia";
            transferenceVar.UseVisualStyleBackColor = false;
            transferenceVar.Click += transferenceVar_Click;
            // 
            // homeUserVar
            // 
            homeUserVar.BackColor = Color.DarkSlateGray;
            homeUserVar.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeUserVar.ForeColor = SystemColors.ControlLightLight;
            homeUserVar.Location = new Point(12, 61);
            homeUserVar.Name = "homeUserVar";
            homeUserVar.Size = new Size(171, 35);
            homeUserVar.TabIndex = 42;
            homeUserVar.Text = "Home";
            homeUserVar.UseVisualStyleBackColor = false;
            homeUserVar.Click += homeUserVar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 44;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(panelVar);
            Controls.Add(panel1);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            panelVar.ResumeLayout(false);
            panelVar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVar;
        private Label label21;
        private Button summaryCard;
        private Button convertCurrencyVar;
        private Button transferenceVar;
        private Button homeUserVar;
        private Panel panel1;
    }
}