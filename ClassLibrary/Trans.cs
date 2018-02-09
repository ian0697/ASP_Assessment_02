using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Trans
    {

        public string ProdName { get; set; }
        public int Quantity { get; set; }
        public Double Price { get; set; }
        public Double Subtotal { get; set; }

        public Trans(String name, int qty1, double subtotal)
        {
            ProdName = name;
            Quantity = qty1;
            Subtotal = subtotal;
        }






    }
}
