using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CRM
{

    // Connected Data Access Object Model
    
    public  static class CustomerDBManager
    {
    public static string conString= @"server=127.0.0.1;Uid=root;database=tap;Pwd=Know@9999#";
    public static List<Customer> GetAll() 
        {
            List<Customer> customers = new List<Customer>();
            IDbConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM tap.customers";
            IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            try
            {
                con.Open(); 
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string name = reader["Name"].ToString();
                    string Email = reader["Email"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();
                    string location = reader["Location"].ToString();
                    int age=int.Parse(reader["Age"].ToString());

                    customers.Add(new Customer()
                    {
                        Id = id,
                        Name = name,
                        Email = Email,
                        ContactNumber = contactNumber,
                        Location=location,
                        Age=age
                    });
                }
                reader.Close();
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                     con.Close();
                }
            }
            return customers;
        }

    public static Customer GetById(int customerId)
        {
            Customer theCustomer=null;
            try
            {
                
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();

                //paramerized query
                string query = "SELECT * FROM customers WHERE Id=@CustomerId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@CustomerId", customerId));
               //Parameterized command handling*/
               
                 IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string name = reader["Name"].ToString();
                    string Email = reader["Email"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();
                    string location = reader["Location"].ToString();
                    int age=int.Parse(reader["Age"].ToString());


                    theCustomer=new Customer()
                    {
                        Id = id,
                        Name = name,
                        Email = Email,
                        ContactNumber = contactNumber,
                        Location=location,
                        Age=age
                    };

                }
                reader.Close();
                if (con.State == ConnectionState.Open)
                con.Close();
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return theCustomer;
        }
    public static bool Delete(int customerId)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();
                string query = "DELETE FROM customers WHERE Id=@CustomerId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@CustomerId", customerId)); //Parameterized command handling
                cmd.ExecuteNonQuery();  // DML Operation
                if (con.State == ConnectionState.Open)
                con.Close();
                status = true;
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return status;
        }   
    public static bool Update(Customer customer)
        {
            bool status = false;
            try
            {
              MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                    string query = "UPDATE tap.customers SET Name=@Name , Email=@Email, " +
                                    "ContactNumber=@ContactNumber " +    "WHERE Id=@Id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", customer.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Name", customer.Name));
                    cmd.Parameters.Add(new MySqlParameter("@ContactNumber", customer.ContactNumber));
                    cmd.Parameters.Add(new MySqlParameter("@Email", customer.Email));
                    /*cmd.Parameters.Add(new MySqlParameter("@Location",customer.Location));
                    cmd.Parameters.Add(new MySqlParameter("@Age",customer.Age));*/
                    
                    cmd.ExecuteNonQuery();  // DML Operation
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return status;
        }
    public static bool Insert(Customer customer)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "INSERT INTO customers (Id,Name, Email, ContactNumber) " +
                                    "VALUES (@Id, @Name, @ContactNumber)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", customer.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Name", customer.Name));
                    cmd.Parameters.Add(new MySqlParameter("@ContactNumber", customer.ContactNumber));
                    cmd.Parameters.Add(new MySqlParameter("@Email", customer.Email));
                    cmd.Parameters.Add(new MySqlParameter("@Location",customer.Location));
                    cmd.Parameters.Add(new MySqlParameter("@Age",customer.Age));
                      cmd.ExecuteNonQuery();// DML
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
                throw ex;
            }
            return status;
        }
  }
}