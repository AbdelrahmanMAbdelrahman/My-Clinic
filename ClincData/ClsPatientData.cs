using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
    public  class ClsPatientData
    {public static int AddNewPatient(int PersonID)
        {
            int PatientID = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "insert into Patients (PersonID)values (@PersonID) ;select scope_identity()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res != null)
                {
                    PatientID = Convert.ToInt32(res);
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return PatientID;
        }
        public static bool DeletePatient(int PatientID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "delete from Patients where PatientID =@PatientID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }
     public static DataTable GetAllPatients()
        {DataTable Patients = new DataTable();
           SqlConnection connection=new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = " select Persons.PersonID,PatientID,Name,DateOfBirth,Gender,PhoneNumber," +
                "Email,Address from Persons join Patients on Persons.PersonID=Patients.PersonID;";
            SqlCommand command= new SqlCommand(Query, connection);
            try { 
            connection .Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read()) { 
                Patients.Load(reader);
                }reader.Close();
            }catch (Exception ex) { }finally { connection.Close(); }
            return Patients;
        }
        public static bool FindPatientBy(int PatientID,ref string Name,ref string Email,ref string PhoneNumber,
            ref string Address,ref DateTime DateOfBirth,ref int PersonID,
            ref bool Gender)
        {
            bool IsFound = false;
            SqlConnection connection=new SqlConnection (ClsDataAccessSettings.ConnectionString);
            string Query = "select Persons.PersonID,PatientID,Name,DateOfBirth,Gender,PhoneNumber," +
                "Email,Address from Persons join Patients on Persons.PersonID=Patients.PersonID " +
                "where Patients.PatientID=@PatientID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            try { 
            connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read()) { 
                IsFound = true;
                   Name=(string)reader["Name"];
                    Address = (string)reader["Address"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Gender =(bool) reader["Gender"];
                    Email = (string)reader["Email"];
                    PersonID=(int) reader["PersonID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                }reader.Close();
            }catch(Exception ex) { }finally { connection.Close(); };
            return IsFound;
        }
        public static bool FindPatientBy(ref int PatientID,  string Name, ref string Email, ref string PhoneNumber,
     ref string Address, ref DateTime DateOfBirth, ref int PersonID,
     ref bool Gender)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "select Persons.PersonID,PatientID,Name,DateOfBirth,Gender,PhoneNumber," +
                "Email,Address from Persons join Patients on Persons.PersonID=Patients.PersonID" +
                "where Persons.Name=@Name";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PatientID = (int)reader["PatientID"];
                    Address = (string)reader["Address"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Gender = (bool)reader["Gender"];
                    Email = (string)reader["Email"];
                    PersonID = (int)reader["PersonID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); };
            return IsFound;
        }
    }
}
