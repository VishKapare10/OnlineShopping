using System;
//import those namespaces
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DisconnectedDataAccessTest
{
    public class CustomerDBManager
    {
        private static string connectionString=string.Empty;
        static CustomerDBManager(){
            
            connectionString= @"server=127.0.0.1;Uid=root;database=tap;Pwd=Know@9999#";

        }
        public static List<Customer> GetAll()
        {
            //Disconnected data access architecture
            //connection, command, adapter, dataset, datarow
            List<Customer> customers=new List<Customer>();
            IDbConnection con=new MySqlConnection();
            con.ConnectionString=connectionString; //property DI
            string query="SELECT * FROM tap.customers";

            MySqlCommand cmd=new MySqlCommand(query, con as MySqlConnection); //constructor-dependency injection
           
            DataSet ds=new DataSet();
           
            MySqlDataAdapter da=new MySqlDataAdapter(cmd);

            try{
                    da.Fill(ds);  //method DI  
                    DataTable dt = ds.Tables[0];
                    foreach(DataRow datarow in dt.Rows){
                        int id=int.Parse(datarow["Id"].ToString());
                        string name=datarow["Name"].ToString();
                        string location=datarow["Location"].ToString();
                        int age=int.Parse(datarow["Age"].ToString());
                        string contactNumber=datarow["ContactNumber"].ToString();

                        Customer cust=new Customer{
                            Id=id,
                            Name=name,
                            Location=location,
                            Age=age,
                            ContactNumber=contactNumber,
                        };
                        customers.Add(cust);
                    }
            }
            catch(System.Exception exp){ 
                Console.WriteLine(exp);
            }
            finally{        }
            return customers;
        }
        public static bool Delete(int customerId){
            bool status = false;

            IDbConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM tap.customers";
            cmd.Connection = con;
            
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();

            try{
                //Builder design pattern
                MySqlCommandBuilder cmdbldr=new MySqlCommandBuilder(da); //Constructor DI
                da.Fill(ds);  //Fetch data from remote database----DI method
                DataColumn[] keyColumns= new DataColumn[1];
                keyColumns[0]=ds.Tables[0].Columns["Id"];
                ds.Tables[0].PrimaryKey =keyColumns;
                    
                DataRow datarow=ds.Tables[0].Rows.Find(customerId); //auto sync with remote database----
                datarow.Delete();
                da.Update(ds);
                status=true;
            }
            catch(MySqlException exp){
                string exceptionMessage=exp.Message;
                throw new Exception(exceptionMessage);
            }
            return status;
        }

        public static bool Insert(Customer newCustomer)
        {
            bool status = false;

            IDbConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            
            string cmdStr= "SELECT * FROM tap.customers";
            IDbCommand cmd = new MySqlCommand();

            cmd.Connection =con as MySqlConnection;
            cmd.CommandText = cmdStr;
            
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();

            try{
                MySqlCommandBuilder cmdBldr=new MySqlCommandBuilder(da);
                MySqlCommand deleteCommand = cmdBldr.GetDeleteCommand();
                string strDeleteCommand = deleteCommand.CommandText;

                da.Fill(ds);
                DataRow newRow= ds.Tables[0].NewRow();
                newRow["Id"]=newCustomer.Id;
                newRow["Name"]=newCustomer.Name;
                newRow["Email"]=newCustomer.Email;
                newRow["ContactNumber"]=newCustomer.ContactNumber;
                newRow["Location"]=newCustomer.Location;
                newRow["Age"]=newCustomer.Age;
                ds.Tables[0].Rows.Add(newRow);
                da.Update(ds);
                status=true;
            }
            catch(Exception exp){
                string exceptionMessage=exp.Message;
            }
            return status;
        }

        public static bool Update(Customer theCustomer){


            bool status = false;
            List <Customer> customer=new List<Customer>();

            IDbConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM tap.customers";
            cmd.Connection = con;
            
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();

            try{
                //Builder design pattern
                MySqlCommandBuilder cmdbldr=new MySqlCommandBuilder(da); //Constructor DI
                da.Fill(ds);  //Fetch data from remote database----DI method
                
                DataColumn[] keyColumns= new DataColumn[1];
                keyColumns[0]=ds.Tables[0].Columns["Id"];
                ds.Tables[0].PrimaryKey =keyColumns;
                    
                DataRow datarow=ds.Tables[0].Rows.Find(theCustomer.Id); //auto sync with remote database----
                datarow["Name"]=theCustomer.Name;
                datarow["Email"]=theCustomer.Email;
                datarow["Location"]=theCustomer.Location;
                datarow["ContactNumber"]=theCustomer.ContactNumber;
                datarow["Age"]=theCustomer.Age;

                da.Update(ds);
                status=true;
            }
            catch(MySqlException exp){
                string exceptionMessage=exp.Message;
                throw new Exception(exceptionMessage);
            }
            return status;
        }
        


}
}
