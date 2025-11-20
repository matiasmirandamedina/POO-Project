namespace mini_home_banking.Vistas
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing" />
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label16 = new Label();
            panelVar = new Panel();
            label21 = new Label();
            summaryCard = new Button();
            generateDebitsVar = new Button();
            insertAccountVar = new Button();
            insertUserVar = new Button();
            panel1 = new Panel();
            panelVar.SuspendLayout();
            SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Harrington", 12F);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(600, 278);
            label16.Name = "label16";
            label16.Size = new Size(0, 19);
            label16.TabIndex = 32;
            // 
            // panelVar
            // 
            panelVar.BackColor = Color.Teal;
            panelVar.Controls.Add(label21);
            panelVar.Controls.Add(summaryCard);
            panelVar.Controls.Add(generateDebitsVar);
            panelVar.Controls.Add(insertAccountVar);
            panelVar.Controls.Add(insertUserVar);
            panelVar.Dock = DockStyle.Left;
            panelVar.Location = new Point(0, 0);
            panelVar.Name = "panelVar";
            panelVar.Size = new Size(200, 491);
            panelVar.TabIndex = 41;
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
            // summaryCard
            // 
            summaryCard.BackColor = Color.DarkSlateGray;
            summaryCard.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryCard.ForeColor = SystemColors.ControlLightLight;
            summaryCard.Location = new Point(12, 206);
            summaryCard.Name = "summaryCard";
            summaryCard.Size = new Size(171, 35);
            summaryCard.TabIndex = 45;
            summaryCard.Text = "Resumen de tarjeta";
            summaryCard.UseVisualStyleBackColor = false;
            summaryCard.Click += summaryCard_Click;
            // 
            // generateDebitsVar
            // 
            generateDebitsVar.BackColor = Color.DarkSlateGray;
            generateDebitsVar.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateDebitsVar.ForeColor = SystemColors.ControlLightLight;
            generateDebitsVar.Location = new Point(12, 157);
            generateDebitsVar.Name = "generateDebitsVar";
            generateDebitsVar.Size = new Size(171, 35);
            generateDebitsVar.TabIndex = 44;
            generateDebitsVar.Text = "Generar Debitos";
            generateDebitsVar.UseVisualStyleBackColor = false;
            generateDebitsVar.Click += generateDebitsVar_Click;
            // 
            // insertAccountVar
            // 
            insertAccountVar.BackColor = Color.DarkSlateGray;
            insertAccountVar.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertAccountVar.ForeColor = SystemColors.ControlLightLight;
            insertAccountVar.Location = new Point(12, 109);
            insertAccountVar.Name = "insertAccountVar";
            insertAccountVar.Size = new Size(171, 35);
            insertAccountVar.TabIndex = 43;
            insertAccountVar.Text = "Insertar Cuenta";
            insertAccountVar.UseVisualStyleBackColor = false;
            insertAccountVar.Click += insertAccountVar_Click;
            // 
            // insertUserVar
            // 
            insertUserVar.BackColor = Color.DarkSlateGray;
            insertUserVar.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertUserVar.ForeColor = SystemColors.ControlLightLight;
            insertUserVar.Location = new Point(12, 61);
            insertUserVar.Name = "insertUserVar";
            insertUserVar.Size = new Size(171, 35);
            insertUserVar.TabIndex = 42;
            insertUserVar.Text = "Insertar Usuario";
            insertUserVar.UseVisualStyleBackColor = false;
            insertUserVar.Click += insertUserVar_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 491);
            panel1.TabIndex = 42;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(600, 491);
            Controls.Add(panelVar);
            Controls.Add(label16);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana de administrador";
            Load += Admin_Load;
            panelVar.ResumeLayout(false);
            panelVar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label16;
        private Panel panelVar;
        private Button insertUserVar;
        private Button summaryCard;
        private Button generateDebitsVar;
        private Button insertAccountVar;
        private Panel panel1;
        private Label label21;
    }
}