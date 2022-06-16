using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Model
{
    public class OrderItems : BaseModel
    {
        public OrderItems(int ID, int orderID, Orders orders, int productID, Products products, int quantity)
        {
            base.ID = ID;
            OrderID = orderID;
            Orders = orders;
            ProductID = productID;
            Products = products;
            Quantity = quantity;
        }

        public int OrderID { get; set; }
        [ForeignKey("ID")]

        public Orders Orders { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ID")]

        public Products Products { get; set; }

        public int Quantity { get; set; }
    }
}
