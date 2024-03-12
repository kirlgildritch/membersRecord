using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using employeeManagement.Dialogs;
using System.Data.Common;




namespace employeeManagement
{
    public partial class Form1 : Form
    {
     
        private Settings settingsForm;
        private static bool isNotificationPreferenceOn = true;
        private EmployeeData employeeData = new EmployeeData();
        private ContextMenuStrip attendanceContextMenu;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30";
        private ContextMenuStrip subcolumnContextMenu;
       


        public Form1()
        {
              
        InitializeComponent();

            settingsForm = new Settings();
            settingsForm.NotificationPreferenceChanged += SettingsForm_NotificationPreferenceChanged;

            InitializeAttendanceContextMenu();
            InitializeSubcolumnContextMenu();

            
        }
        private void InitializeSubcolumnContextMenu()
        {
            subcolumnContextMenu = new ContextMenuStrip();
            subcolumnContextMenu.Items.Add("Delete Subcolumn").Click += new EventHandler(DeleteSubcolumn_Click);
        }
 private void DeleteSubcolumn_Click(object sender, EventArgs e)
    {
        if (dataGridView1.Tag is Point cellCoordinates)
        {
            int columnIndex = cellCoordinates.X;

            // Check if it's a valid subcolumn
            if (columnIndex > 0 && dataGridView1.Columns.Count > columnIndex)
            {
                // Get the name of the subcolumn to be deleted
                string subcolumnName = dataGridView1.Columns[columnIndex].Name;

                // Confirm with the user before deleting
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the subcolumn '{subcolumnName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the subcolumn from the DataGridView
                    dataGridView1.Columns.RemoveAt(columnIndex);

                    // Delete the subcolumn from the SQL database
                    DeleteSubcolumnFromDatabase(subcolumnName);
                }
            }
        }
    }
        private void DeleteSubcolumnFromDatabase(string subcolumnName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Assuming you have a Members table with a column named "Attendance_{year}"
                    string updateQuery = $"ALTER TABLE Members DROP COLUMN [{subcolumnName}]";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeAttendanceContextMenu()
        {
            attendanceContextMenu = new ContextMenuStrip();
            attendanceContextMenu.Items.Add("Add Subcolumn").Click += new EventHandler(AddSubcolumn_Click);
            attendanceContextMenu.Items.Add("Show/ Hide").Click += new EventHandler(ToggleSubcolumnsVisibility_Click);
          
        
        }

        

        private void ToggleSubcolumnsVisibility_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of all subcolumns with the name starting with "Attendance_"
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name.StartsWith("2"))
                {
                    column.Visible = !column.Visible;
                }
            }
        }
        private void SetInitialSubcolumnVisibility()
        {
            // Hide all subcolumns with the name starting with "2" (adjust as needed)
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name.StartsWith("2"))
                {
                    column.Visible = false;
                }
            }
          
        }
        private void AddSubcolumn_Click(object sender, EventArgs e)
        {
            Point cellCoordinates = (Point)dataGridView1.Tag;

            // Prompt the user for the subcolumn name
            string subcolumnName = Microsoft.VisualBasic.Interaction.InputBox("Enter the subcolumn name:", "Add Subcolumn", "");

            if (!string.IsNullOrEmpty(subcolumnName))
            {
               
                DataGridViewTextBoxColumn subColumn = new DataGridViewTextBoxColumn();
                subColumn.HeaderText = subcolumnName;
                subColumn.Name = subcolumnName; // Use a consistent naming convention for subcolumns

                subColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Check if the parent column already exists
                DataGridViewColumn parentColumn = dataGridView1.Columns["Attendance"];
                if (parentColumn == null)
                {
                    // Create a new parent column if it doesn't exist
                    DataGridViewTextBoxColumn parent = new DataGridViewTextBoxColumn();
                    parent.HeaderText = "Attendance";
                    parent.Name = "Attendance";

                    // Add the parent column to the DataGridView
                    dataGridView1.Columns.Insert(cellCoordinates.Y, parent);
                }
               
                // Add the new subcolumn as a child of the parent column
                parentColumn = dataGridView1.Columns["Attendance"];
                parentColumn.DataGridView.Columns.Insert(parentColumn.Index + 1, subColumn);

                // Clear the saved cell coordinates
                dataGridView1.Tag = null;

                // Save the new subcolumn information to the SQL database
                SaveSubcolumnToDatabase(subcolumnName);
            }



        }

       

        private void SaveSubcolumnToDatabase(string year)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Assuming you have a Members table with a column named "Attendance_{year}"
                    string updateQuery = $"ALTER TABLE Members ADD [{year}] VARCHAR(50) NULL";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SettingsForm_NotificationPreferenceChanged(object sender, bool isPreferenceOn)
        {
            // Handle the notification preference change
            isNotificationPreferenceOn = isPreferenceOn;
            Console.WriteLine("Notification Preference Changed: " + isNotificationPreferenceOn);
        }


  

        

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;");
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
            searchComboBox.Text = "Name";

            // Trigger the search based on the default filter
            PerformSearch();
            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyPreview = true; // Enable KeyPreview for the form
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            SetInitialSubcolumnVisibility();


        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullname.Text == "" || gender.Text == "" || age.Text == "" || dateofbirth.Text == ""
                    || address.Text == "" || dateofmembership.Text == "" || sharecapital.Text == "")
                {
                    MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string addedName = fullname.Text;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Members VALUES (@Fullname, @Gender, @Age, @DateOfBirth, @Address, @DateOfMembership, @ShareCapital, @Attendance)", con))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", fullname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Age", int.Parse(age.Text));
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(dateofbirth.Text));
                        cmd.Parameters.AddWithValue("@Address", address.Text);
                        cmd.Parameters.AddWithValue("@DateOfMembership", DateTime.Parse(dateofmembership.Text));
                        cmd.Parameters.AddWithValue("@ShareCapital", double.Parse(sharecapital.Text));

                        // Check if attendance is empty, set a default value or handle as needed
                        if (string.IsNullOrWhiteSpace(attendance.Text))
                        {
                            cmd.Parameters.AddWithValue("@Attendance", DBNull.Value); // Set to DBNull.Value or your default value
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Attendance", attendance.Text);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Clear input fields
                            fullname.Text = "";
                            gender.SelectedIndex = -1;
                            age.Text = "";
                            dateofbirth.Text = "";
                            address.Text = "";
                            dateofmembership.Text = "";
                            sharecapital.Text = "";
                            attendance.Text = "";

                            LoadDataIntoGridView();
                            string successMessage = "Successfully Added";
                            if (!string.IsNullOrEmpty(addedName))  // Use the captured name
                            {
                                successMessage += ": " + addedName;
                            }

                            showMessageDialog(successMessage);
                        }
                        else
                        {
                            MessageBox.Show("Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Any cleanup or finalization code can go here
            }
        }

    
    public void showMessageDialog(string Message)
        {
            messageDialog message = new messageDialog(Message);   // Custom method to set the message
            message.Show();
        }
        private void dateofmembership_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Update the selected row index when a cell is clicked
                selectedRowIndex = e.RowIndex;

                // Change the color of the delete button to red
                deleteRecord.BackColor = Color.Red;

                // Enable the delete button whenever any cell within a row is clicked
                deleteRecord.Enabled = true;
            }
            else
            {
                // Reset the selected row index and disable the delete button when clicking outside the rows
                selectedRowIndex = -1;
                deleteRecord.BackColor = default(Color);
                deleteRecord.Enabled = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Update the selected row index when a cell is clicked
                selectedRowIndex = e.RowIndex;

                // Change the color of the delete button to red
                deleteRecord.BackColor = Color.Red;

                // Enable the delete button whenever any cell within a row is clicked
                deleteRecord.Enabled = true;
            }
            else
            {
                // Reset the selected row index and disable the delete button when clicking outside the rows
                selectedRowIndex = -1;
                deleteRecord.BackColor = default(Color);
                deleteRecord.Enabled = false;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Update the selected row index when a cell is selected
                selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Change the color of the delete button to red
                deleteRecord.BackColor = Color.Red;

                // Enable the delete button whenever any cell within a row is selected
                deleteRecord.Enabled = true;
            }
            else
            {
                // Reset the selected row index and disable the delete button when no cells are selected
                selectedRowIndex = -1;
                deleteRecord.BackColor = default(Color);
                deleteRecord.Enabled = false;
            }
        }
        private void LoadDataIntoGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Members ORDER BY DateOfMembership DESC", con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                      

                        dataGridView1.ReadOnly = false;
                        dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;


                        dataGridView1.DataSource = dt;
                        DataGridViewColumn attendanceColumn = dataGridView1.Columns["Attendance"];
                        DataGridViewColumn GenderCol = dataGridView1.Columns["Gender"];
                        DataGridViewColumn AddressCol = dataGridView1.Columns["Address"];
                       

                        attendanceColumn.Width = 60;

                        
                        attendanceColumn.HeaderText = "Attendance";
                         GenderCol.Width = 50;
                        AddressCol.Width = 150;
                       


                        // Assuming dataGridView1 is the name of your DataGridView control
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            deleteRecord.BackColor = default(Color);
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

                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;"))
                    {
                        con.Open();

                        bool anyRowUpdated = false; // Flag to track if any row has been updated

                        using (SqlCommand cmd = new SqlCommand("UPDATE Members SET FullName = @FullName, Gender = @Gender, Age = @Age, DateOfBirth = @DateOfBirth, Address = @Address, DateOfMembership = @DateOfMembership, ShareCapital = @ShareCapital, Attendance = @Attendance WHERE FullName = @OldFullName", con))
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    // Commit changes in the current row before updating
                                    dataGridView1.EndEdit();

                                    string oldFullName = row.Cells["FullName"].Value.ToString();

                                    cmd.Parameters.Clear();

                                    cmd.Parameters.AddWithValue("@OldFullName", oldFullName);
                                    cmd.Parameters.AddWithValue("@FullName", row.Cells["FullName"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@Gender", row.Cells["Gender"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(row.Cells["Age"].Value));
                                    cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(row.Cells["DateOfBirth"].Value));
                                    cmd.Parameters.AddWithValue("@Address", row.Cells["Address"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@DateOfMembership", Convert.ToDateTime(row.Cells["DateOfMembership"].Value));
                                    cmd.Parameters.AddWithValue("@ShareCapital", Convert.ToDecimal(row.Cells["ShareCapital"].Value));
                                    cmd.Parameters.AddWithValue("@Attendance", row.Cells["Attendance"].Value.ToString());
                                   


                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        anyRowUpdated = true;
                                    }

                                    // Log the generated SQL query for debugging
                                    string sqlQuery = cmd.CommandText;
                                    foreach (SqlParameter parameter in cmd.Parameters)
                                    {
                                        sqlQuery = sqlQuery.Replace(parameter.ParameterName, parameter.Value.ToString());
                                    }
                                    Console.WriteLine("Generated SQL Query: " + sqlQuery);

                                   
                                }
                            }
                        }

                        // Refresh the DataGridView with the updated data
                        LoadDataIntoGridView();

                        // Show a message box if any row has been updated
                        if (anyRowUpdated)
                        {
                            showMessageDialog("Successfully Updated");
                        }

                        selectedRowIndex = -1;
                        isUpdating = false; // Reset the flag
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpdating = false; // Reset the flag in case of an error
            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && MessageBox.Show($"Are you sure you want to delete {dataGridView1.Rows[selectedRowIndex].Cells["FullName"].Value}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Members WHERE FullName = @FullName", con))
                        {
                            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                            cmd.Parameters.AddWithValue("@FullName", selectedRow.Cells["FullName"].Value.ToString());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                showMessageDialog("Successfully Deleted: " + selectedRow.Cells["FullName"].Value.ToString());

                                LoadDataIntoGridView();
                            }
                            else
                            {
                                MessageBox.Show($"Deletion unsuccessful for: {selectedRow.Cells["FullName"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    // After deleting, reset the selected row index
                    selectedRowIndex = -1;

                    deleteRecord.BackColor = default(Color);
                    deleteRecord.Enabled = false;
                }
                //    NotifyMemberChange("Member deleted: " + selectedRowIndex.Cells["FullName"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            display();

        }

        private void PerformSearch()
        {
         
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
        }
        private void display()
        {
           

            con.Open();

           


            if (searchComboBox.Text == "Name")
            {
                string query = "SELECT * FROM Members WHERE LOWER(FullName) LIKE LOWER(@searchTerm)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchBox.Text.ToLower() + "%"); // Use parameters to prevent SQL injection
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable st = new DataTable();
                st.Load(reader);
                dataGridView1.DataSource = st;



            }

            else if (searchComboBox.Text == "Gender")
            {
                try
                {
                    string searchTerm = searchBox.Text.ToLower() + "%"; 

                    string query = "SELECT * FROM Members WHERE LOWER(Gender) LIKE LOWER(@searchTerm)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", searchTerm);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable st = new DataTable();
                            st.Load(reader);
                            dataGridView1.DataSource = st;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (searchBox.Text == "")
                {
                    LoadDataIntoGridView();
                }
            }


            else if (searchComboBox.Text == "Age")
            {
                if (int.TryParse(searchBox.Text, out int age))
                {
                    string query = "SELECT * FROM Members WHERE Age LIKE @searchAge";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@searchAge", age);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable st = new DataTable();
                    st.Load(reader);
                   
                    dataGridView1.DataSource = st;
                }
                if(searchBox.Text == "")
                {
                    LoadDataIntoGridView();
                }
               
            }

            con.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is Button))
            {
                // Call the method to add record when Enter key is pressed
                addRecord_Click(sender, e);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the "Enter" key to prevent the default behavior (move to the next row)

                // Perform the update logic here
               updateRecord1();
            }
        }
        private void updateRecord1()
        {
            try
            {
                if (!isUpdating)
                {
                    isUpdating = true;

                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE Members SET FullName = @FullName, Gender = @Gender, Age = @Age, DateOfBirth = @DateOfBirth, Address = @Address, DateOfMembership = @DateOfMembership, ShareCapital = @ShareCapital, Attendance = @Attendance WHERE FullName = @OldFullName", con))
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    cmd.Parameters.Clear();

                                    cmd.Parameters.AddWithValue("@OldFullName", row.Cells["FullName"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@FullName", row.Cells["FullName"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@Gender", row.Cells["Gender"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(row.Cells["Age"].Value));
                                    cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(row.Cells["DateOfBirth"].Value));
                                    cmd.Parameters.AddWithValue("@Address", row.Cells["Address"].Value.ToString());
                                    cmd.Parameters.AddWithValue("@DateOfMembership", Convert.ToDateTime(row.Cells["DateOfMembership"].Value));
                                    cmd.Parameters.AddWithValue("@ShareCapital", Convert.ToDecimal(row.Cells["ShareCapital"].Value));
                                    cmd.Parameters.AddWithValue("@Attendance", row.Cells["Attendance"].Value.ToString());

                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected <= 0)
                                    {
                                        MessageBox.Show($"Update unsuccessful for: {row.Cells["FullName"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            // Refresh the DataGridView with the updated data
                            LoadDataIntoGridView();

                            // Show a single message box after processing all rows
                            MessageBox.Show("All updates completed successfully.");
                        }
                    }
                    selectedRowIndex = -1;

                    isUpdating = false; // Reset the flag
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpdating = false; // Reset the flag in case of an error
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
          
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];

                // Check if the edited cell is in a subcolumn
                if (column != null && column.Name.StartsWith("2"))
                {
                    
                    object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Get the corresponding column name (subcolumn name)
                    string subcolumnName = column.Name;

                    // Update the value in the database
                    UpdateSubcolumnValue(e.RowIndex, subcolumnName, newValue);
                }
            }

            // Check if the edited cell is in the last row
            if (e.RowIndex == dataGridView1.Rows.Count - 1 && e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                // Perform the update logic here
                updateRecord1();
            }
        }
        private void UpdateSubcolumnValue(int rowIndex, string subcolumnName, object newValue)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string updateQuery = $"UPDATE Members SET [{subcolumnName}] = @NewValue WHERE FullName = @FullName";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@NewValue", newValue);
                        cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[rowIndex].Cells["FullName"].Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Successfully updated {subcolumnName} for {dataGridView1.Rows[rowIndex].Cells["FullName"].Value}");
                        }
                        else
                        {
                            Console.WriteLine($"No rows affected when updating {subcolumnName} for {dataGridView1.Rows[rowIndex].Cells["FullName"].Value}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            Form2 form = new Form2();
            form.Show();

          
            // Show the new form
            
        
    }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Update the selected row index when a cell is clicked
                selectedRowIndex = e.RowIndex;

                // Change the color of the delete button to red
                deleteRecord.BackColor = Color.Red;

                // Enable the delete button whenever any cell within a row is clicked
                deleteRecord.Enabled = true;
            }
            else
            {
                // Reset the selected row index and disable the delete button when clicking outside the rows
                selectedRowIndex = -1;
                deleteRecord.BackColor = default(Color);
                deleteRecord.Enabled = false;
            }
            if (e.Button == MouseButtons.Right && e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Right-click on column header
                dataGridView1.Tag = new Point(e.ColumnIndex, e.RowIndex);
                attendanceContextMenu.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
            }
            else if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                // Right-click on subcolumn
                dataGridView1.Tag = new Point(e.ColumnIndex, e.RowIndex);
                subcolumnContextMenu.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
          


      
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void label15_Click(object sender, EventArgs e)
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

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            // Customize the appearance of the vertical scroll bar
            FieldInfo verticalScrollBarField = typeof(Control).GetField("vScrollBar", BindingFlags.NonPublic | BindingFlags.Instance);
            if (verticalScrollBarField != null)
            {
                var verticalScrollBar = (VScrollBar)verticalScrollBarField.GetValue(dataGridView1);
                if (verticalScrollBar != null)
                {
                    verticalScrollBar.BackColor = Color.FromArgb(60,60,60);
                }
            }

            // Customize the appearance of the horizontal scroll bar
            FieldInfo horizontalScrollBarField = typeof(Control).GetField("hScrollBar", BindingFlags.NonPublic | BindingFlags.Instance);
            if (horizontalScrollBarField != null)
            {
                var horizontalScrollBar = (HScrollBar)horizontalScrollBarField.GetValue(dataGridView1);
                if (horizontalScrollBar != null)
                {
                    horizontalScrollBar.BackColor = Color.DarkGray;
                }
            }
        }
    }
}
