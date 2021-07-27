

using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AnalyticsTest
{

    public static class ProductsDBManager{
        public static string conString= @"server=127.0.0.1;Uid=root;database=tap;Pwd=Know@9999#";

        public static List<Product> GetAll(){
                List<Product> products=new List<Product>();  
                IDbConnection conn=new MySqlConnection(conString);
                string query = "SELECT * FROM tap.flowers";
                IDbCommand command = new MySqlCommand(query,conn as MySqlConnection);

                //Connected Data Access Mode
                //connected is kept alive till operations complete
                try{
                    
                    //Open the connection
                    conn.Open();
                    //Execute command
                    IDataReader reader= command.ExecuteReader();
                    //Read the data
                    while(reader.Read()){
                         int Id=int.Parse(reader["Id"].ToString());
                         string title=reader["Title"].ToString();
                         string description=reader["Description"].ToString();
                         float unitPrice=float.Parse(reader["UnitPrice"].ToString());
                         string image=reader["ImageUrl"].ToString();
                         int quantity=int.Parse(reader["Quantity"].ToString());

                         products.Add(
                             new Product(){
                                 ID=Id,
                                 Title=title,
                                 Description=description,
                                 UnitPrice=unitPrice,
                                 ImageUrl=image,
                                 Quantity=quantity,
                             }
                         );
                    }
                    reader.Close();

                }
                catch (MySqlException exp)
                {
                    string message = exp.Message;
                    //report to developer 
                    //log exception message log file
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return products;
            }
         public static bool Delete(int productId)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();
                string query = "DELETE FROM tap.flowers WHERE Id=@ProductId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@ProductId", productId)); //Parameterized command handling
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

        public static bool Update(Product product)
        {
            bool status = false;
            try
            {
              MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                    string query = "UPDATE flowers SET Title=@Title , Description=@Description, " +
                        "ImageUrl=@Image, UnitPrice=@UnitPrice, Quantity=@Quantity " +
                        "WHERE Id=@Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@Id", product.ID));
                    cmd.Parameters.Add(new MySqlParameter("@Title", product.Title));
                    cmd.Parameters.Add(new MySqlParameter("@Description", product.Description));
                    cmd.Parameters.Add(new MySqlParameter("@Image", product.ImageUrl));
                    cmd.Parameters.Add(new MySqlParameter("@UnitPrice", product.UnitPrice));
                    cmd.Parameters.Add(new MySqlParameter("@Quantity", product.Quantity));   

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

         public static bool Insert(Product product)
        {


            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "INSERT INTO flowers (Id,Title, Description, ImageUrl, UnitPrice, Quantity) " +
                        "VALUES (@Id, @Title, @Description, @Image, @UnitPrice, @Quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", product.ID));
                    cmd.Parameters.Add(new MySqlParameter("@Title", product.Title));
                    cmd.Parameters.Add(new MySqlParameter("@Description", product.Description));
                    cmd.Parameters.Add(new MySqlParameter("@Image", product.ImageUrl));
                    cmd.Parameters.Add(new MySqlParameter("@UnitPrice", product.UnitPrice));
                    cmd.Parameters.Add(new MySqlParameter("@Quantity", product.Quantity));  
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
