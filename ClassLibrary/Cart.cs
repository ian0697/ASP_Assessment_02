using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary {
    public class Cart {
        private List<Product> productList;
        private double total;

        public List<Product> ProductList {
            get { return productList; }
            set { productList = value; }
        }

        public double Total {
            get {
                foreach (Product prod in productList) {
                    total += prod.Subtotal;
                }
                return total;
            }
            
        }

        public void AddToCart(Product prod) {
            ProductList.Add(prod);
        }

        public Cart() {
            productList = new List<Product>();
        }

       

    }
}
