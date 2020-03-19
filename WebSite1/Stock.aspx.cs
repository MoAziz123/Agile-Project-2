using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary2;

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
        // capture Product_ID
        Int32 ProductID = Convert.ToInt32(Product_ID.Text);
        // capture the product name
        string ProductName = Product_Name.Text;
        // capture the type
        string ProductType = Product_Type.Text;
        // Capture product description
        string ProductDescription = Product_Description.Text;
        // capture quantity
        Int32 StockQuantity = Convert.ToInt32(Quantity.Text);
        // var to store any error message
        string Error = "";
        //validate the data
        Error = Stock.Valid(ProductID, ProductName, ProductType, ProductDescription, StockQuantity);

        if (Error == "")
        {
            //Capture the Product_ID
            Stock.Product_ID = Convert.ToInt32(Product_ID.Text);
            //Capture the Product name
            Stock.Product_Name = Product_Name.Text;
            //Capture product type
            Stock.Product_Type = Product_Type.Text;
            //Capture product description
            Stock.Product_Description = Product_Description.Text;
            //Capture quantity
            Stock.Quantity = Convert.ToInt32(Quantity.Text);
            //Store the address in the session object
            Session["Stock"] = Stock;
            //redirect to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display error message
            Response.Write(Error);
        }
    }
  

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock Stock = new clsStock();
        //var of primary  key
        Int32 Product_Id;
        //Var to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered of the find operation
        Product_Id = Convert.ToInt32(Product_ID.Text);
        //find the record if it exists
        Found = Stock.Find(Product_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties
            Product_ID.Text = Convert.ToString(Stock.Product_ID);
            Product_Name.Text = Stock.Product_Name;
            Product_Type.Text = Stock.Product_Type;
            Product_Description.Text = Stock.Product_Description;
            Quantity.Text = Convert.ToString(Stock.Quantity);
        }
        else
        { // tempory error message to be displayed if Product with inputed ID doesn't work
            Response.Write("Product with that ID doesn't exist in our database!");
        }
    }
}