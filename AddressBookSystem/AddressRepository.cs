using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressRepository
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection sqlConnection = null;
        public static Contacts model = new Contacts();
        public List<PersonContactsThread> contactsDetailsListThread = new List<PersonContactsThread>();

        /// <summary>
        /// UC-16 Retrieve all the Entries from the DB.
        /// </summary>
        public static void GetAllEntriesFromDB()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = "select * from AddressBook";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //Console.WriteLine("Connections is established successfully.....");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                        model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                        model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                        model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                        model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                        model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                        model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();

                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// UC17-Update contacts 
        /// </summary>
        /// <param name="model"></param>
        public static void UpdateContacts(Contacts model)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("dbo.spUpdateInformations", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                command.Parameters.AddWithValue("@firstName", model.firstName);
                command.Parameters.AddWithValue("@City", model.city);
                int num = command.ExecuteNonQuery();
                if (num != 0)
                    Console.WriteLine("City update Successfully......");
                else
                    Console.WriteLine("Something went Wrong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// UC18-Ability to contacts at a particular date
        /// </summary>
        /// <param name="model"></param>
        public static void RetrieveParticularDate(Contacts model)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = "select * from AddressBook where StartDate between cast('2019-01-01' as date ) AND GETDATE();";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                        model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                        model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                        model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                        model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                        model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                        model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
