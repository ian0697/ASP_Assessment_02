using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace PrelimAct2
{
    public partial class Registration : System.Web.UI.Page
    {
        AccountList acct_list = new AccountList();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if session is null
            if (Session["list"] == null) {
                Session["list"] = new AccountList();
                acct_list = (AccountList) Session["list"];
                System.Diagnostics.Debug.WriteLine("session null [registration]");
            }
            else {
                acct_list = (AccountList) Session["list"];
                System.Diagnostics.Debug.WriteLine(acct_list.ToString());
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Account account = new Account();
                account.FirstName = TbFirstName.Text;
                account.LastName = TbLastName.Text;
                account.Birthday = TbBirthday.Text.ToString();
                account.ContactNo = TbContact.Text;
                account.EmailAddress = TbEmail.Text;
                account.Password = TbPassword.Text;
                account.Address = TbAddress.Text;
                acct_list.AddToAccounts(account);

                Session["list"] = acct_list;
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}