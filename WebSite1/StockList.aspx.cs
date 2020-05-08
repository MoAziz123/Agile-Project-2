using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //create an instance of the collection
        ClassLibrary2.clsStockCollection Stocks = new ClassLibrary2.clsStockCollection();
        //set data source to the list of countries in the collection
        LstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        LstStockList.DataValueField = "Product_ID";
        //set the data field to display
        LstStockList.DataValueField = "Product_Name";
        //bind the data to the list
        LstStockList.DataBind();
    }

    protected void LstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {
        //create an instance of the collection
        ClassLibrary2.clsStockCollection Stocks = new ClassLibrary2.clsStockCollection();
        //
        LstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        LstStockList.DataValueField = "Product_ID";
        //set the data field to display
        LstStockList.DataValueField = "Product_Name";
        //bind the data to the list
        LstStockList.DataBind();
    }
}