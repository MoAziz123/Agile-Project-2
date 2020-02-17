using System;

namespace ClassLibrary2
{
    public class clsOrder
    {
        private int customer_id;
        private int product_id;
        private string product_name;
        private bool dispatch;
        private int order_quantity;
        private System.DateTime date_ordered;

        public clsOrder()
        {
            customer_id = 0;
            product_id = 0;
            product_name = "";
            dispatch = false;
            order_quantity = 0;
            date_ordered = System.DateTime.Now;
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

        public bool Dispatch
        {
            get { return dispatch; }
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
            db.AddParameter("CustomerID", customer_id);
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
    }
}