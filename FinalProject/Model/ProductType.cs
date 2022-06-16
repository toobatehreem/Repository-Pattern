using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Model
{
    public class ProductType : BaseModel
    {
        public ProductType(int ID, string productType)
        {
            base.ID = ID;
            Product_Type = productType;
        }

        [Required]
        public string Product_Type { get; set; }
    }
}
