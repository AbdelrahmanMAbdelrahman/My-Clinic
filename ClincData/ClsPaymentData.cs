using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClincData
{
   public class ClsPaymentData
    {
        public static int AddNewPayment(string PaymentMethod,int AmountPaid,string AddtionalNotes,DateTime PaymentDate)
        {
            int PaymentID = 0;
            using (SqlConnection Connection=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = " insert into Payments(PaymentMethod,PaymentDate,AmountPaid,AdditionalNotes)" +
                    "values(@PaymentMethod,@PaymentDate,@AmountPaid,@AdditionalNotes);select SCOPE_IDENTITY();";
                using (SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                    Command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                    Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                    Command.Parameters.AddWithValue("@AdditionalNotes", AddtionalNotes);
                    try {
                        Connection.Open();
                        object res = Command.ExecuteScalar();
                        if (res != null&&int.TryParse(res.ToString(),out int id))
                        {
                            PaymentID = id;

                        }
                    }catch(Exception ex) { }
                }
            }return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID,string PaymentMethod, int AmountPaid, string AddtionalNotes, DateTime PaymentDate)
        {
            bool IsUpdated = false;
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = " update Payments set PaymentMethod=@PaymentMethod,PaymentDate=@PaymentDate," +
                    "AmountPaid=@AmountPaid,AddtionalNotes=@AddtionalNotes where PaymentID=@PaymentID;";
                using (SqlCommand Command = new SqlCommand(Query,connection))
                {
                    Command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                    Command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                    Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                    Command.Parameters.AddWithValue("@AddtionalNotes", AddtionalNotes);
                    Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                    try {
                        connection.Open() ;
                        IsUpdated = Command.ExecuteNonQuery() > 0;
                    }catch(Exception ex)
                    {

                    }
                }
            }return IsUpdated;

        }
        public 
            static bool DeletePayment(int paymentID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connectoin=new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Delete from Payments where PaymentID =@PaymentID";
                using (SqlCommand Command=new SqlCommand(Query, Connectoin))
                {
                    Command.Parameters.AddWithValue("@PaymentID", paymentID);
                    try {
                        Connectoin.Open();
                        IsDeleted = Command.ExecuteNonQuery()>0;

                    }catch(Exception ex)
                    {

                    }
                }
            }return IsDeleted;
        }

        public static bool GetPaymentBy(int PaymentID,ref string PaymentMethod,ref DateTime PaymentDate, 
            ref int AmountPaid, ref string AddtionalNotes)
        {
            bool IsFound = false;
            using (SqlConnection Connection =new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select *from Payments where PaymentID =@PaymentID";
                using(SqlCommand Command=new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                    try { Connection.Open();
                           
                        using (SqlDataReader Reader=Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                PaymentDate = (DateTime)Reader["PaymentDate"];
                                PaymentMethod = (string)Reader["PaymentMethod"];
                                AmountPaid = (int)Reader["AmountPaid"];
                                AddtionalNotes = (string)Reader["AddtionalNotes"];
                            }
                        }
                    }catch(Exception ex) { }
                }
            }
            return IsFound;
        }
    }
}
