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
        //Create a new instane of clsAddress
        clsStock AnAddress = new clsStock();
        AnAddress.HouseNo = txtProductID.Text;
        Session["AnAddress"] = AnAddress;
        Response.Redirect("AddressViewer.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

    }
}