namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ModificarPBut_Click(object sender, EventArgs e)
        {
            ModificarProducto Modificar = new ModificarProducto();
            Modificar.Show();

            this.Hide();
        }

        private void GestionCatBut_Click(object sender, EventArgs e)
        {
            Consultas Modificar = new Consultas();
            Modificar.Show();

            this.Hide();
        }

        private void ConsultasBut_Click(object sender, EventArgs e)
        {
            Gestion Modificar = new Gestion();
            Modificar.Show();

            this.Hide();
        }

        private void ReportesBut_Click(object sender, EventArgs e)
        {
            Reportes Modificar = new Reportes();
            Modificar.Show();

            this.Hide();
        }
    }
}
