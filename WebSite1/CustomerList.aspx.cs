using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary2;

public partial class _Default : System.Web.UI.Page
{
    public object lstCustomers { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayACustomers();
        }
    }

    public void DisplayACustomers()
    {
            ClassLibrary2.ClsCustomerCollection AllCustomers = new ClassLibrary2.ClsCustomerCollection();
            lstCustomers.Datasource = AllCustomers.CustomerList;
            lstCustomers.DataValueField = "CustomerID";
            lstCustomers.DataTextField = "firstname";
            lstCustomers.DataBind();
    }
    
}