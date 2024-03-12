using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryManagementSystem : Form
    {
        DataTable inventory = new DataTable();
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public InventoryManagementSystem()
        {
            InitializeComponent();
        }
        private void SaveDataToDatabase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand("TRUNCATE TABLE Inventory", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = "Inventory";

                    connection.Open();
                    bulkCopy.WriteToServer(inventory);
                }
            }
        }
        private void InventoryManagementSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToDatabase();
        }
        private void LoadDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string query = "SELECT * FROM Inventory";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    inventory = table;
                    inventoryGridView.DataSource = inventory;
                }
            }
        }
        private void LoadData()
        {
            try
            {
                // Clear existing data in the inventory DataTable
                inventory.Clear();

                // Open the connection
                connection.Open();

                // Select all records from the Inventory table
                string query = "SELECT * FROM Inventory";

                // Create a SqlCommand object
                SqlCommand command = new SqlCommand(query, connection);

                // Create a SqlDataReader object to read the data
                SqlDataReader reader = command.ExecuteReader();

                // Read the data and add rows to the inventory DataTable
                while (reader.Read())
                {
                    DataRow newRow = inventory.NewRow();
                    newRow["SKU"] = reader["SKU"];
                    newRow["Name"] = reader["Name"];
                    newRow["Category"] = reader["Category"];
                    newRow["Price"] = reader["Price"];
                    newRow["Description"] = reader["Description"];
                    newRow["Quantity"] = reader["Quantity"];
                    inventory.Rows.Add(newRow);
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.SelectedCells.Count > 0)
            {
                int rowIndex = inventoryGridView.SelectedCells[0].RowIndex;
                string sku = inventoryGridView.Rows[rowIndex].Cells["SKU"].Value.ToString();

                string columnName = inventoryGridView.Columns[inventoryGridView.SelectedCells[0].ColumnIndex].Name;
                string updatedValue = inventoryGridView.SelectedCells[0].Value.ToString();

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "UPDATE Inventory SET " + columnName + " = @value WHERE SKU = @sku";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value", updatedValue);
                        command.Parameters.AddWithValue("@sku", sku);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Reload the data from the database to reflect the changes
                LoadDataFromDatabase();
            }
            else
            {
                MessageBox.Show("Please select a cell before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            // save all our values from our fields into the variables
            string sku = skuTextBox.Text;
            string name = nameTextBox.Text;
            string price = priceTextBox.Text;
            string description = descriptionTextBox.Text;
            string quantity = quantityTextBox.Text;
            string category = (string)categoryBox.SelectedItem;

            try
            {
                // create a connection
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    // create a command to insert the data
                    string query = "INSERT INTO Inventory (SKU, Name, Category, Price, Description, Quantity) VALUES (@sku, @name, @category, @price, @description, @quantity)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // add parameters to the command
                        command.Parameters.AddWithValue("@sku", sku);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@quantity", quantity);

                        // open the connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // reload the data from the database to reflect the changes
                LoadDataFromDatabase();

                // clear fields after save
                newButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: Please make sure your inputted data is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.SelectedCells.Count > 0)
            {
                int rowIndex = inventoryGridView.SelectedCells[0].RowIndex;
                string sku = inventoryGridView.Rows[rowIndex].Cells["SKU"].Value.ToString();

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "DELETE FROM Inventory WHERE SKU = @sku";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sku", sku);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Reload the data from the database to reflect the changes
                LoadDataFromDatabase();
            }
            else
            {
                MessageBox.Show("Please select a cell before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                String itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryBox.SelectedIndex = categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("There was an error: " + err);
            }
        }

        private void InventoryManagementSystem_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Quantity");
            inventory.Columns.Add("Description");


            inventoryGridView.DataSource = inventory;
            findTextBox.TextChanged += findTextBox_TextChanged;
            LoadDataFromDatabase();

            categoryBox.Text = "Ink";
            FilterBox.Text = "SKU";
        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterValue = findTextBox.Text.Trim();
            string filterColumn = FilterBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(filterValue))
            {
                // Reload all data if the search box is empty
                LoadDataFromDatabase();
                return;
            }

            try
            {
                string query = "SELECT * FROM Inventory WHERE " + filterColumn + " LIKE @value";
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Geoffrey\\Documents\\Inventory.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for the value with wildcard for partial matching
                        command.Parameters.AddWithValue("@value", "%" + filterValue + "%");

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable filteredTable = new DataTable();
                        filteredTable.Load(reader);

                        inventory = filteredTable;
                        inventoryGridView.DataSource = inventory;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}