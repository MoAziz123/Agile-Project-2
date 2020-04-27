using System;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp1
{
    public partial class RemoveForm : Form
    {
        public clsOrder order;
        public clsOrderCollection col;
        public RemoveForm(clsOrderCollection col)
        {
            InitializeComponent();
        }

        private void load()
        {
            clsDataConnection db = new clsDataConnection();
            
        }
        private void remove_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
