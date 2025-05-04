using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
    public class ClsDoctorData
    {public static DataTable GetAllDoctors()
        {
            DataTable Doctors = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "select * from Doctors join Persons on Persons.PersonID=Doctors.PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Doctors.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }return Doctors;
        }
        public static bool GetDoctorBy(int PersonID,ref int DoctorID,ref string Specialization)
        {
bool IsFound=false;
            SqlConnection connection = new SqlConnection(   ClsDataAccessSettings.ConnectionString);
            string Query = "Select * from Doctors where PersonID =@PersonID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    IsFound = true;
                    DoctorID = (int)reader["DoctorID"];
                    Specialization = (string)reader["Specialization"];
                }reader
                    .Close();
            } catch (Exception ex) { } finally { connection.Close(); }
            return IsFound;
        }
        public static int AddNewDoctor(int PersonID,string Specialization)
        {
            int DoctorID = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "insert into Doctors (PersonID,Specialization) values (@PersonID,@Specialization)" +
                ";select Scope_identity()";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@Specialization",Specialization);
            try
            {
                connection.Open();
                object res = Command.ExecuteScalar();
                if (res != null) { 
                DoctorID = Convert.ToInt32(res);
                }
            }catch (Exception ex) { }
            finally { connection.Close(); }
            return DoctorID;
        }
        public static bool DeleteDoctor(int DoctorID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "Delete from Doctors where DoctorID =@DoctorID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DoctorID",DoctorID);
            try {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }catch (Exception ex) { }finally { connection.Close(); }
            return RowsAffected!=0;
        }
        public static bool UpdateDoctor(int PersonID,string Specialization)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "update Doctors set Specialization =@Specialization where PersonID=@PersonID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Specialization", Specialization);
            command.Parameters.AddWithValue("PersonID", PersonID);
            try {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }catch(Exception ex) { }finally { connection.Close(); }
            return RowsAffected!=0;
        }
    }
}
