using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LocalDbsample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SkypletEntities db = new SkypletEntities();
            var customers = db.Customers;
            string result = "";
            foreach (var customer in customers)
            {
                result += string.Format("{0} | {1} | {2}", customer.Name, customer.CustomerId, customer.Address);
            }
            resultLabel.Text = result;
        }
    }
}