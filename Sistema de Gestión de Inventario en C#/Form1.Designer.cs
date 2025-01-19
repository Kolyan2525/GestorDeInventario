namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ModificarPBut = new Button();
            ConsultaBut = new Button();
            ConsultasBut = new Button();
            ReportesBut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 99.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 100);
            label1.Name = "label1";
            label1.Size = new Size(593, 406);
            label1.TabIndex = 0;
            label1.Text = "Menu General";
            // 
            // ModificarPBut
            // 
            ModificarPBut.BackColor = SystemColors.InactiveBorder;
            ModificarPBut.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModificarPBut.Location = new Point(636, 32);
            ModificarPBut.Name = "ModificarPBut";
            ModificarPBut.Size = new Size(301, 123);
            ModificarPBut.TabIndex = 1;
            ModificarPBut.Text = "Modificar Productos";
            ModificarPBut.UseVisualStyleBackColor = false;
            ModificarPBut.Click += ModificarPBut_Click;
            // 
            // ConsultaBut
            // 
            ConsultaBut.BackColor = SystemColors.InactiveBorder;
            ConsultaBut.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConsultaBut.Location = new Point(636, 175);
            ConsultaBut.Name = "ConsultaBut";
            ConsultaBut.Size = new Size(301, 134);
            ConsultaBut.TabIndex = 2;
            ConsultaBut.Text = "Consultas";
            ConsultaBut.UseVisualStyleBackColor = false;
            ConsultaBut.Click += GestionCatBut_Click;
            // 
            // ConsultasBut
            // 
            ConsultasBut.BackColor = SystemColors.InactiveBorder;
            ConsultasBut.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConsultasBut.Location = new Point(636, 328);
            ConsultasBut.Name = "ConsultasBut";
            ConsultasBut.Size = new Size(301, 94);
            ConsultasBut.TabIndex = 3;
            ConsultasBut.Text = "Gestion";
            ConsultasBut.UseVisualStyleBackColor = false;
            ConsultasBut.Click += ConsultasBut_Click;
            // 
            // ReportesBut
            // 
            ReportesBut.BackColor = SystemColors.InactiveBorder;
            ReportesBut.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReportesBut.Location = new Point(636, 446);
            ReportesBut.Name = "ReportesBut";
            ReportesBut.Size = new Size(301, 99);
            ReportesBut.TabIndex = 4;
            ReportesBut.Text = "Reportes";
            ReportesBut.UseVisualStyleBackColor = false;
            ReportesBut.Click += ReportesBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1051, 588);
            Controls.Add(ReportesBut);
            Controls.Add(ConsultasBut);
            Controls.Add(ConsultaBut);
            Controls.Add(ModificarPBut);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa de Inventario";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ModificarPBut;
        private Button ConsultaBut;
        private Button ConsultasBut;
        private Button ReportesBut;
    }
}
