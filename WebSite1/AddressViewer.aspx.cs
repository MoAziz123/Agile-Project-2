using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UnitTestProject1;

public partial class AddressViewer_aspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of clsStock
        clsStock Stock = new clsStock();
        //get the data from the session object
        Stock = (clsStock)Session["Stock"];
        //Display the house number for this entry
        Response.Write(Stock.Product_ID);
        Response.Write("<br>");
        Response.Write(Stock.Product_Name);
        Response.Write("<br>");
        Response.Write(Stock.Product_Type);
        Response.Write("<br>");
        Response.Write(Stock.Product_Description);
        Response.Write("<br>");
        Response.Write(Stock.Quantity);
    }
}