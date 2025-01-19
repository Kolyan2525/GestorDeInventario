namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    partial class Gestion
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridViewGestProv = new DataGridView();
            dataGridViewGestCat = new DataGridView();
            agregarCatBut = new Button();
            agregarProvBut = new Button();
            label11 = new Label();
            label12 = new Label();
            eliminarCatBut = new Button();
            eliminarProvBut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBoxGestIDcat = new TextBox();
            textBoxGestNomCat = new TextBox();
            textBoxGestDescCat = new TextBox();
            textBoxGestIDprov = new TextBox();
            textBoxGestTelProv = new TextBox();
            textBoxGestNomProv = new TextBox();
            textBoxGestContProv = new TextBox();
            textBoxGestDirProv = new TextBox();
            volverBut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGestProv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGestCat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 77);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 77);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 5;
            label6.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 269);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 269);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "Contacto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 269);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 8;
            label9.Text = "Direccion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(441, 269);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 9;
            label10.Text = "Telefono:";
            // 
            // dataGridViewGestProv
            // 
            dataGridViewGestProv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGestProv.Location = new Point(12, 329);
            dataGridViewGestProv.Name = "dataGridViewGestProv";
            dataGridViewGestProv.Size = new Size(529, 97);
            dataGridViewGestProv.TabIndex = 10;
            // 
            // dataGridViewGestCat
            // 
            dataGridViewGestCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGestCat.Location = new Point(12, 113);
            dataGridViewGestCat.Name = "dataGridViewGestCat";
            dataGridViewGestCat.Size = new Size(529, 92);
            dataGridViewGestCat.TabIndex = 11;
            // 
            // agregarCatBut
            // 
            agregarCatBut.Location = new Point(533, 73);
            agregarCatBut.Name = "agregarCatBut";
            agregarCatBut.Size = new Size(75, 23);
            agregarCatBut.TabIndex = 12;
            agregarCatBut.Text = "Agregar";
            agregarCatBut.UseVisualStyleBackColor = true;
            agregarCatBut.Click += agregarCatBut_Click;
            // 
            // agregarProvBut
            // 
            agregarProvBut.Location = new Point(561, 287);
            agregarProvBut.Name = "agregarProvBut";
            agregarProvBut.Size = new Size(75, 23);
            agregarProvBut.TabIndex = 13;
            agregarProvBut.Text = "Agregar";
            agregarProvBut.UseVisualStyleBackColor = true;
            agregarProvBut.Click += agregarProvBut_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(605, 123);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 14;
            label11.Text = "ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(605, 338);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 15;
            label12.Text = "ID:";
            // 
            // eliminarCatBut
            // 
            eliminarCatBut.Location = new Point(605, 170);
            eliminarCatBut.Name = "eliminarCatBut";
            eliminarCatBut.Size = new Size(100, 23);
            eliminarCatBut.TabIndex = 16;
            eliminarCatBut.Text = "Eliminar";
            eliminarCatBut.UseVisualStyleBackColor = true;
            eliminarCatBut.Click += eliminarCatBut_Click;
            // 
            // eliminarProvBut
            // 
            eliminarProvBut.Location = new Point(605, 385);
            eliminarProvBut.Name = "eliminarProvBut";
            eliminarProvBut.Size = new Size(100, 23);
            eliminarProvBut.TabIndex = 17;
            eliminarProvBut.Text = "Eliminar";
            eliminarProvBut.UseVisualStyleBackColor = true;
            eliminarProvBut.Click += eliminarProvBut_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(605, 356);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(605, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            // 
            // textBoxGestIDcat
            // 
            textBoxGestIDcat.Location = new Point(39, 74);
            textBoxGestIDcat.Name = "textBoxGestIDcat";
            textBoxGestIDcat.Size = new Size(100, 23);
            textBoxGestIDcat.TabIndex = 20;
            // 
            // textBoxGestNomCat
            // 
            textBoxGestNomCat.Location = new Point(214, 74);
            textBoxGestNomCat.Name = "textBoxGestNomCat";
            textBoxGestNomCat.Size = new Size(100, 23);
            textBoxGestNomCat.TabIndex = 21;
            // 
            // textBoxGestDescCat
            // 
            textBoxGestDescCat.Location = new Point(406, 74);
            textBoxGestDescCat.Name = "textBoxGestDescCat";
            textBoxGestDescCat.Size = new Size(100, 23);
            textBoxGestDescCat.TabIndex = 22;
            // 
            // textBoxGestIDprov
            // 
            textBoxGestIDprov.Location = new Point(12, 287);
            textBoxGestIDprov.Name = "textBoxGestIDprov";
            textBoxGestIDprov.Size = new Size(100, 23);
            textBoxGestIDprov.TabIndex = 23;
            // 
            // textBoxGestTelProv
            // 
            textBoxGestTelProv.Location = new Point(441, 287);
            textBoxGestTelProv.Name = "textBoxGestTelProv";
            textBoxGestTelProv.Size = new Size(100, 23);
            textBoxGestTelProv.TabIndex = 24;
            // 
            // textBoxGestNomProv
            // 
            textBoxGestNomProv.Location = new Point(123, 287);
            textBoxGestNomProv.Name = "textBoxGestNomProv";
            textBoxGestNomProv.Size = new Size(100, 23);
            textBoxGestNomProv.TabIndex = 25;
            // 
            // textBoxGestContProv
            // 
            textBoxGestContProv.Location = new Point(229, 287);
            textBoxGestContProv.Name = "textBoxGestContProv";
            textBoxGestContProv.Size = new Size(100, 23);
            textBoxGestContProv.TabIndex = 26;
            // 
            // textBoxGestDirProv
            // 
            textBoxGestDirProv.Location = new Point(335, 287);
            textBoxGestDirProv.Name = "textBoxGestDirProv";
            textBoxGestDirProv.Size = new Size(100, 23);
            textBoxGestDirProv.TabIndex = 27;
            // 
            // volverBut
            // 
            volverBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volverBut.Location = new Point(692, 21);
            volverBut.Name = "volverBut";
            volverBut.Size = new Size(85, 32);
            volverBut.TabIndex = 28;
            volverBut.Text = "Volver";
            volverBut.UseVisualStyleBackColor = true;
            volverBut.Click += volverBut_Click;
            // 
            // Gestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(volverBut);
            Controls.Add(textBoxGestDirProv);
            Controls.Add(textBoxGestContProv);
            Controls.Add(textBoxGestNomProv);
            Controls.Add(textBoxGestTelProv);
            Controls.Add(textBoxGestIDprov);
            Controls.Add(textBoxGestDescCat);
            Controls.Add(textBoxGestNomCat);
            Controls.Add(textBoxGestIDcat);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(eliminarProvBut);
            Controls.Add(eliminarCatBut);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(agregarProvBut);
            Controls.Add(agregarCatBut);
            Controls.Add(dataGridViewGestCat);
            Controls.Add(dataGridViewGestProv);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Gestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Datos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGestProv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGestCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dataGridViewGestProv;
        private DataGridView dataGridViewGestCat;
        private Button agregarCatBut;
        private Button agregarProvBut;
        private Label label11;
        private Label label12;
        private Button eliminarCatBut;
        private Button eliminarProvBut;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxGestIDcat;
        private TextBox textBoxGestNomCat;
        private TextBox textBoxGestDescCat;
        private TextBox textBoxGestIDprov;
        private TextBox textBoxGestTelProv;
        private TextBox textBoxGestNomProv;
        private TextBox textBoxGestContProv;
        private TextBox textBoxGestDirProv;
        private Button volverBut;
    }
}