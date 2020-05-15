using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public clsOrderCollection col;
        public clsDataConnection db = new clsDataConnection();
        public Form1()
        {
            this.Text = "Order Form";
            col = new clsOrderCollection();
            InitializeComponent();
        }
        private void onload(object sender, EventArgs e)
        {
            fillListBox(col.list);
            
        }
        private void add_Click(object sender, EventArgs e)
        {
            clsOrder order = new clsOrder();
            order.Customer_Id = Convert.ToInt32(textBox1.Text);
            order.Product_Id = Convert.ToInt32(textBox2.Text);
            order.Product_Name = textBox5.Text;
            order.Order_Quantity = Convert.ToInt32(textBox4.Text);
            order.Dispatch = Convert.ToBoolean(checkBox1.CheckState);
            order.Date_Ordered = Convert.ToDateTime(dateTimePicker1.Text);
            string Error = order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Dispatch, order.Order_Quantity, order.Date_Ordered);
            if(Error == "")
            {
                col.mthisorder = order;
                col.Add();
                MessageBox.Show("Item has been added");
            }
            

        }

       
       

        private void edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {

                var data = listBox1.SelectedItem.ToString().Split('-');
                clsOrder order = new clsOrder();
                int cid = Convert.ToInt32(data[0]);
                if(order.find(cid))
                {
                    order.Customer_Id = Convert.ToInt32(textBox1.Text);
                    order.Product_Id = Convert.ToInt32(textBox2.Text);
                    order.Product_Name = textBox5.Text;
                    order.Order_Quantity = Convert.ToInt32(textBox4.Text);
                    order.Dispatch = Convert.ToBoolean(checkBox1.CheckState);
                    order.Date_Ordered = Convert.ToDateTime(dateTimePicker1.Text);
                    string Error = order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Dispatch, order.Order_Quantity, order.Date_Ordered);
                    if (Error == "")
                    {
                        col.mthisorder = order;
                        col.Update();
                        MessageBox.Show("Item has been updated");
                    }
                    else
                    {
                        MessageBox.Show(Error);
                    }

                }
                else
                {
                    MessageBox.Show("Item could not be updated.");
                }

            }

            
        }

        private void remove_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {

                var data = listBox1.SelectedItem.ToString().Split('-');
                clsOrder order = new clsOrder();
                int cid = Convert.ToInt32(data[0]);
                if(order.find(cid))
                {

                    col.mthisorder = order;
                    col.Delete();
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    MessageBox.Show("Item has been deleted");
                }
                else
                {
                    MessageBox.Show("Item could not be deleted.");
                }
                

            }



        }

        private void filter_Click(object sender, EventArgs e)
        {
            if(textBox6.Text != null)
            {
                col.Filter(textBox6.Text);
                listBox1.Items.Clear();
                fillListBox(col.list);
                MessageBox.Show("Items have been filtered");


            }
            else
            {
                MessageBox.Show("Please enter some data into the filter field");
            }

        }

        private void listboxdbl_click(object sender, EventArgs e)
        {
            var data = listBox1.SelectedItem.ToString().Split('-');
            clsOrder order = new clsOrder();
            int cid = Convert.ToInt32(data[0]);
            if(order.find(cid))
            {
                textBox1.Text = order.Customer_Id.ToString();
                textBox2.Text = order.Product_Id.ToString();
                textBox5.Text = order.Product_Name;
                textBox4.Text = order.Order_Quantity.ToString();
                checkBox1.Checked = order.Dispatch;
                dateTimePicker1.Text = order.Date_Ordered.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Record could not be matched");
            }
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox7.Text != null)
            {
                clsOrder order = new clsOrder();
                var data = Convert.ToInt32(textBox7.Text);
                if (order.findOne(data))
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(order.Product_Id.ToString() + " - " + order.Product_Name + " - " + order.Date_Ordered);
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number into the find field.");
            }
        }

        private void fillListBox(List<clsOrder> list)
        {
            foreach(clsOrder item in list)
            {
                listBox1.Items.Add(item.Customer_Id + " - " + item.Product_Name + " - " + item.Date_Ordered);
            }
        }
    }
}
