using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Model
{
    public class Customer : BaseModel
    {
        public Customer(int ID, string customerName, string address)
        {
            base.ID = ID;
            CustomerName = customerName;
            Address = address;
        }

        [Required]
        public string CustomerName { get; set; }
        public string Address { get; set; }


    }
}
