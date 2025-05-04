using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
    public class ClsPersonData
    { public static int AddNewPerson(string Name, string Email, string PhoneNumber, string Address, bool Gender, DateTime DateOfBirth)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "insert into Persons (Name,Email,PhoneNumber,Address,Gender,DateOfBirth)" +
                 "values (@Name,@Email,@PhoneNumber,@Address,@Gender,@DateOfBirth);" +
                 "select Scope_identity()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            try {
                connection.Open();
            
                object res = command.ExecuteScalar();
                if (res != null) {
                    PersonID = Convert.ToInt32(res);
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return PersonID;
        }
        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "delete from Persons where PersonID =@PersonID";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("PersonID", PersonID);
            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return RowsAffected != 0;
        }
        public static bool UpdatePerson(int PersonID, string Name, string Email, string PhoneNumber,
            bool Gender, DateTime DateOfBirth, string Address)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "update Persons set Name=@Name,Email=@Email,Address=@Address,PhoneNumber=@PhoneNumber," +
                "DateOfBirth=@DateOfBirth,Gender=@Gender where PersonID =@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            try {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            } catch (Exception ex) { } finally { connection.Close(); }
            return RowsAffected != 0;
        }
        public static bool GetPersonBy(int PersonID,ref string Name,ref string Email,ref string Address,ref string Phone,
            ref bool Gender,ref DateTime DateOfBirth)
        {
            bool IsFound=false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "select *from Persons where PersonID =@PersonID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try {
                connection.Open();
            SqlDataReader reader= command.ExecuteReader();
                if (reader.Read()) {
                    Name = (string)reader["Name"];
                    Email = (string)reader["Email"];
                    Address=(string)reader["Address"];
                    Phone = (string)reader["PhoneNumber"];
                    Gender = (bool)reader["Gender"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    IsFound = true;
                }
            }
            catch (Exception ex) { } 
            finally {connection.Close(); }
            return IsFound;
        }
    }
}
