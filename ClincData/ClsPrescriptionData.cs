using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
  public  class ClsPrescriptionData
    {
        public static int AddNewPrescription(int MedicalRecordID,int Frequency,DateTime StartDate,
            DateTime EndDate,string Dosage,string Instruction,string MedicationName)
        {
            int PrescriptionID = 0;
            using (SqlConnection Connection =new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = " insert into Prescriptions (MedicalRecordID,EndDate,StartDate,Dosage," +
                    "Frequency,MedicationName,SpecialInstruction) values(@MedicalRecordID,@EndDate,@StartDate," +
                    "@Dosage,@Frequency,@MedicationName,@SpecialInstruction);select SCOPE_IDENTITY();";
                using(SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    Command.Parameters.AddWithValue("@EndDate", EndDate);
                    Command.Parameters.AddWithValue("@StartDate", StartDate);
                    Command.Parameters.AddWithValue("@Dosage", Dosage);
                    Command.Parameters.AddWithValue("@Frequency", Frequency);
                    Command.Parameters.AddWithValue("@MedicationName", MedicationName);
                    Command.Parameters.AddWithValue("@SpecialInstruction", Instruction);
                    try {
                        Connection.Open();
                        object res = Command.ExecuteScalar();
                        if(res!=null&&int.TryParse(res.ToString(),out int id))
                        {
                            PrescriptionID = id;
                        }
                    }catch (Exception ex) { }
                }

            }return PrescriptionID;
        }

        public static bool UpdatePrescription(int MedicalRecordID, int Frequency, DateTime StartDate,
            DateTime EndDate, string Dosage, string Instruction, string MedicationName,int PrescriptionID)
        {
            bool IsUpdated = false;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = " update Prescriptions set MedicalRecordID=@MedicalRecordID,EndDate=@EndDate," +
                    "StartDate=@StartDate, Dosage=@Dosage,Frequency=@Frequency,MedicationName=@MedicationName," +
                    "SpecialInstruction=@SpecialInstruction where PrescriptionID=@PrescriptionID;";
                using (SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    try {
                        Connection.Open();
                        IsUpdated = Command.ExecuteNonQuery() > 0;

                    }
                    catch (Exception ex) { }
                }
            }return IsUpdated;
        }

        public static bool DeletePrescription(int PrescriptionID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "delete from Prescriptions where PrescriptionID =@PrescriptionID";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                    Connection.Open();
                    IsDeleted = Command.ExecuteNonQuery() > 0;
                }

            }return IsDeleted;
        }

        public static bool GetPrescriptionBy(ref int MedicalRecordID,ref  int Frequency, ref DateTime StartDate,
           ref DateTime EndDate,ref string Dosage,ref string Instruction,ref string MedicationName,   int PrescriptionID)
        {
            bool IsFound = false;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "select *from Prescriptions where PrescriptionID =@PrescriptionID";
                using (SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                    try
                    {
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                MedicalRecordID = (int)Reader["MedicalRecordID"];
                                Frequency = (int)Reader["Frequency"];
                                StartDate = (DateTime)Reader["StartDate"];
                                EndDate = (DateTime)Reader["EndDate"];
                                Dosage = (String)Reader["Dosage"];
                                Instruction = (string)Reader["SpecialInstruction"];
                                MedicationName = (string)Reader["MedicationName"];
                                IsFound = false;
                            }
                        }
                    }catch(Exception ex)
                    {

                    }
                }
            }return IsFound;
        }        public static bool GetPrescriptionBy( int MedicalRecordID,ref  int Frequency, ref DateTime StartDate,
           ref DateTime EndDate,ref string Dosage,ref string Instruction,ref string MedicationName, ref  int PrescriptionID)
        {
            bool IsFound = false;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "select *from Prescriptions where MedicalRecordID =@MedicalRecordID";
                using (SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    try
                    {
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                PrescriptionID = (int)Reader["PrescriptionID"];
                                Frequency = (int)Reader["Frequency"];
                                StartDate = (DateTime)Reader["StartDate"];
                                EndDate = (DateTime)Reader["EndDate"];
                                Dosage = (String)Reader["Dosage"];
                                Instruction = (string)Reader["SpecialInstruction"];
                                MedicationName = (string)Reader["MedicationName"];
                                IsFound = false;
                            }
                        }
                    }catch(Exception ex)
                    {

                    }
                }
            }return IsFound;
        }
    }
}
