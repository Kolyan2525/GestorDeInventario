namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    partial class ModificarProducto
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
            dataGridView1 = new DataGridView();
            AgregarProductoL = new Label();
            RemoverProdutoL = new Label();
            textBoxRemover = new TextBox();
            IDLa = new Label();
            RemoverProdBut = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AgregarProdBut = new Button();
            textBoxID = new TextBox();
            textBoxNom = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxCateg = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxExistencia = new TextBox();
            textBoxIDproveedor = new TextBox();
            volverBut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(891, 175);
            dataGridView1.TabIndex = 0;
            // 
            // AgregarProductoL
            // 
            AgregarProductoL.AutoSize = true;
            AgregarProductoL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AgregarProductoL.Location = new Point(12, 9);
            AgregarProductoL.Name = "AgregarProductoL";
            AgregarProductoL.Size = new Size(137, 21);
            AgregarProductoL.TabIndex = 1;
            AgregarProductoL.Text = "Agregar Producto";
            // 
            // RemoverProdutoL
            // 
            RemoverProdutoL.AutoSize = true;
            RemoverProdutoL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            RemoverProdutoL.Location = new Point(12, 115);
            RemoverProdutoL.Name = "RemoverProdutoL";
            RemoverProdutoL.Size = new Size(142, 21);
            RemoverProdutoL.TabIndex = 2;
            RemoverProdutoL.Text = "Remover Producto";
            // 
            // textBoxRemover
            // 
            textBoxRemover.BackColor = SystemColors.Window;
            textBoxRemover.Location = new Point(12, 171);
            textBoxRemover.Name = "textBoxRemover";
            textBoxRemover.Size = new Size(100, 23);
            textBoxRemover.TabIndex = 3;
            // 
            // IDLa
            // 
            IDLa.AutoSize = true;
            IDLa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDLa.Location = new Point(12, 153);
            IDLa.Name = "IDLa";
            IDLa.Size = new Size(23, 15);
            IDLa.TabIndex = 4;
            IDLa.Text = "ID:";
            // 
            // RemoverProdBut
            // 
            RemoverProdBut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoverProdBut.Location = new Point(118, 171);
            RemoverProdBut.Name = "RemoverProdBut";
            RemoverProdBut.Size = new Size(75, 23);
            RemoverProdBut.TabIndex = 5;
            RemoverProdBut.Text = "Remover";
            RemoverProdBut.UseVisualStyleBackColor = true;
            RemoverProdBut.Click += RemoverProdBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 42);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 7;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 42);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 42);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Codigo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 42);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 42);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 11;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(654, 42);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 12;
            label7.Text = "Existencia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(767, 42);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 13;
            label8.Text = "ID (Proveedor)";
            // 
            // AgregarProdBut
            // 
            AgregarProdBut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarProdBut.Location = new Point(767, 115);
            AgregarProdBut.Name = "AgregarProdBut";
            AgregarProdBut.Size = new Size(100, 28);
            AgregarProdBut.TabIndex = 14;
            AgregarProdBut.Text = "Agregar";
            AgregarProdBut.UseVisualStyleBackColor = true;
            AgregarProdBut.Click += AgregarProdBut_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(12, 69);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 15;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(142, 69);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 16;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(274, 69);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 17;
            // 
            // textBoxCateg
            // 
            textBoxCateg.Location = new Point(405, 69);
            textBoxCateg.Name = "textBoxCateg";
            textBoxCateg.Size = new Size(100, 23);
            textBoxCateg.TabIndex = 18;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(533, 69);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(100, 23);
            textBoxPrecio.TabIndex = 19;
            // 
            // textBoxExistencia
            // 
            textBoxExistencia.Location = new Point(654, 69);
            textBoxExistencia.Name = "textBoxExistencia";
            textBoxExistencia.Size = new Size(100, 23);
            textBoxExistencia.TabIndex = 20;
            // 
            // textBoxIDproveedor
            // 
            textBoxIDproveedor.Location = new Point(767, 69);
            textBoxIDproveedor.Name = "textBoxIDproveedor";
            textBoxIDproveedor.Size = new Size(100, 23);
            textBoxIDproveedor.TabIndex = 21;
            // 
            // volverBut
            // 
            volverBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volverBut.Location = new Point(700, 171);
            volverBut.Name = "volverBut";
            volverBut.Size = new Size(203, 34);
            volverBut.TabIndex = 22;
            volverBut.Text = "Volver a pagina inicial";
            volverBut.UseVisualStyleBackColor = true;
            volverBut.Click += volverBut_Click;
            // 
            // ModificarProducto
            // 
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(917, 406);
            Controls.Add(volverBut);
            Controls.Add(textBoxIDproveedor);
            Controls.Add(textBoxExistencia);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxCateg);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNom);
            Controls.Add(textBoxID);
            Controls.Add(AgregarProdBut);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RemoverProdBut);
            Controls.Add(IDLa);
            Controls.Add(textBoxRemover);
            Controls.Add(RemoverProdutoL);
            Controls.Add(AgregarProductoL);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ModificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificacion de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label AgregarProductoL;
        private Label RemoverProdutoL;
        private TextBox textBoxRemover;
        private Label IDLa;
        private Button RemoverProdBut;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button AgregarProdBut;
        private TextBox textBoxID;
        private TextBox textBoxNom;
        private TextBox textBoxCodigo;
        private TextBox textBoxCateg;
        private TextBox textBoxPrecio;
        private TextBox textBoxExistencia;
        private TextBox textBoxIDproveedor;
        private Button volverBut;
    }
}