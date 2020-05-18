using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer : System.Web.UI.Page
{
    

    public object TxtCustomer_FirstName { get; private set; }
    public object TxtCustomer_Surname { get; private set; }
    public object TxtCustomer_Email { get; private set; }
    public object TxtCustomer_Address { get; private set; }
    public object TxtCustomerID { get; private set; }
    public int CustomerID { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer Acustomer = new clsCustomer();
        Acustomer = (clsCustomer)Session["Acustomer"];
        Response.Write(Acustomer.CustomerID);

    }



    protected void TxtCustomerID_TextChanged1(object sender, EventArgs e)
    {

    }


    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Acustomer = new clsCustomer();
        Acustomer.CustomerID = Convert.ToInt32(TxtCustomerID.Text);
        Acustomer.Customer_FirstName = txtCustomer_FirstName.Text;
        Acustomer.Customer_SurName = txtCustomer_Surname.Text;
        Acustomer.Customer_Email = txtCustomer_Email.Text;
        Acustomer.Customer_Address = txtCustomer_Address.Text;

        Session["ACustomer"] = Acustomer;
        Response.Redirect("CustomerViewer.aspx");
    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomer Acustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(TxtCustomerID.Text);
        Found = Acustomer.Find(CustomerID);
        if (Found ==true)
        {
            txtCustomerID.Text = Acustomer.CustomerID;
        }
    }
}