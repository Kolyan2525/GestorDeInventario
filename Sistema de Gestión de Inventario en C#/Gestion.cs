using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Sistema_de_Gestión_de_Inventario_en_C_
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
            LoadData();
        }

        string connectionString = @"Data Source=C:\Users\nikol\source\repos\Sistema de Gestión de Inventario en C#\Sistema de Gestión de Inventario en C#\Database1.db;Version=3;";
        public void LoadData()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Categorias";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewGestCat.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando categories: " + ex.Message);
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Proveedores";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewGestProv.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando proveedores: " + ex.Message);
            }
        }

        private void volverBut_Click(object sender, EventArgs e)
        {
            Form1 Modificar = new Form1();
            Modificar.Show();

            this.Hide();
        }

        private void agregarCatBut_Click(object sender, EventArgs e)
        {
            // verificar que todos los campos esten completos
            if (string.IsNullOrWhiteSpace(textBoxGestIDcat.Text) ||
                string.IsNullOrWhiteSpace(textBoxGestNomCat.Text) ||
                string.IsNullOrWhiteSpace(textBoxGestDescCat.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            // obtener los valores de los campos de texto
            int Id_Categoria = int.Parse(textBoxGestIDcat.Text);
            string Nombre_Categoria = textBoxGestNomCat.Text;
            string Descripcion_Categoria = textBoxGestDescCat.Text;

            // query para insertar categoria en la base de datos
            string query = "INSERT INTO Categorias (Id_Categoria, Nombre_Categoria, Descripcion) VALUES (@Id_Categoria, @Nombre_Categoria, @Descripcion)";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametros al comando
                        command.Parameters.AddWithValue("@Id_Categoria", Id_Categoria);
                        command.Parameters.AddWithValue("@Nombre_Categoria", Nombre_Categoria);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion_Categoria);

                        // ejecutar el comando y verificar el resultado
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category added successfully!");
                            LoadData(); // recargar los datos en la tabla
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
            }
        }

        private void eliminarCatBut_Click(object sender, EventArgs e)
        {
            // verificando se esta llena la info
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Proporcione un ID.");
                return;
            }

            // obtener valores
            int Id_Producto = int.Parse(textBox2.Text);

            string query = "DELETE FROM Categorias WHERE Id_Categoria = @Id_Categoria";

            try
            {
                // crear conexion
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametro
                        command.Parameters.AddWithValue("@Id_Categoria", Id_Producto);

                        // ejecutar comando
                        int rowsAffected = command.ExecuteNonQuery();

                        // verificar si se elimino
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Categoria ha sido eliminado!");
                            LoadData(); // recargar tabla
                        }
                        else
                        {
                            MessageBox.Show("No se encontro una categoria con ese ID.");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar categoria " + ex.Message);
            }
        }

        private void agregarProvBut_Click(object sender, EventArgs e)
        {
            // verificar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(textBoxGestIDprov.Text) ||
                string.IsNullOrWhiteSpace(textBoxGestNomProv.Text) ||
                string.IsNullOrWhiteSpace(textBoxGestContProv.Text) ||
                string.IsNullOrWhiteSpace(textBoxGestDirProv.Text) ||
                string.IsNullOrWhiteSpace(textBoxGestTelProv.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            // obtener los valores de los campos de texto
            int Id_Proveedor;
            if (!int.TryParse(textBoxGestIDprov.Text, out Id_Proveedor))
            {
                MessageBox.Show("ID must be a valid number.");
                return;
            }
            string Nombre_Empresa = textBoxGestNomProv.Text;
            string Contacto = textBoxGestContProv.Text;
            string Direccion = textBoxGestDirProv.Text;
            string Telefono = textBoxGestTelProv.Text;

            // query para insertar proveedor en la base de datos
            string query = "INSERT INTO Proveedores (Id_Proveedor, Nombre_Empresa, Contacto, Direccion, Telefono) " +
                           "VALUES (@Id_Proveedor, @Nombre_Empresa, @Contacto, @Direccion, @Telefono)";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parámetros al comando
                        command.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
                        command.Parameters.AddWithValue("@Nombre_Empresa", Nombre_Empresa);
                        command.Parameters.AddWithValue("@Contacto", Contacto);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.Parameters.AddWithValue("@Telefono", Telefono);

                        // ejecutar el comando y verificar el resultado
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Provider added successfully!");
                            LoadProviders(); // recargar los datos en la tabla de proveedores
                        }
                        else
                        {
                            MessageBox.Show("Error para agregar proveedor.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregando proveedor: " + ex.Message);
            }
        }

        private void LoadProviders()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Proveedores";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewGestProv.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando providers: " + ex.Message);
            }
        }

        private void eliminarProvBut_Click(object sender, EventArgs e)
        {
            // verificando se esta llena la info
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Proporcione un ID.");
                return;
            }

            // obtener valores
            int Id_Producto = int.Parse(textBox1.Text);

            string query = "DELETE FROM Proveedores WHERE Id_Proveedor = @Id_Proveedor";

            try
            {
                // crear conexion
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametro
                        command.Parameters.AddWithValue("@Id_Proveedor", Id_Producto);

                        // ejecutar comando
                        int rowsAffected = command.ExecuteNonQuery();

                        // verificar si se elimino
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proveedor ha sido eliminado!");
                            LoadData(); // recargar tabla
                        }
                        else
                        {
                            MessageBox.Show("No se encontro un proveedor con ese ID.");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor " + ex.Message);
            }
        }
    }
}
