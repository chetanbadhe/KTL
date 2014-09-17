using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KTLDemo.Model;

namespace KTLDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        DCOrdersDataContext dc = new DCOrdersDataContext(@"Data Source=CHETANBADHE-PC\SQLEXPRESS;Initial Catalog=KTL;Persist Security Info=True;User ID=sa;Password=sa@123");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               var customers = from c in dc.Customers
                               select c;
               ddlCustomer.DataValueField = "CustomerID";
               ddlCustomer.DataTextField = "CompanyName";
               ddlCustomer.DataSource = customers;
               DataBind(); 
            }
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            if (ddlCustomer.SelectedItem.Value != "")
            {
                gvData.DataSource = GetData(ddlCustomer.SelectedItem.Value);
                gvData.DataBind();
            }               
        }

        public object GetData(string custid)
        {
            if (custid != null)
            {
                var orders = (from o in dc.Orders
                              join od in dc.Order_Details on o.OrderID equals od.OrderID into grop
                              where o.CustomerID == Convert.ToInt32(custid)
                              select new { o.Customer.CompanyName, o.OrderID, o.OrderDate, o.ShipVia, OrderCount = grop.Count() }).ToList();
                return orders;
            }
            else
                return null;
        }
    }
}
