using System;

namespace ClassLibrary2
{
    public class clsOrder
    {
        private int customer_id;
        private int product_id;
        private string product_name;
        private int order_quantity;
        private bool dispatch;
        private System.DateTime date_ordered;

        public clsOrder()
        {
            Customer_Id = 0;
            Product_Id = 0;
            Product_Name = "";
            Dispatch = false;
            Order_Quantity = 0;
            Date_Ordered = System.DateTime.Now;
        }
        public clsOrder(int customer_id, int product_id, string product_name, bool dispatch, int order_quantity, System.DateTime date_ordered)
        {
            this.customer_id = customer_id;
            this.product_id = product_id;
            this.product_name = product_name;
            this.dispatch = dispatch;
            this.order_quantity = order_quantity;
            this.date_ordered = date_ordered;
        }
        public int Customer_Id
        {
            get { return customer_id; }
            set { this.customer_id = value; }

        }
        public int Product_Id
        {
            get { return product_id; }
            set { this.product_id = value; }

        }
        public string Product_Name
        {
            get { return product_name; }
            set { this.product_name = value; }

        }
        public int Order_Quantity
        {
            get { return order_quantity; }
            set { this.order_quantity = value; }

        }

        public bool Dispatch {
            get {return dispatch; }
            set { this.dispatch = value; }
            
        }
        public System.DateTime Date_Ordered
        {
            get { return date_ordered; }
            set { this.date_ordered = value; }
        }

        public bool find(int cid)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@CustomerID", cid);
            db.Execute("findProcedureOrder");
            if(db.Count >= 1)
            {
                this.Customer_Id = Convert.ToInt32(db.DataTable.Rows[0]["Customer_ID"]);
                this.Product_Id = Convert.ToInt32(db.DataTable.Rows[0]["Product_ID"]);
                this.Product_Name = Convert.ToString(db.DataTable.Rows[0]["Product_Name"]);
                this.Order_Quantity = Convert.ToInt32(db.DataTable.Rows[0]["Order_Quantity"]);
                this.Dispatch = Convert.ToBoolean(db.DataTable.Rows[0]["Dispatch"]);
                this.Date_Ordered = Convert.ToDateTime(db.DataTable.Rows[0]["Date_Ordered"]);
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool findOne(int pid)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@ProductID", pid);
            db.Execute("findOneProcedureOrder");
            if(db.Count == 1)
            {
                this.Customer_Id = Convert.ToInt32(db.DataTable.Rows[0]["Customer_ID"]);
                this.Product_Id = Convert.ToInt32(db.DataTable.Rows[0]["Product_ID"]);
                this.Product_Name = Convert.ToString(db.DataTable.Rows[0]["Product_Name"]);
                this.Order_Quantity = Convert.ToInt32(db.DataTable.Rows[0]["Order_Quantity"]);
                this.Dispatch = Convert.ToBoolean(db.DataTable.Rows[0]["Dispatch"]);
                this.Date_Ordered = Convert.ToDateTime(db.DataTable.Rows[0]["Date_Ordered"]);
                return true;
            }
            else
            {
                return false;
            }

        }
       

        public string valid(int cid, int pid, string pn,  int oq, bool d, System.DateTime date_ordered)
        {
            string GlobalError = "";
            string CIDError = customerIDvalid(cid);
            if(CIDError != "")
            {
                GlobalError += CIDError;
            }
            string PIDError = productIDvalid(pid);
            if(PIDError != "")
            {
                GlobalError += PIDError;
            }

            string PNError = productNamevalid(pn);
            if(PNError != "")
            {
                GlobalError += PNError;
            }

            string DError = dispatchValid(d);
            if(DError != "")
            {
                GlobalError += DError;
            }

            string OQError = orderQuantityValid(oq);
            if(OQError != "")
            {
                GlobalError += OQError;
            }

            string DOError = dateTimevalid(date_ordered);
            if(DOError != "")
            {
                GlobalError += DOError;
            }

            return GlobalError;


        }
        public string customerIDvalid(int customer_id)
        {
            string Error = "";
            if(!(customer_id > 0 && customer_id < int.MaxValue))
            {
                Error += string.Format("The customer ID must be between 0 and {0}", int.MaxValue);
                return Error;
            }
            return "";
            

        }
        public string productIDvalid(int product_id)
        {
            string Error = "";
            if (!(product_id is int && product_id > 0 && product_id < int.MaxValue))
            {
                Error += string.Format("The product ID must be between 0 and {0}", int.MaxValue);
                return Error;
            }
            return "";

        }
        public string productNamevalid(string product_name)
        {
            string Error = "";
            if(!(product_name.Length > 0 && product_name.Length < 50))
            {
                Error += "The product name must be between 0 and 50 characters in length";
                return Error;
                
            }
            return "";
        }
        public string dispatchValid(bool dispatch)
        {
            string Error = "";
            if(!(dispatch is bool))
            {
                Error += "The dispatch variable needs to be of type boolean.";
                return Error;
            }
            return "";
        }
        public string orderQuantityValid(int order_quantity)
        {
            string Error = "";
            if (!(order_quantity> 0 && order_quantity< int.MaxValue))
            {
                Error += string.Format("The order quantity needs to be between 0 and {0}.", int.MaxValue);
                return Error;
            }
            return "";
        }
        public string dateTimevalid(System.DateTime date)
        {
            string Error = "";
            if(!(date == DateTime.Today))
            {
                Error += "The date must be today.";
                return Error;
            }
            return "";
        }
    }
}