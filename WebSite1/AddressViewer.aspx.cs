using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary2;

public partial class AddressViewer_aspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnAddress = new clsStock();
        AnAddress = (clsStock)Session["AnAddress"];
        Response.Write(AnAddress.HouseNo);
    }
}