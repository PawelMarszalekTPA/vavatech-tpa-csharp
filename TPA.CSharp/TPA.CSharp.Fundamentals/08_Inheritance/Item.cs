using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.Fundamentals.Inheritance
{


    public abstract class Item  // klasa abstrakcyjna - nie można utworzyć obiektu tej klasy
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class Product : Item
    {
        public string Color { get; set; }
        public string Size { get; set; }
    }

    public class Service : Item
    {
        public TimeSpan Duration { get; set; }
    }

    public class DocumentDetail
    {
        public Item Item { get; set; }

        //public Product Product { get; set; }
        //public Service Service { get; set; }
        public int Quantity { get; set; }

        public decimal TotalLine
        {
            get
            {
                //if (Product!=null)
                //{
                //    return Product.UnitPrice * Quantity;
                //}
                
                //if (Service!=null)
                //{
                //    return Service.UnitPrice * Quantity;
                //}

                //return 0;

                return Item.UnitPrice * Quantity;
            }
        }
    }
}
