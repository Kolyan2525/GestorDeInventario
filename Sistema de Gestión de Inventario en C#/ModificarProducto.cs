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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
            LoadData();
        }

        string connectionString = @"Data Source=C:\Users\nikol\source\repos\Sistema de Gestión de Inventario en C#\Sistema de Gestión de Inventario en C#\Database1.db;Version=3;";

        public void LoadData()
        {
            try
            {
                // crear conexion con base de datos
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    // abrir conexion 
                    connection.Open();

                    // definir query
                    string query = "SELECT * FROM Productos";

                    // ejecutar query y llenar tabla
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // unir datatable con el gridview
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando data: " + ex.Message);
            }
        }

        private void AgregarProdBut_Click(object sender, EventArgs e)
        {
            // viendo si se lleno la info
            if (string.IsNullOrWhiteSpace(textBoxID.Text) ||
                string.IsNullOrWhiteSpace(textBoxNom.Text) ||
                string.IsNullOrWhiteSpace(textBoxCodigo.Text) ||
                string.IsNullOrWhiteSpace(textBoxCateg.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxExistencia.Text) ||
                string.IsNullOrWhiteSpace(textBoxIDproveedor.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            // obtener valores
            int Id_Producto = int.Parse(textBoxID.Text);
            string Nombre = textBoxNom.Text;
            string Codigo_Producto = textBoxCodigo.Text;
            string ID_Categoria = textBoxCateg.Text;
            decimal Precio = decimal.Parse(textBoxPrecio.Text);
            int Existencia = int.Parse(textBoxExistencia.Text);
            int ID_Proveedor = int.Parse(textBoxIDproveedor.Text);

            string query = "INSERT INTO Productos (Id_Producto, Nombre, Codigo_Producto, ID_Categoria, Precio, Existencia, ID_Proveedor) " +
                "VALUES (@Id_Producto, @Nombre, @Codigo_Producto, @ID_Categoria, @Precio, @Existencia, @ID_Proveedor)";

            try
            {
                // crear conexion 
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    // abrir conexion
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametros
                        command.Parameters.AddWithValue("@Id_Producto", Id_Producto);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Codigo_Producto", Codigo_Producto);
                        command.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Existencia", Existencia);
                        command.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto agregado exitosamente!");
                            LoadData(); // recargar datos en la tabla 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void RemoverProdBut_Click(object sender, EventArgs e)
        {
            // verificando se esta llena la info
            if (string.IsNullOrWhiteSpace(textBoxRemover.Text))
            {
                MessageBox.Show("Proporcione un ID.");
                return;
            }

            // obtener valores
            int Id_Producto = int.Parse(textBoxRemover.Text);

            string query = "DELETE FROM Productos WHERE Id_Producto = @Id_Producto";

            try
            {
                // crear conexion
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // agregar parametro
                        command.Parameters.AddWithValue("@Id_Producto", Id_Producto);

                        // ejecutar comando
                        int rowsAffected = command.ExecuteNonQuery();

                        // verificar si se elimino
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto ha sido eliminado!");
                            LoadData(); // recargar tabla
                        }
                        else
                        {
                            MessageBox.Show("No se encontro un producto con ese ID.");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto " + ex.Message);
            }
        }

        private void volverBut_Click(object sender, EventArgs e)
        {
            Form1 Modificar = new Form1();
            Modificar.Show();

            this.Hide();
        }
    }
}
