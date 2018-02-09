using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrelimAct2
{
    public partial class MemberPage : System.Web.UI.Page {

        private static Product Ebooks = new Product("Ebooks", 100, 20.5, 0);
        private static Product aTraining = new Product("Training (Audio)", 100, 8.75, 0);
        private static Product vTraining = new Product("Training (Video)", 100, 32.55, 0);
        private static List<Product> myList;
        private static Double Total;
        private Cart cart = new Cart();


        protected void Page_Load(object sender, EventArgs e) {
            lbl1.Text = Ebooks.Stocks + ""; 
            lbl2.Text = aTraining.Stocks + "";
            lbl3.Text = vTraining.Stocks + "";

            if (!Page.IsPostBack) {
                //for repeater control
                Session["MyList"] = new List<Product>();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e) {

            // deduct stocks from inputted qty
            Ebooks.Stocks -= Convert.ToInt32(tb1.Text);

            String name;
            int quantity;
            double subtotal;

            //Error if stocks is less than 90 
            //meaning the user already bought 
            //more than 10 items of the same product
            if (Ebooks.Stocks < 90) {
                lbl1.Text = "Error";
            }
            else {
                name = Ebooks.ProductName;
                quantity = Convert.ToInt32(tb1.Text);
                subtotal = Ebooks.ProductPrice * quantity;

                Ebooks.ProductQuantity += quantity;
                lbl1.Text = Ebooks.Stocks + "";

                //for repeater control
                UpdateList(new Product(name, quantity, subtotal));
                BindEvent();
            }

            //set back to 0
            tb1.Text = "0";
        }
        
        protected void Button1_Click(object sender, EventArgs e) {
            aTraining.Stocks -= Convert.ToInt32(tb2.Text);
            String name;
            int quantity;
            double subtotal;

            if (aTraining.Stocks < 90) {
                lbl1.Text = "Error";
            }
            else {
                name = aTraining.ProductName;
                quantity = Convert.ToInt32(tb2.Text);
                subtotal = aTraining.ProductPrice * quantity;

                lbl2.Text = aTraining.Stocks + "";
                aTraining.ProductQuantity += Convert.ToInt32(tb2.Text);


                UpdateList(new Product(name, quantity, subtotal));
                BindEvent();
                RefreshCart();
            }


            tb2.Text = "0";
        }

        protected void Button2_Click(object sender, EventArgs e) {
            vTraining.Stocks -= Convert.ToInt32(tb3.Text);
            String name;
            int quantity;
            double subtotal;

            if (vTraining.Stocks < 90) {
                lbl1.Text = "Error";
            }
            else {
                name = vTraining.ProductName;
                quantity = Convert.ToInt32(tb1.Text);
                subtotal = vTraining.ProductPrice * quantity;

                lbl3.Text = vTraining.Stocks + "";
                vTraining.ProductQuantity += Convert.ToInt32(tb3.Text);

                UpdateList(new Product(name, quantity, subtotal));
                BindEvent();
                RefreshCart();
            }

            tb3.Text = "0";
        }

        private void UpdateList(Product product) {
            //Access existing session
            if (Session["MyList"] != null) {
                myList = (List<Product>) Session["MyList"];
            }

            //initialize
            else {
                myList = new List<Product>();
            }

            myList.Add(product);
            Session["MyList"] = myList;
        }

        private void BindEvent() {
            rptTrans.DataSource = myList;
            rptTrans.DataBind();
            RefreshCart();
        }

        // for total label in transaction cart
        // application of css manipulation using Asp.Net
        public void RefreshCart() {
            Total = Ebooks.Subtotal + aTraining.Subtotal + vTraining.Subtotal;
            totalLabel.Style.Add("Display", "inline") ;
            btnsubmit.Style.Add("Display", "block");
            lblTotal.Text = "Php" + Total;
        }

        // trigger if submit btn is clicked
        // all products will then be added to cart
        // and send it to Session["cart"]
        public void FinalizeCart() {
            cart.AddToCart(Ebooks);
            cart.AddToCart(aTraining);
            cart.AddToCart(vTraining);
            Session["cart"] = cart;
            Response.Redirect("Transaction.aspx");
        }

        protected void submit_click(object sender, EventArgs e)
        {
            FinalizeCart();
        }
    }



}