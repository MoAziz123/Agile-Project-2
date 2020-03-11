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

        public bool find(int customer_id)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@CustomerID", customer_id);
            db.Execute("findProcedureOrder");
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
        //public string valid(int customer_id, int product_id, string product_name, bool dispatch, int order_quantity, System.DateTime date_ordered)
        //{
        //    if(customerIDvalid(customer_id) && productIDvalid(product_id) && productNamevalid(product_name) && dispatchValid(dispatch) && orderQuantityValid(order_quantity) &&dateTimevalid(date_ordered))
        //    {
        //        return "";
        //    }
            

        //}
        public string customerIDvalid(int customer_id)
        {
            if(!(customer_id is int && customer_id > 0 && customer_id < int.MaxValue))
            {
                return string.Format("The customer ID must be between 0 and {0}", int.MaxValue);
            }
            return "";
            

        }
        public string productIDvalid(int product_id)
        {
            if (!(product_id is int && product_id > 0 && product_id < int.MaxValue))
            {
                return string.Format("The product ID must be between 0 and {0}", int.MaxValue);
            }
            return "";

        }
        public string productNamevalid(string product_name)
        {
            if(!(product_name is string && product_name.Length > 0 && product_name.Length < 50))
            {
                return "The product name must be between 0 and 50 characters in length";
            }
            return "";
        }
        public string dispatchValid(bool dispatch)
        {
            if(!(dispatch is bool))
            {
                return "The dispatch variable needs to be of type boolean.";
            }
            return "";
        }
        public string orderQuantityValid(int order_quantity)
        {
            if (!(order_quantity is int && order_quantity> 0 && order_quantity< int.MaxValue))
            {
                return string.Format("The order quantity needs to be between 0 and {0}.", int.MaxValue);
            }
            return "";
        }
        public string dateTimevalid(System.DateTime date)
        {
            if(!(date is System.DateTime && date == DateTime.Today))
            {
                return "The date must be today.";
            }
            return "";
        }
    }
}