using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            LoadData();
        }

        // conexion a base de datos
        string connectionString = @"Data Source=C:\Users\nikol\source\repos\Sistema de Gestión de Inventario en C#\Sistema de Gestión de Inventario en C#\Database1.db;Version=3;";

        // cargar tabla
        public void LoadData()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    // query para seleccionar productos con menos de 10 existencias
                    string query = "SELECT * FROM Productos WHERE Existencia < 10";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewReportes.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low inventory products: " + ex.Message);
            }
        }

        // boton de eliminar
        private void volverBut_Click(object sender, EventArgs e)
        {
            Form1 Modificar = new Form1();
            Modificar.Show();

            this.Hide();
        }
    }
}
