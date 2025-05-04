using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
  public  class ClsAppointmentData
    {
        public static int AddNewAppointment(int PatientID, int DoctorID,int PaymentID,DateTime AppointmentDate,
            byte AppointmentStatus,int MedicalRecordID)
        {
            int AppointmentID = 0;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = " insert into Appointments (PatientID,DoctorID,AppointmentDateTime," +
                    "MedicalRecordID,PaymentID,AppointmentStatus) values (@PatientID,@DoctorID," +
                    "@AppointmentDateTime,@MedicalRecordID,@PaymentID,@AppointmentStatus);select SCOPE_IDENTITY();";
                using(SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PatientID", PatientID);
                    Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                    Command.Parameters.AddWithValue("@AppointmentDateTime",AppointmentDate);
                    Command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                    Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
           

                    try
                    { Connection.Open();
                        object res = Command.ExecuteScalar();
                        if(res!=null&&int.TryParse(res.ToString(),out int id))
                        {
                            AppointmentID = id;
                        }
                    }catch(Exception ex)
                    {

                    }
                }
            }return AppointmentID;
        }


        public static bool UpdateAppointment(int PatienID, int DoctorID, int PaymentID, DateTime AppointmentDate,
            string AppointmentStatus, int MedicalRecordID,int AppointmentID)
        {
            bool IsUpdated = false;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = " update Appointments set DoctorID=@DoctorID,PatientID=@PatientID," +
                    " AppointmentDateTime =@AppointmentDateTime,AppointmentStatus=@AppointmentStatus," +
                    "MedicalRecordID=@MedicalRecordID,PaymentID=@PaymentID where AppointmentID=@AppointmentID;";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    try
                    {
                        Connection.Open();
                        IsUpdated = Command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                    }return IsUpdated;
        }
        public static bool DeleteAppointment(int AppointmentID)
        {
            bool IsDelete = false;
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "delete from Appointments where AppoinetmentID=@AppoinetmentID";
                using(SqlCommand Command=new SqlCommand())
                {
                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    try {
                        Connection.Open();
                        IsDelete = Command.ExecuteNonQuery() > 0;
                    }catch(Exception ex) { }
                }
            }return IsDelete;
        }
        public static bool GetAppointmentByBy(int AppointmentID,ref string AppointmentStatus,ref int DoctorID,
            ref int PatienID,ref int PaymentID,
           ref  DateTime PaymentDate,ref int MedicalRecordID)
        {
            bool IsFound = false;
            using(SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select *from Appointments where AppointmentID =@AppointmentID";
                using(SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    try { Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                AppointmentStatus = (String)Reader["AppointmentStatus"];
                                DoctorID = (int)Reader["DoctorID"];
                                PatienID = (int)Reader["PatienID"];
                                MedicalRecordID = (int)Reader["MedicalRecordID"];
                                PaymentDate = (DateTime)Reader["PaymentDate"];
                                PaymentID = (int)Reader["PaymentID"];
                                IsFound = true;
                            }

                        }
                    }catch(Exception ex) { }
                }

            }return IsFound;
        }
        public static DataTable GetAllAppointments()
        {
            DataTable Appointments = new DataTable();
            using (SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select *from Appointments";
                using(SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    try { 
                    Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                Appointments.Load(Reader);
                            } }

                    }catch(Exception ex) { }
                }
            }return Appointments;
        }
    }
}
