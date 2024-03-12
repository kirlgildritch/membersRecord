using employeeManagement.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace employeeManagement
{
  
    public partial class Inventory : Form
    {
        private Main main;
        DataTable inventory = new DataTable();
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;";
        public Inventory()
        {
            InitializeComponent();

        
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            

          

            inventoryGridView.CellValueChanged += inventoryGridView_CellValueChanged;
            findTextBox.TextChanged += searchBox_TextChanged;
            LoadDataFromDatabase();
            this.KeyPreview = true; // Enable KeyPreview for the form

            SaveDataToDatabase();
            FilterBox.Text = "Item";
        }
        private void LoadDataFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Inventory";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                   
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        inventory = table;
                        CalculateRemainingBalance();

                        inventoryGridView.DataSource = inventory;
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateRemainingBalance()
        {
            foreach (DataRow row in inventory.Rows)
            {
                int quantityIn = Convert.ToInt32(row["in"]);
                int quantityOut = Convert.ToInt32(row["out"]);
                int remainingBalance = quantityIn - quantityOut;

                // Add or update the Remaining Balance column in the DataTable
                if (!inventory.Columns.Contains("Remaining Balance"))
                {
                    inventory.Columns.Add("Remaining Balance", typeof(int));
                }

                row["Remaining Balance"] = remainingBalance;
            }
        }
        private void SaveDataToDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Clear existing data in the table
                    using (SqlCommand clearCommand = new SqlCommand("TRUNCATE TABLE Inventory", connection))
                    {
                        clearCommand.ExecuteNonQuery();
                    }

                    // Update remaining balance and save data to the database
                    using (SqlCommand updateCommand = new SqlCommand("INSERT INTO Inventory (ITEM, SPECIFICATION, Price, [in], [out], [Remaining Balance]) VALUES (@ITEM, @SPECIFICATION, @Price, @in, @out, @RemainingBalance)", connection))
                    {
                        foreach (DataRow row in inventory.Rows)
                        {
                            int quantityIn = Convert.ToInt32(row["in"]);
                            int quantityOut = Convert.ToInt32(row["out"]);
                            int remainingBalance = quantityIn - quantityOut;

                            updateCommand.Parameters.Clear();
                            updateCommand.Parameters.AddWithValue("@ITEM", row["ITEM"]);
                            updateCommand.Parameters.AddWithValue("@SPECIFICATION", row["SPECIFICATION"]);
                            updateCommand.Parameters.AddWithValue("@Price", row["Price"]);
                            updateCommand.Parameters.AddWithValue("@in", quantityIn);
                            updateCommand.Parameters.AddWithValue("@out", quantityOut);
                            updateCommand.Parameters.AddWithValue("@RemainingBalance", remainingBalance);

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
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
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;"))
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

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private bool isUpdating = false;
        private int selectedRowIndex = -1;
        private void updateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isUpdating)
                {
                    isUpdating = true;

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        bool allUpdatesSuccessful = true;

                        using (SqlCommand cmd = new SqlCommand("UPDATE Inventory SET ITEM = @ITEM, SPECIFICATION = @SPECIFICATION, Price = @Price, [in] = @in, [out] = @out WHERE ITEM = @OriginalItem", con))
                        {
                            foreach (DataGridViewRow row in inventoryGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    inventoryGridView.EndEdit();
                                    cmd.Parameters.Clear();

                                    cmd.Parameters.AddWithValue("@ITEM", Convert.ToString(row.Cells["ITEM"].Value));
                                    cmd.Parameters.AddWithValue("@SPECIFICATION", Convert.ToString(row.Cells["SPECIFICATION"].Value));


                                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["Price"].Value));

                                   
                                    cmd.Parameters.AddWithValue("@in", Convert.ToInt32(row.Cells["in"].Value));

                                  
                                    cmd.Parameters.AddWithValue("@out", Convert.ToInt32(row.Cells["out"].Value));

                                    cmd.Parameters.AddWithValue("@OriginalItem", Convert.ToString(row.Cells["ITEM"].Value));

                                    string sqlQuery = cmd.CommandText;
                                    foreach (SqlParameter parameter in cmd.Parameters)
                                    {
                                        sqlQuery = sqlQuery.Replace(parameter.ParameterName, parameter.Value != null ? parameter.Value.ToString() : "NULL");
                                    }
                                    Console.WriteLine("Generated SQL Query: " + sqlQuery);

                                    try
                                    {
                                        int rowsAffected = cmd.ExecuteNonQuery();

                                        if (rowsAffected <= 0)
                                        {
                                            allUpdatesSuccessful = false;
                                            MessageBox.Show($"Update unsuccessful for ITEM: {row.Cells["ITEM"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    catch (SqlException sqlEx)
                                    {
                                        allUpdatesSuccessful = false;
                                        MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                   
                                }
                            }

                            inventoryGridView.EndEdit();
                        }

                        LoadDataFromDatabase();

                        if (allUpdatesSuccessful)
                        {
                            showMessageDialog("All records successfully updated.");
                            SaveDataToDatabase();
                        }
                    }
                    selectedRowIndex = -1;

                    isUpdating = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpdating = false;
            }
        }


        private void addRecord_Click(object sender, EventArgs e)
        {
            // save all our values from our fields into the variables
            string item = itemTextBox.Text;
            string specification = specificationTextBox.Text;
            string price = priceTextBox.Text;
          
            string quantityIn = quantityInTextBox.Text;
            string quantityOut = quantityOutTextBox.Text;

            try
            {
                if (item == "" || specification == "" || price == "" 
                    || quantityIn == "" || quantityOut == "")
                {
                    MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string addedName = itemTextBox.Text;
                // create a connection
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;"))
                {
                    // create a command to insert the data
                    string query = "INSERT INTO Inventory (ITEM, SPECIFICATION, Price, [in], [out]) VALUES (@ITEM, @SPECIFICATION, @Price, @in, @out)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // add parameters to the command
                        command.Parameters.AddWithValue("@ITEM", item);
                        command.Parameters.AddWithValue("@SPECIFICATION", specification);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@in", quantityIn);
                        command.Parameters.AddWithValue("@out", quantityOut);
                   

                        // open the connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // reload the data from the database to reflect the changes
                LoadDataFromDatabase();
         
                itemTextBox.Text ="";
               specificationTextBox.Text = "";
                priceTextBox.Text = "";
                quantityOutTextBox.Text = "";
                quantityInTextBox.Text = "";
                

                string successMessage = "Successfully Added";
                if (!string.IsNullOrEmpty(addedName))  // Use the captured name
                {
                    successMessage += ": " + addedName;
                }

                // ... (your existing code)
                SaveDataToDatabase();
                showMessageDialog(successMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showMessageDialog(string Message)
        {
            messageDialog message = new messageDialog(Message);   // Custom method to set the message
            message.Show();
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (inventoryGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = inventoryGridView.SelectedCells[0].RowIndex;
                    string itemName = inventoryGridView.Rows[rowIndex].Cells["ITEM"].Value.ToString();

                    // Ask for confirmation before deletion
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the item '{itemName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Inventory WHERE ITEM = @ITEM";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ITEM", itemName);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }

                        // Reload the data from the database to reflect the changes
                        LoadDataFromDatabase();
                        showMessageDialog($"Successfully Deleted: {itemName}");

                        // Disable the deleteRecord button after deletion
                        deleteRecord.Enabled = false;
                        deleteRecord.BackColor = SystemColors.Control; // Set the background color back to the default
                    }
                    // If the user clicks "No" in the confirmation dialog, do nothing
                }
                else
                {
                    MessageBox.Show("Please select a cell before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // After deleting, reset the selected row index
                selectedRowIndex = -1;

                deleteRecord.BackColor = default(Color);
                deleteRecord.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                itemTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                specificationTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                quantityOutTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityInTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                
            }
            catch (Exception err)
            {
                Console.WriteLine("There was an error: " + err);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryView invent = new inventoryView();
            invent.Show();
           

        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
        private void CloseAllForms()
        {
            List<Form> openForms = Application.OpenForms.Cast<Form>().ToList();

            // Close each form except the main form
            foreach (Form form in openForms)
            {
                if (form != this) // Skip closing the main form
                {
                    form.Close();
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
          
           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
           

        }

        private void inventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteRecord.Enabled = true;
            deleteRecord.BackColor = Color.Red;
        }

        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is Button))
            {
                // Call the method to add record when Enter key is pressed
                addRecord_Click(sender, e);
            }
        }

        private void inventoryGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

           
        }
       

        private void inventoryGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex >= 0)
            {
                DataGridViewColumn column = inventoryGridView.Columns[e.ColumnIndex];

            }
        }

        }
}
    


