using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    public partial class Consultas : Form
    {
        // conexion a base de datos
        string connectionString = @"Data Source=C:\Users\nikol\source\repos\Sistema de Gestión de Inventario en C#\Sistema de Gestión de Inventario en C#\Database1.db;Version=3;";

        public Consultas()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProveedores();
        }

        // CATEGORIAS

        // metodo para cargar las categorias en la caja 
        private void CargarCategorias()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id_Categoria, Nombre_Categoria FROM Categorias";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        comboBox1.Items.Clear();

                        while (reader.Read())
                        {
                            comboBox1.Items.Add(new ComboboxItem
                            {
                                Text = reader["Nombre_Categoria"].ToString(),
                                Value = reader["Id_Categoria"]
                            });
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias" + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null)
            {
                // obtener item seleccionado
                var selectedItem = (ComboboxItem)comboBox1.SelectedItem;

                // obtener id de la categoria seleccionada
                long CategoriaSeleccionadaId = (long)selectedItem.Value;

                // llamar a funcion para poner productos que son de esa categoria
                CargarProductosPorCategoria(CategoriaSeleccionadaId);
            }
        }

        // metodo para cargar productos al dataview
        private void CargarProductosPorCategoria(long categoriaId)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // unir productos con categorias para filtar por categoria id
                    string query = @"
                SELECT p.Id_Producto, p.Nombre, p.Codigo_Producto, p.Precio, p.Existencia, p.ID_Proveedor
                FROM Productos p
                INNER JOIN Categorias c ON p.ID_Categoria = c.Nombre_Categoria
                WHERE c.Id_Categoria = @CategoriaId";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametro de categoria al query
                        command.Parameters.AddWithValue("@CategoriaId", categoriaId);

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // asignar al dataview
                            dataGridViewCategorias.DataSource = table;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        // clase para almacenar texto y valor de cada item del box
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        // PROVEEDORES
        private void CargarProveedores()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id_Proveedor, Nombre_Empresa FROM Proveedores";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        comboBox2.Items.Clear();

                        while (reader.Read())
                        {
                            comboBox2.Items.Add(new ComboboxItem
                            {
                                Text = reader["Nombre_Empresa"].ToString(),
                                Value = reader["Id_Proveedor"]
                            });
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores" + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != null)
            {
                // obtener item seleccionado
                var selectedItem = (ComboboxItem)comboBox2.SelectedItem;

                // obtener id de la categoria seleccionada
                long ProveedorSeleccionadoId = (long)selectedItem.Value;

                // llamar a funcion para poner productos que son de esa categoria
                CargarProductosPorProveedor(ProveedorSeleccionadoId);
            }
        }

        private void CargarProductosPorProveedor(long proveedorId)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id_Proveedor, Nombre_Empresa, Contacto, Direccion," +
                        "Telefono FROM Proveedores WHERE ID_Proveedor = @ProveedorId";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametro de categoria al query
                        command.Parameters.AddWithValue("@ProveedorId", proveedorId);

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // asignar al dataview
                            dataGridViewProveedores.DataSource = table;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: \n" + ex.Message);
            }
        }
        public class ComboboxItem2
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void volverBut_Click(object sender, EventArgs e)
        {
            Form1 Modificar = new Form1();
            Modificar.Show();

            this.Hide();
        }
    }
}
