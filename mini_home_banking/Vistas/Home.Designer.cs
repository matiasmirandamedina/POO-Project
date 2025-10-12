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
            SuspendLayout();
            // 
            // listBoxCuentas
            // 
            listBoxCuentas.FormattingEnabled = true;
            listBoxCuentas.ItemHeight = 15;
            listBoxCuentas.Location = new Point(51, 117);
            listBoxCuentas.Name = "listBoxCuentas";
            listBoxCuentas.Size = new Size(182, 79);
            listBoxCuentas.TabIndex = 0;
            listBoxCuentas.SelectedIndexChanged += listBoxCuentas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 85);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Cuentas";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 343);
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
    }
}