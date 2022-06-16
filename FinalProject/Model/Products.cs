using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Model
{
    public class Products : BaseModel
    {
        public Products(int ID, string productName, int product_Type_ID, decimal product_Price)
        {
            base.ID = ID;
            ProductName = productName;
            Product_Type_ID = product_Type_ID;
            Product_Price = product_Price;
        }

        public string ProductName { get; set; }

        public int Product_Type_ID { get; set; }
        

        public decimal Product_Price { get; set; }

    }
}
