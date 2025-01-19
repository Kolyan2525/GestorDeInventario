namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    partial class Reportes
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
            dataGridViewReportes = new DataGridView();
            volverBut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(444, 45);
            label1.TabIndex = 0;
            label1.Text = "Reportes de inventario bajo";
            // 
            // dataGridViewReportes
            // 
            dataGridViewReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReportes.Location = new Point(12, 104);
            dataGridViewReportes.Name = "dataGridViewReportes";
            dataGridViewReportes.Size = new Size(776, 334);
            dataGridViewReportes.TabIndex = 1;
            // 
            // volverBut
            // 
            volverBut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volverBut.Location = new Point(667, 24);
            volverBut.Name = "volverBut";
            volverBut.Size = new Size(101, 30);
            volverBut.TabIndex = 2;
            volverBut.Text = "Volver";
            volverBut.UseVisualStyleBackColor = true;
            volverBut.Click += volverBut_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(volverBut);
            Controls.Add(dataGridViewReportes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewReportes;
        private Button volverBut;
    }
}