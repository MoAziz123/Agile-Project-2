using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class clsOrder
{
    public int customer_ID;
    public int product_ID;
    public string product_name;
    public int order_quantity;
    public bool dispatch;
    public DateTime date_ordered;
	public clsOrder(int customer_ID, int product_ID, string product_name, int order_quanity, bool dispatch, DateTime date_ordered)
	{
        this.customer_ID = customer_ID;
        this.product_ID = product_ID;
        this.product_name = product_name;
        this.order_quantity = order_quanity;
        this.dispatch = dispatch;
        this.date_ordered = date_ordered;
	}
    public string find()
    {
        
    }
}
