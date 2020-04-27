using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class clsOrderCollection
    {
        private List<clsOrder> lstorder;
        private int lstcount;
        clsOrder thisorder = new clsOrder();
        public clsOrderCollection()
        {
            clsDataConnection db = new clsDataConnection();
            lstorder = new List<clsOrder>();
            db.Execute("select_allProcedureOrder");
            PopulateList(db);
          
        }

        public List<clsOrder> list
        {
            get
            {
                return lstorder;
            }
            set
            {
                lstorder = value;
            }
        }
        public clsOrder mthisorder
        {
            get
            {
                return thisorder;
            }
            set
            {
                thisorder = value;
            }
        }

        public int count
        {
            get
            {
                return lstcount;
            }
            set
            {
                lstcount = value;
            }
        }
        public int Add()
        {
            clsDataConnection dbconn = new clsDataConnection();
            dbconn.AddParameter("@Customer_ID", thisorder.Customer_Id);
            dbconn.AddParameter("@Product_ID", thisorder.Product_Id);
            dbconn.AddParameter("@Product_Name", thisorder.Product_Name);
            dbconn.AddParameter("@Dispatch", thisorder.Dispatch);
            dbconn.AddParameter("@Order_Quanity", thisorder.Order_Quantity);
            dbconn.AddParameter("@Date_Ordered", thisorder.Date_Ordered);
            return dbconn.Execute("addProcedureOrder");
           
        }
        public int Delete()
        {
            clsDataConnection dbconn = new clsDataConnection();
            dbconn.AddParameter("@Product_ID", thisorder.Product_Id);
            return dbconn.Execute("deleteProcedureOrder");
        }

        public int Update()
        {
            clsDataConnection dbconn = new clsDataConnection();
            dbconn.AddParameter("@Customer_ID", thisorder.Customer_Id);
            dbconn.AddParameter("@Product_ID", (int)thisorder.Product_Id);
            dbconn.AddParameter("@Product_Name", thisorder.Product_Name);
            dbconn.AddParameter("@Dispatch", thisorder.Dispatch);
            dbconn.AddParameter("@Order_Quanity", thisorder.Order_Quantity);
            dbconn.AddParameter("@Date_Ordered", thisorder.Date_Ordered);
            return dbconn.Execute("updateProcedureOrder");
        }
        
        public List<string> ToList()
        {
            List<string> list = new List<string>();
            foreach(clsOrder i in lstorder)
            {
                string data = "Order: " + i.Product_Id.ToString() + " - " + i.Product_Name.ToString() + " - " + i.Date_Ordered.ToShortDateString();
                list.Add(data);
            }
            return list;
        }
        public void Filter(string data)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@ProductName", data);
            db.Execute("filterProcedureOrder");
            PopulateList(db);
        }
        public void PopulateList(clsDataConnection db)
        {
            int index = 0;
            int count = db.Count;
            list = new List<clsOrder>();
            while (index < count)
            {
                clsOrder ord = new clsOrder();
                int cid = Convert.ToInt32(db.DataTable.Rows[index]["Customer_ID"]);
                int pid = Convert.ToInt32(db.DataTable.Rows[index]["Product_ID"]);
                string pn = Convert.ToString(db.DataTable.Rows[index]["Product_Name"]);
                int oq = Convert.ToInt32(db.DataTable.Rows[index]["Order_Quantity"]);
                bool d = Convert.ToBoolean(db.DataTable.Rows[index]["Dispatch"]);
                System.DateTime dt = Convert.ToDateTime(db.DataTable.Rows[index]["Date_Ordered"]);
                list.Add(new clsOrder(cid, pid, pn, d, oq, dt));
                index++;

            }

        }

    }
}
