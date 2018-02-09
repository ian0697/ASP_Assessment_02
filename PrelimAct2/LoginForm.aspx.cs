using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace PrelimAct2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static AccountList aList;
        public static Account acct;

        protected void Page_Load(object sender, EventArgs e)
        {
            // initial account setup
            Account initial_acct = new Account();
            initial_acct.FirstName = "Ian";
            initial_acct.LastName = "Santiago";
            initial_acct.ContactNo = "09063290109";
            initial_acct.Password = "admin";
            initial_acct.EmailAddress = "admin@gmail.com";

            // if the session is null
            // Session["list"] will be initialized
            // at the same time, the admin acct will
            // be added to that session
            if (Session["list"] == null) {
                Session["list"] = new AccountList();
                aList = (AccountList) Session["list"];
                aList.AddToAccounts(initial_acct);
                System.Diagnostics.Debug.WriteLine("session is null [login]");
            }

            else {
                aList = (AccountList) Session["list"];
                System.Diagnostics.Debug.WriteLine(aList.ToString());
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)  {
            if (Page.IsValid) {

                // if there is an existing account,
                // access the account and pass it to Session["account"]
                if (aList.DoesExist(TbEmail.Text)) {
                    acct = aList.GetAccount(TbEmail.Text);

                    //if success
                    if (IsAuthenticationValid(acct)) {
                        Session["account"] = acct;
                        Response.Redirect("MemberPage.aspx");
                    }
                }
            }
        }


        // function of custom validator
        // validates if account exist
        // or input password is wrong
        protected void ServerValidation(object source, ServerValidateEventArgs arguments){

            //If No Account exist
            if (!aList.DoesExist(TbEmail.Text)) {
                arguments.IsValid = false;
                custalert.Style.Add("Display", "block");
                customValidator.ErrorMessage = "No account found!";
            }

            //If Account exist but wrong password
            if (aList.DoesExist(TbEmail.Text)) {
                acct = aList.GetAccount(TbEmail.Text);

                if (!TbPassword.Text.Equals(acct.Password)) {
                    customValidator.ErrorMessage = "Error password!";
                    custalert.Style.Add("Display", "block");
                    arguments.IsValid = false;
                }
            }

        }
        
        private Boolean IsAuthenticationValid(Account acct) {
            if (TbPassword.Text.Equals(acct.Password) && TbEmail.Text.Equals(acct.EmailAddress)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}

