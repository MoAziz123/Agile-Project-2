using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UnitTestProject1;

public partial class AnAddres : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        //create a new instance of clsStock
        clsStock Stock = new clsStock();
        Stock = Session["Stock"] as clsStock;
        //display the house number for this entry
        Response.Write(Stock.Product_ID);
        */
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Creating an instance
        clsStock Stock = new clsStock();
        //Capture the Product_ID
        Stock.Product_ID = Convert.ToInt32( Product_ID.Text);
        //Capture the Product name
        Stock.Product_Name = Product_Name.Text;
        //Capture product type
        Stock.Product_Type = Product_Type.Text;
        //Capture product description
        Stock.Product_Description = Product_Description.Text;
        //Capture quantity
        Stock.Quantity = Convert.ToInt32( Quantity.Text);
        //Store the address in the session object
        Session["Stock"] = Stock;
        //redirect to the viewer page
        Response.Redirect("AddressViewer.aspx");
    }
}