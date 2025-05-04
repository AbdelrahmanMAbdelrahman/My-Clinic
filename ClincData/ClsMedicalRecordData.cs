using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
  public  class ClsMedicalRecordData
    {
        public static int AddNewMedicalRecord(string VisitDescription,string AdditionalNote,string Diagnosis)
        { int MedicalRecordID = 0;
            using (SqlConnection connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "insert into MedicalRecords (Diagnosis,AddtionalNotes,VisitDescription)" +
                    "values(@Diagnosis,@AddtionalNotes,@VisitDescription);select SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                    command.Parameters.AddWithValue("@AddtionalNotes", AdditionalNote);
                    command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
                    try
                    {
                        connection.Open();
                        object res = command.ExecuteScalar();
                        if (res != null && int.TryParse(res.ToString(), out int id)){
                            MedicalRecordID = id;
                        }
                }
                    catch (Exception ex) { }
                }
              
            }return MedicalRecordID;
        }
        public static bool UpdateMedicalRecord( string VisitDescription,string Diagnosis,string AddtionalNotes, int MedicalRecordID)
        {
            bool IsUpdated = false;
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "update MedicalRecords set Diagnosis =@Diagnosis,AddtionalNotes=@AddtionalNotes," +
                    "VisitDescription=@VisitDescription where MedicalRecordID =@MedicalRecordID;";
                using (SqlCommand Command=new SqlCommand(Query, connection))
                {
                    Command.Parameters.AddWithValue("@AddtionalNotes", AddtionalNotes);
                    Command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                    Command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
                    Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    try {
                        connection.Open();
                        IsUpdated = Command.ExecuteNonQuery()>0;
                    }catch(Exception ex) { }
                }
            }return IsUpdated;
        }

        public static bool DeletedMedicalRecord(int MedicalRecordID)
        {
            bool IsDeleted = false;
            using(SqlConnection connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "delete from MedicalRecords where MedicalRecordID=@MedicalRecordID";
                using(SqlCommand Command=new SqlCommand(Query, connection))
                {
                    connection.Open();
                    Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    try {
                        IsDeleted = Command.ExecuteNonQuery() > 0;
                    }catch(Exception ex) { }
                }

            }
            return IsDeleted;
        }


        public static bool GetMedicalReocrdBy(int MedicalRecordID,ref string Diagnosis,ref string AdditionalNotes,ref string VisitDescription)
        { bool IsFound = false;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "select *from MedicalRecords where MedicalRecordID=@MedicalRecordID";
                using(SqlCommand Command=new SqlCommand(Query, Connection)) {
                    Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    try { 
                            Connection.Open();
                    using(SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                Diagnosis = (string)reader["Diagnosis"];
                                AdditionalNotes = (string)reader["AdditionalNotes"];
                                VisitDescription = (string)reader["VisitDescription"];
                            }
                        }
                    }catch(Exception ex) { }
                }
            }
            return IsFound;
        }  
    }
}
