namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    partial class Consultas
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
            dataGridViewCategorias = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridViewProveedores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            volverBut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            dataGridViewCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategorias.Location = new Point(214, 90);
            dataGridViewCategorias.Name = "dataGridViewCategorias";
            dataGridViewCategorias.Size = new Size(574, 126);
            dataGridViewCategorias.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 312);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Location = new Point(214, 312);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.Size = new Size(574, 126);
            dataGridViewProveedores.TabIndex = 3;
            dataGridViewProveedores.CellContentClick += dataGridViewProveedores_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 39);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 4;
            label1.Text = "Consultas de Categorias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 251);
            label2.Name = "label2";
            label2.Size = new Size(295, 32);
            label2.TabIndex = 5;
            label2.Text = "Consultas de Proveedores";
            // 
            // volverBut
            // 
            volverBut.Location = new Point(23, 22);
            volverBut.Name = "volverBut";
            volverBut.Size = new Size(83, 29);
            volverBut.TabIndex = 6;
            volverBut.Text = "Volver";
            volverBut.UseVisualStyleBackColor = true;
            volverBut.Click += volverBut_Click;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(volverBut);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridViewCategorias);
            Name = "Consultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCategorias;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridViewProveedores;
        private Label label1;
        private Label label2;
        private Button volverBut;
    }
}