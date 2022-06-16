using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Model
{
    public class Orders : BaseModel
    {
        public Orders(int ID, int customerID, Customer customer, DateTime dateTime)
        {
            base.ID = ID;
            CustomerID = customerID;
            Customer = customer;
            DateTime = dateTime;
        }

        public int CustomerID { get; set; }
        [ForeignKey("ID")]
        public Customer Customer { get; set; }

        public DateTime DateTime { get; set; }
    }
}
