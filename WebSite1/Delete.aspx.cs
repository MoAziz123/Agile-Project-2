using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 Product_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        Product_ID = Convert.ToInt32(Session["Product_ID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(Product_ID);
        StockBook.Delete();
        Response.Redirect("StockList.aspx");
    }
}