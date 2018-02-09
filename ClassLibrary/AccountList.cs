using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This serves as a database
// object of Session["list"]
// accessible to all asp website

namespace ClassLibrary
{
    public class AccountList
    {

        public List<Account> accountList { get; set; }

        public AccountList()
        {
            accountList = new List<Account>();
        }

        public void AddToAccounts(Account acct)
        {
            accountList.Add(acct);
        }


        // return true if passed string is equal to
        // an existing account in account list
        public Boolean DoesExist(string email)
        {
            foreach(Account acc in accountList){
                if (email.Equals(acc.EmailAddress)) {
                    System.Diagnostics.Debug.WriteLine(email + " is equal to " + acc.EmailAddress);
                    return true;
                }
            }

            return false;
        }


        // return the account with the
        // existing emailaddress passed through a string
        public Account GetAccount(string email)
        {
            foreach (Account acc in accountList)
            {
                if (email.Equals(acc.EmailAddress)) {
                    return acc;
                }
            }

            return null;
        }

        override public String ToString() {
            StringBuilder sb = new StringBuilder();
            foreach (Account acc in accountList) {
                sb.Append(acc.EmailAddress + " " + acc.Password + "\n");
            }

            return sb.ToString();
        }
    }

}
