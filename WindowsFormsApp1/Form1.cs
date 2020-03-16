using ClassLibrary2;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public clsOrder order;
        public Form1()
        {
            this.Text = "Order Form";
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            order.Customer_Id = Convert.ToInt32(textBox1.Text);
            order.Product_Id = Convert.ToInt32(textBox2.Text);
            order.Product_Name = textBox5.Text;
            order.Order_Quantity = Convert.ToInt32(textBox4.Text);
            order.Dispatch = Convert.ToBoolean(checkBox1.CheckState);
            order.Date_Ordered = Convert.ToDateTime(dateTimePicker1.Text);

            //string Error = order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
