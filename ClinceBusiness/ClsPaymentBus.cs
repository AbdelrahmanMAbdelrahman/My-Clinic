using ClincData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClinceBusiness
{
  public  class ClsPaymentBus
    {
        public int PaymentID { get; set; }
        public string PaymentMethod { get; set; }
        public int AmountPaid { get;set; }
        public DateTime PaymentDate { get; set; }
        public string AddtionalNotes { get; set; }
        public enum EnMode { AddNew=0,Update=1}
        public EnMode Mode { get; set; }
        public ClsPaymentBus()
        {
            this.AmountPaid = 0;
            this.PaymentID = 0;
            this.AddtionalNotes = "";
            this.PaymentDate = DateTime.Now;
            this.PaymentMethod = "";
            
        }
       private ClsPaymentBus(int PaymentID,string AddtionalNotes,string PaymentMethod,int AmountPaid,
           DateTime PaymentDate)
        {
            this.Mode = EnMode.Update;
            this.AddtionalNotes = AddtionalNotes;
            this.PaymentMethod = PaymentMethod;
            this.PaymentID = PaymentID;
            this.AmountPaid = AmountPaid;
            this.PaymentDate = PaymentDate;
            
        }
        public static bool DeletePayment(int PaymentID)
        {
            return ClsPaymentData.DeletePayment(PaymentID);
        }
        bool _AddNewPayment()
        {
            this.PaymentID = ClsPaymentData.AddNewPayment(this.PaymentMethod, this.AmountPaid, this.AddtionalNotes, this.PaymentDate);
            return this.PaymentID > 0;

        }
        bool _UpdatePayment()
        {
            return ClsPaymentData.UpdatePayment(this.PaymentID,this.PaymentMethod,this.AmountPaid,this.AddtionalNotes,this.PaymentDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else
                    {
                        return _UpdatePayment();
                    }
            }
            return false;

        }
        public static ClsPaymentBus GetPaymentBy(int PaymentID)
        {
            int AmountPaid = 0;
            string PaymentMethod = "";
            string AddtionlNotes = "";
            DateTime PaymentDate = DateTime.Now;
            if(ClsPaymentData.GetPaymentBy(PaymentID,ref PaymentMethod,ref PaymentDate,ref AmountPaid,ref AddtionlNotes))
            {
                return new ClsPaymentBus(PaymentID, AddtionlNotes, PaymentMethod, AmountPaid, PaymentDate);
            }
            return null;
        }
    }
}
