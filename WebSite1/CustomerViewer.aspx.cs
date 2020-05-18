using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer Acustomer = new clsCustomer();
        Acustomer = (clsCustomer)Session["Acustomer"];
        Response.Write(Acustomer.CustomerID);
    }
}
