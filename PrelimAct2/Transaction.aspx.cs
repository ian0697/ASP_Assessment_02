using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace PrelimAct2
{
    public partial class Transaction : System.Web.UI.Page
    {
        Account loggedin;
        Cart cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            //this must not be null
            if(Session["account"] != null) {
                loggedin = (Account) Session["account"];
            }

            //this must not be null
            if(Session["cart"] != null) {
                cart = (Cart) Session["cart"];
            }


            SetLabels();

        }

        protected void SetLabels() {
            lblAddress.Text = loggedin.Address;
            lblBirthday.Text = loggedin.Birthday;
            lblFullname.Text = loggedin.FirstName + " " + loggedin.LastName;
            lblContact.Text = loggedin.ContactNo;
            lblTotal.Text = "$ " + cart.Total;
        }
        
    }
}