using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace membersRecord
{
    class EmployeeData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime DateOfMembership { get; set; }
        public double ShareCapital { get; set; }
        public string Attendance { get; set; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kirlg\OneDrive\Documents\dataBank-member.mdf;Integrated Security=True;Connect Timeout=30");

        public List<EmployeeData> EmployeeListData()
        {
            List<EmployeeData> listData = new List<EmployeeData>();

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();

               
                    
                   SqlCommand command = new SqlCommand("SELECT * FROM employees", connect);
                    SqlDataReader reader = command.ExecuteReader();

                  while (reader.Read())
                    {
                        EmployeeData ed = new EmployeeData();
                        ed.Name = reader["full_name"].ToString();
                        ed.Age = (int)reader["Age"];

                        // Convert the DateOfBirth and DateOfMembership from SqlDataReader to DateTime
                        ed.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        ed.Address = reader["Address"].ToString();
                        ed.DateOfMembership = Convert.ToDateTime(reader["DateOfMembership"]);
                        ed.ShareCapital = (double)reader["ShareCapital"];
                        ed.Attendance = reader["Attendance"].ToString();

                        listData.Add(ed);

                    }
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                // Close the connection in the finally block to ensure it gets closed even if an exception occurs
                connect.Close();
            }

            return listData;
        }
    }
}
