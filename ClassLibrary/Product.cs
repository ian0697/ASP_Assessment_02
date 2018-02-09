using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {

        private Double subtotal;

        public String ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public int Stocks { get; set; }
        public double Subtotal {
            get {
                return ProductPrice* ProductQuantity;
            }
            set {
                subtotal = value;
            }
        }


        public Product(string productName, int stocks, double productPrice, int productQuantity) {
            ProductName = productName;
            Stocks = stocks;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            Subtotal = 0;
        }

        public Product(string productName, int productQuantity, double subtotal) {
            ProductName = productName;
            ProductQuantity = productQuantity;
            Subtotal = subtotal;
        }
    }
}
