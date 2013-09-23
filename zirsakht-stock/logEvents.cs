using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace zirsakht_stock
{
    
    class logEvents
    {
       
        public static void RegEvent(int actionid, int userid,string desc)
        {
             lqStockDataContext lq = new lqStockDataContext();
            tbl_log_Event a = new tbl_log_Event();
            a.Actionid = actionid;
            a.userid = userid;
            a.date = DateTime.Now.ToString();
            a.Description = desc;
            lq.tbl_log_Events.InsertOnSubmit(a);
            lq.SubmitChanges();

        }
        public enum Actions
        {
              Login=1,
              Logout=2,
              Issued_Havale=3,
              Issued_Resid=4,
              Register_Kharid=5,
              Use_Kardex=6,
              Print_Havaleh=7,
        }
    }
    
}
